using System.Data.SqlClient;

namespace VMES.Contragent.DataModel
{
    class CommandAndParams
    {
        private SqlConnection connection;
        private SqlCommand command;
        

        //создаем комманду и передаем имя процы
        public CommandAndParams(string sqlExpression)
        {
            connection = ConnectionSingleton.Connection;
            command = new SqlCommand(sqlExpression, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
        }
        
        //добваляем параметры в комманду
        public void AddParam(string paramName, object paramValue)
        {
             command.Parameters.Add(new SqlParameter(paramName, paramValue));
        }

        //выполняем запрос
        public object ExecuteScalar()
        {
            connection.Open();
            return command.ExecuteScalar();
        }

        public object ExecuteNonQuery()
        {
            connection.Open();
            return command.ExecuteNonQuery();
        }

        public SqlDataReader ExecuteReader()
        {
            connection.Open();
            return command.ExecuteReader();
        }

        //закрываем соединение
        public void CloseConnection()
        {
            connection.Close();
        }
    }
}
