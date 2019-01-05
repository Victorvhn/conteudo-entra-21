using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Youtuber
    {
        public static int UltimoCodigo;
        private int Codigo;
        private string Nome;
        private string Sobrenome;
        private string Apelido;
        private string NomeCanal;
        private long QuantidadeInscritos;
        private long QuantidadeVisualizacoes;
        private long QuantidadeLikes;
        private int QuantidadeVideos;
        private string Categoria;
        private bool TemAnuncios;
        private string Descricao;
        private double Renda;
        private string Nacionalidade;
        private bool TemPatrocinador;
        private int QuantidadeStrikes;
        private string Plataforma;
        private bool Streamer;
        private string LinkCanal;

        public int GetCodigo()
        {
            return Codigo;
        }
        public void SetCodigo(int codigo)
        {
            this.Codigo = codigo;
        }

        public void SetNome(string nome)
        {
            if (nome.Trim().Count() < 3)
            {
                throw new Exception("Nome deve conter mais que 3 caracteres");
            }
            if (nome.Trim().Count() > 50)
            {
                throw new Exception("Nome deve conter no máximo 50 caracteres");
            }
            Nome = nome;
        }
        public string GetNome()
        {
            return Nome;
        }        

        public void SetSobrenome(string sobrenome)
        {
            if (sobrenome.Trim().Count() < 3)
            {
                throw new Exception("Sobrenome deve conter mais que 3 caracteres");
            }
            if (sobrenome.Trim().Count() > 50)
            {
                throw new Exception("Sobrenome deve conter no máximo 50 caracteres");
            }
            Sobrenome = sobrenome;
        }
        public string GetSobrenome()
        {
            return Sobrenome;
        }

        public void SetApelido(string apelido)
        {
            if (apelido.Trim().Count() < 3)
            {
                throw new Exception("Apelido deve conter mais que 3 caracteres");
            }
            if (apelido.Trim().Count() > 50)
            {
                throw new Exception("Apelido deve conter no máximo 50 caracteres");
            }
            Apelido = apelido;
        }
        public string GetApelido()
        {
            return Apelido;
        }

        public void SetNomeCanal(string nomeCanal)
        {
            if (nomeCanal.Trim().Count() < 3)
            {
                throw new Exception("Nome do Canal deve conter mais que 3 caracteres");
            }
            if (nomeCanal.Trim().Count() > 50)
            {
                throw new Exception("Nome do Canal deve conter no máximo 50 caracteres");
            }
            NomeCanal = nomeCanal;
        }
        public string GetNomeCanal()
        {
            return NomeCanal;
        }

        public void SetQuantidadeInscritos(long quantidadeInscritos)
        {
            if (quantidadeInscritos < 0)
            {
                throw new Exception("Quantidade de inscritos deve ser maior ou igual a 0");
            }
            if (quantidadeInscritos.ToString() == "")
            {
                throw new Exception("Quantidade de inscritos deve ser maior ou igual a 0");
            }
            if (quantidadeInscritos > long.MaxValue)
            {
                throw new Exception("Quantidade de inscritos deve ser menor ou igual a " + long.MaxValue);
            }
            QuantidadeInscritos = quantidadeInscritos;
        }
        public long GetQuantidadeInscritos()
        {
            return QuantidadeInscritos;
        }

        public void SetQuantidadeVisualizacoes(long quantidadeVisualizacoes)
        {
            if (quantidadeVisualizacoes < 0)
            {
                throw new Exception("Quantidade de visualizações deve ser maior ou igual a 0");
            }
            if (quantidadeVisualizacoes > long.MaxValue)
            {
                throw new Exception("Quantidade de visualizações deve ser menor ou igual a " + long.MaxValue);
            }
            QuantidadeVisualizacoes = quantidadeVisualizacoes;
        }
        public long GetQuantidadeVisualizacoes()
        {
            return QuantidadeVisualizacoes;
        }

        public void SetQuantidadeLikes(long quantidadeLikes)
        {
            if (quantidadeLikes < 0)
            {
                throw new Exception("Quantidade de likes deve ser maior ou igual a 0");
            }
            if (quantidadeLikes > long.MaxValue)
            {
                throw new Exception("Quantidade de likes deve ser menor que ou igual a " + long.MaxValue);
            }
            QuantidadeLikes = quantidadeLikes;
        }
        public long GetQuantidadeLikes()
        {
            return QuantidadeLikes;
        }

        public void SetQuantidadeVideos(int quantidadeVideos)
        {
            if (quantidadeVideos < 0)
            {
                throw new Exception("Quantidade de vídeos deve ser maior ou igual a 0");
            }
            if (quantidadeVideos < 0)
            {
                throw new Exception("Quantidade de vídeos deve ser menor ou igual a " + int.MaxValue);
            }
            QuantidadeVideos = quantidadeVideos;
        }
        public int GetQuantidadeVideos()
        {
            return QuantidadeVideos;
        }

        public void SetCategoria(string categoria)
        {
            Categoria = categoria;
        }
        public string GetCategoria()
        {
            return Categoria;
        }

        public void SetTemAnuncios(bool temAnuncios)
        {
            TemAnuncios = temAnuncios;
        }
        public bool GetTemAnuncios()
        {
            return TemAnuncios;
        }

        public void SetDescricao(string descricao)
        {
            if (descricao.Count() > 500)
            {
                throw new Exception("Descrição deve ter no máximo 500 caracteres");
            }
            Descricao = descricao;
        }
        public string GetDescricao()
        {
            return Descricao;
        }

        public void SetRenda(double renda)
        {
            if (renda < 0)
            {
                throw new Exception("Renda deve ser maior ou igual a 0");
            }
            Renda = renda;
        }
        public double GetRenda()
        {
            return Renda;
        }

        public void SetNacionalidade(string nacionalidade)
        {
            Nacionalidade = nacionalidade;
        }
        public string GetNacionalidade()
        {
            return Nacionalidade;
        }

        public void SetTemPatrocinador(bool temPatrocinador)
        {
            TemPatrocinador = temPatrocinador;
        }
        public bool GetTemPatrocinador()
        {
            return TemPatrocinador;
        }

        public void SetQuantidadeStrikes(int quantidadeStrikes)
        {
            if (quantidadeStrikes < 0)
            {
                throw new Exception("Quantidade de strikes deve ser maior ou igual a 0");
            }
            if (quantidadeStrikes > 3)
            {
                throw new Exception("Quantidade de strikes deve ser menor ou igual a 3");
            }
            QuantidadeStrikes = quantidadeStrikes;
        }
        public int GetQuantidadeStrikes()
        {
            return QuantidadeStrikes;
        }

        public void SetPlataforma(string plataforma)
        {
            Plataforma = plataforma;
        }
        public string GetPlataforma()
        {
            return Plataforma;
        }

        public void SetStreamer(bool streamer)
        {
            Streamer = streamer;
        }
        public bool GetStreamer()
        {
            return Streamer;
        }

        public void SetLinkCanal(string linkCanal)
        {
            if (linkCanal.Count() < 8)
            {
                throw new Exception("Coloque um link valido");
            }
            LinkCanal = linkCanal;
        }
        public string GetLinkCanal()
        {
            return LinkCanal;
        }
    }
}
