using System;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing.Printing;
using ZXing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Word = Microsoft.Office.Interop.Word;

namespace cdo_den
{
    public partial class PrintContract : Form
    {
        DataGridViewRow data;

        public PrintContract(DataGridViewRow a)
        {
            data = a;
            InitializeComponent();
        }

        private void PrintContract_Load(object sender, EventArgs e)
        {
            File.Delete("temp_file.png");
            genTicketImage();
        }

        private void button_TicketDocx_Click(object sender, EventArgs e)
        {
            ticketToDoc();
        }

        private void button_TicketPDF_Click(object sender, EventArgs e)
        {
            ticketToPdf();
        }

        private void button_TicketPrint_Click(object sender, EventArgs e)
        {
            toPrint(true);
        }

        private void button_ContractDocx_Click(object sender, EventArgs e)
        {
            contractToDoc();
        }

        private void button_ContractPDF_Click(object sender, EventArgs e)
        {
            contractToPdf();
        }

        private void button_ContractPrint_Click(object sender, EventArgs e)
        {
            toPrint(false);
        }

        private void toPrint(bool a)
        {
            if (a)
            {
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument1;

                if (printDialog.ShowDialog() == DialogResult.OK)
                    printDialog.Document.Print();
            }
            else
            {
                try
                {
                    string fileName = $"{Directory.GetCurrentDirectory()}/contracts/id {data.Cells[0].Value} - {data.Cells[9].Value}.docx";
                    ProcessStartInfo info = new ProcessStartInfo(fileName);
                    info.Verb = "Print";
                    info.CreateNoWindow = true;
                    info.WindowStyle = ProcessWindowStyle.Hidden;
                    Process.Start(info);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pictureBox_Ticket.Image, 0, 0);
        }






        private void genTicketImage()
        {
            Bitmap image = new Bitmap(1260, 620);
            Graphics g = Graphics.FromImage(image);

            var small = new System.Drawing.Font("Arial", 10);
            var big = new System.Drawing.Font("Arial", 16);
            var bigb = new System.Drawing.Font("Arial", 16, FontStyle.Bold);

            g.Clear(Color.White);

            g.DrawLine(Pens.Black, 10, 10, 10, 610);
            g.DrawLine(Pens.Black, 310, 10, 310, 610);
            g.DrawLine(Pens.Black, 1250, 10, 1250, 610);
            g.DrawLine(Pens.Black, 10, 10, 1250, 10);
            g.DrawLine(Pens.Black, 310, 65, 1250, 65);
            g.DrawLine(Pens.Black, 310, 120, 1250, 120);
            g.DrawLine(Pens.Black, 310, 175, 1250, 175);
            g.DrawLine(Pens.Black, 310, 235, 1250, 235);
            g.DrawLine(Pens.Black, 310, 275, 1250, 275);
            g.DrawLine(Pens.Black, 310, 315, 1250, 315);
            g.DrawLine(Pens.Black, 310, 355, 1250, 355);
            g.DrawLine(Pens.Black, 310, 395, 1250, 395);
            g.DrawLine(Pens.Black, 310, 435, 1250, 435);
            g.DrawLine(Pens.Black, 310, 475, 1250, 475);
            g.DrawLine(Pens.Black, 310, 515, 1250, 515);
            g.DrawLine(Pens.Black, 10, 610, 1250, 610);

            int xl = (int)g.MeasureString("Квитанция", bigb).Width;
            g.DrawString("Квитанция", bigb, Brushes.Black, (310 - xl) / 2, 145);
            g.DrawImage(getQr(data.Cells[9].Value.ToString()), 25, 175);

            xl = (int)g.MeasureString("Форма №ПД-4", small).Width;
            g.DrawString("Форма №ПД-4", small, Brushes.Black, (940 - xl) / 2 + 310, 11);
            xl = (int)g.MeasureString("Воронежский филиал РЭУ им. Г. В. Плеханова", bigb).Width;
            g.DrawString("Воронежский филиал РЭУ им. Г. В. Плеханова", bigb, Brushes.Black, (940 - xl) / 2 + 310, 35);
            xl = (int)g.MeasureString("(наименование получателя платежа)", small).Width;
            g.DrawString("(наименование получателя платежа)", small, Brushes.Black, (940 - xl) / 2 + 310, 66);
            xl = (int)g.MeasureString("ИНН 7705043493 КПП 366643101", big).Width;
            g.DrawString("ИНН 7705043493 КПП 366643101", big, Brushes.Black, (470 - xl) / 2 + 310, 90);
            xl = (int)g.MeasureString("032146431000000013100", big).Width;
            g.DrawString("032146431000000013100", big, Brushes.Black, (470 - xl) / 2 + 780, 90);
            xl = (int)g.MeasureString("(инн получателя платежа)", small).Width;
            g.DrawString("(инн получателя платежа)", small, Brushes.Black, (470 - xl) / 2 + 310, 121);
            xl = (int)g.MeasureString("(номер счета получателя платежа)", small).Width;
            g.DrawString("(номер счета получателя платежа)", small, Brushes.Black, (470 - xl) / 2 + 780, 121);
            xl = (int)g.MeasureString("БИК 012007084 (ОТДЕЛЕНИЕ ВОРОНЕЖ БАНКА РОССИИ)", big).Width;
            g.DrawString("БИК 012007084 (ОТДЕЛЕНИЕ ВОРОНЕЖ БАНКА РОССИИ)", big, Brushes.Black, (940 - xl) / 2 + 310, 145);
            xl = (int)g.MeasureString("(наименование банка получателя платежа)", small).Width;
            g.DrawString("(наименование банка получателя платежа)", small, Brushes.Black, (940 - xl) / 2 + 310, 176);
            g.DrawString("Договор: " + data.Cells[9].Value, bigb, Brushes.Black, 315, 205);
            g.DrawString("ФИО обучающегося: " + data.Cells[2].Value, bigb, Brushes.Black, 315, 245);
            g.DrawString("Назначение: Оплата за курсы", bigb, Brushes.Black, 315, 285);
            g.DrawString("ФИО плательщика: " + data.Cells[3].Value, bigb, Brushes.Black, 315, 325);
            g.DrawString("Адрес плательщика: " + data.Cells[4].Value, bigb, Brushes.Black, 315, 365);
            g.DrawString("КБК: 00000130", bigb, Brushes.Black, 315, 405);
            g.DrawString("ОКТМО: 20701000", bigb, Brushes.Black, 315, 445);
            g.DrawString("Сумма: " + data.Cells[5].Value, bigb, Brushes.Black, 315, 485);
            g.DrawString("С условиями приёма указанной в платёжном документе суммы, в т.ч. с суммой взимаемой платы за услуги банка ознакомлен и согласен.", small, Brushes.Black, 315, 520);
            g.DrawString("Подпись плательщика _____________________", small, Brushes.Black, 315, 580);

            pictureBox_Ticket.Image = image;
            image.Save("temp_file.png", System.Drawing.Imaging.ImageFormat.Png);
        }

        private Bitmap getQr(string text)
        {
            BarcodeWriter writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new ZXing.QrCode.QrCodeEncodingOptions
                {
                    Width = 270,
                    Height = 270,
                    Margin = 0
                }
            };

            var qrCode = writer.Write("ticket_" + text);
            return qrCode;
        }

        private void ticketToDoc()
        {
            try
            {
                if (!Directory.Exists("tickets"))
                    Directory.CreateDirectory("tickets");

                Word.Application wordApp = new Word.Application();
                Word.Document wordDoc = wordApp.Documents.Add();
                Word.Range range = wordDoc.Range(0, 0);
                range.InlineShapes.AddPicture(Directory.GetCurrentDirectory() + "/temp_file.png");
                wordDoc.SaveAs($"{Directory.GetCurrentDirectory()}/tickets/id {data.Cells[0].Value} - {data.Cells[9].Value}.docx");
                wordDoc.Close();
                wordApp.Quit();
                MessageBox.Show($"Файл сохранен!\nПуть: /tickets/id {data.Cells[0].Value} - {data.Cells[9].Value}.docx", "2DOCX");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void ticketToPdf()
        {
            if (!Directory.Exists("tickets"))
                Directory.CreateDirectory("tickets");

            try
            {
                Document document = new Document();
                using (var writer = PdfWriter.GetInstance(document, new FileStream($"tickets/id {data.Cells[0].Value} - {data.Cells[9].Value}.pdf", FileMode.Create)))
                {
                    document.Open();

                    var fileStream = new FileStream("temp_file.png", FileMode.Open);
                    var img = iTextSharp.text.Image.GetInstance(fileStream);

                    img.ScaleAbsoluteWidth(document.PageSize.Width);
                    img.ScaleAbsoluteHeight(img.Height * (document.PageSize.Width / img.Width));
                    img.SetAbsolutePosition(0, document.PageSize.Height - (img.Height * (document.PageSize.Width / img.Width)));

                    writer.DirectContent.AddImage(img);

                    document.Close();
                    fileStream.Dispose();

                    MessageBox.Show($"Файл сохранен!\nПуть: /tickets/id {data.Cells[0].Value} - {data.Cells[9].Value}.pdf", "2PDF");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void contractToDoc()
        {
            try
            {
                var dt = DateTime.Now;
                string month = dt.ToString("MMMM", new System.Globalization.CultureInfo("ru-RU")).ToLower();
                month = month.Substring(0, month.Length - 1) + "я";

                Word.Application app = new Word.Application();
                Word.Document doc = app.Documents.Add();

                Word.Paragraph para1 = doc.Content.Paragraphs.Add();
                para1.Range.Bold = 1;
                para1.Range.Font.Size = 14;
                para1.Range.Text = "Договор оказания образовательных услуг";
                para1.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                para1.Range.InsertParagraphAfter();

                Word.Paragraph para2 = doc.Content.Paragraphs.Add();
                para2.Range.Bold = 0;
                para1.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                para2.Range.Text = $"г. Воронеж, {dt.Day} {month} {dt.Year} года\n" +
                    "ООО «ЦБО Воронеж», в лице генерального директора Когтева Дмитрия Андреевич, " +
                    "действующего на основании Устава общества, именуемого в дальнейшем Исполнитель, с одной стороны\nИ\n" +
                    $"{data.Cells[3].Value}, проживающий по адресу: {data.Cells[4].Value}, именуемый в дальнейшем Заказчик, с другой стороны " +
                    "заключили настоящий договор о нижеследующем";
                para2.Range.InsertParagraphAfter();

                Word.Paragraph para3 = doc.Content.Paragraphs.Add();
                para3.Range.Bold = 1;
                para3.Range.Text = "Предмет";
                para3.Range.InsertParagraphAfter();

                Word.Paragraph para4 = doc.Content.Paragraphs.Add();
                para4.Range.Bold = 0;
                para4.Range.Text = "В соответствии с настоящим соглашением Исполнитель в лице ООО «ЦДО Воронеж» обязуется оказать " +
                    $"Заказчику в лице {data.Cells[3].Value}, за оговоренную договором плату, следующие образовательные услуги:" +
                    "\n    • обучающий курс по заявленной тематике;\n    • курс лекций в режиме online, связанных с заявленной тематикой.";
                para4.Range.InsertParagraphAfter();

                Word.Paragraph para5 = doc.Content.Paragraphs.Add();
                para5.Range.Bold = 1;
                para5.Range.Text = "Заключительные положения";
                para5.Range.InsertParagraphAfter();

                Word.Paragraph para6 = doc.Content.Paragraphs.Add();
                para6.Range.Bold = 0;
                para6.Range.Text = "    • Настоящий договор составлен в двух экземплярах. Один экземпляр передается Заказчику, другой " +
                    "передается Исполнителю.\n    • По всем моментам, которые не оговорены в настоящем соглашении, стороны " +
                    "руководствуются действующим законодательством Российской Федерации.";
                para6.Range.InsertParagraphAfter();

                Word.Paragraph para7 = doc.Content.Paragraphs.Add();
                para7.Range.Bold = 1;
                para7.Range.Text = "Подпись директора ___________\nПодпись плательщика ___________";
                para7.Range.InsertParagraphAfter();

                if (!Directory.Exists("contracts"))
                    Directory.CreateDirectory("contracts");

                doc.SaveAs($"{Directory.GetCurrentDirectory()}/contracts/id {data.Cells[0].Value} - {data.Cells[9].Value}.docx");
                doc.Close();
                app.Quit();

                MessageBox.Show($"Файл сохранен!\nПуть: /contracts/id {data.Cells[0].Value} - {data.Cells[9].Value}.docx", "2DOCX");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void contractToPdf()
        {
            try
            {
                var dt = DateTime.Now;
                string month = dt.ToString("MMMM", new System.Globalization.CultureInfo("ru-RU")).ToLower();
                month = month.Substring(0, month.Length - 1) + "я";

                if (!Directory.Exists("contracts"))
                    Directory.CreateDirectory("contracts");

                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream($"contracts/id {data.Cells[0].Value} - {data.Cells[9].Value}.pdf",
                    FileMode.Create));
                doc.Open();

                BaseFont font = BaseFont.CreateFont(@"C:\Windows\Fonts\times.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                var russianFont = new iTextSharp.text.Font(font, 14);

                doc.Add(new Paragraph("Договор оказания образовательных услуг", new iTextSharp.text.Font(font, 14, iTextSharp.text.Font.BOLD))
                { Alignment = Element.ALIGN_CENTER });

                doc.Add(new Paragraph($"г. Воронеж, {dt.Day} {month} {dt.Year} года\n" +
                    "ООО «ЦБО Воронеж», в лице генерального директора Денисова Арсения Александровича и Бордохина Сергея Владимировча, " +
                    "действующего на основании Устава общества, именуемого в дальнейшем Исполнитель, с одной стороны\nИ\n" +
                    $"{data.Cells[3].Value}, проживающий по адресу: {data.Cells[4].Value}, именуемый в дальнейшем Заказчик, с другой стороны " +
                    "заключили настоящий договор о нижеследующем", russianFont)
                { Alignment = Element.ALIGN_JUSTIFIED });

                doc.Add(new Paragraph("Предмет", new iTextSharp.text.Font(font, 14, iTextSharp.text.Font.BOLD))
                { Alignment = Element.ALIGN_JUSTIFIED });

                doc.Add(new Paragraph("В соответствии с настоящим соглашением Исполнитель в лице ООО «ЦДО Воронеж» обязуется оказать " +
                    $"Заказчику в лице {data.Cells[3].Value}, за оговоренную договором плату, следующие образовательные услуги:" +
                    "\n    • обучающий курс по заявленной тематике;\n    • курс лекций в режиме online, связанных с заявленной тематикой.", russianFont)
                { Alignment = Element.ALIGN_JUSTIFIED });

                doc.Add(new Paragraph("Заключительные положения", new iTextSharp.text.Font(font, 14, iTextSharp.text.Font.BOLD))
                { Alignment = Element.ALIGN_JUSTIFIED });

                doc.Add(new Paragraph("    • Настоящий договор составлен в двух экземплярах. Один экземпляр передается Заказчику, другой " +
                    "передается Исполнителю.\n    • По всем моментам, которые не оговорены в настоящем соглашении, стороны " +
                    "руководствуются действующим законодательством Российской Федерации.", russianFont)
                { Alignment = Element.ALIGN_JUSTIFIED });

                doc.Add(new Paragraph("Подпись директора ___________\nПодпись плательщика ___________", new iTextSharp.text.Font(font, 14, iTextSharp.text.Font.BOLD))
                { Alignment = Element.ALIGN_JUSTIFIED });

                doc.Close();

                MessageBox.Show($"Файл сохранен!\nПуть: /contracts/id {data.Cells[0].Value} - {data.Cells[9].Value}.pdf", "2PDF");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}
