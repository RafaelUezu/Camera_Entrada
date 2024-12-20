
using System;
using System.IO;
using System.Globalization;

namespace Camera_Entrada.Model.DataBase.Image
{
    internal class ImageCleaner
    {
        public void ApagarImagensAntigas(string diretorio, int meses)
        {
            // Define a data limite (3 meses atrás da data atual)

            DateTime dataLimite = DateTime.Now.AddMonths(-1*meses);

            // Obtém todos os arquivos de imagem no diretório (exemplo: jpg, png)
            // Ajuste o filtro conforme a necessidade. Aqui, uso *.jpg apenas como exemplo.
            string[] arquivos = Directory.GetFiles(diretorio, "*.jpg");

            foreach (var arquivo in arquivos)
            {
                // Obtém o nome sem extensão
                string nomeSemExtensao = Path.GetFileNameWithoutExtension(arquivo);

                // Verifica se o nome possui ao menos 11 caracteres (XXXddmmyyyy)
                if (nomeSemExtensao.Length >= 11)
                {
                    string ddStr = nomeSemExtensao.Substring(3, 2);   // dia
                    string mmStr = nomeSemExtensao.Substring(5, 2);   // mês
                    string yyyyStr = nomeSemExtensao.Substring(7, 4); // ano

                    // Tenta converter para inteiro
                    if (int.TryParse(ddStr, out int dia) &&
                        int.TryParse(mmStr, out int mes) &&
                        int.TryParse(yyyyStr, out int ano))
                    {
                        // Tenta criar o DateTime a partir dos valores extraídos
                        if (DateTime.TryParseExact(ddStr + mmStr + yyyyStr, "ddMMyyyy",
                                                   CultureInfo.InvariantCulture,
                                                   DateTimeStyles.None,
                                                   out DateTime dataArquivo))
                        {
                            // Se a data do arquivo for mais antiga que a data limite, apaga
                            if (dataArquivo < dataLimite)
                            {
                                File.Delete(arquivo);
                            }
                        }
                    }
                }
            }
        }
    }
}
