using EntityFrameWork_Hw2.Context;

namespace EntityFrameWork_Hw2;

public partial class Form1 : Form
{

    private AppDbContext? AppDb { get; set; }
    public Form1()
    {
        InitializeComponent();
        AppDb= new AppDbContext();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
            

        foreach (var item in AppDb.Studentss)
        {
            comboBox1.Items.Add(item.FirstName);
        }

        foreach (var item in AppDb.Teacherss)
        {
            comboBox2.Items.Add(item.FirstName);
        }


        foreach (var item in AppDb.Categorys)
        {
            comboBox3.Items.Add(item.Id);
        }


    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {


        var list = (from S in AppDb.Studentss
                         where S.FirstName == comboBox1.Text
                         select S.Id_Group).ToList();

        foreach (var item in list)
        {
            textBox1.Text= item.ToString();
        }

        var list1 = (from S in AppDb.Studentss
                    where S.FirstName == comboBox1.Text
                    select S.Term).ToList();


        foreach (var item in list1)
        {
            textBox2.Text = item.ToString();
        }
    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
        var list = (from S in AppDb.Teacherss
                    where S.FirstName == comboBox2.Text
                    select S.Id_Dep).ToList();

        foreach (var item in list)
        {
            textBox3.Text = item.ToString();
        }

       
    }

    private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
    {
        var list = (from S in AppDb.Bookss
                    where S.Name == comboBox3.Text
                    select S.Id_Author).ToList();

        foreach (var item in list)
        {
            textBox4.Text = item.ToString();
        }

        //var list1= (from S in AppDb.Authorss
        //            where S.Id == list
        //            select S.Id_Author).ToList();
    }
}