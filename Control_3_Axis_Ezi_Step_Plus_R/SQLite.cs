using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

namespace Control_3_Axis_Ezi_Step_Plus_R
{
    public class SQLite
    {
        public static string _DBFilePath = Application.StartupPath + "\\DBMachineBending.db";
        public bool _SqliteConnected = false;
        public bool _checkconnect = false;
        SQLiteConnection con = new SQLiteConnection("Datasource=" + _DBFilePath + ";Version=3;Compress=True;");

        private static SQLite _instance;
        /// <summary>
        /// return a instance of class SQLite
        /// </summary>
        /// <returns></returns>
        public static SQLite Instance()
        {
            if (_instance == null)
            {
                _instance = new SQLite();
            }
            return _instance;
        }
        /// <summary>
        /// Do check have see connection?
        /// </summary>
        public void CheckConnect()
        {
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    _checkconnect = true;
                    con.Close();
                }
                else
                {
                    _checkconnect = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _checkconnect = false;
            }
        }
        /// <summary>
        /// Function Open Connect to Database sqlite
        /// </summary>
        public void OpenConnection()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    _SqliteConnected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Function Close Connect to Database sqlite
        /// </summary>
        public void CloseConnection()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                    _SqliteConnected = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// insert value measure to table MeasureValueTemplate 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="point"></param>
        /// <param name="value"></param>
        public void InsertData(int id, string point, string value)
        {
            OpenConnection();
            if (_SqliteConnected)
            {
                string query = "INSERT INTO MeasureValueTemplate (ID,Point,Value) VALUES" +
                    "(@ID,@Point,@Value)";
                try
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, con))
                    {
                        command.Parameters.AddWithValue("ID", id);
                        command.Parameters.AddWithValue("Point", point);
                        command.Parameters.AddWithValue("Value", value);
                        command.ExecuteNonQuery();
                    }
                    CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    CloseConnection();
                }
            }
        }
        /// <summary>
        /// Insert into points coordinate is Bending
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="id"></param>
        /// <param name="point"></param>
        /// <param name="Xcoor"></param>
        /// <param name="Ycoor"></param>
        public void InsertPointsCoordinateBending(string tableName, int id, string point, string Xcoor, string Ycoor, string Zcoor)
        {
            OpenConnection();
            if (_SqliteConnected)
            {
                string query = "INSERT INTO " + tableName + " (ID,Point,Xcoor,Ycoor,Zcoor) " + "VALUES " +
                    "(@ID,@Point,@Xcoor,@Ycoor,@Zcoor)";
                try
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, con))
                    {
                        command.Parameters.AddWithValue("ID", id);
                        command.Parameters.AddWithValue("Point", point);
                        command.Parameters.AddWithValue("Xcoor", Xcoor);
                        command.Parameters.AddWithValue("Ycoor", Ycoor);
                        command.Parameters.AddWithValue("Zcoor", Zcoor);
                        command.ExecuteNonQuery();
                    }
                    CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    CloseConnection();
                }
            }
        }
        /// <summary>
        /// Insert default point coordinates for 3 axis: X Y Z
        /// </summary>
        /// <param name="id"></param>
        /// <param name="point"></param>
        /// <param name="Xcoor"></param>
        /// <param name="Ycoor"></param>
        /// <param name="Zcoor"></param>
        public void InsertDefaultPointsCoordinate(string tableName, int id, string point, string Xcoor, string Ycoor, string Zcoor)
        {
            OpenConnection();
            if (_SqliteConnected)
            {
                string query = "INSERT INTO " + tableName + " (ID,Point,Xcoor,Ycoor,Zcoor) " + "VALUES " +
                    "(@ID,@Point,@Xcoor,@Ycoor,@Zcoor)";
                try
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, con))
                    {
                        command.Parameters.AddWithValue("ID", id);
                        command.Parameters.AddWithValue("Point", point);
                        command.Parameters.AddWithValue("Xcoor", Xcoor);
                        command.Parameters.AddWithValue("Ycoor", Ycoor);
                        command.Parameters.AddWithValue("Zcoor", Zcoor);
                        command.ExecuteNonQuery();
                    }
                    CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    CloseConnection();
                }
            }
        }
        /// <summary>
        /// Get measurement value template, compare with data received
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="column"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetMeasureValueTemplate(string tableName, string column, int id)
        {
            string temp = "";
            OpenConnection();
            if (_SqliteConnected)
            {
                string query = "SELECT " + column + " FROM " + tableName + " WHERE ID=@ID";

                using (SQLiteCommand command = new SQLiteCommand(query, con))
                {
                    command.Parameters.AddWithValue("ID", id);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                temp = reader.GetValue(0).ToString();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return null;
                        }
                    }
                }
                CloseConnection();
                if (temp.Length > 1)
                {
                    return temp;
                }
                else
                {
                    return null;
                }
            }
            else { return null; }
        }
        /// <summary>
        /// Get Z coordinate for Bending
        /// </summary>
        /// <returns></returns>
        public string[] GetZCoorBending(int id)
        {
            string[] temp = new string[2];
            OpenConnection();
            if (_SqliteConnected)
            {
                string query = "SELECT ZCoorConvex, ZCoorConcave FROM T24ZCoordinateBending WHERE ID=@ID";
                using (SQLiteCommand command = new SQLiteCommand(query, con))
                {
                    command.Parameters.AddWithValue("ID", id);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                temp[0] = reader.GetValue(0).ToString();
                                temp[1] = reader.GetValue(1).ToString();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return null;
                        }
                    }
                }
                CloseConnection();
                if (temp.Length > 0)
                {
                    return temp;
                }
                else return null;
            }
            else return null;
        }
        /// <summary>
        /// Get 24 default points coordinate or 24 points coordinate bending convex, concave
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="id"></param>
        /// <param name="columnX"></param>
        /// <param name="columnY"></param>
        /// <returns></returns>
        public string[] GetPointsCoordinate(string tableName, int id, string columnX, string columnY, string columnZ)
        {
            string[] temp = new string[3];
            OpenConnection();
            if (_SqliteConnected)
            {
                string query = "SELECT " + columnX + "," + columnY + "," + columnZ + " FROM " + tableName + " WHERE ID=@ID";
                using (SQLiteCommand command = new SQLiteCommand(query, con))
                {
                    command.Parameters.AddWithValue("ID", id);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                temp[0] = reader.GetValue(0).ToString();
                                temp[1] = reader.GetValue(1).ToString();
                                temp[2] = reader.GetValue(2).ToString();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            CloseConnection();
                        }
                    }
                }
                CloseConnection();
                if (temp.Length > 0)
                {
                    return temp;
                }
                else return null;
            }
            else return null;
        }
        /// <summary>
        /// Get SpeedJOG
        /// </summary>
        /// <param name="column1"></param>
        /// <param name="column2"></param>
        /// <param name="column3"></param>
        /// <returns></returns>
        public uint[] GetSpeedJOG()
        {
            uint[] temp = new uint[3] { 0, 0, 0 };
            OpenConnection();
            if (_SqliteConnected)
            {
                string query = "SELECT *FROM SpeedJog";
                using (SQLiteCommand command = new SQLiteCommand(query, con))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                temp[0] = uint.Parse(reader.GetValue(1).ToString());
                                temp[1] = uint.Parse(reader.GetValue(2).ToString());
                                temp[2] = uint.Parse(reader.GetValue(3).ToString());
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            CloseConnection();
                        }
                    }
                }
                CloseConnection();
                return temp;
            }
            else return temp = new uint[] { 0, 0, 0 };
        }
        /// <summary>
        /// Lấy ra 3 hệ số của phương trình tính toán giá trị nội suy
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public float[] Get_Default_Coefficient(string tableName, int id)
        {
            float[] temp = new float[3];

            OpenConnection();

            string query = "SELECT *FROM " + tableName + " WHERE ID=@ID";
            using (SQLiteCommand command = new SQLiteCommand(query, con))
            {
                command.Parameters.AddWithValue("ID", id);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        while (reader.Read())
                        {
                            temp[0] = float.Parse(reader.GetValue(1).ToString());
                            temp[1] = float.Parse(reader.GetValue(2).ToString());
                            temp[2] = float.Parse(reader.GetValue(3).ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        CloseConnection();
                        return null;
                    }
                }
            }
            CloseConnection();
            if (temp[0].ToString() != null && temp[1].ToString() != null && temp[1].ToString() != null)
                return temp;
            else
                return null;
        }
        /// <summary>
        /// Insert Z Coordinate for Bending
        /// </summary>
        public void InsertZCoorBending(string columnName, int id, string valueCoor)
        {
            OpenConnection();
            if (_SqliteConnected)
            {
                string query = "INSERT INTO T24ZCoordinateBending (ID," + columnName + ") VALUES " +
                   "(@ID,@columnName)";
                try
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, con))
                    {
                        command.Parameters.AddWithValue("ID", id);
                        command.Parameters.AddWithValue("columnName", valueCoor);
                        command.ExecuteNonQuery();
                    }
                    CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    CloseConnection();
                }
            }
        }
        /// <summary>
        /// Update Z coordinates for Bending
        /// </summary>
        public void UpdateZCoorBending(string columnName, int id, string valueCoor)
        {
            OpenConnection();
            if (_SqliteConnected)
            {
                string query = "UPDATE T24ZCoordinateBending SET " + columnName + "=@columnName "
                    + "WHERE ID =@id";
                try
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, con))
                    {
                        command.Parameters.AddWithValue("columnName", valueCoor);
                        command.Parameters.AddWithValue("ID", id);
                        command.ExecuteNonQuery();
                    }
                    CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    CloseConnection();
                }
            }
        }
        /// <summary>
        /// Update points coordinate Bending
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="id"></param>
        /// <param name="Xcoor"></param>
        /// <param name="Ycoor"></param>
        public void UpdatePointsCoordinateBending(string tableName, int id, string Xcoor, string Ycoor, string Zcoor)
        {
            OpenConnection();
            if (_SqliteConnected)
            {
                string query = "UPDATE " + tableName + " SET Xcoor=@Xcoor,Ycoor=@Ycoor,Zcoor=@Zcoor WHERE ID=@ID";
                try
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, con))
                    {
                        command.Parameters.AddWithValue("ID", id);
                        command.Parameters.AddWithValue("Xcoor", Xcoor);
                        command.Parameters.AddWithValue("Ycoor", Ycoor);
                        command.Parameters.AddWithValue("Zcoor", Zcoor);
                        command.ExecuteNonQuery();
                    }
                    CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    CloseConnection();
                }
            }
        }
        /// <summary>
        /// Update default point coordinate for 3 axis: X Y Z
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="id"></param>
        /// <param name="Xcoor"></param>
        /// <param name="Ycoor"></param>
        /// <param name="Zcoor"></param>
        public void UpdateDefaultPointsCoordinate(string tableName, int id, string Xcoor, string Ycoor, string Zcoor)
        {
            OpenConnection();
            if (_SqliteConnected)
            {
                string query = "UPDATE " + tableName + " SET Xcoor=@Xcoor,Ycoor=@Ycoor,Zcoor=@Zcoor WHERE ID=@ID";
                try
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, con))
                    {
                        command.Parameters.AddWithValue("ID", id);
                        command.Parameters.AddWithValue("Xcoor", Xcoor);
                        command.Parameters.AddWithValue("Ycoor", Ycoor);
                        command.Parameters.AddWithValue("Zcoor", Zcoor);
                        command.ExecuteNonQuery();
                    }
                    CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    CloseConnection();
                }
            }
        }
        /// <summary>
        /// Update measurement value template
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void UpdateMeasureValueTemplate(int id, string value)
        {
            OpenConnection();
            if (_SqliteConnected)
            {
                string query = "UPDATE MeasureValueTemplate SET Value=@Value WHERE ID=@ID";
                try
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, con))
                    {
                        command.Parameters.AddWithValue("Value", value);
                        command.Parameters.AddWithValue("ID", id);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    CloseConnection();
                }
                CloseConnection();
            }
        }
        public void UpdateSpeedJOG(uint speedX, uint speedY, uint speedZ)
        {
            OpenConnection();
            if (_SqliteConnected)
            {
                string query = "UPDATE SpeedJog SET SpeedJogXaxis=@spX,SpeedJogYaxis=@spY,SpeedJogZaxis=@spZ";
                try
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, con))
                    {
                        command.Parameters.AddWithValue("spX", speedX);
                        command.Parameters.AddWithValue("spY", speedY);
                        command.Parameters.AddWithValue("spZ", speedZ);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        /// <summary>
        /// Delete all data of table
        /// </summary>
        /// <param name="tableName"></param>
        public void DeleteAll(string tableName)
        {
            OpenConnection();
            if (_SqliteConnected)
            {
                int result;
                string query = "DELETE FROM " + tableName;
                using (SQLiteCommand command = new SQLiteCommand(query, con))
                {
                    result = command.ExecuteNonQuery();
                }
                if (result > 1)
                    MessageBox.Show("Delete success!");
                CloseConnection();
            }
        }

        public bool CheckExistData(string tableName, int id)
        {
            string s = "";
            OpenConnection();
            string query = "SELECT *FROM " + tableName + " WHERE ID=@ID";
            using (SQLiteCommand command = new SQLiteCommand(query, con))
            {
                command.Parameters.AddWithValue("ID", id);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        while (reader.Read())
                        {
                            s = reader.GetValue(0).ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        CloseConnection();
                    }
                }
            }
            CloseConnection();
            if (s.Length > 0)
            {
                return true;
            }
            else return false;
        }
        /// <summary>
        /// Kiểm tra xem dữ liệu theo ID ở một hoặc nhiều cột có null hay không?
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="columnsName"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool CheckNullData(string columnsName, string tableName, int id)
        {
            string temp = "";
            string[] arr = new string[3];
            OpenConnection();
            string query = "SELECT " + columnsName + " FROM " + tableName + " WHERE ID=@ID";
            using (SQLiteCommand command = new SQLiteCommand(query, con))
            {
                command.Parameters.AddWithValue("ID", id);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        while (reader.Read())
                        {
                            temp = reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString() + "-" +
                                reader.GetValue(2).ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        CloseConnection();
                    }
                }
            }
            CloseConnection();
            arr = temp.Split('-');
            if (arr[0] != null && arr[1] != null && arr[2] != null)
                return false;
            else
                return true;
        }
    }
}

