using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_DnD_Generator
{
    public partial class Form1 : Form
    {
        LevelAgeStats Barbo = new LevelAgeStats();
        MonsterDisease Orcus = new MonsterDisease();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Barbo.Level = Convert.ToInt32(LevelBox.Text);
            Barbo.Age = Convert.ToInt32(AgeBox.Text);

            Barbo.genStrength();
            Barbo.genDexterity();
            Barbo.genConstitution();
            Barbo.genIntelligence();
            Barbo.genWisdom();
            Barbo.genCharisma();
            Barbo.genAge();
            Orcus.genType();
            Orcus.genIllness();

            richTextBox1.Text = Barbo.Level.ToString();
        }
    }
}
