using System;
using System.Drawing;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;

namespace resolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria um documento exercicio
            Document exercicio = new Document();

            #region item 1
                // Cria uma seção capa e adiciona ao documento
                Section capa = exercicio.AddSection();

                    #region item 1.1
                        // Cria um parágrafo titulo e adiciona à seção capa
                        Paragraph titulo = capa.AddParagraph();

                        // Adiciona um texto ao parágrafo titulo
                        titulo.AppendText("\n\nExercício resolvido!\n\n");

                        // Centraliza o parágrafo titulo
                        titulo.Format.HorizontalAlignment = HorizontalAlignment.Center;
                    #endregion

                    #region item 1.2
                        // Cria novo parágrafo texto e adiciona à seção capa
                        Paragraph texto = capa.AddParagraph();

                        // Adiciona um texto ao parágrafo texto
                        texto.AppendText("\n\nFonte Arial Negrito, Itálico e Sublinhado, Tamanho 18\n\n\n\n");

                        // Centraliza o parágrafo texto
                        texto.Format.HorizontalAlignment = HorizontalAlignment.Center;

                        // Cria um estilo
                        ParagraphStyle estilo00 = new ParagraphStyle(exercicio);

                        // Define um nome para o estilo
                        estilo00.Name = "Multiplos estilos";

                        // Define que a fonte será Arial
                        estilo00.CharacterFormat.FontName = "Arial";

                        // Define que a fonte terá tamanho 18
                        estilo00.CharacterFormat.FontSize = 18;

                        // Define que o texto será em negrito
                        estilo00.CharacterFormat.Bold = true;

                        // Define que o texto será em itálico
                        estilo00.CharacterFormat.Italic = true;

                        // Define que o texto será sublinhado
                        estilo00.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;

                        // Adiciona o estilo ao documento
                        exercicio.Styles.Add(estilo00);

                        // Aplica o estilo01 ao parágrafo texto
                        texto.ApplyStyle("Multiplos estilos");
                    #endregion

                    #region item 1.3
                        // Adiciona uma tabela
                        Table tabela = capa.AddTable(true);

                        // Cria o cabeçalho
                        String[] cabecalho = { "Nome", "Descrição", "Nome Vendedor(a)", "Preço" };                        

                        // Cria os dados da tabela
                        String[][] dados = {
                                    new String[]{"Marmita 1", "Picadinho", "Persona 1", "R$ 10,00"},
                                    new String[]{"Marmita 2", "Bife acebolado", "Persona 2", "R$ 10,00"},
                                    new String[]{"Marmita 3", "Legumes refogados", "Persona 3", "R$ 12,00"}
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

                        // Centraliza a tabela
                        tabela.TableFormat.HorizontalAlignment = RowAlignment.Center;
                    #endregion
            #endregion            

            #region item 2
                // Cria uma seção corpo e adiciona ao documento
                Section corpo = exercicio.AddSection();

                #region item 2.1 e 2.2
                    // Cria um parágrafo imagem e adiciona à seção corpo
                    Paragraph imagem = corpo.AddParagraph();

                    // Adiciona um espaço ao parágrafo imagem antes de inserir a imagem dos pinguins
                    imagem.AppendText("\n\n\n\n");

                    // Adiciona uma imagem pinguins ao parágrafo imagem
                    DocPicture pinguins = imagem.AppendPicture(Image.FromFile(@"img\pinguins.jpeg"));

                    // Define a largura e a altura da imagem
                    pinguins.Width = 450;
                    pinguins.Height = 350;

                    // Adiciona um texto ao parágrafo imagem
                    imagem.AppendText("\n\nPinguins dançantes!\n\n");

                    // Centraliza o parágrafo imagem
                    imagem.Format.HorizontalAlignment = HorizontalAlignment.Center;

                    // Cria um estilo para o parágrafo imagem
                    ParagraphStyle estiloimg = new ParagraphStyle(exercicio);

                    // Define um nome para o estilo
                    estiloimg.Name = "Estilo imagem";

                    // Define que a fonte será Arial
                    estiloimg.CharacterFormat.FontName = "Arial";

                    // Define que a fonte terá tamanho 14
                    estiloimg.CharacterFormat.FontSize = 14;

                    // Adiciona o estilo ao documento
                    exercicio.Styles.Add(estiloimg);

                    // Aplica o estiloimg ao parágrafo imagem
                    imagem.ApplyStyle("Estilo imagem");
                #endregion

                #region item 2.3
                    // Adiciona um parágrafo vazio para que a imagem apareça na página seguinte no pdf
                    Paragraph breaksection = capa.AddParagraph();

                    #region item 3.2
                    // Cria novo parágrafo desafio e adiciona à seção corpo
                    Paragraph desafio = corpo.AddParagraph();

                    // Adiciona um trecho de texto ao parágrafo desafio
                    TextRange trecho01 = desafio.AppendText("\n\n\n\n\n\n\n\n\n\n\n\n\n\nTrecho em Negrito, ");

                    // Formata o trecho01 para ser negrito
                    trecho01.CharacterFormat.Bold = true;

                    // Adiciona um trecho de texto ao parágrafo desafio
                    TextRange trecho02 = desafio.AppendText("trecho Itálico, ");

                    // Formata o trecho02 para ser itálico
                    trecho02.CharacterFormat.Italic = true;

                    // Adiciona um trecho de texto ao parágrafo desafio
                    TextRange trecho03 = desafio.AppendText("trecho Sublinhado");

                    // Formata o trecho03 para ser sublinhado
                    trecho03.CharacterFormat.UnderlineStyle = UnderlineStyle.Single;

                    // Centraliza o parágrafo desafio
                    desafio.Format.HorizontalAlignment = HorizontalAlignment.Center;

                    // Cria um estilo para o parágrafo desafio
                    ParagraphStyle desafioStyle = new ParagraphStyle(exercicio);

                    // Define um nome para o estilo
                    desafioStyle.Name = "Estilo desafio";

                    // Define que a fonte será Arial
                    desafioStyle.CharacterFormat.FontName = "Arial";

                    // Define que a fonte terá tamanho 14
                    desafioStyle.CharacterFormat.FontSize = 14;

                    // Adiciona o estilo ao documento
                    exercicio.Styles.Add(desafioStyle);

                    // Aplica o desafioStyle ao parágrafo desafio
                    desafio.ApplyStyle("Estilo desafio");
                    #endregion
                #endregion

                // Salva o documento em PDF
                exercicio.SaveToFile(@"saida\exercicio_resolvido.pdf", FileFormat.PDF);
            #endregion

            // Salva o documento em Docx
            exercicio.SaveToFile(@"saida\exercicio_resolvido.docx", FileFormat.Docx);

            #region item 3
                #region item 3.1
                    // Salva o documento em html
                    exercicio.SaveToFile(@"saida\exercicio_resolvido.html", FileFormat.Html);
                #endregion
            #endregion
        }
    }
}
