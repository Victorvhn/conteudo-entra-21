using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace WFA
{
    [Serializable]
    class YoutuberRepository
    {
        List<Youtuber> youtubers = new List<Youtuber>();

        public YoutuberRepository()
        {
            if (File.Exists(ListaDeCriadoresDeConteudo.NOME_ARQUIVO))
            {
                BinaryFormatter binaryReader = new BinaryFormatter();
                Stream stream = File.OpenRead(ListaDeCriadoresDeConteudo.NOME_ARQUIVO);
                youtubers = ((YoutuberRepository)binaryReader.Deserialize(stream)).ObterYoutuber();
                stream.Close();
                int maiorCodigo = int.MinValue;
                foreach (Youtuber youtuber in youtubers)
                {
                    maiorCodigo = youtuber.GetCodigo() > maiorCodigo ? youtuber.GetCodigo() : maiorCodigo;
                }
                if (Youtuber.UltimoCodigo == 0)
                {
                    Youtuber.UltimoCodigo = maiorCodigo;
                }
            }
        }

        private void EscreverNoArquivoDosYoutubers()
        {
            BinaryFormatter binaryWrite = new BinaryFormatter();
            Stream stream = new FileStream(ListaDeCriadoresDeConteudo.NOME_ARQUIVO, FileMode.Create, FileAccess.Write);
            binaryWrite.Serialize(stream, this);
            stream.Close();
        }

        public List<Youtuber> ObterYoutuber()
        {
            return youtubers;
        }

        internal void AdicionarYoutuber(Youtuber youtuber)
        {
            youtuber.SetCodigo(++Youtuber.UltimoCodigo);
            youtubers.Add(youtuber);

            EscreverNoArquivoDosYoutubers();
        }

        internal void EditarYoutuber(Youtuber youtuber, int posicao)
        {
            for (int i = 0; i < youtubers.Count(); i++)
            {
                Youtuber youtuberAux = youtubers[i];
                if (youtuberAux.GetCodigo() == posicao)
                {
                    youtubers[i] = youtuber;
                    EscreverNoArquivoDosYoutubers();
                    return;

                }
            }

        }
                
        public int RetornarQuantidade()
        {
            return youtubers.Count();
        }

        internal void ApagarYoutuber(int codigo)
        {
            foreach (Youtuber youtuber in youtubers)
            {
                if (youtuber.GetCodigo() == codigo)
                {
                    youtubers.Remove(youtuber);
                    EscreverNoArquivoDosYoutubers();
                    return;
                }
            }
        }
    }
}
