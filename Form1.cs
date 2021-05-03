using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCalendar
{
    
    public partial class Form1 : Form
    {
        CheckBox currentChecked;
        public static int FurnitureID = 0;
        int MouseX;
        int MouseY;
        string CurrentName;
        List<Furniture> Furnitures = new List<Furniture>();
        ResourceManager rm;
        List<Line> Paths;
        Rectangle bounds;
        Furniture SFur;
        Line CurrentLine;
        Pen blackPen;
        int WallX;
        int WallY;
        public Form1()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-GB");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
            InitializeComponent();
            this.OldBitmap.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.OldBitmap_MouseWheel);
            

        }

        //private List<PictureBox> Furnitures = new List<PictureBox>();
        private void splitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            OldBitmap.Image = new Bitmap(OldBitmap.Width, OldBitmap.Height);
            OldBitmap.BackColor = Color.White;
            blackPen = new Pen(Color.Black, 5);
            
            rm = new ResourceManager("WinFormsCalendar.Resources.EN", Assembly.GetExecutingAssembly());
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Bitmap puste = new Bitmap(OldBitmap.Width, OldBitmap.Height);
            OldBitmap.Image = puste;
            Furnitures.Clear();
            CreatedFurnitureList.Items.Clear();
            FurnitureID = 0;
            SFur = null;

        }

        private void splitContainer_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ChangeImageOpacity(float alpha)
        {
            Bitmap bmp = new Bitmap(SFur.Size, SFur.Size);
            Graphics g = Graphics.FromImage(bmp);
            ColorMatrix cm = new ColorMatrix();
            cm.Matrix33 = alpha;
            ImageAttributes ia = new ImageAttributes();
            ia.SetColorMatrix(cm);
            g.DrawImage(SFur.image,
                new Rectangle(0, 0, SFur.Size, SFur.Size), 0, 0,
                SFur.Size, SFur.Size, GraphicsUnit.Pixel, ia);
            SFur.image = bmp;
            g.Dispose();
        }
        private void OldBitmap_MouseDown(object sender, MouseEventArgs e)
        {
            MouseX = e.X-62;
            MouseY = e.Y-62;
            if (currentChecked == null)
            {
                if(SFur == null)
                {
                    foreach (var item in Furnitures)
                    {
                        bounds = new Rectangle(item.Position.X, item.Position.Y, item.Size, item.Size);
                        if (bounds.Contains(e.Location.X, e.Location.Y))
                        {
                            SFur = item;
                            break;
                        }
                    }
                    if (SFur != null && !SFur.Semi_Trans)
                    {
                        ChangeImageOpacity(0.5F);
                        CreatedFurnitureList.Items[SFur.id].Selected = true;
                        CreatedFurnitureList.Focus();
                        SFur.Semi_Trans = true;
                        bounds = new Rectangle(SFur.Position.X, SFur.Position.Y, SFur.Size, SFur.Size);
                        SFur.OriginalImage = SFur.image;

                    }
                }
                else if (!bounds.Contains(e.Location.X, e.Location.Y) && SFur !=null)
                {
                    ChangeImageOpacity(2F);
                    CreatedFurnitureList.Items[SFur.id].Selected = false;
                    SFur.Semi_Trans = false;
                    SFur = null;
                }
            }

            else if (currentChecked != null && CurrentName != rm.GetString("Wall"))
            {
                Furniture temp = new Furniture(currentChecked.BackgroundImage, CurrentName, MouseX, MouseY);
                temp.id = FurnitureID++;
                Furnitures.Add(temp);
                currentChecked.BackColor = Color.White;
                currentChecked.Checked = false; 
                currentChecked = null;
                //DrawFurnitures();
                string Position = "{" + $"X={temp.Position.X},Y={temp.Position.Y}" + "}";
                string total = CurrentName + " " + Position;
                ListViewItem newItem = new ListViewItem(total);
                CreatedFurnitureList.Items.Add(newItem);
            }
            else if (currentChecked != null && CurrentName == rm.GetString("Wall") && CurrentLine == null)
            {
                Paths = new List<Line>();
                Point p = new Point(e.Location.X, e.Location.Y);
                var newline = new Line(p);
                GraphicsPath Path = new GraphicsPath();
                newline.StartPoint = p;
                newline.Points.Add(p);
                newline.path = Path;
            }
            else if (currentChecked != null && CurrentName == rm.GetString("Wall") && CurrentLine != null)
            {
                Point click = new Point(e.Location.X, e.Location.Y);
                CurrentLine.Points.Add(click);
                var arr = CurrentLine.Points.ToArray();
                CurrentLine.path.AddLines(arr);
            }

        }

        private void OldBitmap_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (SFur != null && bounds.Contains(e.Location.X, e.Location.Y))
                {
                    
                    SFur.Position = new Point(e.Location.X - 60, e.Location.Y - 60);
                    bounds = new Rectangle(SFur.Position.X, SFur.Position.Y, SFur.Size, SFur.Size);
                    CreatedFurnitureList.Items[SFur.id].Text = SFur.Name + $" {{X={SFur.Position.X + 60},Y={SFur.Position.Y + 60}}}";
                }
            }

        }

        private void OldBitmap_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void splitContainer_Panel1_SizeChanged(object sender, EventArgs e)
        {
            splitContainer.Panel1.AutoScrollMinSize = new Size(OldBitmap.Width, OldBitmap.Height);
        }
        private void OldBitmap_MouseWheel(object sender, MouseEventArgs e)
        {
            if (SFur != null)
            {

                if (e.Delta < 0)
                {
                    SFur.RotationAngle = (SFur.RotationAngle - 10) % (-360);


                }
                else if (e.Delta > 0)
                {

                    SFur.RotationAngle = (SFur.RotationAngle + 10) % 360;
                }

            }
            ((HandledMouseEventArgs)e).Handled = true;
        }

        private void splitContainer_Panel1_MouseHover(object sender, EventArgs e)
        {
            splitContainer.Panel1.Focus();
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = rm.GetString("DialogFilter");
            saveFileDialog1.Title = rm.GetString("DialogTitle");
            saveFileDialog1.FileName = ".bp";
            saveFileDialog1.DefaultExt = "bp";
            if (saveFileDialog1.FileName != "" && saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FurnituresToSave toSave = new FurnituresToSave();
                    toSave.FToSave = Furnitures;
                    FileStream fs = (FileStream)saveFileDialog1.OpenFile();
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(fs, toSave);
                    MessageBox.Show(rm.GetString("BlueprintSaveMessage"));
                    fs.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: Could not save file. " + ex.Message);
                }

            }
            
        }
 
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string FilePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = rm.GetString("DialogFilter");
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FurnituresToSave toOpen = new FurnituresToSave();
                        FileStream fs = (FileStream)openFileDialog.OpenFile();
                        BinaryFormatter b = new BinaryFormatter();
                        toOpen = (FurnituresToSave)b.Deserialize(fs);
                        Furnitures = toOpen.FToSave;
                        MessageBox.Show(rm.GetString("BlueprintOpenMessage"));
                        fs.Close();
                        CreatedFurnitureList.Items.Clear();
                        ResourceManager rmm = new ResourceManager("WinFormsCalendar.Resources.EN", Assembly.GetExecutingAssembly());
                        if (Furnitures.Count!=0 && !Furnitures[0].NameLanguageEN)
                        {
                            rmm = new ResourceManager("WinFormsCalendar.Resources.PL", Assembly.GetExecutingAssembly()); ;

                        }
                        foreach (var item in Furnitures)
                        {
                            if (item.Semi_Trans)
                            {
                                SFur = item;
                                ChangeImageOpacity(2F);
                                item.Semi_Trans = false;
                                SFur = null;
                            }
                            UpdateFNames(item, rmm);
                            string Position = $"{{X={item.Position.X},Y={item.Position.Y}}}";
                            string total = item.Name + " " + Position;
                            ListViewItem newItem = new ListViewItem(total);
                            CreatedFurnitureList.Items.Add(newItem);
                        }
                        //DrawFurnitures();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file. " + ex.Message);
                    }
                    
                }

            }
          
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-GB");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
            rm = new ResourceManager("WinFormsCalendar.Resources.EN", Assembly.GetExecutingAssembly());
            UpdateFormText();
            CreatedFurnitureList.Items.Clear();
            var rmm = new ResourceManager("WinFormsCalendar.Resources.PL", Assembly.GetExecutingAssembly());

            foreach (var item in Furnitures)
            {
                UpdateFNames(item,rmm);
                string Position = "{" + $"X={item.Position.X},Y={item.Position.Y}" + "}";
                string total = item.Name + " " + Position;
                ListViewItem newItem = new ListViewItem(total);
                CreatedFurnitureList.Items.Add(newItem);
            }
        }

        private void polishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pl-PL");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pl-PL");
            UpdateFormText();
            rm = new ResourceManager("WinFormsCalendar.Resources.PL", Assembly.GetExecutingAssembly());
            //UpdateFormText();
            var rmm = new ResourceManager("WinFormsCalendar.Resources.EN", Assembly.GetExecutingAssembly());
            CreatedFurnitureList.Items.Clear();
            foreach (var item in Furnitures)
            {
                UpdateFNames(item, rmm);

                string Position = "{" + $"X={item.Position.X},Y={item.Position.Y}" + "}";
                string total = item.Name + " " + Position;
                ListViewItem newItem = new ListViewItem(total);
                CreatedFurnitureList.Items.Add(newItem);
            }


        }
        private void UpdateFormText()
        {
            
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            resources.ApplyResources(this.CreatedFurnitureBox, CreatedFurnitureBox.Name); // 
            resources.ApplyResources(AddFurnitureBox, AddFurnitureBox.Name); 

            resources.ApplyResources(this, "$this");
            foreach (Control c in this.Controls)
            {
                resources.ApplyResources(c, c.Name);
                foreach (Control cc in c.Controls)
                {
                    resources.ApplyResources(cc, cc.Name);
                }

            }
            foreach (ToolStripMenuItem r in menuStrip1.Items)
            {
                resources.ApplyResources(r, r.Name);
                foreach (ToolStripMenuItem rr in r.DropDownItems)
                {
                    resources.ApplyResources(rr, rr.Name);
                }
            }
        }
        private void UpdateFNames(Furniture f, ResourceManager rmm)
        {
            if (f.Name == rmm.GetString("Kitchen_table"))
                f.Name = rm.GetString("Kitchen_table");
            if (f.Name == rmm.GetString("Table"))
                f.Name = rm.GetString("Table");
            if (f.Name == rmm.GetString("Bed"))
                f.Name = rm.GetString("Bed");
            if (f.Name == rmm.GetString("Sofa"))
                f.Name = rm.GetString("Sofa");
            if (f.Name == rmm.GetString("Wall"))
                f.Name = rm.GetString("Wall");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            OldBitmap.Image = new Bitmap(OldBitmap.Width, OldBitmap.Height);
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Kitchen_table.Checked)
            {
                if (Table.Checked)
                    Table.Checked = false;
                if (Sofa.Checked)
                    Sofa.Checked = false;
                if (Bed.Checked)
                    Bed.Checked = false;

                CurrentName = rm.GetString("Kitchen_table");

                Kitchen_table.BackColor = Color.Beige;
                currentChecked = Kitchen_table;
            }
            else
                Kitchen_table.BackColor = Color.White;

        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Table.Checked)
            {
                if (Kitchen_table.Checked)
                    Kitchen_table.Checked = false;
                if (Sofa.Checked)
                    Sofa.Checked = false;
                if (Bed.Checked)
                    Bed.Checked = false;

                CurrentName = CurrentName = rm.GetString("Table");
                Table.BackColor = Color.Beige;
                currentChecked = Table;

            }
            else
            {
                currentChecked = null;
                Table.BackColor = Color.White;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (Sofa.Checked)
            {
                if (Kitchen_table.Checked)
                    Kitchen_table.Checked = false;
                if (Table.Checked)
                    Table.Checked = false;
                if (Bed.Checked)
                    Bed.Checked = false;

                CurrentName = rm.GetString("Sofa");

                Sofa.BackColor = Color.Beige;
                currentChecked = Sofa;

            }
            else
            {
                currentChecked = null;
                Sofa.BackColor = Color.White;

            }
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (Bed.Checked)
            {
                if (Kitchen_table.Checked)
                    Kitchen_table.Checked = false;
                if (Sofa.Checked)
                    Sofa.Checked = false;
                if (Table.Checked)
                    Table.Checked = false;

                CurrentName = rm.GetString("Bed");


                Bed.BackColor = Color.Beige;
                currentChecked = Bed;

            }
            else
            {
                currentChecked = null;
                Bed.BackColor = Color.White;
            }
        }
        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                FurnitureID = 0;
                List<Furniture> temp = new List<Furniture>();
                CreatedFurnitureList.Items.Clear();
                if (Furnitures.Count != 0)
                {
                    foreach(var item in Furnitures)
                    {
                        if (item == SFur)
                        {
                            continue;
                        }
                        Furniture fe = new Furniture(item.image, item.Name, item.Position.X, item.Position.Y);
                        fe.RotationAngle = item.RotationAngle;
                        fe.id = FurnitureID++;
                        temp.Add(fe);
                        string total = item.Name + " " + $"{{X={fe.Position.X},Y={fe.Position.Y}}}";
                        ListViewItem newItem = new ListViewItem(total);
                        CreatedFurnitureList.Items.Add(newItem);

                    }
                }
                SFur = null;
                Furnitures = temp;

            }

            e.Handled = true;
        }


        private void CreatedFurnitureList_MouseDown(object sender, MouseEventArgs e)
        {
            
            for (int i = 0; i < CreatedFurnitureList.Items.Count; i++)
            {
                var rectangle = CreatedFurnitureList.GetItemRect(i);
                if (rectangle.Contains(e.Location))
                {
                    if (!CreatedFurnitureList.Items[i].Selected)
                    {
                        for (int ii = 0; ii < Furnitures.Count; ii++)
                        {
                            if (i == Furnitures[ii].id)
                            {
                                if(SFur != null)
                                {
                                    ChangeImageOpacity(2F);
                                    SFur.Semi_Trans = false;
                                    SFur = null;
                                }
                                SFur = Furnitures[ii];
                                ChangeImageOpacity(0.5F);
                                SFur.Semi_Trans = true;
                                return;

                            }
                        }
                    }
                }
                
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(OldBitmap.Size.Width, OldBitmap.Size.Height);
            Graphics g = Graphics.FromImage(bmp);
            ImageAttributes ia = new ImageAttributes();
            if (Furnitures.Count == 0)
            {
                OldBitmap.Image = bmp;
                g.Dispose();
                return;
            }
            foreach (Furniture item in Furnitures)
            {
                Graphics paint = Graphics.FromImage(bmp);
                Matrix rotMatrix = new Matrix();
                rotMatrix.RotateAt(item.RotationAngle, new Point(item.Position.X + 64, item.Position.Y + 64));
                paint.Transform = rotMatrix;
                if (item == SFur && SFur.Semi_Trans)
                {
                    ColorMatrix cm = new ColorMatrix();
                    cm.Matrix33 = 0.5F;
                    ia.SetColorMatrix(cm);
                    SFur.Semi_Trans = true;
                    paint.DrawImage(item.image,
                    new Rectangle(item.Position, new Size(item.Size, item.Size)), 0, 0,
                    item.Size, item.Size, GraphicsUnit.Pixel, ia);
                }
                else
                {
                    paint.DrawImage(item.image, item.Position);
                }

                paint.Dispose();
                OldBitmap.Image = bmp;
            }
            g.Dispose();
            
        }
    }
}
