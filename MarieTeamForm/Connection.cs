using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using MarieTeamForm;
using System.Collections;
using Microsoft.Win32;


namespace MarieTeamForm
{
    public class Connection
    {
            private MySqlConnection connection;
            private string server;
            private string database;
            private string uid;
            private string password;

            //Constructor
            public Connection()
            {
                Initialize();
            }

            //Initialize values
            private void Initialize()
            {
                server = "localhost";
                database = "marieteam";
                uid = "supAdmin";
                password = "4uFw9is0/qUxZ)Wh";
                string connectionString;
                connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

                connection = new MySqlConnection(connectionString);
            }

            //open connection to database
            private bool OpenConnection()
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (MySqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 0:
                            MessageBox.Show("Impossible de se connecter au serveur.");
                            break;
                        case 1045:
                            MessageBox.Show("Utilisateur/Mdp incorrect");
                            break;
                        default:
                            MessageBox.Show(ex.Message);
                            break;
                    }
                }
                return false;
            }


            //Close connection
            private bool CloseConnection()
            {
                try
                {
                    connection.Close();
                    return true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }

        //Insert statement
        public void insertBoat(int id, string libelle_bateau, double longueur, double largeur,int vitesse)
            {
                string query = $"INSERT INTO bateau (id_bateau,libelle_bateau,longueur,largeur,vitesse) VALUES('{id}','{libelle_bateau}','{longueur}','{largeur}','{vitesse}')";

                //open connection
                if (this.OpenConnection() == true)
                {
                try
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }
                catch (MySql.Data.MySqlClient.MySqlException err)
                {
                    switch (err.Number)
                    {
                        case 0:
                            MessageBox.Show("Impossible de se connecter au serveur.");
                            break;
                        case 1045:
                            MessageBox.Show("Utilisateur/Mdp incorrect");
                            break;
                        default:
                            MessageBox.Show(err.Message);
                            break;
                    }
                }
                }
            }

            //Update statement
            public void Update(string libelle_bateau, double longueur, double largeur, int vitesse)
            {
                string query = $"UPDATE bateau SET libelle_bateau={libelle_bateau}, longueur={longueur}, largeur={largeur} , vitesse={vitesse}  WHERE id={Program.idBateau}";

                //Open connection
                if (this.OpenConnection() == true)
                {
                    //create mysql command
                    MySqlCommand cmd = new MySqlCommand();
                    //Assign the query using CommandText
                    cmd.CommandText = query;
                    //Assign the connection using Connection
                    cmd.Connection = connection;

                    //Execute query
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }
            }

            //Delete statement
            public void Delete()
            {
                string query = $"DELETE FROM bateau WHERE id={Program.idBateau}";

                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
            }

            //Select statement
            public void SelectAllBoat(DataGridView dgv)
            {
                Connection start = new Connection();
               
                try
                   {

                    string sql = "SELECT id_bateau AS ID, libelle_bateau AS NomBateau FROM bateau";
                    MySqlDataAdapter daBateau = new MySqlDataAdapter(sql, connection);
                    MySqlCommandBuilder cb = new MySqlCommandBuilder(daBateau);

                    DataSet dsBateau = new DataSet();
                    daBateau.Fill(dsBateau, "Bateau");
                    dgv.DataSource = dsBateau;
                    dgv.DataMember = "Bateau";
                    dgv.Location = new System.Drawing.Point(169, 30);
                    dgv.Name = "dataGridView_fullList";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {               
                       this.CloseConnection();   
                    }
               
                }
            // Recupére les détails du bateau
            public void getDetailsBoatById()
            {
                string query = $"SELECT longueur, largeur, vitesse FROM bateau WHERE id_bateau = {Program.idBateau}";

            //open connection
            if (this.OpenConnection() == true)
            {
                try
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    MySqlDataReader drAN = cmd.ExecuteReader();

                   while (drAN.Read())
                    {
                        Program.longueurBateau = double.Parse(drAN[0].ToString());
                        Program.largeurBateau = double.Parse(drAN[1].ToString());
                        Program.vitesseBateau = int.Parse(drAN[2].ToString());
                    }

                    //close connection
                    this.CloseConnection();
                   
                }
                catch (MySql.Data.MySqlClient.MySqlException err)
                {
                    switch (err.Number)
                    {
                        case 0:
                            MessageBox.Show("Impossible de se connecter au serveur.");
                            break;
                        case 1045:
                            MessageBox.Show("Utilisateur/Mdp incorrect");
                            break;
                        default:
                            MessageBox.Show(err.Message);
                            break;
                    }
                }
            }
        }
        //Recupere l'equipement du bateau
        public void getEquipement()
        {
            string query = $"SELECT libelle_equipement FROM equipement WHERE id_equipement IN (SELECT id_equipement FROM equipe WHERE id_bateau = {Program.idBateau} )";

            //open connection
            if (this.OpenConnection() == true)
            {
                try
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    MySqlDataReader drAN = cmd.ExecuteReader();

                    var list = new List<string>();

                    while (drAN.Read())
                    {
                        list.Add(drAN.GetString(0));
                    }
                    Program.equipement = list.ToArray();

                    //close connection
                    this.CloseConnection();

                }
                catch (MySql.Data.MySqlClient.MySqlException err)
                {
                    switch (err.Number)
                    {
                        case 0:
                            MessageBox.Show("Impossible de se connecter au serveur.");
                            break;
                        case 1045:
                            MessageBox.Show("Utilisateur/Mdp incorrect");
                            break;
                        default:
                            MessageBox.Show(err.Message);
                            break;
                    }
                }
            }
        }
        //Count statement
        public int Count()
            {
                string query = "SELECT Count(*) FROM bateau";
                int Count = -1;

                //Open Connection
                if (this.OpenConnection() == true)
                {
                    //Create Mysql Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //ExecuteScalar will return one value
                    Count = int.Parse(cmd.ExecuteScalar() + "");

                    //close Connection
                    this.CloseConnection();

                    return Count;
                }
                else
                {
                    return Count;
                }
            }

            //Backup
            public void Backup()
            {
                try
                {
                    DateTime Time = DateTime.Now;
                    int year = Time.Year;
                    int month = Time.Month;
                    int day = Time.Day;
                    int hour = Time.Hour;
                    int minute = Time.Minute;
                    int second = Time.Second;
                    int millisecond = Time.Millisecond;

                    //Save file to C:\ with the current date as a filename
                    string path;
                    path = "C:\\MySqlBackup" + year + "-" + month + "-" + day +
                "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
                    StreamWriter file = new StreamWriter(path);


                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = "mysqldump";
                    psi.RedirectStandardInput = false;
                    psi.RedirectStandardOutput = true;
                    psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                        uid, password, server, database);
                    psi.UseShellExecute = false;

                    Process process = Process.Start(psi);

                    string output;
                    output = process.StandardOutput.ReadToEnd();
                    file.WriteLine(output);
                    process.WaitForExit();
                    file.Close();
                    process.Close();
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Error , unable to backup!" + ex);
                }
            }

            //Restore
            //Restore
            public void Restore()
            {
                try
                {
                    //Read file from C:\
                    string path;
                    path = "C:\\MySqlBackup.sql";
                    StreamReader file = new StreamReader(path);
                    string input = file.ReadToEnd();
                    file.Close();

                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = "mysql";
                    psi.RedirectStandardInput = true;
                    psi.RedirectStandardOutput = false;
                    psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                        uid, password, server, database);
                    psi.UseShellExecute = false;


                    Process process = Process.Start(psi);
                    process.StandardInput.WriteLine(input);
                    process.StandardInput.Close();
                    process.WaitForExit();
                    process.Close();
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Error , unable to Restore!" + ex);
                }
            }   
    }
}
