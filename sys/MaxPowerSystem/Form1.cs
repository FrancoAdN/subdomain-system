using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Word = Microsoft.Office.Interop.Word;

namespace MaxPowerSystem
{
    public partial class Form1 : Form
    {
        public int IdUser;
        public bool Admin;
        public string UserName;
        public Form1()
        {
            InitializeComponent();

        }
        public void FindAndReplace(Word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllforms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref nmatchAllforms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiactitics, ref matchAlefHamza,
                ref matchControl);
        }
        public bool CreateWordDocument(object filename, object SaveAs, object arr)
        {
           

            //Console.WriteLine("CREATE WORD DOC");
            Word.Application wordApp = new Word.Application();
            object missing = Missing.Value;
            Word.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();

                //find and replace
                
                if (arr is List<Files>)
                {
                    List<Files> data = arr as List<Files>;
                    foreach (Files d in data)
                    {
                        //Console.WriteLine(c.Data);
                        this.FindAndReplace(wordApp, d.Ref, d.Data);
                    }
                }


            }
            else
            {
                MessageBox.Show("File not Found!");
                return false;
            }

            //Save as
            myWordDoc.SaveAs(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);


            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("File Created!");
            return true;

        }



        public void CreateTableWord(object filename, object SaveAs, object arr, int n_table)
        {

            Word.Application wordApp = new Word.Application();
            object missing = Missing.Value;
            Word.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();


                object findText = "<table>";


                Word.Range rng = myWordDoc.Range();
                rng.Find.ClearFormatting();
                if (rng.Find.Execute(ref findText,
                    ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing) && arr is List<Detalle>)
                {
                    List<Detalle> data = arr as List<Detalle>;

                    Detalle aux = data[0];
                    data[0] = data[data.Count - 1];
                    data[data.Count - 1] = aux;
                    rng.Select();
                    Word.Table tableobj;
                    tableobj = myWordDoc.Tables.Add(rng, 1, 5, ref missing, ref missing);
                    //5

                    myWordDoc.Tables[n_table].Columns[1].SetWidth(50, Word.WdRulerStyle.wdAdjustNone);
                    myWordDoc.Tables[n_table].Columns[2].SetWidth(50, Word.WdRulerStyle.wdAdjustNone);
                    myWordDoc.Tables[n_table].Columns[3].SetWidth(200, Word.WdRulerStyle.wdAdjustNone);
                    myWordDoc.Tables[n_table].Columns[4].SetWidth(80, Word.WdRulerStyle.wdAdjustNone);
                    myWordDoc.Tables[n_table].Columns[5].SetWidth(80, Word.WdRulerStyle.wdAdjustNone);



                    myWordDoc.Tables[n_table].Rows[1].Range.Paragraphs.Alignment =
                    Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    myWordDoc.Tables[n_table].Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                    myWordDoc.Tables[n_table].Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;

                    myWordDoc.Tables[n_table].Rows[1].Cells[1].Range.Text = "Item";

                    myWordDoc.Tables[n_table].Rows[1].Cells[2].Range.Text = data[0].Cant;

                    myWordDoc.Tables[n_table].Rows[1].Cells[3].Range.Text = data[0].Desc;

                    myWordDoc.Tables[n_table].Rows[1].Cells[4].Range.Text = data[0].Unit;

                    myWordDoc.Tables[n_table].Rows[1].Cells[5].Range.Text = data[0].Total;



                    for (int i = 1; i < data.Count; i++)
                    {
                        myWordDoc.Tables[n_table].Rows.Add(ref missing);
                        myWordDoc.Tables[n_table].Rows[i + 1].Cells[1].Range.Text = i.ToString();

                        myWordDoc.Tables[n_table].Rows[i + 1].Cells[2].Range.Text = data[i].Cant;

                        myWordDoc.Tables[n_table].Rows[i + 1].Cells[3].Range.Text = data[i].Desc;

                        myWordDoc.Tables[n_table].Rows[i + 1].Cells[4].Range.Text = data[i].Unit;


                        myWordDoc.Tables[n_table].Rows[i + 1].Cells[5].Range.Text = data[i].Total;

                        tableobj.Rows[i + 1].Range.Font.Underline = 0;
                    }

                    tableobj.Rows[1].Range.Font.Underline = 0;
                    tableobj.Rows[1].Range.Font.Bold = 1;
                }
                else
                {
                    MessageBox.Show("Text not found.");
                }



            }
            else
            {
                MessageBox.Show("File not Found!");

            }

            myWordDoc.SaveAs(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);


            myWordDoc.Close();
            wordApp.Quit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Admin)
            {
                button9.Visible = true;
                button10.Visible = true;
            }
            else
            {
                button9.Visible = false;
                button10.Visible = false;

            }

            //HIDE EVERY USER CONTROL
            uploadDataBaseUC1.Hide();
            tecAsistUC1.Hide();
            viewDataBaseUC1.Hide();
            ventaProdUC1.Hide();
            repProdUC1.Hide();
            compExteriorUC1.Hide();
            compNacUC1.Hide();
            ordConfUC1.Hide();
            notificacionesUC1.Hide();
            solicitudesUC1.Hide();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //SHOW VIEW DB UC
            uploadDataBaseUC1.Hide();
            tecAsistUC1.Hide();
            ventaProdUC1.Hide();
            repProdUC1.Hide();
            compExteriorUC1.Hide();
            compNacUC1.Hide();
            ordConfUC1.Hide();
            notificacionesUC1.Hide();
            solicitudesUC1.Hide();

            viewDataBaseUC1.Show();
            viewDataBaseUC1.BringToFront();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // SHOW UP DB UC

            button6.Visible = !button6.Visible;
            button5.Visible = !button5.Visible;
            button15.Visible = !button15.Visible;
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            // SHOW TEC ASIST UC
            uploadDataBaseUC1.Hide();
            viewDataBaseUC1.Hide();
            ventaProdUC1.Hide();
            repProdUC1.Hide();
            compExteriorUC1.Hide();
            compNacUC1.Hide();
            ordConfUC1.Hide();
            notificacionesUC1.Hide();
            solicitudesUC1.Hide();

            tecAsistUC1.Show();
            tecAsistUC1.BringToFront();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //SHOW COT PROD UC
            uploadDataBaseUC1.Hide();
            viewDataBaseUC1.Hide();
            tecAsistUC1.Hide();
            ventaProdUC1.Hide();
            compExteriorUC1.Hide();
            compNacUC1.Hide();
            ordConfUC1.Hide();
            notificacionesUC1.Hide();
            solicitudesUC1.Hide();

            repProdUC1.Show();
            repProdUC1.BringToFront();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            // SHOW VENT PROD UC
            uploadDataBaseUC1.Hide();
            viewDataBaseUC1.Hide();
            tecAsistUC1.Hide();
            repProdUC1.Hide();
            compExteriorUC1.Hide();
            compNacUC1.Hide();
            ordConfUC1.Hide();
            notificacionesUC1.Hide();
            solicitudesUC1.Hide();

            ventaProdUC1.Show();
            ventaProdUC1.BringToFront();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            uploadDataBaseUC1.Hide();
            viewDataBaseUC1.Hide();
            tecAsistUC1.Hide();
            ventaProdUC1.Hide();
            repProdUC1.Hide();
            compNacUC1.Hide();
            ordConfUC1.Hide();
            notificacionesUC1.Hide();
            solicitudesUC1.Hide();

            compExteriorUC1.Show();
            compExteriorUC1.BringToFront();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            uploadDataBaseUC1.Hide();
            viewDataBaseUC1.Hide();
            tecAsistUC1.Hide();
            ventaProdUC1.Hide();
            repProdUC1.Hide();
            compExteriorUC1.Hide();
            ordConfUC1.Hide();
            notificacionesUC1.Hide();
            solicitudesUC1.Hide();

            compNacUC1.Show();
            compNacUC1.BringToFront();
        }

        private void showMen(object sender, MouseEventArgs e)
        {
            if (ATButton.Visible)
            {
                ATButton.Visible = false;
                RLButton.Visible = false;
                VPButton.Visible = false;
                viewCot.Visible = false;

                uploadDataBaseUC1.Hide();
                viewDataBaseUC1.Hide();
                tecAsistUC1.Hide();
                ventaProdUC1.Hide();
                repProdUC1.Hide();
                compNacUC1.Hide();
                compExteriorUC1.Hide();
                ordConfUC1.Hide();
                notificacionesUC1.Hide();
                solicitudesUC1.Hide();

            }
            else
            {
                OCNButton.Visible = false;
                OCEButton.Visible = false;
                viewOrdC.Visible = false;

                ATButton.Visible = true;
                RLButton.Visible = true;
                VPButton.Visible = true;
                viewCot.Visible = true;
            }

            
        }

        private void showMenComp(object sender, MouseEventArgs e)
        {
            if (OCNButton.Visible)
            {
                OCNButton.Visible = false;
                OCEButton.Visible = false;
                viewOrdC.Visible = false;

                uploadDataBaseUC1.Hide();
                viewDataBaseUC1.Hide();
                tecAsistUC1.Hide();
                ventaProdUC1.Hide();
                repProdUC1.Hide();
                compNacUC1.Hide();
                compExteriorUC1.Hide();
                ordConfUC1.Hide();
                notificacionesUC1.Hide();
                solicitudesUC1.Hide();
            }
            else
            {
                ATButton.Visible = false;
                RLButton.Visible = false;
                VPButton.Visible = false;
                viewCot.Visible = false;

                OCEButton.Visible = true;
                OCNButton.Visible = true;
                viewOrdC.Visible = true;
            }
        }

        private void OACButton_MouseClick(object sender, MouseEventArgs e)
        {
            uploadDataBaseUC1.Hide();
            viewDataBaseUC1.Hide();
            tecAsistUC1.Hide();
            ventaProdUC1.Hide();
            repProdUC1.Hide();
            compNacUC1.Hide();
            compExteriorUC1.Hide();
            ordConfUC1.Hide();
            notificacionesUC1.Hide();
            solicitudesUC1.Hide();

            ordConfUC1.Show();
            ordConfUC1.BringToFront();


        }

        private void Button11_MouseClick(object sender, MouseEventArgs e)
        {
            uploadDataBaseUC1.Hide();
            viewDataBaseUC1.Hide();
            tecAsistUC1.Hide();
            ventaProdUC1.Hide();
            repProdUC1.Hide();
            compNacUC1.Hide();
            compExteriorUC1.Hide();
            ordConfUC1.Hide();
            notificacionesUC1.Hide();
            solicitudesUC1.Hide();

            notificacionesUC1.Show();
            notificacionesUC1.BringToFront();
        }

        private void Button4_MouseClick(object sender, MouseEventArgs e)
        {
            uploadDataBaseUC1.Hide();
            viewDataBaseUC1.Hide();
            tecAsistUC1.Hide();
            ventaProdUC1.Hide();
            repProdUC1.Hide();
            compNacUC1.Hide();
            compExteriorUC1.Hide();
            ordConfUC1.Hide();
            notificacionesUC1.Hide();
            solicitudesUC1.Hide();

            solicitudesUC1.Show();
            solicitudesUC1.BringToFront();

            viewSol.Visible = !viewSol.Visible;
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            uploadDataBaseUC1.Hide();
            viewDataBaseUC1.Hide();
            tecAsistUC1.Hide();
            ventaProdUC1.Hide();
            repProdUC1.Hide();
            compNacUC1.Hide();
            compExteriorUC1.Hide();
            ordConfUC1.Hide();
            notificacionesUC1.Hide();
            solicitudesUC1.Hide();

            uploadDataBaseUC1.changeName("Proveedores");
            uploadDataBaseUC1.Show();
            uploadDataBaseUC1.BringToFront();
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            uploadDataBaseUC1.Hide();
            viewDataBaseUC1.Hide();
            tecAsistUC1.Hide();
            ventaProdUC1.Hide();
            repProdUC1.Hide();
            compNacUC1.Hide();
            compExteriorUC1.Hide();
            ordConfUC1.Hide();
            notificacionesUC1.Hide();
            solicitudesUC1.Hide();

            uploadDataBaseUC1.changeName("Clientes");
            uploadDataBaseUC1.Show();
            uploadDataBaseUC1.BringToFront();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            uploadDataBaseUC1.Hide();
            viewDataBaseUC1.Hide();
            tecAsistUC1.Hide();
            ventaProdUC1.Hide();
            repProdUC1.Hide();
            compNacUC1.Hide();
            compExteriorUC1.Hide();
            ordConfUC1.Hide();
            notificacionesUC1.Hide();
            solicitudesUC1.Hide();

            viewDataBaseUC1.changeVal("Empresas");
            viewDataBaseUC1.Show();
            viewDataBaseUC1.BringToFront();
        }

        private void viewCot_Click(object sender, EventArgs e)
        {
            uploadDataBaseUC1.Hide();
            viewDataBaseUC1.Hide();
            tecAsistUC1.Hide();
            ventaProdUC1.Hide();
            repProdUC1.Hide();
            compNacUC1.Hide();
            compExteriorUC1.Hide();
            ordConfUC1.Hide();
            notificacionesUC1.Hide();
            solicitudesUC1.Hide();

            viewDataBaseUC1.changeVal("Cot");
            viewDataBaseUC1.Show();
            viewDataBaseUC1.BringToFront();
        }

        private void viewOrdC_Click(object sender, EventArgs e)
        {
            uploadDataBaseUC1.Hide();
            viewDataBaseUC1.Hide();
            tecAsistUC1.Hide();
            ventaProdUC1.Hide();
            repProdUC1.Hide();
            compNacUC1.Hide();
            compExteriorUC1.Hide();
            ordConfUC1.Hide();
            notificacionesUC1.Hide();
            solicitudesUC1.Hide();

            viewDataBaseUC1.changeVal("Ord");
            viewDataBaseUC1.Show();
            viewDataBaseUC1.BringToFront();
        }


    }

}
