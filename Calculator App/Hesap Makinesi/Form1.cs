using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        /*burada işlem değişikliği tanımlayarak (+,/,-,*,....) gibi işaretlere tıklandığında
         label3e yazdırmasını istedik .Eşittire tıklandığında ise label 1 e geri dönülebilmesini sağladık . o yüzden bu kavramı kontrol etmek için bool tanımladık */
        bool _islemdegisikligi;

        /*char _islem tanımlayarak secilen işleme göre hesap yapılmasını sağladık . bunu switch case ile hesaplattım */
        char _islem;
        //Burada sonuç değerimi global olarak tanımladım .
        double sonuc =0;
        /* burada sonuclabelime yazdırdığım sonuç örneğin =40 XL diye yazdırıldı .
         yeni bir işlem yaptığım zaman sonuclabelim yeni bir işlem gereği birincilabela yerleşiyordu. ancak başındaki eşittir ve devamındaki romen rakamıyla birlikte
        yerleşiyordu . Eşittir ve boşluk gördüğünde sonucumu ayırması için split kullandım . böldüğüm kavramları ise bir string a tanımlayarak yaptım . */
        string[] a;
        /*_sonsuzluksağlama ile ikinci sayının sıfır olma durumunda cevabın sonsuz olarak yazdırılmasını sağladım .*/
        bool _sonsuzluksaglama;
      
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        /*Her bir işlem butonunda _isleme islemi atadım ve switch(_islem) şeklinde oluşturmaya olanak sağladım . */
        private void karekokbutton_Click(object sender, EventArgs e)
        {
            _islem = 'S';
            ikincilabel.Text = "SQRT";
           
            if (birincilabel.Text != "")
            {
                _islemdegisikligi = true;
                //birincilabel doluysa ikiye geç dedim .
            }
            else if(birincilabel.Text=="")
            {
                birincilabel.Text = "1";
                _islemdegisikligi = true;
                /*  birincilabel boşsa karekök butonuna tıkladığımızda birincilabelı 1  olarak doldurur 
                 (sonuç anlamında değişiklik olmaz . işlemimizin daha estetik durmasını sağlar .)
                
                gireceğimiz değerde ucunculabela girilir . ve sonucumuzu yazdırır. */

            }
            if (sonuclabel.Text != "")
            {
                birincilabel.Text = "1";
                ucunculabel.Text = a[1];
                /*  sonuclabelim doluysa sonucumun karekökünü almak istediğim zaman birincilabela 1 yazdırır.
                ikincilabela islem ismi ,ucuncu labela ise karekökünü almak istediğimiz ifade yerleşir. eşittir butonuna tıkladığımız zaman   
                ise sonucumuzu ekrana yazdırır . */
                
            }
            
           
        } 

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rakam1button_Click(object sender, EventArgs e)
        {
            
            if (_islemdegisikligi)
            {
                ucunculabel.Text +=rakam1button.Text;
                /*herhangi bir operatöre bastıysak işlemin ucunculabeldan itibaren devam etmesini sağladık .
                eğer operatöre basılmadıysa birincilabeldan yazmaya devam ettik .*/
            }
            else
                birincilabel.Text += rakam1button.Text;



        }

        private void rakam2button_Click(object sender, EventArgs e)
        {
            if (_islemdegisikligi)
            {
                ucunculabel.Text += rakam2button.Text;
                /*herhangi bir operatöre bastıysak işlemin ucunculabeldan itibaren devam etmesini sağladık .
              eğer operatöre basılmadıysa birincilabeldan yazmaya devam ettik .*/
            }
            else
                birincilabel.Text += rakam2button.Text;


        }

        private void rakam3button_Click(object sender, EventArgs e)
        {
            if (_islemdegisikligi)
            {
                ucunculabel.Text += rakam3button.Text;
                /*herhangi bir operatöre bastıysak işlemin ucunculabeldan itibaren devam etmesini sağladık .
              eğer operatöre basılmadıysa birincilabeldan yazmaya devam ettik .*/
            }
            else
                birincilabel.Text += rakam3button.Text;

        }

        private void rakam4button_Click(object sender, EventArgs e)
        {
            if (_islemdegisikligi)
            {
                ucunculabel.Text += rakam4button.Text;
                /*herhangi bir operatöre bastıysak işlemin ucunculabeldan itibaren devam etmesini sağladık .
             eğer operatöre basılmadıysa birincilabeldan yazmaya devam ettik .*/
            }
            else
                birincilabel.Text += rakam4button.Text;

        }

        private void rakam5button_Click(object sender, EventArgs e)
        {
            if (_islemdegisikligi)
            {
                ucunculabel.Text += rakam5button.Text;
                /*herhangi bir operatöre bastıysak işlemin ucunculabeldan itibaren devam etmesini sağladık .
             eğer operatöre basılmadıysa birincilabeldan yazmaya devam ettik .*/
            }
            else
                birincilabel.Text += rakam5button.Text;

        }

        private void rakam6button_Click(object sender, EventArgs e)
        {
            if (_islemdegisikligi)
            {
                ucunculabel.Text += rakam6button.Text;
                /*herhangi bir operatöre bastıysak işlemin ucunculabeldan itibaren devam etmesini sağladık .
             eğer operatöre basılmadıysa birincilabeldan yazmaya devam ettik .*/
            }
            else
                birincilabel.Text += rakam6button.Text;

        }

        private void rakam7button_Click(object sender, EventArgs e)
        {
            if (_islemdegisikligi)
            {
                ucunculabel.Text += rakam7button.Text;
                /*herhangi bir operatöre bastıysak işlemin ucunculabeldan itibaren devam etmesini sağladık .
              eğer operatöre basılmadıysa birincilabeldan yazmaya devam ettik .*/
            }
            else
                birincilabel.Text += rakam7button.Text;


        }

        private void rakam8button_Click(object sender, EventArgs e)
        {
            if (_islemdegisikligi)
            {
                ucunculabel.Text += rakam8button.Text;
                /*herhangi bir operatöre bastıysak işlemin ucunculabeldan itibaren devam etmesini sağladık .
             eğer operatöre basılmadıysa birincilabeldan yazmaya devam ettik .*/
            }
            else
                birincilabel.Text += rakam8button.Text;

        }

        private void rakam9button_Click(object sender, EventArgs e)
        {
            if (_islemdegisikligi)
            {
                ucunculabel.Text += rakam9button.Text;
                /*herhangi bir operatöre bastıysak işlemin ucunculabeldan itibaren devam etmesini sağladık .
              eğer operatöre basılmadıysa birincilabeldan yazmaya devam ettik .*/
            }
            else
                birincilabel.Text += rakam9button.Text;


        }

        private void rakam0button_Click(object sender, EventArgs e)
        {
            if (_islemdegisikligi)
            {
                ucunculabel.Text += rakam0button.Text;
                /*herhangi bir operatöre bastıysak işlemin ucunculabeldan itibaren devam etmesini sağladık .
             eğer operatöre basılmadıysa birincilabeldan yazmaya devam ettik .*/
            }
            else
                birincilabel.Text += rakam0button.Text;

            
        }

        private void bolubutton_Click(object sender, EventArgs e)
        {
            labelgecmis.Visible = false;
            if (sonuclabel.Text != "")
            {
                birincilabel.Text = a[1];
                ucunculabel.Text = "";
                /*sonuç label doluysa split yaparak sonucu ,eşittir ve romen rakamından ayırdım . ve sonucu yeni bir işlem için temiz halde 
                 birincilabele yolladım  */
            }
            _islem = '/'; ;
            _islemdegisikligi = true;
            ikincilabel.Text = bolubutton.Text;
            if(birincilabel.Text=="")
            {
                //birincilabel girmeden işleme basarsak hata verir . 
                MessageBox.Show("Birinci Sayi Girilmeden İşlem Yapılamaz !","Hata Penceresi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                ikincilabel.Text = "";
                _islemdegisikligi = false;
            }
            
            


        }

        private void eksibutton_Click(object sender, EventArgs e)
        {
            labelgecmis.Visible = false;
            if (sonuclabel.Text != "")
            {
                /*sonuç label doluysa split yaparak sonucu ,eşittir ve romen rakamından ayırdım . ve sonucu yeni bir işlem için temiz halde 
                 birincilabele yolladım  */
                birincilabel.Text = a[1];
                ucunculabel.Text = "";

            }
            _islem = '-'; 
            _islemdegisikligi = true;
            ikincilabel.Text = eksibutton.Text;
            if (birincilabel.Text == "")
            {
                //birincilabel girmeden işleme basarsak hata verir .
                MessageBox.Show("Birinci Sayi Girilmeden İşlem Yapılamaz !", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ikincilabel.Text = "";
                _islemdegisikligi = false;
            }

        }

        private void artıbutton_Click(object sender, EventArgs e)
        {
            labelgecmis.Visible = false;
            if (sonuclabel.Text != "")
            {
                /*sonuç label doluysa split yaparak sonucu ,eşittir ve romen rakamından ayırdım . ve sonucu yeni bir işlem için temiz halde 
                birincilabele yolladım  */
                birincilabel.Text = a[1];
                ucunculabel.Text = "";

            }
            _islem = '+';
            _islemdegisikligi = true;
            ikincilabel.Text = artıbutton.Text;
            if (birincilabel.Text == "")
            {
                //birincilabel girmeden işleme basarsak hata verir .
                MessageBox.Show("Birinci Sayi Girilmeden İşlem Yapılamaz !", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ikincilabel.Text = "";
                _islemdegisikligi = false;
            }

        }

        private void carpibutton_Click(object sender, EventArgs e)
        {
            labelgecmis.Visible = false;
            if (sonuclabel.Text != "")
            {
                /*sonuç label doluysa split yaparak sonucu ,eşittir ve romen rakamından ayırdım . ve sonucu yeni bir işlem için temiz halde 
                birincilabele yolladım  */
                birincilabel.Text = a[1];
                ucunculabel.Text = "";

            }
            _islem = '*';
            _islemdegisikligi = true;
            ikincilabel.Text = carpibutton.Text;
            
            if (birincilabel.Text == "")
            {
                //birincilabel girmeden işleme basarsak hata verir .
                MessageBox.Show("Birinci Sayi Girilmeden İşlem Yapılamaz !", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ikincilabel.Text = "";
                _islemdegisikligi = false;
            }
           

        }

        private void artıeksibutton_Click(object sender, EventArgs e)
        {
            labelgecmis.Visible = false;
            if (sonuclabel.Text != "")
            {
                /*sonuclabel doluysa artıeksi butonuna bastığımız zaman sonuclabeldaki değeri eşittir ve romen rakamlarından split yapılarak ayrılmış
                 a[1] değerini -1 ile çarpılarak birincilabela yolladım . ve diğer tüm labelları boşalttım . */
                sonuclabel.Text = "";
                birincilabel.Text = (Convert.ToDouble(a[1])*-1).ToString();
                ikincilabel.Text = "";
                ucunculabel.Text = "";
               
            }
            else if (ucunculabel.Text !="")
            {
                //ucuncu label doluysa artıeksiye tıkladığımız zaman ucunculabela kendisinin -1 ile çarpılmış halini yazdırdım . 

                ucunculabel.Text = ((Convert.ToDouble(ucunculabel.Text)) * -1).ToString();
                
               
            }
            else if (birincilabel.Text!="")
            {
                //birincilabel doluysa artıeksiye tıkladığımız zaman birincilabela kendisinin -1 ile çarpılmış halini yazdırdım . 
                birincilabel.Text = (Convert.ToDouble(birincilabel.Text) * -1).ToString();
            }
          
            
            if (birincilabel.Text == "")
            {
                //birincilabel girmeden işleme basarsak hata verir .
                MessageBox.Show("İkinci Sayi Girilmeden İşlem Yapılamaz ", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            
        }

        private void esittirbutton_Click(object sender, EventArgs e)
        {
            if(ucunculabel.Text=="")
            {
                //ucunculabel girmeden işleme basarsak hata verir .
                MessageBox.Show("İkinci Sayi Girilmeden İşlem Yapılamaz ", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                birincilabel.Text = "";
                ikincilabel.Text = "";
                _islemdegisikligi = false;
            }
           
            else
            {
               

                double ilksayi = Convert.ToDouble(birincilabel.Text);
                double ikincisayi = Convert.ToDouble(ucunculabel.Text);
                //ilksayi ve ikincisayiyi double olarak aldım 
                switch (_islem)
                {
                    case '+':
                        sonuc = ilksayi + ikincisayi;
                        sonuclabel.Text = "=" + sonuc.ToString("F3");
                        //F3 kısmını yazarak virgülden sonra 3 basamak bıraktım .
                       

                        break;
                    case '-':
                        sonuc = ilksayi - ikincisayi;
                        sonuclabel.Text = "=" + sonuc.ToString("F3");
                        //F3 kısmını yazarak virgülden sonra 3 basamak bıraktım .

                        break;
                    case '/':
                        if (ikincisayi == 0)
                        {
                            sonuc = Convert.ToDouble("∞");
                            //sonsuzluk işaretini yazdırdığım kısım .
                            sonuclabel.Text = "=" + sonuc.ToString("F3");
                            //F3 kısmını yazarak virgülden sonra 3 basamak bıraktım .
                            _sonsuzluksaglama = true;
                            
                        }
                        else
                        {
                            sonuc = ilksayi / ikincisayi;
                            _sonsuzluksaglama = false;
                            
                        }
                        sonuclabel.Text = "=" + sonuc.ToString("F3");
                        //F3 kısmını yazarak virgülden sonra 3 basamak bıraktım .
                        break;
                    case '*':
                        sonuc = ilksayi * ikincisayi;
                        sonuclabel.Text = "=" + sonuc.ToString("F3");
                        //F3 kısmını yazarak virgülden sonra 3 basamak bıraktım .

                        break;
                    case '±':
                        sonuc = ilksayi * -1;
                        sonuclabel.Text = "=" + sonuc.ToString("F3");
                        //F3 kısmını yazarak virgülden sonra 3 basamak bıraktım .

                        break;
                    case 'P':
                        double taban = Convert.ToDouble(birincilabel.Text);
                        double üs = Convert.ToDouble(ucunculabel.Text);
                        sonuc = Math.Pow(taban, üs);
                        sonuclabel.Text = "=" + sonuc.ToString("F3");
                        //F3 kısmını yazarak virgülden sonra 3 basamak bıraktım .

                        break;
                    case 'E':

                        double sayi1 = Convert.ToDouble(birincilabel.Text);
                        double sayi2 = Convert.ToDouble(ucunculabel.Text);
                        double ebob = 0;
                        

                        for (int i = 1; i < sayi1; i++)
                        {
                            if (sayi1 % i == 0 && sayi2 % i == 0)
                            {
                                ebob = i;
                                sonuc = ebob;
                            } 
                        }
                        sonuclabel.Text = "=" + sonuc.ToString("F3");
                        
                        //F3 kısmını yazarak virgülden sonra 3 basamak bıraktım .
                        break;
                    case 'O':
                            double number1 = Convert.ToDouble(birincilabel.Text);
                            double number2 = Convert.ToDouble(ucunculabel.Text);
                            double max = number1 * number2;
                            double ekok = 0;
                            for (double i = max; i > 0; i--)
                            {
                                if (i % number1 == 0 && i % number2 == 0)
                                {
                                ekok = i;
                                sonuc = ekok;
                                }
                            }
                        
                        sonuclabel.Text= "="+ sonuc.ToString("F3");
                        //F3 kısmını yazarak virgülden sonra 3 basamak bıraktım .
                        break;
                    case 'M':
                        double deger1 = Convert.ToDouble(birincilabel.Text);
                        double deger2 = Convert.ToDouble(ucunculabel.Text);
                        double mod = deger1 % deger2;
                        sonuc = mod;
                        sonuclabel.Text = "=" + sonuc.ToString("F3");
                        //F3 kısmını yazarak virgülden sonra 3 basamak bıraktım .

                        break;
                    case 'S':
                        double deger11=Convert.ToDouble(birincilabel.Text);
                        double deger22=Convert.ToDouble(ucunculabel.Text);
                        double sonucc = deger11 * Math.Sqrt(deger22);
                        sonuc = sonucc;
                        sonuclabel.Text = "=" +sonuc.ToString("F3") ;
                        //F3 kısmını yazarak virgülden sonra 3 basamak bıraktım .

                        break;
                       
                    default:
                        sonuclabel.Text = "=" + sonuc.ToString("F3");
                        //F3 kısmını yazarak virgülden sonra 3 basamak bıraktım .
                        break;
                }
                /*Burada sonucun romen rakamına çevrilme kısmını yaptım.Her bir romen rakamının sayısal karşılığını switch case kısmında bulduğum sonuç değerinden 
                 çıkardım. Geriye kalan değeri ise diğer roma harflerini ekleyeerek işlemin sonuna kadar devam ettirdim .
                 */
                
              
                if(ucunculabel.Text!="0" && _sonsuzluksaglama==false)
                {
                    /* 5/0 şartını sonsuz olarak sağlatmak için ucuncu labelim sıfır olduğu zaman ve islemimin sonucu sonsuz olduğu zaman bu kısma girmesin diye
                    if oluşturdum . switch case içerisinde bölme işleminin içinde _sonsuzluksağlama diye bir bool oluşturdum  . _sonsuzluksağlama oluşturma nedenim
                    ise sonucun sonsuz olması ve olmaması farkını ortaya koyup sonsuz olmayan cevabı roma rakamına çevirmekti . bu ifi kullanmasam programım patlıyordu .
                     */
                    sonuclabel.Text += " ";
                while (sonuc >= 1000)
                {
                   
                   
                    sonuclabel.Text += "M";
                    sonuc -= 1000;
                }

                while (sonuc >= 900)
                {
                  
                    sonuclabel.Text += "CM";
                    sonuc -= 900;
                }

                while (sonuc >= 500)
                {
                    
                    sonuclabel.Text += "D";
                    sonuc -= 500;
                }

                while (sonuc >= 400)
                {
                   
                    sonuclabel.Text += "CD";
                    sonuc -= 400;
                }

                while (sonuc >= 100)
                {
                    sonuclabel.Text += "C";
                    sonuc -= 100;
                }

                while (sonuc >= 90)
                {
                    
                    sonuclabel.Text += "XC";
                    sonuc -= 90;
                }

                while (sonuc >= 50)
                {
                    
                    sonuclabel.Text += "L";
                    sonuc -= 50;
                }

                while (sonuc >= 40)
                {
                    
                    sonuclabel.Text += "XL";
                    sonuc -= 40;
                }

                while (sonuc >= 10)
                {
                   
                    sonuclabel.Text += "X";
                    sonuc -= 10;
                }

                while (sonuc >= 9)
                {
                    
                    sonuclabel.Text += "IX";
                    sonuc -= 9;
                }

                while (sonuc >= 5)
                {
                   
                    sonuclabel.Text += "V";
                    sonuc -= 5;
                }

                while (sonuc >= 4)
                {
                    
                    sonuclabel.Text += "IV";
                    sonuc -= 4;
                }

                while (sonuc >= 1)
                {
                  
                    sonuclabel.Text += "I";
                    sonuc -= 1;
                }
                //Burada tüm romen rakamlarını ekledim ve sayısal değerinden çıkarttım , Ta ki sonuc=0 olana kadar. Ve romen değerimi bu şekilde oluşturdum .
                sonuclabel.Text += " ";

                a = sonuclabel.Text.Split('=',' ');
                    /*Burada yaptığım split işlemi ile eşittir,sonucum ve romen rakamlarını birbirinden ayırdım  .
                     Ve operatörlere sadece sayının olduğu kısmı döndürdüm . Çünkü yeni bir işlem daha yapmak istesem eşittir ve romen rakamlarını
                    sayıyla beraber bir bütün halinde alıyor ve programım patlıyor .*/

                }
                labelgecmis.Text =birincilabel.Text + "" + ikincilabel.Text + "" + ucunculabel.Text + "" + sonuclabel.Text  + "\n" + labelgecmis.Text ;
            }
           
        }

        private void Cbutton_Click(object sender, EventArgs e)
        {

            birincilabel.Text = "";
            ikincilabel.Text = "";
            ucunculabel.Text = "";
            sonuclabel.Text = "";
            _islemdegisikligi = false;   //işlem değişikliğini false yaparak işlemi birincilabeldan itibaren başlattım.
        }

        private void CEbutton_Click(object sender, EventArgs e)
        {
            if(sonuclabel.Text!="")
            {
                //sonuclabel doluysa hepsini boşalttım 
                birincilabel.Text="";
                ikincilabel.Text = "";
                ucunculabel.Text = "";
                sonuclabel.Text = "";
                _islemdegisikligi = false;  //birincilabeldan itibaren yazmasını sağladım.
            }
            
            else if(ucunculabel.Text != "")
            {
                //ucunculabel doluysa sadece ucunculabelı boşalttım . 
                ucunculabel.Text = "";
            }
            else if (ikincilabel.Text != "")
            {
                // işlem operatörünü silmesini istemediğim için boş bir else if içine yazdım .
            }
            else 
            {
                //birincilabel doluysa birincilabeli boşalttım . 
                birincilabel.Text="";
                
            }
            
        }

        private void Hesaplama_Enter(object sender, EventArgs e)
        {

        }

        private void virgulbutton_Click(object sender, EventArgs e)
        {
            if(_islemdegisikligi==false)
            {
                if (birincilabel.Text.Contains(","))
                {
                    //birincilabelda virgül varsa başına sıfır eklememe gerek yok .
                    birincilabel.Text += "";
                    
                }

                else if ( birincilabel.Text.Contains(",") == false)
                {
                    if(birincilabel.Text == "")
                    {
                        birincilabel.Text += "0,";
                        //sadece virgüle bastığımızda direk virgülün sol tarafına sıfır ekleten satır .
                    }
                    else
                        //birincilabel boş değilse sadece virgül eklesek yeterlidir. 
                        birincilabel.Text += ",";



                }
              

            }
            else
            {

                if (ucunculabel.Text.Contains(","))
                {
                    //ucunculabelda virgül varsa başına sıfır eklememe gerek yok .
                    ucunculabel.Text += "";
                   
                }
                else if ( ucunculabel.Text.Contains(",") == false)
                {
                    if(ucunculabel.Text == "")
                    {
                        ucunculabel.Text += "0,";
                        //sadece virgüle bastığımızda direk virgülün sol tarafına sıfır ekleten satır .
                    }
                    else
                        // ucunculabel boş değilse sadece virgül eklesek yeterlidir. 
                        ucunculabel.Text += ",";

                }
                
            }


        }

        private void kucukturbutton_Click(object sender, EventArgs e)
        {
           
            //substring sayesinde geri alma olayını yaptım .
            if(_islemdegisikligi && ucunculabel.Text != "")
            {
                ucunculabel.Text = ucunculabel.Text.Substring(0, ucunculabel.Text.Length - 1);
            }
            else if(_islemdegisikligi==false && birincilabel.Text!="")
            {
                birincilabel.Text = birincilabel.Text.Substring(0, birincilabel.Text.Length - 1);
            }
            
        }

        private void powbutton_Click(object sender, EventArgs e)
        {
            labelgecmis.Visible = false;
            _islem = 'P';
            ikincilabel.Text = "Pow";

            if(birincilabel.Text!="")
            {
                //birincilabeldoluysa ucunculabela geç dedim .
                _islemdegisikligi = true;
            }
            if (sonuclabel.Text != "")
            {
                //sonuçlabel doluysa split ile a[1] halini birincilabela atadım . diğerlerini boşaltarak yeni bir işleme adım attım  .
                birincilabel.Text = a[1];
                ucunculabel.Text = "";
                sonuclabel.Text = "";
            }
            if (birincilabel.Text=="")
            {
                //birincisayi girmezsem hata vermesini sağladım
                MessageBox.Show("Birinci sayi girilmeden islem yapilamaz !!", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ikincilabel.Text = "";
            }
            

        }

        private void ebobbutton_Click(object sender, EventArgs e)
        {
            labelgecmis.Visible = false;
            _islem = 'E';
            ikincilabel.Text = "EBOB";

            if (birincilabel.Text != "")
            {
                //birincilabeldoluysa ucunculabela geç dedim .
                _islemdegisikligi = true;
            }
            if (sonuclabel.Text != "")
            {
                //sonuçlabel doluysa split ile a[1] halini birincilabela atadım . ucunculabel boşaltarak yeni bir işleme adım attım  .
                birincilabel.Text = a[1];
                ucunculabel.Text = "";
                
            }
            if (birincilabel.Text == "")
            {
                //birincisayi girmezsem hata vermesini sağladım
                MessageBox.Show("Birinci sayi girilmeden islem yapilamaz !!", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ikincilabel.Text = "";
            }
            

        }

        private void ekokbutton_Click(object sender, EventArgs e)
        {
            labelgecmis.Visible = false;
            _islem = 'O';
            ikincilabel.Text = "EKOK";
            if (sonuclabel.Text != "")
            {
                //sonuçlabel doluysa split ile a[1] halini birincilabela atadım . ucunculabel boşaltarak yeni bir işleme adım attım  .
                birincilabel.Text = a[1];
                ucunculabel.Text = "";
            }
            if (birincilabel.Text != "")
            {
                //birincilabeldoluysa ucunculabela geç dedim .
                _islemdegisikligi = true;
            }
           
            if (birincilabel.Text == "")
            {

                //birincisayi girmezsem hata vermesini sağladım
                MessageBox.Show("Birinci sayi girilmeden islem yapilamaz !!", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ikincilabel.Text = "";
            }

        }

        private void modbutton_Click(object sender, EventArgs e)
        {
            labelgecmis.Visible = false;
            _islem = 'M';
            ikincilabel.Text = "MOD";
            if (birincilabel.Text != "")
            {
                //birincilabeldoluysa ucunculabela geç dedim .
                _islemdegisikligi = true;
            }
            if (sonuclabel.Text != "")
            {
                //sonuçlabel doluysa split ile a[1] halini birincilabela atadım . ucunculabel boşaltarak yeni bir işleme adım attım  .
                birincilabel.Text = a[1];
                ucunculabel.Text = "";
            }
            if (birincilabel.Text == "")
            {

                //birincisayi girmezsem hata vermesini sağladım
                MessageBox.Show("Birinci sayi girilmeden islem yapilamaz !!");
                ikincilabel.Text = "";
            }
        }

        private void gecmislabel_Click(object sender, EventArgs e)
        {

        }

        private void gecmisbutton_Click(object sender, EventArgs e)
        {
            labelgecmis.Visible = true;
            /*özelliklerden visible false olarak ayarladım . geçmiş butonunda ise true olarak .geçmiş butonuna bastığımı zaman visible true oluyor .
              ,işleme(+,-,*,/..) bastığımız zaman 
             visible tekrardan false oluyor .butona bastığımıza zaman tekrar görünür hale geliyor  */
     
        }

        private void labelgecmis_Click(object sender, EventArgs e)
        {

        }
    }
}

