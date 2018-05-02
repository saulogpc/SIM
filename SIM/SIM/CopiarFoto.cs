using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIM
{
    public class CopiarFoto
    {
        public bool CopiarParaLocalDoAplicativo(string Arquivo)
        {
            try
            {
                string caminhoDoExecutavel = System.Reflection.Assembly.GetCallingAssembly().Location;
                string pastaDoExecutavel = new System.IO.FileInfo(caminhoDoExecutavel).DirectoryName;

                //string nomeDoArquivo = Arquivo.Split(new char[] { '\\' })[Arquivo.Split(new char[] { '\\' }).Length - 1];

                string novoCaminhoArquivo = pastaDoExecutavel + @"\FOTOS\Perfil\" + Constantes.idLogado +".png";

                System.IO.File.Copy(Arquivo, novoCaminhoArquivo, true);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
