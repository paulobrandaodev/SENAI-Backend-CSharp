using System;
using System.Drawing;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;

namespace aula7_manipulacao_arquivos_word
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Criar documento
                // Cria um documento com o nome exemploDoc
            Document exemploDoc = new Document();
            #endregion

            #region Criar seção no documento
                // Cria uma seção com o nome secaoCapa e adiciona ao documento
                // Cada seção pode ser entendida como uma página do arquivo
                // Portanto, caso seja adicionada uma nova seção, é feita uma quebra de página no arquivo e uma nova página é criada
            Section secaoCapa = exemploDoc.AddSection();
            #endregion

            #region Criar parágrafo
                // Cria um parágrafo com o nome titulo e adiciona à seção secaoCapa
                // Os parágrafos são necessários para a inserção de textos, imagens, tabelas etc, ainda que o conteúdo ocupe apenas uma linha
                // Para que parágrafos possam ser adicionados, é preciso declarar o uso da dependência Spire.Doc.Document
            Paragraph titulo = secaoCapa.AddParagraph();
            #endregion


            #region Adicionar texto ao parágrafo
                // Adiciona um texto ao parágrafo titulo criado anteriormente
                // Assim como em console, é possível utilizar o comando \n para definir uma nova linha
                // Ou seja, no comando abaixo é atribuído um texto e dá-se um espaçamento de duas linhas em seguida
            titulo.AppendText("Exemplo de título\n\n");
            #endregion
            
            #region Formatar parágrafo
                // Através da propriedade HorizontalAligment, é possível alinhar o parágrafo horizontalmente
                // No exemplo abaixo, o parágrafo é alinhado ao centro
                titulo.Format.HorizontalAlignment = HorizontalAlignment.Center;

                // Cria um estilo de formatação
                // Para definir parâmetros de estilização de parágrafo, cria-se um estilo de formatação e adiciona ao documento
                ParagraphStyle estilo01 = new ParagraphStyle(exemploDoc);

                // Define um nome para o estilo
                estilo01.Name = "Cor do título";

                // Define a cor do texto
                // Para que a cor do texto possa ser definida, é preciso declarar o uso da dependência System.Drawing
                estilo01.CharacterFormat.TextColor = Color.DarkBlue;

                // Define que o texto deste estilo será em negrito (bold)
                estilo01.CharacterFormat.Bold = true;

                // Adiciona o estilo ao documento
                exemploDoc.Styles.Add(estilo01);

                // Aplica o estilo ao parágrafo
                // O método ApplyStyle recebe como parâmetro o nome do estilo, que pode ser definido pela propriedade (exemplo abaixo)
                // ou passando o nome do estilo como string ex: ("Cor do título")
                titulo.ApplyStyle(estilo01.Name);
            #endregion

            #region Trabalhar com tabulação
                // Adiciona um novo parágrafo na mesma seção
                Paragraph textoCapa = secaoCapa.AddParagraph();

                // Adiciona um texto ao parágrafo com tabulação (\t é semelhante à tecla tab)
                textoCapa.AppendText("\tEste é um exemplo de criação de um parágrafo utilizando a biblioteca Spire.Doc\n");

                // Adiciona mais um novo parágrafo na mesma seção
                Paragraph textoCapa2 = secaoCapa.AddParagraph();

                // Adiciona um texto ao parágrafo com concatenação
                textoCapa2.AppendText("\tBasicamente, então, uma seção representa uma página e os parágrafos dentro de uma mesma seção, " +
                "obviamente, aprecem na mesma página.");
            #endregion

            #region Inserir imagens
                // Adiciona um novo parágrafo na mesma seção
                Paragraph imagemCapa = secaoCapa.AddParagraph();

                // Adiciona um texto ao parágrafo
                imagemCapa.AppendText("\n\n\tAgora vamos inserir uma imagem em um parágrafo\n\n");

                // Centraliza o texto acima
                imagemCapa.Format.HorizontalAlignment = HorizontalAlignment.Center;

                // Adiciona uma imagem ao parágrafo
                DocPicture imagemExemplo = imagemCapa.AppendPicture(Image.FromFile(@"saida\img\logo_csharp.png"));

                // Define a largura e a altura da imagem
                imagemExemplo.Width = 300;
                imagemExemplo.Height = 300;
            #endregion

            #region Adicionar nova seção
                // Adiciona uma nova seção
                Section secaoCorpo = exemploDoc.AddSection();

                // Adiciona um novo parágrafo a esta nova seção
                Paragraph paragrafoCorpo1 = secaoCorpo.AddParagraph();

                // Adiciona um texto a este parágrafo
                paragrafoCorpo1.AppendText("\tEste é um exemplo de criação de um parágrafo em uma nova página, após uma quebra de seção. " +
                "Assim como quando utilizamos variáveis, é possível fechar aspas, inserir um sinal '+' e continuar o parágrafo.\n\n" +
                "\tComo foi criada outra seção, perceba que o parágrafo acima começou em outra página.\n");
            #endregion

            #region Adicionar uma tabela
                // Adiciona uma tabela
                Table tabela = secaoCorpo.AddTable(true);

                // Cria o cabeçalho da tabela
                String[] cabecalho ={"Item", "Descrição", "Qtd.", "Preço Unit", "Preço"};

                // Cria os dados da tabela
                String[][] dados = {
                    new String[]{"Cenoura", "Vegetal muito nutritivo", "1", "R$ 4,00", "R$ 4,00"},
                    new String[]{"Batata", "Vegetal muito consumido", "2", "R$ 5,00", "R$ 10,00"},
                    new String[]{"Alface", "Vegetal utilizado desde 500 a.C.", "1", "R$ 1,50", "R$ 1,50"},
                    new String[]{"Tomate", "Tomate é uma fruta", "2", "R$ 6,00", "R$ 12,00"}
                };

                // Adiciona as células da tabela
                tabela.ResetCells(dados.Length + 1, cabecalho.Length);

                // Adiciona uma linha na posição [0] do array de linhas e define que ela é o cabeçalho
                TableRow Linha1 = tabela.Rows[0];
                Linha1.IsHeader = true;

                // Define a altura da linha
                Linha1.Height = 23;

                // Formatação do cabeçalho
                Linha1.RowFormat.BackColor = Color.AliceBlue;
                for (int i = 0; i < cabecalho.Length; i++)
                {
                    // Alinhamento das células
                    Paragraph p = Linha1.Cells[i].AddParagraph();
                    Linha1.Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                    p.Format.HorizontalAlignment = HorizontalAlignment.Center;

                    // Formatação dos dados do cabeçalho
                    TextRange TR = p.AppendText(cabecalho[i]);
                    TR.CharacterFormat.FontName = "Calibri";
                    TR.CharacterFormat.FontSize = 14;
                    TR.CharacterFormat.TextColor = Color.Teal;
                    TR.CharacterFormat.Bold = true;
                }

                // Adiciona as linhas do corpo da tabela
                for (int r = 0; r < dados.Length; r++)
                {
                    TableRow LinhaDados = tabela.Rows[r + 1];

                    // Define a altura da linha
                    LinhaDados.Height = 20;

                    // Percorre as colunas
                    for (int c = 0; c < dados[r].Length; c++)
                    {
                        // Alinha as células
                        LinhaDados.Cells[c].CellFormat.VerticalAlignment = VerticalAlignment.Middle;

                        // Preenche os dados nas linhas
                        Paragraph p2 = LinhaDados.Cells[c].AddParagraph();
                        TextRange TR2 = p2.AppendText(dados[r][c]);
                        
                        // Formata as células
                        p2.Format.HorizontalAlignment = HorizontalAlignment.Center;
                        TR2.CharacterFormat.FontName = "Calibri";
                        TR2.CharacterFormat.FontSize = 12;
                        TR2.CharacterFormat.TextColor = Color.Brown;
                    }
                }
            #endregion

            #region Salvar arquivo
                // Salvando o arquivo
                // Utiliza o método SaveToFile para salvar com o nome e o formato escolhido
                // Assim como no Word, caso já exista um arquivo com o mesmo nome, este será substituído por um novo
                exemploDoc.SaveToFile(@"saida\exemplo_arquivo_word.docx", FileFormat.Docx);
            #endregion
        }
    }
}
