using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;

public class Pessoa
{
    private int id; 
    private string nome;
    private long cpf;
    private string endereço;
    private int telefone; 

    public int Id { get => id; set => id = value; } 
    public string Nome { get => nome; set => nome = value; } 
    public long Cpf { get => cpf; set => cpf = value; }
    public string Endereço { get => endereço; set => endereço = value; }
    public int Telefone { get => telefone; set => telefone = value; }
}

public class Endereco
{
    private int id;
    private string logradouro;
    private int numero;
    private int cep;
    private string bairro;
    private string cidade;
    private string estado;

    public int Id { get => id; set => id = value; }
    public string Logradouro { get => logradouro; set => logradouro = value; }
    public int Numero { get => numero; set => numero = value; }
    public int Cep { get => cep; set => cep = value; }
    public string Bairro { get => bairro; set => bairro = value; }
    public string Cidade { get => cidade; set => cidade = value; }
    public string Estado { get => estado; set => estado = value; }
}

public class Telefone
{
    private int id;
    private int numeroTelefone;
    private int ddd;
    private string tipoTelefone;

    public int Id { get => id; set => id = value; }
    public int NumeroTelefone { get => numeroTelefone; set => numeroTelefone = value; }
    public int Ddd { get => ddd; set => ddd = value; }
    public string TipoTelefone { get => tipoTelefone; set => tipoTelefone = value; }
}

public bool exclua(Pessoa)
{
    return true;
}
public bool insira(Pessoa)
{
    return true;
}
public bool altere(Pessoa)
{
    return true;
}
public long consulte(Pessoa)
{
    return true;
}

public DataSet ExecutaSelect(string pSql)
        {
            try
            
            {
                DataSet DS = new DataSet();
                bdConn = new MySqlConnection(conexao.Conexao);

                try
                {
                    bdConn.Open();
                }
                catch (Exception ErroConexao)
                {
                    _errobanco = ErroConexao.ToString();
                    return (null);
                }

                if (bdConn.State == ConnectionState.Open)
                {
                    MySqlDataAdapter bdAdapter = new MySqlDataAdapter();
                    bdAdapter.SelectCommand = new MySqlCommand(pSql, bdConn);
                    bdAdapter.Fill(DS);
                    return (DS);
                }
                return (null);
            }
            catch (Exception Erro)
            {
                _errobanco = Erro.ToString() + Environment.NewLine + pSql;
                return (null);
            }
            finally
            {
                bdConn.Close();
            }
        }

        public bool ExecutaUpdate(string pSql)
        {
            try
            {
                DataSet DS = new DataSet();
                bdConn = new MySqlConnection(conexao.Conexao);

                try
                {
                    bdConn.Open();
                }
                catch (Exception ErroConexao)
                {
                    _errobanco = ErroConexao.ToString();
                    return false;
                }

                if (bdConn.State == ConnectionState.Open)
                {
                    MySqlDataAdapter bdAdapter = new MySqlDataAdapter();
                    bdAdapter.SelectCommand = new MySqlCommand(pSql, bdConn);
                    bdAdapter.Fill(DS);
                    return true;
                }
                return false;
            }
            catch (Exception Erro)
            {
                _errobanco = Erro.ToString() + Environment.NewLine + pSql;
                return false;
            }
            finally
            {
                bdConn.Close();
            }
        }

        public bool ExecutaInsert(string pSql)
        {
            try
            {

                DataSet DS = new DataSet();
                bdConn = new MySqlConnection(conexao.Conexao);

                try
                {
                    bdConn.Open();
                }
                catch (Exception ErroConexao)
                {
                    _errobanco = ErroConexao.ToString();
                    return false;
                }

                if (bdConn.State == ConnectionState.Open)
                {
                    MySqlDataAdapter bdAdapter = new MySqlDataAdapter();
                    bdAdapter.SelectCommand = new MySqlCommand(pSql, bdConn);
                    bdAdapter.Fill(DS);
                    return true;
                }
                return false;
            }
            catch (Exception Erro)
            {
                _errobanco = Erro.ToString() + Environment.NewLine + pSql;
                return false;
            }
            finally
            {
                bdConn.Close();
            }
        }

        public bool ExecutaDelete(string pSql)
        {
            try
            {
                DataSet DS = new DataSet();
                bdConn = new MySqlConnection(conexao.Conexao);

                try
                {
                    bdConn.Open();
                }
                catch (Exception ErroConexao)
                {
                    _errobanco = ErroConexao.ToString();
                    return false;
                }

                if (bdConn.State == ConnectionState.Open)
                {
                    MySqlDataAdapter bdAdapter = new MySqlDataAdapter();
                    bdAdapter.SelectCommand = new MySqlCommand(pSql, bdConn);
                    bdAdapter.Fill(DS);
                    return true;
                }
                return false;
            }
            catch (Exception Erro)
            {
                _errobanco = Erro.ToString() + Environment.NewLine + pSql;
                return false;
            }
            finally
            {
                bdConn.Close();
            }
        }
