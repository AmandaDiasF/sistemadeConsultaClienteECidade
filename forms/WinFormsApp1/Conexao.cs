using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Drawing;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace Atividade1Matheus
{
    internal class ConectaBanco
    {
        MySqlConnection conectaBD = new MySqlConnection("server=localhost;user id=root;password=;database=jesftech.db");//conectando ao banco de dados
        public String mensagem; //criando variável mensagem

        //CCCCC IIIII DDDD  AAAAA DDDD  EEEEE
        //CC     III  DD DD A   A DD DD EE
        //CC     III  DD DD AAAAA DD DD EEEEE
        //CC     III  DD DD A   A DD DD EE
        //CCCCC IIIII DDDD  A   A DDDD  EEEEE

        public DataTable listaCidades()
        {
            MySqlCommand cmd = new MySqlCommand("Yproc_selectAllCidades", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conectaBD.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conectaBD.Close();
            }
        }

        public DataTable listaCidadesFromNameSearch(string search)
        {
            MySqlCommand cmd = new MySqlCommand("Yproc_selectAllCidadesFromSearch", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_search", '%' + search + '%');
            try
            {
                conectaBD.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conectaBD.Close();
            }
        }

        public List<int> listaCidadesEmLista()
        {
            List<int> listaIdCod = new List<int>();
            MySqlCommand cmd = new MySqlCommand("Yproc_selectAllCidades2", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conectaBD.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Supondo que o idCod é do tipo int e está na primeira coluna
                        listaIdCod.Add(reader.GetInt32(0)); // Altere o índice se necessário
                    }
                }
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conectaBD.Close();
            }

            return listaIdCod;
        }

        public List<String> listaEstadoEmLista()
        {
            List<String> listaIdCod = new List<String>();
            MySqlCommand cmd = new MySqlCommand("Yproc_selectAllEstados2", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conectaBD.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Supondo que o idCod é do tipo int e está na primeira coluna
                        listaIdCod.Add(reader.GetString(0)); // Altere o índice se necessário
                    }
                }
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conectaBD.Close();
            }

            return listaIdCod;
        }
        public int selectCidadeFromName(String nomeCidade)
        {
            MySqlCommand cmd = new MySqlCommand("Yproc_selectCiyFromName", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_nome", nomeCidade);

            try
            {
                conectaBD.Open();
                // Executa o comando e espera um único valor de retorno
                object result = cmd.ExecuteScalar();

                // Verifica se o resultado não é nulo e converte para int
                return result != null ? Convert.ToInt32(result) : 0; // Retorna 0 se não houver resultado
            }
            catch (MySqlException ex)
            {
                // Tratar exceção de banco de dados
                Console.WriteLine($"Erro ao executar o comando: {ex.Message}");
                return -1; // Retornar um valor indicando erro, se necessário
            }
            finally
            {
                conectaBD.Close();
            }
        }
        public int selectEstadoFromUf(String uf)
        {
            MySqlCommand cmd = new MySqlCommand("Yproc_selectEstadosFromUF", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_uf", uf);
            try
            {
                conectaBD.Open();
                // Executa o comando e espera um único valor de retorno
                object result = cmd.ExecuteScalar();

                // Verifica se o resultado não é nulo e converte para int
                return result != null ? Convert.ToInt32(result) : 0; // Retorna 0 se não houver resultado
            }
            catch (MySqlException ex)
            {
                // Tratar exceção de banco de dados
                Console.WriteLine($"Erro ao executar o comando: {ex.Message}");
                return -1; // Retornar um valor indicando erro, se necessário
            }
            finally
            {
                conectaBD.Close();
            }
        }

        public DataTable listaCidadePorCod(int codCliente)
        {
            MySqlCommand cmd = new MySqlCommand("Yproc_selectTheCity", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_codCidade", codCliente);
            try
            {
                conectaBD.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conectaBD.Close();
            }
        }

        public bool insereCidades(Cidade c)
        {
            MySqlCommand cmd = new MySqlCommand("Yproc_insertCidades", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_nome", c.Cid);
            cmd.Parameters.AddWithValue("p_idEstado", c.UF);
            try
            {
                conectaBD.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro ao inserir cidade: " + e.Message + " (idEstado: " + c.UF + ")";
                MessageBox.Show(mensagem);
                return false;
            }
            finally
            {

                conectaBD.Close();
                if (!EstadoExiste(c.UF))
                {
                    MessageBox.Show("O estado com ID " + c.UF + " não existe.");
                }
            }
        }

        public bool EstadoExiste(int idEstado)
        {
            using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM estado WHERE codEstado = @idEstado", conectaBD))
            {
                cmd.Parameters.AddWithValue("@idEstado", idEstado);
                conectaBD.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                conectaBD.Close();
                return count > 0;
            }
        }
        public bool alteraCidade(Cidade c, int codCidade)
        {
            MySqlCommand cmd = new MySqlCommand("proc_alteraCliente", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_codCidade", codCidade);
            cmd.Parameters.AddWithValue("p_nome", c.Cid);
            cmd.Parameters.AddWithValue("p_uf", c.UF);
            try
            {
                conectaBD.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conectaBD.Close();
            }
        }

        public bool deletaCidade(int codCidade)
        {
            MySqlCommand cmd = new MySqlCommand("Yproc_deleteCidades", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_codCidade", codCidade);
            try
            {
                conectaBD.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conectaBD.Close();
            }
        }

        //CCCCC LL    IIIII EEEEE N   N TTTTT EEEEE
        //CC    LL     III  EE    NN  N  TTT  EE
        //CC    LL     III  EEEEE N N N  TTT  EEEEE
        //CC    LL     III  EE    N  NN  TTT  EE
        //CCCCC LLLLL IIIII EEEEE N   N  TTT  EEEEE

        public DataTable listaCLientes()
        {
            MySqlCommand cmd = new MySqlCommand("Yproc_selectAllClients", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conectaBD.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conectaBD.Close();
            }
        }

        public DataTable listaClientesFromNameSearch(string search)
        {
            MySqlCommand cmd = new MySqlCommand("Yproc_selectAllClientsFromSearch", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_search", '%' + search + '%');
            try
            {
                conectaBD.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conectaBD.Close();
            }
        }

        public DataTable listaCLientesPorCod(int codCliente)
        {
            MySqlCommand cmd = new MySqlCommand("Yproc_selectTheClient", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_codCliente", codCliente);
            try
            {
                conectaBD.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conectaBD.Close();
            }
        }

        public List<int> listaClientesEmLista()
        {
            List<int> listaIdCod = new List<int>();
            MySqlCommand cmd = new MySqlCommand("Yproc_selectAllClients2", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conectaBD.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Supondo que o idCod é do tipo int e está na primeira coluna
                        listaIdCod.Add(reader.GetInt32(0)); // Altere o índice se necessário
                    }
                }
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conectaBD.Close();
            }

            return listaIdCod;
        }

        public bool insereCliente(Cliente c)
        {
            MySqlCommand cmd = new MySqlCommand("Yproc_insertClients", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_nome", c.NomeCliente);
            cmd.Parameters.AddWithValue("p_sobrenome", c.SobrenomeCliente);
            cmd.Parameters.AddWithValue("p_email", c.EmailCliente);
            cmd.Parameters.AddWithValue("p_telefone", c.TelefoneCliente);
            cmd.Parameters.AddWithValue("p_senha", c.SenhaCliente);
            cmd.Parameters.AddWithValue("p_cpfCnpj", c.CpfCnpjCliente);
            cmd.Parameters.AddWithValue("p_dataNascimento", c.DataNascimento);
            cmd.Parameters.AddWithValue("p_observacoes", c.ObservacaoCliente);
            cmd.Parameters.AddWithValue("p_genero", c.GeneroCliente);
            cmd.Parameters.AddWithValue("p_cep", c.CepCliente);
            cmd.Parameters.AddWithValue("p_logradouro", c.LogradouroCliente);
            cmd.Parameters.AddWithValue("p_bairro", c.BairroCliente);
            cmd.Parameters.AddWithValue("p_num", c.NumCliente);
            cmd.Parameters.AddWithValue("p_codCidade", c.CodCidade);
            try
            {
                conectaBD.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                MessageBox.Show("Erro: " + e.Message);
                return false;
            }
            finally
            {
                conectaBD.Close();
            }
        }

        public bool alteraCliente(Cliente c, int codCliente)
        {
            MySqlCommand cmd = new MySqlCommand("Yproc_updateClients", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_codCliente", codCliente);
            cmd.Parameters.AddWithValue("p_nome", c.NomeCliente);
            cmd.Parameters.AddWithValue("p_sobrenome", c.SobrenomeCliente);
            cmd.Parameters.AddWithValue("p_email", c.EmailCliente);
            cmd.Parameters.AddWithValue("p_telefone", c.TelefoneCliente);
            cmd.Parameters.AddWithValue("p_senha", c.SenhaCliente);
            cmd.Parameters.AddWithValue("p_cpfCnpj", c.CpfCnpjCliente);
            cmd.Parameters.AddWithValue("p_dataNascimento", c.DataNascimento);
            cmd.Parameters.AddWithValue("p_observacoes", c.ObservacaoCliente);
            cmd.Parameters.AddWithValue("p_genero", c.GeneroCliente);
            cmd.Parameters.AddWithValue("p_cep", c.CepCliente);
            cmd.Parameters.AddWithValue("p_logradouro", c.LogradouroCliente);
            cmd.Parameters.AddWithValue("p_bairro", c.BairroCliente);
            cmd.Parameters.AddWithValue("p_num", c.NumCliente);
            cmd.Parameters.AddWithValue("p_codCidade", c.CodCidade);
            try
            {
                conectaBD.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                MessageBox.Show("Erro: " + e.Message);
                return false;
            }
            finally
            {
                conectaBD.Close();
            }
        }// fim altera cliente

        public bool deletaCliente(int codCliente)
        {
            MySqlCommand cmd = new MySqlCommand("Yproc_deleteClients", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("p_codCliente", codCliente);
            try
            {
                conectaBD.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                Console.WriteLine("Erro:" + e.Message);
                MessageBox.Show("Erro: " + e.Message);
                return false;
            }
            finally
            {
                conectaBD.Close();
            }
        }// fim deleta Cliente

        //FFFFF UU UU N   N CCCCC IIIII OOOOO N   N AAAAA RRRRR IIIII OOOOO
        //FF    UU UU NN  N CC     III  OO OO NN  N A   A R   R  III  OO OO
        //FFFFF UU UU N N N CC     III  OO OO N N N AAAAA RRRRR  III  OO OO
        //FF    UU UU N  NN CC     III  OO OO N  NN A   A RRRR   III  OO OO
        //FF    UUUUU N   N CCCCC IIIII OOOOO N   N A   A RR RR IIIII OOOOO

        public DataTable listaFuncionario()
        {
            MySqlCommand cmd = new MySqlCommand("Yproc_selectAllFuncionarios", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conectaBD.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conectaBD.Close();
            }
        }

        public bool insereFuncionario(Funcionario c)
        {
            MySqlCommand cmd = new MySqlCommand("Yproc_insertClients", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nome", c.NomeFuncionario);
            cmd.Parameters.AddWithValue("email", c.EmailFuncionario);
            cmd.Parameters.AddWithValue("senha", c.SenhaFuncionario);
            cmd.Parameters.AddWithValue("cpf", c.CpfFuncionario);
            cmd.Parameters.AddWithValue("cargo", c.CargoFuncionario);
            cmd.Parameters.AddWithValue("nascimento", c.NascimentoFuncionario);
            cmd.Parameters.AddWithValue("salario", c.SalarioFuncionario);
            cmd.Parameters.AddWithValue("cep", c.CepFuncionario);
            cmd.Parameters.AddWithValue("endereco", c.EnderecoFuncionario);
            cmd.Parameters.AddWithValue("bairro", c.BairroFuncionario);
            cmd.Parameters.AddWithValue("num", c.NumFuncionario);
            cmd.Parameters.AddWithValue("codCidade", c.CodCidade);
            // complete
            try
            {
                conectaBD.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conectaBD.Close();
            }
        }

        public bool alteraFuncionario(Funcionario c, int codFuncionario)
        {
            MySqlCommand cmd = new MySqlCommand("proc_alteraCliente", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codFuncionario", codFuncionario);
            cmd.Parameters.AddWithValue("nome", c.NomeFuncionario);
            cmd.Parameters.AddWithValue("email", c.EmailFuncionario);
            cmd.Parameters.AddWithValue("senha", c.SenhaFuncionario);
            cmd.Parameters.AddWithValue("cpf", c.CpfFuncionario);
            cmd.Parameters.AddWithValue("cargo", c.CargoFuncionario);
            cmd.Parameters.AddWithValue("nascimento", c.NascimentoFuncionario);
            cmd.Parameters.AddWithValue("salario", c.SalarioFuncionario);
            cmd.Parameters.AddWithValue("cep", c.CepFuncionario);
            cmd.Parameters.AddWithValue("endereco", c.EnderecoFuncionario);
            cmd.Parameters.AddWithValue("bairro", c.BairroFuncionario);
            cmd.Parameters.AddWithValue("num", c.NumFuncionario);
            cmd.Parameters.AddWithValue("codCidade", c.CodCidade);
            try
            {
                conectaBD.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conectaBD.Close();
            }
        }// fim altera Funcionario

        public bool deletaFuncionario(int codFuncionario)
        {
            MySqlCommand cmd = new MySqlCommand("proc_deletaCliente", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codFuncionario", codFuncionario);
            try
            {
                conectaBD.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conectaBD.Close();
            }
        }// fim deleta Funcionario

        //IIIII TTTTT EEEEE N   N V   V EEEEE N   N DDDD  AAAAA
        // III  TTTTT EE    NN  N V   V EE    NN  N DD DD A   A
        // III   TTT  EEEEE N N N  V V  EEEEE N N N DD DD AAAAA
        // III   TTT  EE    N  NN  V V  EE    N  NN DD DD A   A
        //IIIII  TTT  EEEEE N   N   V   EEEEE N   N DDDD  A   A

        public DataTable listaItemVenda()
        {
            MySqlCommand cmd = new MySqlCommand("Yproc_selectAllItensVenda", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conectaBD.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conectaBD.Close();
            }
        }

        public bool insereItemVenda(ItemVenda i)
        {
            MySqlCommand cmd = new MySqlCommand("proc_insereMarca", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codProduto", i.CodProduto);
            cmd.Parameters.AddWithValue("valor", i.Valor);
            cmd.Parameters.AddWithValue("quantVenda", i.QuantVenda);
            cmd.Parameters.AddWithValue("codVenda", i.CodVenda);
            try
            {
                conectaBD.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conectaBD.Close();
            }
        }

        public bool alteraItemVenda(ItemVenda i, int codItemVenda)
        {
            MySqlCommand cmd = new MySqlCommand("proc_alteraMarca", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codMarca", codItemVenda);
            cmd.Parameters.AddWithValue("codProduto", i.CodProduto);
            cmd.Parameters.AddWithValue("valor", i.Valor);
            cmd.Parameters.AddWithValue("quantVenda", i.QuantVenda);
            cmd.Parameters.AddWithValue("codVenda", i.CodVenda);

            try
            {
                conectaBD.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conectaBD.Close();
            }
        }

        public bool deletaItemVenda(int codItemVenda)
        {
            MySqlCommand cmd = new MySqlCommand("proc_deletaMarca", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codItemVenda", codItemVenda);
            try
            {
                conectaBD.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conectaBD.Close();
            }
        }

        //LL    OOOOO GGGGG
        //LL    OO OO GG GG
        //LL    OO OO GG 
        //LL    OO OO GG GGG
        //LLLLL OOOOO GGGGG

        public DataTable listaLog()
        {
            // comentario
            MySqlCommand cmd = new MySqlCommand("Yproc_selectAllLog", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conectaBD.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conectaBD.Close();
            }

        }

        //  M   M AAAAA RRRRR CCCCC AAAAA
        //  MM MM A   A R   R CC    A   A
        //  MMMMM AAAAA RRRRR CC    AAAAA
        //  M M M A   A RRRR  CC    A   A
        //  M M M A   A RR RR CCCCC A   A
        public DataTable listaMarcas()
        {
            // comentario
            MySqlCommand cmd = new MySqlCommand("Yproc_selectAllMarca", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conectaBD.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conectaBD.Close();
            }
        }
        public bool insereMarca(Marca m)
        {
            MySqlCommand cmd = new MySqlCommand("proc_insereMarca", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("marca", m.NomeMarca);
            try
            {
                conectaBD.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conectaBD.Close();
            }
        }

        public bool alteraMarca(Marca m, int codMarca)
        {
            MySqlCommand cmd = new MySqlCommand("proc_alteraMarca", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codMarca", codMarca);
            cmd.Parameters.AddWithValue("marca", m.NomeMarca);

            try
            {
                conectaBD.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conectaBD.Close();
            }
        }

        public bool deletaMarca(int codMarca)
        {
            MySqlCommand cmd = new MySqlCommand("proc_deletaMarca", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codMarca", codMarca);
            try
            {
                conectaBD.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conectaBD.Close();
            }
        }

        //PPPPP RRRRR OOOOO DDDD  UU UU TTTTT OOOOO SSSSS
        //PP PP RR RR OO OO DD DD UU UU TTTTT OO OO SS
        //PPPPP RRRRR OO OO DD DD UU UU  TTT  OO OO SSSSS
        //PP    RRRR  OO OO DD DD UU UU  TTT  OO OO    SS
        //PP    RR RR OOOOO DDDD  UUUUU  TTT  OOOOO SSSSS
        public DataTable listaProdutos()
        {
            // comentario
            MySqlCommand cmd = new MySqlCommand("Yproc_selectAllProduts", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conectaBD.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conectaBD.Close();
            }

        }
        public bool insereProdutos(Produto pr)
        {
            MySqlCommand cmd = new MySqlCommand("proc_insereProduto", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nome", pr.NomeProduto);
            cmd.Parameters.AddWithValue("quantidade", pr.QuantidadeProduto);
            cmd.Parameters.AddWithValue("estoque", pr.EstoqueProduto);
            cmd.Parameters.AddWithValue("preco", pr.PrecoProduto);
            cmd.Parameters.AddWithValue("codMarca", pr.CodMarca);

            try
            {
                conectaBD.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conectaBD.Close();
            }
        }
        public bool alteraProdutos(Produto pr, int codProd)
        {
            MySqlCommand cmd = new MySqlCommand("proc_alteraProduto", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codProduto", codProd);
            cmd.Parameters.AddWithValue("nome", pr.NomeProduto);
            cmd.Parameters.AddWithValue("quantidade", pr.QuantidadeProduto);
            cmd.Parameters.AddWithValue("estoque", pr.EstoqueProduto);
            cmd.Parameters.AddWithValue("preco", pr.PrecoProduto);
            cmd.Parameters.AddWithValue("codMarca", pr.CodMarca);

            try
            {
                conectaBD.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conectaBD.Close();
            }
        }
        public bool deletaProduto(int codProd)
        {
            MySqlCommand cmd = new MySqlCommand("proc_deletaProduto", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codProduto", codProd);
            try
            {
                conectaBD.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conectaBD.Close();
            }
        }

        //V   V EEEEE N   N DDDD  AAAAA
        //V   V EE    NN  N DD DD A   A
        // V V  EEEEE N N N DD DD AAAAA
        // V V  EE    N  NN DD DD A   A
        //  V   EEEEE N   N DDDD  A   A

        public DataTable listaVenda()
        {
            // comentario
            MySqlCommand cmd = new MySqlCommand("Yproc_selectAllProduts", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conectaBD.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conectaBD.Close();
            }

        }

        public bool insereVendas(Venda venda)
        {
            MySqlCommand cmd = new MySqlCommand("proc_insereVenda", conectaBD);
            cmd.CommandType = CommandType.StoredProcedure;

            // Convertendo a dataVenda de string para DateTime
            DateTime dataVenda;
            if (!DateTime.TryParse(venda.DataVenda, out dataVenda))
            {
                mensagem = "Formato de data inválido.";
                return false; // Retorna false se a data não puder ser convertida
            }

            // Adicionando os parâmetros necessários
            cmd.Parameters.AddWithValue("codCliente", venda.CodCliente);
            cmd.Parameters.AddWithValue("statusDaVenda", venda.StatusDaVenda);
            cmd.Parameters.AddWithValue("dataVenda", dataVenda); // Passa o DateTime
            cmd.Parameters.AddWithValue("codTransporte", venda.CodTransporte);

            try
            {
                conectaBD.Open();
                cmd.ExecuteNonQuery();
                return true; // Retorna true se a inserção foi bem-sucedida
            }
            catch (MySqlException e)
            {
                mensagem = "Erro: " + e.Message;
                return false; // Retorna false se ocorreu um erro
            }
            finally
            {
                conectaBD.Close(); // Garante que a conexão seja fechada
            }
        }
    }
}