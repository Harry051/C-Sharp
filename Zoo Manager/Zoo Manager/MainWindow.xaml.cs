using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration; //<--Need to right click references and add this in before "using"
using System.Data.SqlClient; //<-- Makes the SQL data accessible
using System.Data;//<-- Allows for DataTable

namespace Zoo_Manager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlconnex;
        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Zoo_Manager.Properties.Settings.HarrysDBConnectionString"].ConnectionString;
            sqlconnex = new SqlConnection(connectionString);

            ShowZoos();
            ShowAnimals();
            ShowAssociatedAnimals();
        }

        private void ShowZoos()
        {
            try        //Good practice to use lots of try & catches when it comes to databases
            {
                string query = "SELECT * FROM Zoo";
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlconnex);
                //The SQL adaptercan be imagined like an interface to make SQL Tables usable by C# Objects

                using (adapter)
                {
                    DataTable zooTable = new DataTable();
                    // DataTable allows us to store our data from tables in an object

                    adapter.Fill(zooTable);

                    //what info should be shown in our listbox
                    ListZoos.DisplayMemberPath = "Location"; //ListZoos XAML name

                    //which value should be delivered when an item in our listbox is selected>
                    ListZoos.SelectedValuePath = "Id";

                    //The Reference to the data the listbox should populate
                    ListZoos.ItemsSource = zooTable.DefaultView;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void ShowAnimals()
        {
            try 
            {
                string query = "SELECT * FROM Animal";
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlconnex);
                
                using (adapter)
                {
                    DataTable animalTable = new DataTable();
                    adapter.Fill(animalTable);
                    ListAnimals.DisplayMemberPath = "Name";
                    ListAnimals.SelectedValuePath = "Id";
                    ListAnimals.ItemsSource = animalTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        private void ShowAssociatedAnimals()
        {
            try        //Good practice to use lots of try & catches when it comes to databases
            {
                string query = "SELECT * FROM Animal a inner join ZooAnimal za ON a.Id = za.AnimalId WHERE za.ZooId = @ZooId";
                //@ZooID like a variable in code


                SqlCommand myCommand = new SqlCommand(query, sqlconnex);

                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                

                using (adapter)
                {
                    myCommand.Parameters.AddWithValue("@ZooID", ListZoos.SelectedValue);

                    DataTable associatedAnimalsTable = new DataTable();
                    adapter.Fill(associatedAnimalsTable);                    
                    ListAssociatedAnimals.DisplayMemberPath = "Name";
                    ListAssociatedAnimals.SelectedValuePath = "Id";
                    ListAssociatedAnimals.ItemsSource = associatedAnimalsTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.ToString());
            }

        }

        private void ShowSelectedZooInTextBox()
        {
            try
            {
                string query = "SELECT Location FROM Zoo WHERE Id = @ZooId";


                SqlCommand myCommand = new SqlCommand(query, sqlconnex);

                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);


                using (adapter)
                {
                    myCommand.Parameters.AddWithValue("@ZooID", ListZoos.SelectedValue);
                    //One PArticular value and will create a new table/object based on our command

                    DataTable zooDataTable = new DataTable();
                    adapter.Fill(zooDataTable);

                    MyTextBox.Text = zooDataTable.Rows[0]["Location"].ToString();
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }

        }

        private void ShowSelectedAnimalInTextBox()
        {
            try
            {
                string query = "SELECT Name FROM Animal WHERE Id = @AnimalId";


                SqlCommand myCommand = new SqlCommand(query, sqlconnex);

                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);


                using (adapter)
                {
                    myCommand.Parameters.AddWithValue("@AnimalId", ListAnimals.SelectedValue);

                    DataTable animalDataTable = new DataTable();
                    adapter.Fill(animalDataTable);

                    MyTextBox.Text = animalDataTable.Rows[0]["Name"].ToString();
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }

        }

        private void ListZoos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowAssociatedAnimals();
            ShowSelectedZooInTextBox();
        }

        private void DeleteZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "DELETE FROM Zoo WHERE Id = @ZooID";
                SqlCommand deleteCommand = new SqlCommand(query, sqlconnex);

                sqlconnex.Open();
                deleteCommand.Parameters.AddWithValue("@ZooId", ListZoos.SelectedValue);
                //.SelectedValue is Zoo ID not Location
                deleteCommand.ExecuteScalar();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                sqlconnex.Close();  //Need to close otherwise errors

                ShowZoos(); // Will show the updated list after deletion
            }
        }

        private void DeleteAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "DELETE FROM Animal WHERE Id = @AnimalId";
                SqlCommand deleteCommand = new SqlCommand(query, sqlconnex);

                sqlconnex.Open();
                deleteCommand.Parameters.AddWithValue("@AnimalId", ListAnimals.SelectedValue);
                deleteCommand.ExecuteScalar();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                sqlconnex.Close();

                ShowAnimals();
            }
        }

        private void AddZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "INSERT INTO Zoo VALUES (@Location)"; //LINQ is better but we'll get there :)
                SqlCommand addCommand = new SqlCommand(query, sqlconnex);

                sqlconnex.Open();
                addCommand.Parameters.AddWithValue("@Location", MyTextBox.Text);
                addCommand.ExecuteScalar();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                sqlconnex.Close();

                ShowZoos();
            }
        }

        private void AddAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "INSERT INTO Animal VALUES (@Name)";
                SqlCommand addCommand = new SqlCommand(query, sqlconnex);

                sqlconnex.Open();
                addCommand.Parameters.AddWithValue("@Name", MyTextBox.Text);
                addCommand.ExecuteScalar();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                sqlconnex.Close();

                ShowAnimals();
            }
        }

        private void AddAnimalToZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "INSERT INTO ZooAnimal VALUES (@ZooId, @AnimalId)"; //LINQ is better but we'll get there :)
                SqlCommand addCommand = new SqlCommand(query, sqlconnex);

                sqlconnex.Open();
                addCommand.Parameters.AddWithValue("@ZooId", ListZoos.SelectedValue);
                addCommand.Parameters.AddWithValue("@AnimalId", ListAnimals.SelectedValue);
                addCommand.ExecuteScalar();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                sqlconnex.Close();
                ShowAssociatedAnimals();
            }
        }

        //Need to fix this method :(
        private void DeleteAnimalFromZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "DELETE FROM ZooAnimal WHERE Id = @Id"; ////////////////////////////////////////;
                SqlCommand deleteCommand = new SqlCommand(query, sqlconnex);

                sqlconnex.Open();
                deleteCommand.Parameters.AddWithValue("@Id", ListAssociatedAnimals.SelectedValue);                
                deleteCommand.ExecuteScalar();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                sqlconnex.Close();
                ShowAssociatedAnimals();
            }
        }

        private void UpdateZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "UPDATE Zoo Set Location = @Location WHERE Id = @ZooID";
                SqlCommand addCommand = new SqlCommand(query, sqlconnex);

                sqlconnex.Open();
                addCommand.Parameters.AddWithValue("@ZooId", ListZoos.SelectedValue);
                addCommand.Parameters.AddWithValue("@Location", MyTextBox.Text);
                addCommand.ExecuteScalar();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                sqlconnex.Close();
                ShowZoos();
            }
        }

        private void UpdateAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "UPDATE Animal Set Name = @Name WHERE Id = @AnimalID";
                SqlCommand addCommand = new SqlCommand(query, sqlconnex);

                sqlconnex.Open();
                addCommand.Parameters.AddWithValue("@AnimalId", ListAnimals.SelectedValue);
                addCommand.Parameters.AddWithValue("@Name", MyTextBox.Text);
                addCommand.ExecuteScalar();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                sqlconnex.Close();
                ShowAnimals();
            }
        }

        private void ListAnimals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowSelectedAnimalInTextBox();
        }
    }
}
