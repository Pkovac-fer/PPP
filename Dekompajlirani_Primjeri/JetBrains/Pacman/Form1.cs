// Decompiled with JetBrains decompiler
// Type: Pacman_Zagorschi_Franco.Form1
// Assembly: Pacman_Zagorschi_Franco, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E1912E80-659D-41AE-B9F0-CD405BA0A8F1
// Assembly location: C:\Users\Petar\OneDrive\Desktop\C#PRIMJERI\Pacman game in c#\Pacman_Zagorschi_Franco\bin\Debug\Pacman_Zagorschi_Franco.exe

using Pacman_Zagorschi_Franco.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Pacman_Zagorschi_Franco
{
  public class Form1 : Form
  {
    public int temp = 1;
    public bool tresec = true;
    public int vita = 3;
    public int startdirection = 1;
    public int ghost1velocity = 2;
    public int ghost2velocity = 2;
    public int ghost3velocity = 2;
    public int ghost4velocity = 2;
    public Random rand = new Random();
    public List<object> oggetti = new List<object>();
    private IContainer components = (IContainer) null;
    public int leftghost1;
    public int leftghost2;
    public int leftghost3;
    public int leftghost4;
    public int left;
    public int topghost1;
    public int topghost2;
    public int topghost3;
    public int topghost4;
    public int top;
    public int next;
    public int direzione;
    public bool pacturn;
    public bool ghost1turn;
    public bool ghost2turn;
    public bool ghost3turn;
    public bool ghost4turn;
    public bool start;
    public bool ghost1puomangiare;
    public bool ghost2puomangiare;
    public bool ghost3puomangiare;
    public bool ghost4puomangiare;
    public bool g1mangiato;
    public bool g2mangiato;
    public bool g3mangiato;
    public bool g4mangiato;
    public bool dir1;
    public bool dir2;
    public bool dir3;
    public bool dir4;
    public bool c;
    public bool Supermod;
    public bool Supermod1;
    public bool Supermod2;
    public bool Supermod3;
    public bool Supermod4;
    public bool v1;
    public bool v2;
    public bool v3;
    public bool v4;
    public int random1;
    public int random2;
    public int random3;
    public int random4;
    public int tic4;
    public int tic5;
    public int tic6;
    public int point;
    public int prec1;
    public int prec2;
    public int prec3;
    public int prec4;
    private Timer timer1;
    private Label ghost1;
    private Label ghost2;
    private Label ghost4;
    private Label ghost3;
    private Label label1;
    private Label label2;
    private PictureBox pictureBox1;
    private PictureBox pictureBox2;
    private Label label3;
    private Timer timer2;
    private Timer timer3;
    private Timer timer4;
    private Timer timer5;
    private Timer timer6;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private Label label9;
    private Label label10;
    private Label label11;
    private Label label12;
    private Label label13;
    private Label label14;
    private Label label15;
    private Label label16;
    private Label label17;
    private Label label18;
    private Label label19;
    private Label label20;
    private Label label21;
    private Label label22;
    private Label label23;
    private Label label24;
    private Label label25;
    private Label label26;
    private Label label27;
    private Label label28;
    private Label label29;
    private Label label30;
    private Label label31;
    private Label score;
    private Label label43;
    private Label label44;
    private Label label32;
    private Label label45;
    private Label label46;
    private Label label47;
    private Label label49;
    private Label label50;
    private Label label33;
    private Label label34;
    private Label label35;
    private Label label36;
    private Label label37;
    private Label label38;
    private Label label39;
    private Label label40;
    private Label label41;
    private Label label42;
    private Label label48;
    private Label label51;
    private Label label52;
    private Label label53;
    private Label label54;
    private Label label55;
    private Label label56;
    private Label label57;
    private Label label58;
    private Label label59;
    private Label label60;
    private Label label61;
    private Label label62;
    private Label label63;
    private Label label64;
    private Label label65;
    private Label label66;
    private Label label67;
    private Label label68;
    private Label label69;
    private Label label70;
    private Label label71;
    private Label label72;
    private Label label73;
    private Label label74;
    private Label label76;
    private Label label77;
    private Label label78;
    private Label label79;
    private Label label80;
    private Label label81;
    private Label label82;
    private Label label83;
    private Label label75;
    private Label label84;
    private Label label85;
    private Label label86;
    private Label label87;
    private Label label88;
    private Label label89;
    private Label label90;
    private Label label91;
    private Label label92;
    private Label label94;
    private Label label93;
    private Label label95;
    private Label label96;
    private Label label98;
    private Label label97;
    private Label label99;
    private Label label100;
    private Label label101;
    private Label label102;
    private Label label103;
    private Label label104;
    private Label label105;
    private Label label106;
    private Label label107;
    private Label label108;
    private Label label109;
    private Label label110;
    private Label label111;
    private Label label112;
    private Label label113;
    private Label label114;
    private Label label115;
    private Label label116;
    private Label label117;
    private Label label118;
    private Label label119;
    private Label label120;
    private Label label121;
    private Label label122;
    private Label label123;
    private Label label125;
    private Label label126;
    private Label label127;
    private Label label128;
    private Label label129;
    private Label label130;
    private Label label131;
    private Label label132;
    private Label label133;
    private Label label134;
    private Label label135;
    private Label label136;
    private Label label137;
    private Label label138;
    private Label label139;
    private Label label140;
    private Label label143;
    private Label label144;
    private Label label145;
    private Label label146;
    private Label label147;
    private Label label148;
    private Label label149;
    private Label label150;
    private Label label151;
    private Label label152;
    private Label label153;
    private Label label154;
    private Label label155;
    private Label label156;
    private Label label157;
    private Label label158;
    private Label label159;
    private Label label160;
    private Label label161;
    private Label label162;
    private Label label163;
    private Label label164;
    private Label label165;
    private Label label166;
    private Label label167;
    private Label label168;
    private Label label169;
    private Label label170;
    private Label label171;
    private Label label172;
    private Label label173;
    private Label label174;
    private Label label175;
    private Label label176;
    private Label label177;
    private Label label178;
    private Label label179;
    private Label label180;
    private Label label181;
    private Label label182;
    private Label label183;
    private Label label184;
    private Label label185;
    private Label label186;
    private Label label187;
    private Label label188;
    private Label label189;
    private Label label190;
    private Label label191;
    private Label label192;
    private Label label193;
    private Label label194;
    private Label label195;
    private Label label196;
    private Label label199;
    private Label label198;
    private Label label200;
    private Label label201;
    private Label label202;
    private Label label203;
    private Label label204;
    private Label label205;
    private Label label206;
    private Label label207;
    private Label label208;
    private Label label209;
    private Label label210;
    private Label label211;
    private Label label212;
    private Label label213;
    private Label label214;
    private Label label197;
    private Label label215;
    private Label label216;
    private Label label217;
    private Label label218;
    private Label label219;
    private Label label220;
    private Label label221;
    private Label label222;
    private Label label223;
    private Label label224;
    private Label label225;
    private Label label226;
    private Label label227;
    private Label label228;
    private Label label229;
    private Label label230;
    private Label label231;
    private Label label232;
    private Label label233;
    private Label label234;
    private Label label235;
    private Label label236;
    private Label label237;
    private Label label238;
    private Label label239;
    private Label label240;
    private Label label241;
    private Label label242;
    private Label label243;
    private Label label244;
    private Label label245;
    private Label label246;
    private Label label247;
    private Label label248;
    private Label label249;
    private Label label250;
    private Label label251;
    private Label label252;
    private Label label256;
    private Label label257;
    private Label label258;
    private Label label259;
    private Label label260;
    private Label label261;
    private Label label262;
    private Label label263;
    private Label label264;
    private Label label265;
    private Label label272;
    private Label label273;
    private Label label274;
    private Label label280;
    private Label label281;
    private Label label282;
    private Label label283;
    private Label label284;
    private Label label266;
    private Label label267;
    private Label label268;
    private Label label269;
    private Label label270;
    private Label label271;
    private Label label275;
    private Label label276;
    private Label label277;
    private Label label278;
    private Label label279;
    private Label label285;
    private Label label286;
    private Label label287;
    private Label label288;
    private Label label289;
    private Label label290;
    private Label label293;
    private Label label294;
    private Label label295;
    private Label label296;
    private Label label297;
    private Label label298;
    private Label label299;
    private Label label300;
    private Label label301;
    private Label label302;
    private Label label291;
    private Label label292;
    private Label label303;
    private Label label304;
    private Label label305;
    private Label label306;
    private Label label307;
    private Label label308;
    private Label label309;
    private Label label310;
    private Label label311;
    private Label label312;
    private Label label313;
    private Label label314;
    private Label label315;
    private Label label316;
    private Label label317;
    private Label label318;
    private Label label319;
    private Label label320;
    private Label label321;
    private Label label322;
    private Label label323;
    private Label label324;
    private Label label325;
    private Label label327;
    private Label label326;
    private Label label328;
    private Label label329;
    private Label label330;
    private Label label331;
    private Label label332;
    private Label label333;
    private Label label334;
    private Label label335;
    private Label label336;
    private Label label337;
    private Label label338;
    private Label label339;
    private Label label340;
    private Label label341;
    private Timer timer8;
    private Panel panel1;
    private Button button1;
    private PictureBox pictureBox3;
    private PictureBox pacman;
    private Timer powermod;
    private Timer timer7;
    private Timer timer9;
    private Timer ghostmangiato;
    private Label label124;
    private Label label141;
    private Timer powermod1;
    private Timer attendo;
    private PictureBox pictureBox4;
    private PictureBox pictureBox5;
    private Label label254;
    private Label label255;
    private Label label253;
    private Label label142;

    private void label254_Click_1(object sender, EventArgs e)
    {
    }

    private void pictureBox5_Click(object sender, EventArgs e)
    {
    }

    private void label255_Click(object sender, EventArgs e)
    {
    }

    private void label254_Click(object sender, EventArgs e)
    {
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {
    }

    private void label142_Click(object sender, EventArgs e)
    {
    }

    private void pictureBox4_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {
    }

    public Form1()
    {
      this.InitializeComponent();
      this.oggetti.Add((object) this.label4);
      this.oggetti.Add((object) this.label5);
      this.oggetti.Add((object) this.label6);
      this.oggetti.Add((object) this.label7);
      this.oggetti.Add((object) this.label8);
      this.oggetti.Add((object) this.label9);
      this.oggetti.Add((object) this.label10);
      this.oggetti.Add((object) this.label11);
      this.oggetti.Add((object) this.label12);
      this.oggetti.Add((object) this.label13);
      this.oggetti.Add((object) this.label14);
      this.oggetti.Add((object) this.label15);
      this.oggetti.Add((object) this.label16);
      this.oggetti.Add((object) this.label17);
      this.oggetti.Add((object) this.label18);
      this.oggetti.Add((object) this.label19);
      this.oggetti.Add((object) this.label20);
      this.oggetti.Add((object) this.label21);
      this.oggetti.Add((object) this.label22);
      this.oggetti.Add((object) this.label23);
      this.oggetti.Add((object) this.label24);
      this.oggetti.Add((object) this.label25);
      this.oggetti.Add((object) this.label26);
      this.oggetti.Add((object) this.label27);
      this.oggetti.Add((object) this.label28);
      this.oggetti.Add((object) this.label29);
      this.oggetti.Add((object) this.label30);
      this.oggetti.Add((object) this.label31);
      this.oggetti.Add((object) this.label32);
      this.oggetti.Add((object) this.label33);
      this.oggetti.Add((object) this.label34);
      this.oggetti.Add((object) this.label35);
      this.oggetti.Add((object) this.label36);
      this.oggetti.Add((object) this.label37);
      this.oggetti.Add((object) this.label38);
      this.oggetti.Add((object) this.label39);
      this.oggetti.Add((object) this.label40);
      this.oggetti.Add((object) this.label41);
      this.oggetti.Add((object) this.label42);
      this.oggetti.Add((object) this.label43);
      this.oggetti.Add((object) this.label44);
      this.oggetti.Add((object) this.label45);
      this.oggetti.Add((object) this.label46);
      this.oggetti.Add((object) this.label47);
      this.oggetti.Add((object) this.label48);
      this.oggetti.Add((object) this.label49);
      this.oggetti.Add((object) this.label50);
      this.oggetti.Add((object) this.label51);
      this.oggetti.Add((object) this.label52);
      this.oggetti.Add((object) this.label53);
      this.oggetti.Add((object) this.label54);
      this.oggetti.Add((object) this.label55);
      this.oggetti.Add((object) this.label56);
      this.oggetti.Add((object) this.label57);
      this.oggetti.Add((object) this.label58);
      this.oggetti.Add((object) this.label59);
      this.oggetti.Add((object) this.label60);
      this.oggetti.Add((object) this.label61);
      this.oggetti.Add((object) this.label62);
      this.oggetti.Add((object) this.label63);
      this.oggetti.Add((object) this.label64);
      this.oggetti.Add((object) this.label65);
      this.oggetti.Add((object) this.label66);
      this.oggetti.Add((object) this.label67);
      this.oggetti.Add((object) this.label68);
      this.oggetti.Add((object) this.label69);
      this.oggetti.Add((object) this.label70);
      this.oggetti.Add((object) this.label71);
      this.oggetti.Add((object) this.label72);
      this.oggetti.Add((object) this.label73);
      this.oggetti.Add((object) this.label74);
      this.oggetti.Add((object) this.label75);
      this.oggetti.Add((object) this.label76);
      this.oggetti.Add((object) this.label77);
      this.oggetti.Add((object) this.label78);
      this.oggetti.Add((object) this.label79);
      this.oggetti.Add((object) this.label80);
      this.oggetti.Add((object) this.label81);
      this.oggetti.Add((object) this.label82);
      this.oggetti.Add((object) this.label83);
      this.oggetti.Add((object) this.label84);
      this.oggetti.Add((object) this.label85);
      this.oggetti.Add((object) this.label86);
      this.oggetti.Add((object) this.label87);
      this.oggetti.Add((object) this.label88);
      this.oggetti.Add((object) this.label89);
      this.oggetti.Add((object) this.label90);
      this.oggetti.Add((object) this.label91);
      this.oggetti.Add((object) this.label92);
      this.oggetti.Add((object) this.label93);
      this.oggetti.Add((object) this.label94);
      this.oggetti.Add((object) this.label95);
      this.oggetti.Add((object) this.label96);
      this.oggetti.Add((object) this.label97);
      this.oggetti.Add((object) this.label98);
      this.oggetti.Add((object) this.label99);
      this.oggetti.Add((object) this.label100);
      this.oggetti.Add((object) this.label101);
      this.oggetti.Add((object) this.label102);
      this.oggetti.Add((object) this.label103);
      this.oggetti.Add((object) this.label104);
      this.oggetti.Add((object) this.label105);
      this.oggetti.Add((object) this.label106);
      this.oggetti.Add((object) this.label107);
      this.oggetti.Add((object) this.label108);
      this.oggetti.Add((object) this.label109);
      this.oggetti.Add((object) this.label110);
      this.oggetti.Add((object) this.label111);
      this.oggetti.Add((object) this.label112);
      this.oggetti.Add((object) this.label113);
      this.oggetti.Add((object) this.label114);
      this.oggetti.Add((object) this.label115);
      this.oggetti.Add((object) this.label116);
      this.oggetti.Add((object) this.label117);
      this.oggetti.Add((object) this.label118);
      this.oggetti.Add((object) this.label119);
      this.oggetti.Add((object) this.label120);
      this.oggetti.Add((object) this.label121);
      this.oggetti.Add((object) this.label122);
      this.oggetti.Add((object) this.label123);
      this.oggetti.Add((object) this.label125);
      this.oggetti.Add((object) this.label126);
      this.oggetti.Add((object) this.label127);
      this.oggetti.Add((object) this.label128);
      this.oggetti.Add((object) this.label129);
      this.oggetti.Add((object) this.label130);
      this.oggetti.Add((object) this.label131);
      this.oggetti.Add((object) this.label132);
      this.oggetti.Add((object) this.label133);
      this.oggetti.Add((object) this.label134);
      this.oggetti.Add((object) this.label135);
      this.oggetti.Add((object) this.label136);
      this.oggetti.Add((object) this.label137);
      this.oggetti.Add((object) this.label138);
      this.oggetti.Add((object) this.label139);
      this.oggetti.Add((object) this.label140);
      this.oggetti.Add((object) this.label143);
      this.oggetti.Add((object) this.label144);
      this.oggetti.Add((object) this.label145);
      this.oggetti.Add((object) this.label146);
      this.oggetti.Add((object) this.label147);
      this.oggetti.Add((object) this.label148);
      this.oggetti.Add((object) this.label149);
      this.oggetti.Add((object) this.label150);
      this.oggetti.Add((object) this.label151);
      this.oggetti.Add((object) this.label152);
      this.oggetti.Add((object) this.label153);
      this.oggetti.Add((object) this.label154);
      this.oggetti.Add((object) this.label155);
      this.oggetti.Add((object) this.label156);
      this.oggetti.Add((object) this.label157);
      this.oggetti.Add((object) this.label158);
      this.oggetti.Add((object) this.label159);
      this.oggetti.Add((object) this.label160);
      this.oggetti.Add((object) this.label161);
      this.oggetti.Add((object) this.label162);
      this.oggetti.Add((object) this.label163);
      this.oggetti.Add((object) this.label164);
      this.oggetti.Add((object) this.label165);
      this.oggetti.Add((object) this.label166);
      this.oggetti.Add((object) this.label167);
      this.oggetti.Add((object) this.label168);
      this.oggetti.Add((object) this.label169);
      this.oggetti.Add((object) this.label170);
      this.oggetti.Add((object) this.label171);
      this.oggetti.Add((object) this.label172);
      this.oggetti.Add((object) this.label173);
      this.oggetti.Add((object) this.label174);
      this.oggetti.Add((object) this.label175);
      this.oggetti.Add((object) this.label176);
      this.oggetti.Add((object) this.label177);
      this.oggetti.Add((object) this.label178);
      this.oggetti.Add((object) this.label179);
      this.oggetti.Add((object) this.label180);
      this.oggetti.Add((object) this.label181);
      this.oggetti.Add((object) this.label182);
      this.oggetti.Add((object) this.label183);
      this.oggetti.Add((object) this.label184);
      this.oggetti.Add((object) this.label185);
      this.oggetti.Add((object) this.label186);
      this.oggetti.Add((object) this.label187);
      this.oggetti.Add((object) this.label188);
      this.oggetti.Add((object) this.label189);
      this.oggetti.Add((object) this.label190);
      this.oggetti.Add((object) this.label191);
      this.oggetti.Add((object) this.label192);
      this.oggetti.Add((object) this.label193);
      this.oggetti.Add((object) this.label194);
      this.oggetti.Add((object) this.label195);
      this.oggetti.Add((object) this.label196);
      this.oggetti.Add((object) this.label197);
      this.oggetti.Add((object) this.label198);
      this.oggetti.Add((object) this.label199);
      this.oggetti.Add((object) this.label200);
      this.oggetti.Add((object) this.label201);
      this.oggetti.Add((object) this.label202);
      this.oggetti.Add((object) this.label203);
      this.oggetti.Add((object) this.label204);
      this.oggetti.Add((object) this.label205);
      this.oggetti.Add((object) this.label206);
      this.oggetti.Add((object) this.label207);
      this.oggetti.Add((object) this.label208);
      this.oggetti.Add((object) this.label209);
      this.oggetti.Add((object) this.label210);
      this.oggetti.Add((object) this.label211);
      this.oggetti.Add((object) this.label212);
      this.oggetti.Add((object) this.label213);
      this.oggetti.Add((object) this.label214);
      this.oggetti.Add((object) this.label215);
      this.oggetti.Add((object) this.label216);
      this.oggetti.Add((object) this.label217);
      this.oggetti.Add((object) this.label218);
      this.oggetti.Add((object) this.label219);
      this.oggetti.Add((object) this.label220);
      this.oggetti.Add((object) this.label221);
      this.oggetti.Add((object) this.label222);
      this.oggetti.Add((object) this.label223);
      this.oggetti.Add((object) this.label224);
      this.oggetti.Add((object) this.label225);
      this.oggetti.Add((object) this.label226);
      this.oggetti.Add((object) this.label227);
      this.oggetti.Add((object) this.label228);
      this.oggetti.Add((object) this.label229);
      this.oggetti.Add((object) this.label230);
      this.oggetti.Add((object) this.label231);
      this.oggetti.Add((object) this.label232);
      this.oggetti.Add((object) this.label233);
      this.oggetti.Add((object) this.label234);
      this.oggetti.Add((object) this.label235);
      this.oggetti.Add((object) this.label236);
      this.oggetti.Add((object) this.label237);
      this.oggetti.Add((object) this.label238);
      this.oggetti.Add((object) this.label239);
      this.oggetti.Add((object) this.label240);
      this.oggetti.Add((object) this.label241);
      this.oggetti.Add((object) this.label242);
      this.oggetti.Add((object) this.label243);
      this.oggetti.Add((object) this.label244);
      this.oggetti.Add((object) this.label245);
      this.oggetti.Add((object) this.label246);
      this.oggetti.Add((object) this.label247);
      this.oggetti.Add((object) this.label248);
      this.oggetti.Add((object) this.label249);
      this.oggetti.Add((object) this.label250);
      this.oggetti.Add((object) this.label251);
      this.oggetti.Add((object) this.label252);
      this.oggetti.Add((object) this.label256);
      this.oggetti.Add((object) this.label257);
      this.oggetti.Add((object) this.label258);
      this.oggetti.Add((object) this.label259);
      this.oggetti.Add((object) this.label260);
      this.oggetti.Add((object) this.label261);
      this.oggetti.Add((object) this.label262);
      this.oggetti.Add((object) this.label263);
      this.oggetti.Add((object) this.label264);
      this.oggetti.Add((object) this.label265);
      this.oggetti.Add((object) this.label266);
      this.oggetti.Add((object) this.label267);
      this.oggetti.Add((object) this.label268);
      this.oggetti.Add((object) this.label269);
      this.oggetti.Add((object) this.label270);
      this.oggetti.Add((object) this.label271);
      this.oggetti.Add((object) this.label272);
      this.oggetti.Add((object) this.label273);
      this.oggetti.Add((object) this.label274);
      this.oggetti.Add((object) this.label275);
      this.oggetti.Add((object) this.label276);
      this.oggetti.Add((object) this.label277);
      this.oggetti.Add((object) this.label278);
      this.oggetti.Add((object) this.label279);
      this.oggetti.Add((object) this.label280);
      this.oggetti.Add((object) this.label281);
      this.oggetti.Add((object) this.label282);
      this.oggetti.Add((object) this.label283);
      this.oggetti.Add((object) this.label284);
      this.oggetti.Add((object) this.label285);
      this.oggetti.Add((object) this.label286);
      this.oggetti.Add((object) this.label287);
      this.oggetti.Add((object) this.label288);
      this.oggetti.Add((object) this.label289);
      this.oggetti.Add((object) this.label290);
      this.oggetti.Add((object) this.label291);
      this.oggetti.Add((object) this.label292);
      this.oggetti.Add((object) this.label293);
      this.oggetti.Add((object) this.label294);
      this.oggetti.Add((object) this.label295);
      this.oggetti.Add((object) this.label296);
      this.oggetti.Add((object) this.label297);
      this.oggetti.Add((object) this.label298);
      this.oggetti.Add((object) this.label299);
      this.oggetti.Add((object) this.label300);
      this.oggetti.Add((object) this.label301);
      this.oggetti.Add((object) this.label302);
      this.oggetti.Add((object) this.label303);
      this.oggetti.Add((object) this.label304);
      this.oggetti.Add((object) this.label305);
      this.oggetti.Add((object) this.label306);
      this.oggetti.Add((object) this.label307);
      this.oggetti.Add((object) this.label308);
      this.oggetti.Add((object) this.label309);
      this.oggetti.Add((object) this.label310);
      this.oggetti.Add((object) this.label311);
      this.oggetti.Add((object) this.label312);
      this.oggetti.Add((object) this.label313);
      this.oggetti.Add((object) this.label314);
      this.oggetti.Add((object) this.label315);
      this.oggetti.Add((object) this.label316);
      this.oggetti.Add((object) this.label317);
      this.oggetti.Add((object) this.label318);
      this.oggetti.Add((object) this.label319);
      this.oggetti.Add((object) this.label320);
      this.oggetti.Add((object) this.label321);
      this.oggetti.Add((object) this.label322);
      this.oggetti.Add((object) this.label323);
      this.oggetti.Add((object) this.label324);
      this.oggetti.Add((object) this.label325);
      this.oggetti.Add((object) this.label326);
      this.oggetti.Add((object) this.label327);
      this.oggetti.Add((object) this.label328);
      this.oggetti.Add((object) this.label329);
      this.oggetti.Add((object) this.label330);
      this.oggetti.Add((object) this.label331);
      this.oggetti.Add((object) this.label332);
      this.oggetti.Add((object) this.label333);
      this.oggetti.Add((object) this.label334);
      this.oggetti.Add((object) this.label335);
      this.oggetti.Add((object) this.label336);
      this.oggetti.Add((object) this.label337);
      this.oggetti.Add((object) this.label338);
      this.oggetti.Add((object) this.label339);
      this.oggetti.Add((object) this.label340);
      this.oggetti.Add((object) this.label341);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.start = true;
      this.life();
      this.points();
      this.panel1.Visible = false;
      this.resetall();
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Left)
        this.next = 1;
      if (e.KeyCode == Keys.Right)
        this.next = 2;
      if (e.KeyCode == Keys.Up)
        this.next = 3;
      if (e.KeyCode == Keys.Down)
        this.next = 4;
      if (e.KeyCode == Keys.Escape)
        this.Close();
      this.temp = this.next;
    }

    private void button1_MouseLeave(object sender, EventArgs e)
    {
      this.button1.Image = (Image) Resources.playgame;
    }

    private void button1_MouseEnter(object sender, EventArgs e)
    {
      this.button1.Image = (Image) Resources.playgame2;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      if (this.pacman.Enabled)
      {
        this.direction();
        this.freedirection();
      }
      if (this.ghost1.Enabled || this.ghost2.Enabled || this.ghost3.Enabled || this.ghost4.Enabled)
        this.ghost();
      if (this.c)
        this.control();
      this.supermod();
      this.points();
      this.collision();
    }

    private void timer2_Tick(object sender, EventArgs e)
    {
      this.label3.Visible = false;
      this.timer1.Enabled = true;
      this.timer2.Enabled = false;
      this.c = true;
    }

    private void timer3_Tick(object sender, EventArgs e)
    {
      if (this.ghost2.Top == 180)
        this.startdirection = 2;
      if (this.ghost2.Top == 192)
        this.startdirection = 1;
      if (this.startdirection == 1)
      {
        --this.ghost2.Top;
        --this.ghost4.Top;
      }
      if (this.startdirection != 2)
        return;
      ++this.ghost2.Top;
      ++this.ghost4.Top;
    }

    private void timer4_Tick(object sender, EventArgs e)
    {
      ++this.tic4;
      if (this.ghost3.Top > 150 && this.tic4 > 100)
      {
        this.prec1 = 3;
        --this.ghost3.Top;
      }
      if (this.ghost3.Top != 150)
        return;
      this.timer4.Enabled = false;
    }

    private void timer5_Tick(object sender, EventArgs e)
    {
      ++this.tic5;
      if (this.ghost2.Left > 153 && this.ghost2.Left < 176 && this.tic5 > 300)
        ++this.ghost2.Left;
      if (this.ghost2.Top > 150 && this.ghost2.Left == 176)
        --this.ghost2.Top;
      if (this.ghost2.Top != 150)
        return;
      this.timer6.Enabled = true;
      this.timer5.Enabled = false;
    }

    private void timer6_Tick(object sender, EventArgs e)
    {
      ++this.tic6;
      if (this.ghost4.Left > 176 && this.ghost4.Left < 200 && this.tic6 > 100)
        --this.ghost4.Left;
      if (this.ghost4.Top > 150 && this.ghost4.Left == 176)
        --this.ghost4.Top;
      if (this.ghost4.Top != 150)
        return;
      this.timer6.Enabled = false;
    }

    private void powermod_Tick(object sender, EventArgs e)
    {
      this.tresec = false;
      if (!this.g1mangiato)
      {
        this.v1 = false;
        this.ghost1puomangiare = true;
        this.Supermod1 = false;
        this.ghost1velocity = 2;
      }
      if (!this.g2mangiato)
      {
        this.v2 = false;
        this.ghost2puomangiare = true;
        this.Supermod2 = false;
        this.ghost2velocity = 2;
      }
      if (!this.g3mangiato)
      {
        this.v3 = false;
        this.ghost3puomangiare = true;
        this.Supermod3 = false;
        this.ghost3velocity = 2;
      }
      if (!this.g4mangiato)
      {
        this.v4 = false;
        this.ghost4puomangiare = true;
        this.Supermod4 = false;
        this.ghost4velocity = 2;
      }
      this.Supermod = false;
      this.powermod.Enabled = false;
      this.powermod1.Enabled = false;
      if (this.prec1 == 1 && !this.g1mangiato)
      {
        if (this.ghost1.Left % 2 == 0)
          this.leftghost1 = this.ghost1velocity;
        this.ghost1.Image = (Image) Resources.rdx;
      }
      if (this.prec1 == 2 && !this.g1mangiato)
      {
        if (this.ghost1.Left % 2 == 0)
          this.leftghost1 = -this.ghost1velocity;
        this.ghost1.Image = (Image) Resources.rsx;
      }
      if (this.prec1 == 3 && !this.g1mangiato)
      {
        if (this.ghost1.Top % 2 == 0)
          this.topghost1 = -this.ghost1velocity;
        this.ghost1.Image = (Image) Resources.rup;
      }
      if (this.prec1 == 4 && !this.g1mangiato)
      {
        if (this.ghost1.Top % 2 == 0)
          this.topghost1 = this.ghost1velocity;
        this.ghost1.Image = (Image) Resources.rdown;
      }
      if (this.prec2 == 1 && !this.g2mangiato)
      {
        if (this.ghost2.Left % 2 == 0)
          this.leftghost2 = this.ghost2velocity;
        this.ghost2.Image = (Image) Resources.adx;
      }
      if (this.prec2 == 2 && !this.g2mangiato)
      {
        if (this.ghost2.Left % 2 == 0)
          this.leftghost2 = -this.ghost2velocity;
        this.ghost2.Image = (Image) Resources.asx;
      }
      if (this.prec2 == 3 && !this.g2mangiato)
      {
        if (this.ghost2.Top % 2 == 0)
          this.topghost2 = -this.ghost2velocity;
        this.ghost2.Image = (Image) Resources.aup;
      }
      if (this.prec2 == 4 && !this.g2mangiato)
      {
        if (this.ghost2.Top % 2 == 0)
          this.topghost2 = this.ghost2velocity;
        this.ghost2.Image = (Image) Resources.adown;
      }
      if (this.prec3 == 1 && !this.g3mangiato)
      {
        if (this.ghost3.Left % 2 == 0)
          this.leftghost3 = this.ghost3velocity;
        this.ghost3.Image = (Image) Resources.vdx;
      }
      if (this.prec3 == 2 && !this.g3mangiato)
      {
        if (this.ghost3.Left % 2 == 0)
          this.leftghost3 = -this.ghost3velocity;
        this.ghost3.Image = (Image) Resources.vsx;
      }
      if (this.prec3 == 3 && !this.g3mangiato)
      {
        if (this.ghost3.Top % 2 == 0)
          this.topghost3 = -this.ghost3velocity;
        this.ghost3.Image = (Image) Resources.vup;
      }
      if (this.prec3 == 4 && !this.g3mangiato)
      {
        if (this.ghost3.Top % 2 == 0)
          this.topghost3 = this.ghost3velocity;
        this.ghost3.Image = (Image) Resources.vdown;
      }
      if (this.prec4 == 1 && !this.g4mangiato)
      {
        if (this.ghost4.Left % 2 == 0)
          this.leftghost4 = this.ghost4velocity;
        this.ghost4.Image = (Image) Resources.gdx;
      }
      if (this.prec4 == 2 && !this.g4mangiato)
      {
        if (this.ghost4.Left % 2 == 0)
          this.leftghost4 = -this.ghost4velocity;
        this.ghost4.Image = (Image) Resources.gsx;
      }
      if (this.prec4 == 3 && !this.g4mangiato)
      {
        if (this.ghost4.Top % 2 == 0)
          this.topghost4 = -this.ghost4velocity;
        this.ghost4.Image = (Image) Resources.gup;
      }
      if (this.prec4 != 4 || this.g4mangiato)
        return;
      if (this.ghost4.Top % 2 == 0)
        this.topghost4 = this.ghost4velocity;
      this.ghost1.Image = (Image) Resources.gdown;
    }

    private void timer8_Tick(object sender, EventArgs e)
    {
      this.pacman.SetBounds(this.pacman.Left, this.pacman.Top, 0, 0);
      this.g1mangiato = false;
      this.g2mangiato = false;
      this.g3mangiato = false;
      this.g4mangiato = false;
      this.v1 = false;
      this.v2 = false;
      this.v3 = false;
      this.v4 = false;
      this.ghost1puomangiare = true;
      this.ghost2puomangiare = true;
      this.ghost3puomangiare = true;
      this.ghost4puomangiare = true;
      this.ghost1.Visible = false;
      this.ghost2.Visible = false;
      this.ghost3.Visible = false;
      this.ghost4.Visible = false;
      this.pacman.Visible = false;
      this.tic4 = 0;
      this.tic5 = 0;
      this.tic6 = 0;
      this.Supermod = false;
      this.Supermod1 = false;
      this.Supermod2 = false;
      this.Supermod3 = false;
      this.Supermod4 = false;
      this.ghost1velocity = 2;
      this.ghost2velocity = 2;
      this.ghost3velocity = 2;
      this.ghost4velocity = 2;
      --this.vita;
      this.life();
      this.prec1 = 0;
      this.prec2 = 0;
      this.prec3 = 0;
      this.prec4 = 0;
      this.startdirection = 1;
      this.dir1 = false;
      this.dir2 = false;
      this.dir3 = false;
      this.dir4 = false;
      this.c = false;
      this.next = 0;
      this.temp = 1;
      this.direzione = 0;
      this.pacman.Left = 24;
      this.pacman.Top = 364;
      this.ghost1.Left = 176;
      this.ghost1.Top = 150;
      this.ghost2.Left = 154;
      this.ghost2.Top = 185;
      this.ghost3.Left = 176;
      this.ghost3.Top = 185;
      this.ghost4.Left = 199;
      this.ghost4.Top = 185;
      this.leftghost1 = 0;
      this.leftghost2 = 0;
      this.leftghost3 = 0;
      this.leftghost4 = 0;
      this.topghost1 = 0;
      this.topghost2 = 0;
      this.topghost3 = 0;
      this.topghost4 = 0;
      this.left = 0;
      this.top = 0;
      this.timer8.Enabled = false;
      this.pacman.Image = (Image) Resources._1dx;
      this.ghost1.Image = (Image) Resources.rup;
      this.ghost2.Image = (Image) Resources.aup;
      this.ghost3.Image = (Image) Resources.vup;
      this.ghost4.Image = (Image) Resources.gup;
      this.ghost1.Visible = true;
      this.ghost2.Visible = true;
      this.ghost3.Visible = true;
      this.ghost4.Visible = true;
      this.pacman.SetBounds(this.pacman.Left, this.pacman.Top, 22, 22);
      this.pacman.Visible = true;
      this.timer2.Enabled = true;
      this.timer3.Enabled = true;
      this.timer8.Interval = 1900;
    }

    private void timer9_Tick(object sender, EventArgs e)
    {
      this.pictureBox3.Visible = true;
      this.button1.Visible = true;
      this.timer9.Enabled = false;
    }

    private void resetall()
    {
      this.g1mangiato = false;
      this.g2mangiato = false;
      this.g3mangiato = false;
      this.g4mangiato = false;
      this.v1 = false;
      this.v2 = false;
      this.v3 = false;
      this.v4 = false;
      this.ghost1puomangiare = true;
      this.ghost2puomangiare = true;
      this.ghost3puomangiare = true;
      this.ghost4puomangiare = true;
      this.label124.Visible = false;
      this.label141.Visible = false;
      this.pacman.SetBounds(this.pacman.Left, this.pacman.Top, 22, 22);
      this.tic4 = 0;
      this.tic5 = 0;
      this.tic6 = 0;
      this.Supermod = false;
      this.Supermod1 = false;
      this.Supermod2 = false;
      this.Supermod3 = false;
      this.Supermod4 = false;
      this.ghost1velocity = 2;
      this.ghost2velocity = 2;
      this.ghost3velocity = 2;
      this.ghost4velocity = 2;
      this.life();
      this.prec1 = 0;
      this.prec2 = 0;
      this.prec3 = 0;
      this.prec4 = 0;
      this.startdirection = 1;
      this.dir1 = false;
      this.dir2 = false;
      this.dir3 = false;
      this.dir4 = false;
      this.c = false;
      this.next = 0;
      this.temp = 1;
      this.direzione = 0;
      this.pacman.Left = 24;
      this.pacman.Top = 364;
      this.ghost1.Left = 176;
      this.ghost1.Top = 150;
      this.ghost2.Left = 154;
      this.ghost2.Top = 185;
      this.ghost3.Left = 176;
      this.ghost3.Top = 185;
      this.ghost4.Left = 199;
      this.ghost4.Top = 185;
      this.leftghost1 = 0;
      this.leftghost2 = 0;
      this.leftghost3 = 0;
      this.leftghost4 = 0;
      this.topghost1 = 0;
      this.topghost2 = 0;
      this.topghost3 = 0;
      this.topghost4 = 0;
      this.left = 0;
      this.top = 0;
      this.pacman.Image = (Image) Resources._1dx;
      this.ghost1.Image = (Image) Resources.rup;
      this.ghost2.Image = (Image) Resources.aup;
      this.ghost3.Image = (Image) Resources.vup;
      this.ghost4.Image = (Image) Resources.gup;
      this.timer1.Enabled = false;
      this.timer4.Enabled = false;
      this.timer5.Enabled = false;
      this.timer6.Enabled = false;
      this.timer7.Enabled = false;
      this.timer8.Enabled = false;
      this.powermod.Enabled = false;
      this.powermod1.Enabled = false;
      if (this.start)
      {
        this.timer2.Enabled = true;
        this.timer3.Enabled = true;
      }
      this.start = false;
      for (int index = 0; index < 332; ++index)
        ((Control) this.oggetti[index]).Visible = true;
    }

    private void timer7_Tick(object sender, EventArgs e)
    {
      this.timer7.Enabled = false;
      this.panel1.Visible = true;
      this.attendo.Enabled = true;
    }

    private void attendo_Tick(object sender, EventArgs e)
    {
      this.resetall();
      this.attendo.Enabled = false;
    }

    private void control()
    {
      if (this.ghost2.Top != 185)
        return;
      this.timer3.Enabled = false;
      this.timer4.Enabled = true;
      this.c = false;
      this.timer5.Enabled = true;
    }

    private void life()
    {
      if (this.vita == 3)
      {
        this.pictureBox1.Visible = true;
        this.pictureBox2.Visible = true;
      }
      if (this.vita == 2)
      {
        this.pictureBox1.Visible = true;
        this.pictureBox2.Visible = false;
      }
      if (this.vita != 1)
        return;
      this.pictureBox1.Visible = false;
      this.pictureBox2.Visible = false;
    }

    private void supermod()
    {
      if (this.pacman.Bounds.IntersectsWith(this.label173.Bounds) && this.label173.Visible)
        this.supermod2();
      Rectangle bounds = this.pacman.Bounds;
      if (bounds.IntersectsWith(this.label307.Bounds) && this.label307.Visible)
        this.supermod2();
      bounds = this.pacman.Bounds;
      if (bounds.IntersectsWith(this.label220.Bounds) && this.label220.Visible)
        this.supermod2();
      bounds = this.pacman.Bounds;
      if (!bounds.IntersectsWith(this.label71.Bounds) || !this.label71.Visible)
        return;
      this.supermod2();
    }

    private void supermod2()
    {
      if (!this.g1mangiato)
      {
        this.v1 = false;
        this.ghost1velocity = 2;
        this.Supermod1 = true;
        this.ghost1.Image = (Image) Resources.crazy;
        this.ghost1puomangiare = true;
      }
      if (!this.g2mangiato)
      {
        this.v2 = false;
        this.ghost2velocity = 2;
        this.Supermod2 = true;
        this.ghost2.Image = (Image) Resources.crazy;
        this.ghost2puomangiare = true;
      }
      if (!this.g3mangiato)
      {
        this.v3 = false;
        this.ghost3velocity = 2;
        this.Supermod3 = true;
        this.ghost3.Image = (Image) Resources.crazy;
        this.ghost3puomangiare = true;
      }
      if (!this.g4mangiato)
      {
        this.v4 = false;
        this.ghost4velocity = 2;
        this.Supermod4 = true;
        this.ghost4.Image = (Image) Resources.crazy;
        this.ghost4puomangiare = true;
      }
      this.powermod.Enabled = false;
      this.powermod1.Enabled = false;
      this.powermod1.Enabled = true;
      this.tresec = false;
      this.powermod.Enabled = true;
      this.Supermod = true;
    }

    private void powermod1_Tick(object sender, EventArgs e)
    {
      this.tresec = true;
      this.powermod1.Enabled = false;
    }

    private void collision()
    {
      Rectangle bounds;
      int num;
      if (!this.pacman.Bounds.IntersectsWith(this.ghost1.Bounds))
      {
        bounds = this.pacman.Bounds;
        if (!bounds.IntersectsWith(this.ghost2.Bounds))
        {
          bounds = this.pacman.Bounds;
          if (!bounds.IntersectsWith(this.ghost3.Bounds))
          {
            bounds = this.pacman.Bounds;
            num = bounds.IntersectsWith(this.ghost4.Bounds) ? 1 : 0;
            goto label_5;
          }
        }
      }
      num = 1;
label_5:
      if (num == 0)
        return;
      bounds = this.pacman.Bounds;
      if (bounds.IntersectsWith(this.ghost1.Bounds) && !this.Supermod1)
        this.mangiato();
      bounds = this.pacman.Bounds;
      if (bounds.IntersectsWith(this.ghost2.Bounds) && !this.Supermod2)
        this.mangiato();
      bounds = this.pacman.Bounds;
      if (bounds.IntersectsWith(this.ghost3.Bounds) && !this.Supermod3)
        this.mangiato();
      bounds = this.pacman.Bounds;
      if (bounds.IntersectsWith(this.ghost4.Bounds) && !this.Supermod4)
        this.mangiato();
      if (this.Supermod)
      {
        bounds = this.pacman.Bounds;
        if (bounds.IntersectsWith(this.ghost1.Bounds) && !this.Supermod1)
          this.mangiato();
        bounds = this.pacman.Bounds;
        if (bounds.IntersectsWith(this.ghost2.Bounds) && !this.Supermod2)
          this.mangiato();
        bounds = this.pacman.Bounds;
        if (bounds.IntersectsWith(this.ghost3.Bounds) && !this.Supermod3)
          this.mangiato();
        bounds = this.pacman.Bounds;
        if (bounds.IntersectsWith(this.ghost4.Bounds) && !this.Supermod4)
          this.mangiato();
      }
      bounds = this.pacman.Bounds;
      if (bounds.IntersectsWith(this.ghost1.Bounds) && this.ghost1puomangiare && this.Supermod1)
      {
        this.g1mangiato = true;
        this.v1 = true;
        this.ghost1puomangiare = false;
        this.timer1.Enabled = false;
        this.ghostmangiato.Enabled = true;
        this.ghost1velocity = 4;
      }
      bounds = this.pacman.Bounds;
      if (bounds.IntersectsWith(this.ghost2.Bounds) && this.ghost2puomangiare && this.Supermod2)
      {
        this.g2mangiato = true;
        this.v2 = true;
        this.ghost2puomangiare = false;
        this.timer1.Enabled = false;
        this.ghostmangiato.Enabled = true;
        this.ghost2velocity = 4;
      }
      bounds = this.pacman.Bounds;
      if (bounds.IntersectsWith(this.ghost3.Bounds) && this.ghost3puomangiare && this.Supermod3)
      {
        this.g3mangiato = true;
        this.v3 = true;
        this.ghost3puomangiare = false;
        this.timer1.Enabled = false;
        this.ghostmangiato.Enabled = true;
        this.ghost3velocity = 4;
      }
      bounds = this.pacman.Bounds;
      if (bounds.IntersectsWith(this.ghost4.Bounds) && this.ghost4puomangiare && this.Supermod4)
      {
        this.g4mangiato = true;
        this.v4 = true;
        this.ghost4puomangiare = false;
        this.timer1.Enabled = false;
        this.ghostmangiato.Enabled = true;
        this.ghost4velocity = 4;
      }
    }

    private void ghostmangiato_Tick(object sender, EventArgs e)
    {
      this.timer1.Enabled = true;
      this.ghostmangiato.Enabled = false;
    }

    private void mangiato()
    {
      this.pacman.Image = (Image) Resources.pacmorto;
      if (this.vita - 1 <= 0)
      {
        this.label124.Visible = true;
        this.finepartita();
      }
      else
      {
        this.top = 0;
        this.left = 0;
        this.topghost1 = 0;
        this.topghost2 = 0;
        this.topghost3 = 0;
        this.topghost4 = 0;
        this.leftghost1 = 0;
        this.leftghost2 = 0;
        this.leftghost3 = 0;
        this.leftghost4 = 0;
        this.timer1.Enabled = false;
        this.timer4.Enabled = false;
        this.timer5.Enabled = false;
        this.timer6.Enabled = false;
        this.pacturn = false;
        this.ghost1turn = false;
        this.ghost2turn = false;
        this.ghost3turn = false;
        this.ghost4turn = false;
        this.timer8.Enabled = true;
      }
    }

    private void points()
    {
      for (int index = 0; index < 332; ++index)
      {
        if (((Control) this.oggetti[index]).Visible && this.pacman.Bounds.IntersectsWith(((Control) this.oggetti[index]).Bounds))
        {
          ++this.point;
          ((Control) this.oggetti[index]).Visible = false;
        }
      }
      this.score.Text = this.point.ToString();
      if (this.point < 332)
        return;
      this.finepartita();
      this.label141.Visible = true;
    }

    private void finepartita()
    {
      this.point = 0;
      this.vita = 3;
      this.timer1.Enabled = false;
      this.timer2.Enabled = false;
      this.timer3.Enabled = false;
      this.timer4.Enabled = false;
      this.timer5.Enabled = false;
      this.timer6.Enabled = false;
      this.powermod1.Enabled = false;
      this.powermod.Enabled = false;
      this.timer7.Enabled = true;
    }

    private void freedirection()
    {
      switch (this.direzione)
      {
        case 1:
          if (this.next != 2)
            break;
          this.left = 2;
          this.pacman.Image = (Image) Resources.pacdx;
          this.direzione = this.next;
          this.temp = this.next;
          break;
        case 2:
          if (this.next != 1)
            break;
          this.left = -2;
          this.pacman.Image = (Image) Resources.pacsx;
          this.direzione = this.next;
          this.temp = this.next;
          break;
        case 3:
          if (this.next != 4)
            break;
          this.top = 2;
          this.pacman.Image = (Image) Resources.pacdown;
          this.direzione = this.next;
          this.temp = this.next;
          break;
        case 4:
          if (this.next != 3)
            break;
          this.top = -2;
          this.pacman.Image = (Image) Resources.pacup;
          this.direzione = this.next;
          this.temp = this.next;
          break;
      }
    }

    private void leftright(int i, int y, int n, int m)
    {
      if (this.ghost1turn)
      {
        if (this.Supermod1 && !this.ghost1puomangiare)
        {
          if (this.ghost1.Left < 180 && this.ghost1.Top == 150 || this.ghost1.Left > 170 && this.ghost1.Top == 150)
          {
            this.ghost1velocity = 2;
            this.Supermod1 = false;
            this.v1 = false;
            this.ghost1puomangiare = true;
            this.g1mangiato = false;
          }
          else
          {
            if (this.ghost1.Top < 150 && (n == 1 && m == 1))
              n = 0;
            if (this.ghost1.Top > 150 && (n == 1 && m == 1))
              m = 0;
            if (this.ghost1.Left < 176 && (i == 1 && y == 1))
              i = 0;
            if (this.ghost1.Left > 176 && (i == 1 && y == 1))
              y = 0;
          }
        }
        this.topghost1 = 0;
        this.leftghost1 = 0;
        while (!this.dir1)
        {
          this.random1 = this.rand.Next(1, 5);
          if (this.random1 == 1 && !this.dir1 && this.random1 != this.prec1 && i == 1)
          {
            this.leftghost1 = -this.ghost1velocity;
            this.dir1 = true;
            if (!this.Supermod1 && this.ghost1puomangiare)
              this.ghost1.Image = (Image) Resources.rsx;
            else if (!this.tresec || this.g1mangiato)
            {
              if (!this.tresec)
                this.ghost1.Image = (Image) Resources.crazy;
              if (this.g1mangiato)
                this.ghost1.Image = (Image) Resources.msx;
            }
            else
              this.ghost1.Image = (Image) Resources.tempo;
          }
          if (this.random1 == 2 && !this.dir1 && this.random1 != this.prec1 && y == 1)
          {
            this.leftghost1 = this.ghost1velocity;
            this.dir1 = true;
            if (!this.Supermod1 && this.ghost1puomangiare)
              this.ghost1.Image = (Image) Resources.rdx;
            else if (!this.tresec || this.g1mangiato)
            {
              if (!this.tresec)
                this.ghost1.Image = (Image) Resources.crazy;
              if (this.g1mangiato)
                this.ghost1.Image = (Image) Resources.mdx;
            }
            else
              this.ghost1.Image = (Image) Resources.tempo;
          }
          if (this.random1 == 3 && !this.dir1 && this.random1 != this.prec1 && m == 1)
          {
            this.topghost1 = this.ghost1velocity;
            this.dir1 = true;
            if (!this.Supermod1 && this.ghost1puomangiare)
              this.ghost1.Image = (Image) Resources.rdown;
            else if (!this.tresec || this.g1mangiato)
            {
              if (!this.tresec)
                this.ghost1.Image = (Image) Resources.crazy;
              if (this.g1mangiato)
                this.ghost1.Image = (Image) Resources.mdown;
            }
            else
              this.ghost1.Image = (Image) Resources.tempo;
          }
          if (this.random1 == 4 && !this.dir1 && this.random1 != this.prec1 && n == 1)
          {
            this.topghost1 = -this.ghost1velocity;
            this.dir1 = true;
            if (!this.Supermod1 && this.ghost1puomangiare)
              this.ghost1.Image = (Image) Resources.rup;
            else if (!this.tresec || this.g1mangiato)
            {
              if (!this.tresec)
                this.ghost1.Image = (Image) Resources.crazy;
              if (this.g1mangiato)
                this.ghost1.Image = (Image) Resources.mup1;
            }
            else
              this.ghost1.Image = (Image) Resources.tempo;
          }
        }
        if (this.random1 == 1)
          this.prec1 = 2;
        if (this.random1 == 2)
          this.prec1 = 1;
        if (this.random1 == 3)
          this.prec1 = 4;
        if (this.random1 == 4)
          this.prec1 = 3;
        this.dir1 = false;
      }
      if (this.ghost2turn)
      {
        if (this.Supermod2 && !this.ghost2puomangiare)
        {
          if (this.ghost2.Left < 180 && this.ghost2.Top == 150 || this.ghost2.Left > 170 && this.ghost2.Top == 150)
          {
            this.ghost2velocity = 2;
            this.Supermod2 = false;
            this.v2 = false;
            this.ghost2puomangiare = true;
            this.g2mangiato = false;
          }
          else
          {
            if (this.ghost2.Top < 150 && (n == 1 && m == 1))
              n = 0;
            if (this.ghost2.Top > 150 && (n == 1 && m == 1))
              m = 0;
            if (this.ghost2.Left < 176 && (i == 1 && y == 1))
              i = 0;
            if (this.ghost2.Left > 176 && (i == 1 && y == 1))
              y = 0;
          }
        }
        this.topghost2 = 0;
        this.leftghost2 = 0;
        while (!this.dir2)
        {
          this.random2 = this.rand.Next(1, 5);
          if (this.random2 == 1 && !this.dir2 && this.random2 != this.prec2 && i == 1)
          {
            this.leftghost2 = -this.ghost2velocity;
            this.dir2 = true;
            if (!this.Supermod2 && this.ghost2puomangiare)
              this.ghost2.Image = (Image) Resources.asx;
            else if (!this.tresec || this.g2mangiato)
            {
              if (!this.tresec)
                this.ghost2.Image = (Image) Resources.crazy;
              if (this.g2mangiato)
                this.ghost2.Image = (Image) Resources.msx;
            }
            else
              this.ghost2.Image = (Image) Resources.tempo;
          }
          if (this.random2 == 2 && !this.dir2 && this.random2 != this.prec2 && y == 1)
          {
            this.leftghost2 = this.ghost2velocity;
            this.dir2 = true;
            if (!this.Supermod2 && this.ghost2puomangiare)
              this.ghost2.Image = (Image) Resources.adx;
            else if (!this.tresec || this.g2mangiato)
            {
              if (!this.tresec)
                this.ghost2.Image = (Image) Resources.crazy;
              if (this.g2mangiato)
                this.ghost2.Image = (Image) Resources.mdx;
            }
            else
              this.ghost2.Image = (Image) Resources.tempo;
          }
          if (this.random2 == 3 && !this.dir2 && this.random2 != this.prec2 && m == 1)
          {
            this.topghost2 = this.ghost2velocity;
            this.dir2 = true;
            if (!this.Supermod2 && this.ghost2puomangiare)
              this.ghost2.Image = (Image) Resources.adown;
            else if (!this.tresec || this.g2mangiato)
            {
              if (!this.tresec)
                this.ghost2.Image = (Image) Resources.crazy;
              if (this.g2mangiato)
                this.ghost2.Image = (Image) Resources.mdown;
            }
            else
              this.ghost2.Image = (Image) Resources.tempo;
          }
          if (this.random2 == 4 && !this.dir2 && this.random2 != this.prec2 && n == 1)
          {
            this.topghost2 = -this.ghost2velocity;
            this.dir2 = true;
            if (!this.Supermod2 && this.ghost2puomangiare)
              this.ghost2.Image = (Image) Resources.aup;
            else if (!this.tresec || this.g2mangiato)
            {
              if (!this.tresec)
                this.ghost2.Image = (Image) Resources.crazy;
              if (this.g2mangiato)
                this.ghost2.Image = (Image) Resources.mup1;
            }
            else
              this.ghost2.Image = (Image) Resources.tempo;
          }
        }
        if (this.random2 == 1)
          this.prec2 = 2;
        if (this.random2 == 2)
          this.prec2 = 1;
        if (this.random2 == 3)
          this.prec2 = 4;
        if (this.random2 == 4)
          this.prec2 = 3;
        this.dir2 = false;
      }
      if (this.ghost3turn)
      {
        if (this.Supermod3 && !this.ghost3puomangiare)
        {
          if (this.ghost3.Left < 180 && this.ghost3.Top == 150 || this.ghost3.Left > 170 && this.ghost3.Top == 150)
          {
            this.ghost3velocity = 2;
            this.Supermod3 = false;
            this.v3 = false;
            this.ghost3puomangiare = true;
            this.g3mangiato = false;
          }
          else
          {
            if (this.ghost3.Top > 150 && (n == 1 && m == 1))
              m = 0;
            if (this.ghost3.Top < 150 && (n == 1 && m == 1))
              n = 0;
            if (this.ghost3.Left < 176 && (i == 1 && y == 1))
              i = 0;
            if (this.ghost3.Left > 176 && (i == 1 && y == 1))
              y = 0;
          }
        }
        this.topghost3 = 0;
        this.leftghost3 = 0;
        while (!this.dir3)
        {
          this.random3 = this.rand.Next(1, 5);
          if (this.random3 == 1 && !this.dir3 && this.random3 != this.prec3 && i == 1)
          {
            this.leftghost3 = -this.ghost3velocity;
            this.dir3 = true;
            if (!this.Supermod3 && this.ghost3puomangiare)
              this.ghost3.Image = (Image) Resources.vsx;
            else if (!this.tresec || this.g3mangiato)
            {
              if (!this.tresec)
                this.ghost3.Image = (Image) Resources.crazy;
              if (this.g3mangiato)
                this.ghost3.Image = (Image) Resources.msx;
            }
            else
              this.ghost3.Image = (Image) Resources.tempo;
          }
          if (this.random3 == 2 && !this.dir3 && this.random3 != this.prec3 && y == 1)
          {
            this.leftghost3 = this.ghost3velocity;
            this.dir3 = true;
            if (!this.Supermod3 && this.ghost3puomangiare)
              this.ghost3.Image = (Image) Resources.vdx;
            else if (!this.tresec || this.g3mangiato)
            {
              if (!this.tresec)
                this.ghost3.Image = (Image) Resources.crazy;
              if (this.g3mangiato)
                this.ghost3.Image = (Image) Resources.mdx;
            }
            else
              this.ghost3.Image = (Image) Resources.tempo;
          }
          if (this.random3 == 3 && !this.dir3 && this.random3 != this.prec3 && m == 1)
          {
            this.topghost3 = this.ghost3velocity;
            this.dir3 = true;
            if (!this.Supermod3 && this.ghost3puomangiare)
              this.ghost3.Image = (Image) Resources.vdown;
            else if (!this.tresec || this.g3mangiato)
            {
              if (!this.tresec)
                this.ghost3.Image = (Image) Resources.crazy;
              if (this.g3mangiato)
                this.ghost3.Image = (Image) Resources.mdown;
            }
            else
              this.ghost3.Image = (Image) Resources.tempo;
          }
          if (this.random3 == 4 && !this.dir3 && this.random3 != this.prec3 && n == 1)
          {
            this.topghost3 = -this.ghost3velocity;
            this.dir3 = true;
            if (!this.Supermod3 && this.ghost3puomangiare)
              this.ghost3.Image = (Image) Resources.vup;
            else if (!this.tresec || this.g3mangiato)
            {
              if (!this.tresec)
                this.ghost3.Image = (Image) Resources.crazy;
              if (this.g3mangiato)
                this.ghost3.Image = (Image) Resources.mup1;
            }
            else
              this.ghost3.Image = (Image) Resources.tempo;
          }
        }
        if (this.random3 == 1)
          this.prec3 = 2;
        if (this.random3 == 2)
          this.prec3 = 1;
        if (this.random3 == 3)
          this.prec3 = 4;
        if (this.random3 == 4)
          this.prec3 = 3;
        this.dir3 = false;
      }
      if (this.ghost4turn)
      {
        if (this.Supermod4 && !this.ghost4puomangiare)
        {
          if (this.ghost4.Left < 180 && this.ghost4.Top == 150 || this.ghost4.Left > 170 && this.ghost4.Top == 150)
          {
            this.ghost4velocity = 2;
            this.Supermod4 = false;
            this.v4 = false;
            this.ghost4puomangiare = true;
            this.g4mangiato = false;
          }
          else
          {
            if (this.ghost4.Top > 150 && (n == 1 && m == 1))
              m = 0;
            if (this.ghost4.Top < 150 && (n == 1 && m == 1))
              n = 0;
            if (this.ghost4.Left < 176 && (i == 1 && y == 1))
              i = 0;
            if (this.ghost4.Left > 176 && (i == 1 && y == 1))
              y = 0;
          }
        }
        this.topghost4 = 0;
        this.leftghost4 = 0;
        while (!this.dir4)
        {
          this.random4 = this.rand.Next(1, 5);
          if (this.random4 == 1 && !this.dir4 && this.random4 != this.prec4 && i == 1)
          {
            this.leftghost4 = -this.ghost4velocity;
            this.dir4 = true;
            if (!this.Supermod4 && this.ghost4puomangiare)
              this.ghost4.Image = (Image) Resources.gsx;
            else if (!this.tresec || this.g4mangiato)
            {
              if (!this.tresec)
                this.ghost4.Image = (Image) Resources.crazy;
              if (this.g4mangiato)
                this.ghost4.Image = (Image) Resources.msx;
            }
            else
              this.ghost4.Image = (Image) Resources.tempo;
          }
          if (this.random4 == 2 && !this.dir4 && this.random4 != this.prec4 && y == 1)
          {
            this.leftghost4 = this.ghost4velocity;
            this.dir4 = true;
            if (!this.Supermod4 && this.ghost4puomangiare)
              this.ghost4.Image = (Image) Resources.gdx;
            else if (!this.tresec || this.g4mangiato)
            {
              if (!this.tresec)
                this.ghost4.Image = (Image) Resources.crazy;
              if (this.g4mangiato)
                this.ghost4.Image = (Image) Resources.mdx;
            }
            else
              this.ghost4.Image = (Image) Resources.tempo;
          }
          if (this.random4 == 3 && !this.dir4 && this.random4 != this.prec4 && m == 1)
          {
            this.topghost4 = this.ghost4velocity;
            this.dir4 = true;
            if (!this.Supermod4 && this.ghost4puomangiare)
              this.ghost4.Image = (Image) Resources.gdown;
            else if (!this.tresec || this.g4mangiato)
            {
              if (!this.tresec)
                this.ghost4.Image = (Image) Resources.crazy;
              if (this.g4mangiato)
                this.ghost4.Image = (Image) Resources.mdown;
            }
            else
              this.ghost4.Image = (Image) Resources.tempo;
          }
          if (this.random4 == 4 && !this.dir4 && this.random4 != this.prec4 && n == 1)
          {
            this.topghost4 = -this.ghost4velocity;
            this.dir4 = true;
            if (!this.Supermod4 && this.ghost4puomangiare)
              this.ghost4.Image = (Image) Resources.gup;
            else if (!this.tresec || this.g4mangiato)
            {
              if (!this.tresec)
                this.ghost4.Image = (Image) Resources.crazy;
              if (this.g4mangiato)
                this.ghost4.Image = (Image) Resources.mup1;
            }
            else
              this.ghost4.Image = (Image) Resources.tempo;
          }
        }
        if (this.random4 == 1)
          this.prec4 = 2;
        if (this.random4 == 2)
          this.prec4 = 1;
        if (this.random4 == 3)
          this.prec4 = 4;
        if (this.random4 == 4)
          this.prec4 = 3;
        this.dir4 = false;
      }
      if (!this.pacturn)
        return;
      this.top = 0;
      this.left = 0;
      if (this.temp == 1 && i == 1 || this.temp == 2 && y == 1 || this.temp == 3 && n == 1 || this.temp == 4 && m == 1)
        this.next = this.temp;
      if (this.next == 1 && i == 1)
      {
        this.left = -2;
        this.pacman.Image = (Image) Resources.pacsx;
        this.direzione = this.next;
      }
      if (this.next == 2 && y == 1)
      {
        this.left = 2;
        this.pacman.Image = (Image) Resources.pacdx;
        this.direzione = this.next;
      }
      if (this.next == 3 && n == 1)
      {
        this.top = -2;
        this.pacman.Image = (Image) Resources.pacup;
        this.direzione = this.next;
      }
      if (this.next == 4 && m == 1)
      {
        this.top = 2;
        this.pacman.Image = (Image) Resources.pacdown;
        this.direzione = this.next;
      }
      if (this.top == 0 && this.left == 0)
      {
        this.temp = this.next;
        this.next = this.direzione;
        if (this.next == 1)
          this.pacman.Image = (Image) Resources._1sx;
        if (this.next == 2)
          this.pacman.Image = (Image) Resources._1dx;
        if (this.next == 3)
          this.pacman.Image = (Image) Resources._1up;
        if (this.next == 4)
          this.pacman.Image = (Image) Resources._1down;
      }
    }

    private void direction()
    {
      this.pacturn = true;
      this.a(this.pacman.Left, this.pacman.Top);
      this.pacman.Left += this.left;
      this.pacman.Top += this.top;
    }

    private void a(int left, int top)
    {
      if (this.pacturn)
      {
        switch (left)
        {
          case -26:
            if (top == 184)
            {
              this.transport(1, 0);
              break;
            }
            break;
          case 24:
            switch (top)
            {
              case 28:
                this.leftright(0, 1, 0, 1);
                break;
              case 76:
                this.leftright(0, 1, 1, 1);
                break;
              case 112:
                this.leftright(0, 1, 1, 0);
                break;
              case 256:
                this.leftright(0, 1, 0, 1);
                break;
              case 292:
                this.leftright(0, 1, 1, 0);
                break;
              case 328:
                this.leftright(0, 1, 0, 1);
                break;
              case 364:
                this.leftright(0, 1, 1, 0);
                break;
            }
					break;
          case 48:
            switch (top)
            {
              case 292:
                this.leftright(1, 0, 0, 1);
                break;
              case 328:
                this.leftright(1, 1, 1, 0);
                break;
            }
					break;
				case 84:
            switch (top)
            {
              case 28:
                this.leftright(1, 1, 0, 1);
                break;
              case 76:
                this.leftright(1, 1, 1, 1);
                break;
              case 112:
                this.leftright(1, 0, 1, 1);
                break;
              case 184:
                this.leftright(1, 1, 1, 1);
                break;
              case 256:
                this.leftright(1, 1, 1, 1);
                break;
              case 292:
                this.leftright(0, 1, 1, 1);
                break;
              case 328:
                this.leftright(1, 0, 1, 0);
                break;
            }
					break;
				case 120:
            switch (top)
            {
              case 76:
                this.leftright(1, 1, 0, 1);
                break;
              case 112:
                this.leftright(0, 1, 1, 0);
                break;
              case 148:
                this.leftright(0, 1, 0, 1);
                break;
              case 184:
                this.leftright(1, 0, 1, 1);
                break;
              case 220:
                this.leftright(0, 1, 1, 1);
                break;
              case 256:
                this.leftright(1, 1, 1, 0);
                break;
              case 292:
                this.leftright(1, 1, 0, 1);
                break;
              case 328:
                this.leftright(0, 1, 1, 0);
                break;
            }
					break;
				case 156:
            switch (top)
            {
              case 28:
                this.leftright(1, 0, 0, 1);
                break;
              case 76:
                this.leftright(1, 1, 1, 0);
                break;
              case 112:
                this.leftright(1, 0, 0, 1);
                break;
              case 148:
                this.leftright(1, 1, 1, 0);
                break;
              case 256:
                this.leftright(1, 0, 0, 1);
                break;
              case 292:
                this.leftright(1, 1, 1, 0);
                break;
              case 328:
                this.leftright(1, 0, 0, 1);
                break;
              case 364:
                this.leftright(1, 1, 1, 0);
                break;
            }
					break;
				case 174:
            if (top == 148)
            {
              this.leftright(1, 1, 0, 0);
              break;
            }
            break;
          case 192:
            switch (top)
            {
              case 28:
                this.leftright(0, 1, 0, 1);
                break;
              case 76:
                this.leftright(1, 1, 1, 0);
                break;
              case 112:
                this.leftright(0, 1, 0, 1);
                break;
              case 148:
                this.leftright(1, 1, 1, 0);
                break;
              case 256:
                this.leftright(0, 1, 0, 1);
                break;
              case 292:
                this.leftright(1, 1, 1, 0);
                break;
              case 328:
                this.leftright(0, 1, 0, 1);
                break;
              case 364:
                this.leftright(1, 1, 1, 0);
                break;
            }
					break;
				case 228:
            switch (top)
            {
              case 76:
                this.leftright(1, 1, 0, 1);
                break;
              case 112:
                this.leftright(1, 0, 1, 0);
                break;
              case 148:
                this.leftright(1, 0, 0, 1);
                break;
              case 184:
                this.leftright(0, 1, 1, 1);
                break;
              case 220:
                this.leftright(1, 0, 1, 1);
                break;
              case 256:
                this.leftright(1, 1, 1, 0);
                break;
              case 292:
                this.leftright(1, 1, 0, 1);
                break;
              case 328:
                this.leftright(1, 0, 1, 0);
                break;
            }
					break;
				case 264:
            switch (top)
            {
              case 28:
                this.leftright(1, 1, 0, 1);
                break;
              case 76:
                this.leftright(1, 1, 1, 1);
                break;
              case 112:
                this.leftright(0, 1, 1, 1);
                break;
              case 184:
                this.leftright(1, 1, 1, 1);
                break;
              case 256:
                this.leftright(1, 1, 1, 1);
                break;
              case 292:
                this.leftright(1, 0, 1, 1);
                break;
              case 328:
                this.leftright(0, 1, 1, 0);
                break;
            }
					break;
				case 300:
            switch (top)
            {
              case 292:
                this.leftright(0, 1, 0, 1);
                break;
              case 328:
                this.leftright(1, 1, 1, 0);
                break;
            }

					break;
				case 324:
            switch (top)
            {
              case 28:
                this.leftright(1, 0, 0, 1);
                break;
              case 76:
                this.leftright(1, 0, 1, 1);
                break;
              case 112:
                this.leftright(1, 0, 1, 0);
                break;
              case 256:
                this.leftright(1, 0, 0, 1);
                break;
              case 292:
                this.leftright(1, 0, 1, 0);
                break;
              case 328:
                this.leftright(1, 0, 0, 1);
                break;
              case 364:
                this.leftright(1, 0, 1, 0);
                break;
            }
					break;
				case 374:
            if (top == 184)
            {
              this.transport(0, 1);
              break;
            }
            break;
        }
      }
      else
      {
        switch (left)
        {
          case -28:
            if (top == 186)
            {
              this.transport(1, 0);
              break;
            }
            break;
          case 26:
            switch (top)
            {
              case 30:
                this.leftright(0, 1, 0, 1);
                break;
              case 78:
                this.leftright(0, 1, 1, 1);
                break;
              case 114:
                this.leftright(0, 1, 1, 0);
                break;
              case 258:
                this.leftright(0, 1, 0, 1);
                break;
              case 294:
                this.leftright(0, 1, 1, 0);
                break;
              case 330:
                this.leftright(0, 1, 0, 1);
                break;
              case 366:
                this.leftright(0, 1, 1, 0);
                break;
            }
					break;
				case 50:
            if (top == 330)
            {
              this.leftright(1, 1, 1, 0);
              break;
            }
            if (top == 294)
            {
              this.leftright(1, 0, 0, 1);
              break;
            }
            break;
          case 86:
            switch (top)
            {
              case 30:
                this.leftright(1, 1, 0, 1);
                break;
              case 78:
                this.leftright(1, 1, 1, 1);
                break;
              case 114:
                this.leftright(1, 0, 1, 1);
                break;
              case 186:
                this.leftright(1, 1, 1, 1);
                break;
              case 258:
                this.leftright(1, 1, 1, 1);
                break;
              case 294:
                this.leftright(0, 1, 1, 1);
                break;
              case 330:
                this.leftright(1, 0, 1, 0);
                break;
            }
					break;
				case 122:
            switch (top)
            {
              case 78:
                this.leftright(1, 1, 0, 1);
                break;
              case 114:
                this.leftright(0, 1, 1, 0);
                break;
              case 150:
                this.leftright(0, 1, 0, 1);
                break;
              case 186:
                this.leftright(1, 0, 1, 1);
                break;
              case 222:
                this.leftright(0, 1, 1, 1);
                break;
              case 258:
                this.leftright(1, 1, 1, 0);
                break;
              case 294:
                this.leftright(1, 1, 0, 1);
                break;
              case 330:
                this.leftright(0, 1, 1, 0);
                break;
            }
					break;
				case 158:
            switch (top)
            {
              case 30:
                this.leftright(1, 0, 0, 1);
                break;
              case 78:
                this.leftright(1, 1, 1, 0);
                break;
              case 114:
                this.leftright(1, 0, 0, 1);
                break;
              case 150:
                this.leftright(1, 1, 1, 0);
                break;
              case 258:
                this.leftright(1, 0, 0, 1);
                break;
              case 294:
                this.leftright(1, 1, 1, 0);
                break;
              case 330:
                this.leftright(1, 0, 0, 1);
                break;
              case 366:
                this.leftright(1, 1, 1, 0);
                break;
            }
					break;
				case 176:
            if (top == 150)
            {
              this.leftright(1, 1, 0, 0);
              break;
            }
            break;
          case 194:
            switch (top)
            {
              case 30:
                this.leftright(0, 1, 0, 1);
                break;
              case 78:
                this.leftright(1, 1, 1, 0);
                break;
              case 114:
                this.leftright(0, 1, 0, 1);
                break;
              case 150:
                this.leftright(1, 1, 1, 0);
                break;
              case 258:
                this.leftright(0, 1, 0, 1);
                break;
              case 294:
                this.leftright(1, 1, 1, 0);
                break;
              case 330:
                this.leftright(0, 1, 0, 1);
                break;
              case 366:
                this.leftright(1, 1, 1, 0);
                break;
            }
					break;
				case 230:
            switch (top)
            {
              case 78:
                this.leftright(1, 1, 0, 1);
                break;
              case 114:
                this.leftright(1, 0, 1, 0);
                break;
              case 150:
                this.leftright(1, 0, 0, 1);
                break;
              case 186:
                this.leftright(0, 1, 1, 1);
                break;
              case 222:
                this.leftright(1, 0, 1, 1);
                break;
              case 258:
                this.leftright(1, 1, 1, 0);
                break;
              case 294:
                this.leftright(1, 1, 0, 1);
                break;
              case 330:
                this.leftright(1, 0, 1, 0);
                break;
            }
					break;
				case 266:
            switch (top)
            {
              case 30:
                this.leftright(1, 1, 0, 1);
                break;
              case 78:
                this.leftright(1, 1, 1, 1);
                break;
              case 114:
                this.leftright(0, 1, 1, 1);
                break;
              case 186:
                this.leftright(1, 1, 1, 1);
                break;
              case 258:
                this.leftright(1, 1, 1, 1);
                break;
              case 294:
                this.leftright(1, 0, 1, 1);
                break;
              case 330:
                this.leftright(0, 1, 1, 0);
                break;
            }
					break;
				case 302:
            if (top == 294)
            {
              this.leftright(0, 1, 0, 1);
              break;
            }
            if (top == 330)
            {
              this.leftright(1, 1, 1, 0);
              break;
            }
            break;
          case 326:
            switch (top)
            {
              case 30:
                this.leftright(1, 0, 0, 1);
                break;
              case 78:
                this.leftright(1, 0, 1, 1);
                break;
              case 114:
                this.leftright(1, 0, 1, 0);
                break;
              case 258:
                this.leftright(1, 0, 0, 1);
                break;
              case 294:
                this.leftright(1, 0, 1, 0);
                break;
              case 330:
                this.leftright(1, 0, 0, 1);
                break;
              case 366:
                this.leftright(1, 0, 1, 0);
                break;
            }
					break;
				case 376:
            if (top == 186)
            {
              this.transport(0, 1);
              break;
            }
            break;
        }
      }
      this.pacturn = false;
      this.ghost1turn = false;
      this.ghost2turn = false;
      this.ghost3turn = false;
      this.ghost4turn = false;
    }

    private void transport(int i, int n)
    {
      if (this.pacturn)
      {
        if (i == 0)
          this.pacman.Left = -26;
        if (n == 0)
          this.pacman.Left = 374;
      }
      if (this.ghost1turn)
      {
        if (i == 0)
          this.ghost1.Left = -26;
        if (n == 0)
          this.ghost1.Left = 374;
      }
      if (this.ghost2turn)
      {
        if (i == 0)
          this.ghost2.Left = -26;
        if (n == 0)
          this.ghost2.Left = 374;
      }
      if (this.ghost3turn)
      {
        if (i == 0)
          this.ghost3.Left = -26;
        if (n == 0)
          this.ghost3.Left = 374;
      }
      if (!this.ghost4turn)
        return;
      if (i == 0)
        this.ghost4.Left = -26;
      if (n == 0)
        this.ghost4.Left = 374;
    }

    private void ghost()
    {
      if (this.ghost1.Enabled)
      {
        this.ghost1.Left += this.leftghost1;
        this.ghost1.Top += this.topghost1;
        this.ghost1turn = true;
        this.a(this.ghost1.Left, this.ghost1.Top);
      }
      if (this.ghost2.Enabled)
      {
        this.ghost2.Left += this.leftghost2;
        this.ghost2.Top += this.topghost2;
        this.ghost2turn = true;
        this.a(this.ghost2.Left, this.ghost2.Top);
      }
      if (this.ghost3.Enabled)
      {
        this.ghost3.Left += this.leftghost3;
        this.ghost3.Top += this.topghost3;
        this.ghost3turn = true;
        this.a(this.ghost3.Left, this.ghost3.Top);
      }
      if (!this.ghost4.Enabled)
        return;
      this.ghost4.Left += this.leftghost4;
      this.ghost4.Top += this.topghost4;
      this.ghost4turn = true;
      this.a(this.ghost4.Left, this.ghost4.Top);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.timer1 = new Timer(this.components);
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.timer2 = new Timer(this.components);
      this.timer3 = new Timer(this.components);
      this.timer4 = new Timer(this.components);
      this.timer5 = new Timer(this.components);
      this.timer6 = new Timer(this.components);
      this.pictureBox2 = new PictureBox();
      this.pictureBox1 = new PictureBox();
      this.ghost3 = new Label();
      this.ghost4 = new Label();
      this.ghost2 = new Label();
      this.ghost1 = new Label();
      this.label4 = new Label();
      this.label5 = new Label();
      this.label6 = new Label();
      this.label7 = new Label();
      this.label8 = new Label();
      this.label9 = new Label();
      this.label10 = new Label();
      this.label11 = new Label();
      this.label12 = new Label();
      this.label13 = new Label();
      this.label14 = new Label();
      this.label15 = new Label();
      this.label16 = new Label();
      this.label17 = new Label();
      this.label18 = new Label();
      this.label19 = new Label();
      this.label20 = new Label();
      this.label21 = new Label();
      this.label22 = new Label();
      this.label23 = new Label();
      this.label24 = new Label();
      this.label25 = new Label();
      this.label26 = new Label();
      this.label27 = new Label();
      this.label28 = new Label();
      this.label29 = new Label();
      this.label30 = new Label();
      this.label31 = new Label();
      this.score = new Label();
      this.label43 = new Label();
      this.label44 = new Label();
      this.label32 = new Label();
      this.label45 = new Label();
      this.label46 = new Label();
      this.label47 = new Label();
      this.label49 = new Label();
      this.label50 = new Label();
      this.label33 = new Label();
      this.label34 = new Label();
      this.label35 = new Label();
      this.label36 = new Label();
      this.label37 = new Label();
      this.label38 = new Label();
      this.label39 = new Label();
      this.label40 = new Label();
      this.label41 = new Label();
      this.label42 = new Label();
      this.label48 = new Label();
      this.label51 = new Label();
      this.label52 = new Label();
      this.label53 = new Label();
      this.label54 = new Label();
      this.label55 = new Label();
      this.label56 = new Label();
      this.label57 = new Label();
      this.label58 = new Label();
      this.label59 = new Label();
      this.label60 = new Label();
      this.label61 = new Label();
      this.label62 = new Label();
      this.label63 = new Label();
      this.label64 = new Label();
      this.label65 = new Label();
      this.label66 = new Label();
      this.label67 = new Label();
      this.label68 = new Label();
      this.label69 = new Label();
      this.label70 = new Label();
      this.label71 = new Label();
      this.label72 = new Label();
      this.label73 = new Label();
      this.label74 = new Label();
      this.label76 = new Label();
      this.label77 = new Label();
      this.label78 = new Label();
      this.label79 = new Label();
      this.label80 = new Label();
      this.label81 = new Label();
      this.label82 = new Label();
      this.label83 = new Label();
      this.label75 = new Label();
      this.label84 = new Label();
      this.label85 = new Label();
      this.label86 = new Label();
      this.label87 = new Label();
      this.label88 = new Label();
      this.label89 = new Label();
      this.label90 = new Label();
      this.label91 = new Label();
      this.label92 = new Label();
      this.label94 = new Label();
      this.label93 = new Label();
      this.label95 = new Label();
      this.label96 = new Label();
      this.label98 = new Label();
      this.label97 = new Label();
      this.label99 = new Label();
      this.label100 = new Label();
      this.label101 = new Label();
      this.label102 = new Label();
      this.label103 = new Label();
      this.label104 = new Label();
      this.label105 = new Label();
      this.label106 = new Label();
      this.label107 = new Label();
      this.label108 = new Label();
      this.label109 = new Label();
      this.label110 = new Label();
      this.label111 = new Label();
      this.label112 = new Label();
      this.label113 = new Label();
      this.label114 = new Label();
      this.label115 = new Label();
      this.label116 = new Label();
      this.label117 = new Label();
      this.label118 = new Label();
      this.label119 = new Label();
      this.label120 = new Label();
      this.label121 = new Label();
      this.label122 = new Label();
      this.label123 = new Label();
      this.label125 = new Label();
      this.label126 = new Label();
      this.label127 = new Label();
      this.label128 = new Label();
      this.label129 = new Label();
      this.label130 = new Label();
      this.label131 = new Label();
      this.label132 = new Label();
      this.label133 = new Label();
      this.label134 = new Label();
      this.label135 = new Label();
      this.label136 = new Label();
      this.label137 = new Label();
      this.label138 = new Label();
      this.label139 = new Label();
      this.label140 = new Label();
      this.label143 = new Label();
      this.label144 = new Label();
      this.label145 = new Label();
      this.label146 = new Label();
      this.label147 = new Label();
      this.label148 = new Label();
      this.label149 = new Label();
      this.label150 = new Label();
      this.label151 = new Label();
      this.label152 = new Label();
      this.label153 = new Label();
      this.label154 = new Label();
      this.label155 = new Label();
      this.label156 = new Label();
      this.label157 = new Label();
      this.label158 = new Label();
      this.label159 = new Label();
      this.label160 = new Label();
      this.label161 = new Label();
      this.label162 = new Label();
      this.label163 = new Label();
      this.label164 = new Label();
      this.label165 = new Label();
      this.label166 = new Label();
      this.label167 = new Label();
      this.label168 = new Label();
      this.label169 = new Label();
      this.label170 = new Label();
      this.label171 = new Label();
      this.label172 = new Label();
      this.label173 = new Label();
      this.label174 = new Label();
      this.label175 = new Label();
      this.label176 = new Label();
      this.label177 = new Label();
      this.label178 = new Label();
      this.label179 = new Label();
      this.label180 = new Label();
      this.label181 = new Label();
      this.label182 = new Label();
      this.label183 = new Label();
      this.label184 = new Label();
      this.label185 = new Label();
      this.label186 = new Label();
      this.label187 = new Label();
      this.label188 = new Label();
      this.label189 = new Label();
      this.label190 = new Label();
      this.label191 = new Label();
      this.label192 = new Label();
      this.label193 = new Label();
      this.label194 = new Label();
      this.label195 = new Label();
      this.label196 = new Label();
      this.label199 = new Label();
      this.label198 = new Label();
      this.label200 = new Label();
      this.label201 = new Label();
      this.label202 = new Label();
      this.label203 = new Label();
      this.label204 = new Label();
      this.label205 = new Label();
      this.label206 = new Label();
      this.label207 = new Label();
      this.label208 = new Label();
      this.label209 = new Label();
      this.label210 = new Label();
      this.label211 = new Label();
      this.label212 = new Label();
      this.label213 = new Label();
      this.label214 = new Label();
      this.label197 = new Label();
      this.label215 = new Label();
      this.label216 = new Label();
      this.label217 = new Label();
      this.label218 = new Label();
      this.label219 = new Label();
      this.label220 = new Label();
      this.label221 = new Label();
      this.label222 = new Label();
      this.label223 = new Label();
      this.label224 = new Label();
      this.label225 = new Label();
      this.label226 = new Label();
      this.label227 = new Label();
      this.label228 = new Label();
      this.label229 = new Label();
      this.label230 = new Label();
      this.label231 = new Label();
      this.label232 = new Label();
      this.label233 = new Label();
      this.label234 = new Label();
      this.label235 = new Label();
      this.label236 = new Label();
      this.label237 = new Label();
      this.label238 = new Label();
      this.label239 = new Label();
      this.label240 = new Label();
      this.label241 = new Label();
      this.label242 = new Label();
      this.label243 = new Label();
      this.label244 = new Label();
      this.label245 = new Label();
      this.label246 = new Label();
      this.label247 = new Label();
      this.label248 = new Label();
      this.label249 = new Label();
      this.label250 = new Label();
      this.label251 = new Label();
      this.label252 = new Label();
      this.label256 = new Label();
      this.label257 = new Label();
      this.label258 = new Label();
      this.label259 = new Label();
      this.label260 = new Label();
      this.label261 = new Label();
      this.label262 = new Label();
      this.label263 = new Label();
      this.label264 = new Label();
      this.label265 = new Label();
      this.label272 = new Label();
      this.label273 = new Label();
      this.label274 = new Label();
      this.label280 = new Label();
      this.label281 = new Label();
      this.label282 = new Label();
      this.label283 = new Label();
      this.label284 = new Label();
      this.label266 = new Label();
      this.label267 = new Label();
      this.label268 = new Label();
      this.label269 = new Label();
      this.label270 = new Label();
      this.label271 = new Label();
      this.label275 = new Label();
      this.label276 = new Label();
      this.label277 = new Label();
      this.label278 = new Label();
      this.label279 = new Label();
      this.label285 = new Label();
      this.label286 = new Label();
      this.label287 = new Label();
      this.label288 = new Label();
      this.label289 = new Label();
      this.label290 = new Label();
      this.label293 = new Label();
      this.label294 = new Label();
      this.label295 = new Label();
      this.label296 = new Label();
      this.label297 = new Label();
      this.label298 = new Label();
      this.label299 = new Label();
      this.label300 = new Label();
      this.label301 = new Label();
      this.label302 = new Label();
      this.label291 = new Label();
      this.label292 = new Label();
      this.label303 = new Label();
      this.label304 = new Label();
      this.label305 = new Label();
      this.label306 = new Label();
      this.label307 = new Label();
      this.label308 = new Label();
      this.label309 = new Label();
      this.label310 = new Label();
      this.label311 = new Label();
      this.label312 = new Label();
      this.label313 = new Label();
      this.label314 = new Label();
      this.label315 = new Label();
      this.label316 = new Label();
      this.label317 = new Label();
      this.label318 = new Label();
      this.label319 = new Label();
      this.label320 = new Label();
      this.label321 = new Label();
      this.label322 = new Label();
      this.label323 = new Label();
      this.label324 = new Label();
      this.label325 = new Label();
      this.label327 = new Label();
      this.label326 = new Label();
      this.label328 = new Label();
      this.label329 = new Label();
      this.label330 = new Label();
      this.label331 = new Label();
      this.label332 = new Label();
      this.label333 = new Label();
      this.label334 = new Label();
      this.label335 = new Label();
      this.label336 = new Label();
      this.label337 = new Label();
      this.label338 = new Label();
      this.label339 = new Label();
      this.label340 = new Label();
      this.label341 = new Label();
      this.timer8 = new Timer(this.components);
      this.panel1 = new Panel();
      this.pictureBox5 = new PictureBox();
      this.pictureBox4 = new PictureBox();
      this.pictureBox3 = new PictureBox();
      this.button1 = new Button();
      this.pacman = new PictureBox();
      this.powermod = new Timer(this.components);
      this.timer7 = new Timer(this.components);
      this.timer9 = new Timer(this.components);
      this.ghostmangiato = new Timer(this.components);
      this.label124 = new Label();
      this.label141 = new Label();
      this.powermod1 = new Timer(this.components);
      this.attendo = new Timer(this.components);
      this.label254 = new Label();
      this.label255 = new Label();
      this.label253 = new Label();
      this.label142 = new Label();
      ((ISupportInitialize) this.pictureBox2).BeginInit();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.panel1.SuspendLayout();
      ((ISupportInitialize) this.pictureBox5).BeginInit();
      ((ISupportInitialize) this.pictureBox4).BeginInit();
      ((ISupportInitialize) this.pictureBox3).BeginInit();
      ((ISupportInitialize) this.pacman).BeginInit();
      this.SuspendLayout();
      this.timer1.Interval = 16;
      this.timer1.Tick += new EventHandler(this.timer1_Tick);
      this.label1.BackColor = Color.Black;
      this.label1.Font = new Font("Segoe UI Black", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.White;
      this.label1.Image = (Image) Resources.score;
      this.label1.Location = new Point(16, 400);
      this.label1.Name = "label1";
      this.label1.Size = new Size(84, 30);
      this.label1.TabIndex = 129;
      this.label2.BackColor = Color.Black;
      this.label2.Font = new Font("Segoe UI Black", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = Color.White;
      this.label2.Image = (Image) Resources.lives;
      this.label2.Location = new Point(226, 399);
      this.label2.Name = "label2";
      this.label2.Size = new Size(69, 30);
      this.label2.TabIndex = 130;
      this.label3.BackColor = Color.Black;
      this.label3.Font = new Font("Segoe UI Black", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label3.ForeColor = Color.White;
      this.label3.Image = (Image) Resources.getready;
      this.label3.Location = new Point(123, 222);
      this.label3.Name = "label3";
      this.label3.Size = new Size(125, 19);
      this.label3.TabIndex = 133;
      this.label3.Text = "          ";
      this.label3.TextAlign = ContentAlignment.MiddleRight;
      this.timer2.Interval = 3000;
      this.timer2.Tick += new EventHandler(this.timer2_Tick);
      this.timer3.Interval = 1;
      this.timer3.Tick += new EventHandler(this.timer3_Tick);
      this.timer4.Interval = 1;
      this.timer4.Tick += new EventHandler(this.timer4_Tick);
      this.timer5.Interval = 1;
      this.timer5.Tick += new EventHandler(this.timer5_Tick);
      this.timer6.Interval = 1;
      this.timer6.Tick += new EventHandler(this.timer6_Tick);
      this.pictureBox2.BackgroundImageLayout = ImageLayout.Center;
      this.pictureBox2.Image = (Image) Resources._1sx;
      this.pictureBox2.Location = new Point(318, 402);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new Size(22, 22);
      this.pictureBox2.TabIndex = 132;
      this.pictureBox2.TabStop = false;
      this.pictureBox1.BackgroundImageLayout = ImageLayout.Center;
      this.pictureBox1.Image = (Image) Resources._1sx;
      this.pictureBox1.Location = new Point(297, 402);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(22, 22);
      this.pictureBox1.TabIndex = 131;
      this.pictureBox1.TabStop = false;
      this.ghost3.BackColor = Color.Transparent;
      this.ghost3.Cursor = Cursors.Default;
      this.ghost3.ForeColor = Color.Transparent;
      this.ghost3.Image = (Image) Resources.vup;
      this.ghost3.Location = new Point(176, 185);
      this.ghost3.Margin = new Padding(0);
      this.ghost3.Name = "ghost3";
      this.ghost3.Size = new Size(18, 18);
      this.ghost3.TabIndex = (int) sbyte.MaxValue;
      this.ghost4.BackColor = Color.Transparent;
      this.ghost4.Cursor = Cursors.Default;
      this.ghost4.ForeColor = Color.Transparent;
      this.ghost4.Image = (Image) Resources.gup;
      this.ghost4.Location = new Point(199, 185);
      this.ghost4.Margin = new Padding(0);
      this.ghost4.Name = "ghost4";
      this.ghost4.Size = new Size(18, 18);
      this.ghost4.TabIndex = 126;
      this.ghost2.BackColor = Color.Transparent;
      this.ghost2.Cursor = Cursors.Default;
      this.ghost2.ForeColor = Color.Transparent;
      this.ghost2.Image = (Image) Resources.aup;
      this.ghost2.Location = new Point(154, 185);
      this.ghost2.Margin = new Padding(0);
      this.ghost2.Name = "ghost2";
      this.ghost2.Size = new Size(18, 18);
      this.ghost2.TabIndex = 125;
      this.ghost1.BackColor = Color.Transparent;
      this.ghost1.Cursor = Cursors.Default;
      this.ghost1.ForeColor = Color.Transparent;
      this.ghost1.Image = (Image) Resources.rup;
      this.ghost1.Location = new Point(176, 150);
      this.ghost1.Margin = new Padding(0);
      this.ghost1.Name = "ghost1";
      this.ghost1.Size = new Size(18, 18);
      this.ghost1.TabIndex = 124;
      this.label4.BackColor = Color.White;
      this.label4.Location = new Point(102, 266);
      this.label4.Name = "label4";
      this.label4.Size = new Size(2, 2);
      this.label4.TabIndex = 134;
      this.label5.BackColor = Color.White;
      this.label5.Location = new Point(111, 266);
      this.label5.Name = "label5";
      this.label5.Size = new Size(2, 2);
      this.label5.TabIndex = 135;
      this.label6.BackColor = Color.White;
      this.label6.Location = new Point(129, 266);
      this.label6.Name = "label6";
      this.label6.Size = new Size(2, 2);
      this.label6.TabIndex = 137;
      this.label7.BackColor = Color.White;
      this.label7.Location = new Point(120, 266);
      this.label7.Name = "label7";
      this.label7.Size = new Size(2, 2);
      this.label7.TabIndex = 136;
      this.label8.BackColor = Color.White;
      this.label8.Location = new Point(165, 266);
      this.label8.Name = "label8";
      this.label8.Size = new Size(2, 2);
      this.label8.TabIndex = 141;
      this.label9.BackColor = Color.White;
      this.label9.Location = new Point(156, 266);
      this.label9.Name = "label9";
      this.label9.Size = new Size(2, 2);
      this.label9.TabIndex = 140;
      this.label10.BackColor = Color.White;
      this.label10.Location = new Point(147, 266);
      this.label10.Name = "label10";
      this.label10.Size = new Size(2, 2);
      this.label10.TabIndex = 139;
      this.label11.BackColor = Color.White;
      this.label11.Location = new Point(138, 266);
      this.label11.Name = "label11";
      this.label11.Size = new Size(2, 2);
      this.label11.TabIndex = 138;
      this.label12.BackColor = Color.White;
      this.label12.Location = new Point(94, 266);
      this.label12.Name = "label12";
      this.label12.Size = new Size(2, 2);
      this.label12.TabIndex = 149;
      this.label13.BackColor = Color.White;
      this.label13.Location = new Point(78, 266);
      this.label13.Name = "label13";
      this.label13.Size = new Size(2, 2);
      this.label13.TabIndex = 148;
      this.label14.BackColor = Color.White;
      this.label14.Location = new Point(69, 266);
      this.label14.Name = "label14";
      this.label14.Size = new Size(2, 2);
      this.label14.TabIndex = 147;
      this.label15.BackColor = Color.White;
      this.label15.Location = new Point(60, 266);
      this.label15.Name = "label15";
      this.label15.Size = new Size(2, 2);
      this.label15.TabIndex = 146;
      this.label16.BackColor = Color.White;
      this.label16.Location = new Point(52, 266);
      this.label16.Name = "label16";
      this.label16.Size = new Size(2, 2);
      this.label16.TabIndex = 145;
      this.label17.BackColor = Color.White;
      this.label17.Location = new Point(43, 266);
      this.label17.Name = "label17";
      this.label17.Size = new Size(2, 2);
      this.label17.TabIndex = 144;
      this.label18.BackColor = Color.White;
      this.label18.Location = new Point(247, 266);
      this.label18.Name = "label18";
      this.label18.Size = new Size(2, 2);
      this.label18.TabIndex = 163;
      this.label19.BackColor = Color.White;
      this.label19.Location = new Point(238, 266);
      this.label19.Name = "label19";
      this.label19.Size = new Size(2, 2);
      this.label19.TabIndex = 162;
      this.label20.BackColor = Color.White;
      this.label20.Location = new Point(229, 266);
      this.label20.Name = "label20";
      this.label20.Size = new Size(2, 2);
      this.label20.TabIndex = 161;
      this.label21.BackColor = Color.White;
      this.label21.Location = new Point(220, 266);
      this.label21.Name = "label21";
      this.label21.Size = new Size(2, 2);
      this.label21.TabIndex = 160;
      this.label22.BackColor = Color.White;
      this.label22.Location = new Point(211, 266);
      this.label22.Name = "label22";
      this.label22.Size = new Size(2, 2);
      this.label22.TabIndex = 159;
      this.label23.BackColor = Color.White;
      this.label23.Location = new Point(202, 266);
      this.label23.Name = "label23";
      this.label23.Size = new Size(2, 2);
      this.label23.TabIndex = 158;
      this.label24.BackColor = Color.White;
      this.label24.Location = new Point(318, 266);
      this.label24.Name = "label24";
      this.label24.Size = new Size(2, 2);
      this.label24.TabIndex = 157;
      this.label25.BackColor = Color.White;
      this.label25.Location = new Point(310, 266);
      this.label25.Name = "label25";
      this.label25.Size = new Size(2, 2);
      this.label25.TabIndex = 156;
      this.label26.BackColor = Color.White;
      this.label26.Location = new Point(301, 266);
      this.label26.Name = "label26";
      this.label26.Size = new Size(2, 2);
      this.label26.TabIndex = 155;
      this.label27.BackColor = Color.White;
      this.label27.Location = new Point(292, 266);
      this.label27.Name = "label27";
      this.label27.Size = new Size(2, 2);
      this.label27.TabIndex = 154;
      this.label28.BackColor = Color.White;
      this.label28.Location = new Point(283, 266);
      this.label28.Name = "label28";
      this.label28.Size = new Size(2, 2);
      this.label28.TabIndex = 153;
      this.label29.BackColor = Color.White;
      this.label29.Location = new Point(274, 266);
      this.label29.Name = "label29";
      this.label29.Size = new Size(2, 2);
      this.label29.TabIndex = 152;
      this.label30.BackColor = Color.White;
      this.label30.Location = new Point(265, 266);
      this.label30.Name = "label30";
      this.label30.Size = new Size(2, 2);
      this.label30.TabIndex = 151;
      this.label31.BackColor = Color.White;
      this.label31.Location = new Point(256, 266);
      this.label31.Name = "label31";
      this.label31.Size = new Size(2, 2);
      this.label31.TabIndex = 150;
      this.score.AutoSize = true;
      this.score.Font = new Font("Segoe UI Black", 15f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.score.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 51);
      this.score.Location = new Point(93, 399);
      this.score.Name = "score";
      this.score.Size = new Size(24, 28);
      this.score.TabIndex = 164;
      this.score.Text = "0";
      this.label43.BackColor = Color.White;
      this.label43.Location = new Point(165, 284);
      this.label43.Name = "label43";
      this.label43.Size = new Size(2, 2);
      this.label43.TabIndex = 180;
      this.label44.BackColor = Color.White;
      this.label44.Location = new Point(165, 293);
      this.label44.Name = "label44";
      this.label44.Size = new Size(2, 2);
      this.label44.TabIndex = 181;
      this.label32.BackColor = Color.White;
      this.label32.Location = new Point(165, 275);
      this.label32.Name = "label32";
      this.label32.Size = new Size(2, 2);
      this.label32.TabIndex = 179;
      this.label45.BackColor = Color.White;
      this.label45.Location = new Point(202, 293);
      this.label45.Name = "label45";
      this.label45.Size = new Size(2, 2);
      this.label45.TabIndex = 185;
      this.label46.BackColor = Color.White;
      this.label46.Location = new Point(202, 284);
      this.label46.Name = "label46";
      this.label46.Size = new Size(2, 2);
      this.label46.TabIndex = 184;
      this.label47.BackColor = Color.White;
      this.label47.Location = new Point(202, 275);
      this.label47.Name = "label47";
      this.label47.Size = new Size(2, 2);
      this.label47.TabIndex = 183;
      this.label49.BackColor = Color.White;
      this.label49.Location = new Point(326, 266);
      this.label49.Name = "label49";
      this.label49.Size = new Size(2, 2);
      this.label49.TabIndex = 186;
      this.label50.BackColor = Color.White;
      this.label50.Location = new Point(35, 266);
      this.label50.Name = "label50";
      this.label50.Size = new Size(2, 2);
      this.label50.TabIndex = 187;
      this.label33.BackColor = Color.White;
      this.label33.Location = new Point(94, 302);
      this.label33.Name = "label33";
      this.label33.Size = new Size(2, 2);
      this.label33.TabIndex = 196;
      this.label34.BackColor = Color.White;
      this.label34.Location = new Point(165, 302);
      this.label34.Name = "label34";
      this.label34.Size = new Size(2, 2);
      this.label34.TabIndex = 195;
      this.label35.BackColor = Color.White;
      this.label35.Location = new Point(156, 302);
      this.label35.Name = "label35";
      this.label35.Size = new Size(2, 2);
      this.label35.TabIndex = 194;
      this.label36.BackColor = Color.White;
      this.label36.Location = new Point(147, 302);
      this.label36.Name = "label36";
      this.label36.Size = new Size(2, 2);
      this.label36.TabIndex = 193;
      this.label37.BackColor = Color.White;
      this.label37.Location = new Point(138, 302);
      this.label37.Name = "label37";
      this.label37.Size = new Size(2, 2);
      this.label37.TabIndex = 192;
      this.label38.BackColor = Color.White;
      this.label38.Location = new Point(129, 302);
      this.label38.Name = "label38";
      this.label38.Size = new Size(2, 2);
      this.label38.TabIndex = 191;
      this.label39.BackColor = Color.White;
      this.label39.Location = new Point(120, 302);
      this.label39.Name = "label39";
      this.label39.Size = new Size(2, 2);
      this.label39.TabIndex = 190;
      this.label40.BackColor = Color.White;
      this.label40.Location = new Point(111, 302);
      this.label40.Name = "label40";
      this.label40.Size = new Size(2, 2);
      this.label40.TabIndex = 189;
      this.label41.BackColor = Color.White;
      this.label41.Location = new Point(102, 302);
      this.label41.Name = "label41";
      this.label41.Size = new Size(2, 2);
      this.label41.TabIndex = 188;
      this.label42.BackColor = Color.White;
      this.label42.Location = new Point(202, 302);
      this.label42.Name = "label42";
      this.label42.Size = new Size(2, 2);
      this.label42.TabIndex = 205;
      this.label48.BackColor = Color.White;
      this.label48.Location = new Point(274, 302);
      this.label48.Name = "label48";
      this.label48.Size = new Size(2, 2);
      this.label48.TabIndex = 204;
      this.label51.BackColor = Color.White;
      this.label51.Location = new Point(265, 302);
      this.label51.Name = "label51";
      this.label51.Size = new Size(2, 2);
      this.label51.TabIndex = 203;
      this.label52.BackColor = Color.White;
      this.label52.Location = new Point(256, 302);
      this.label52.Name = "label52";
      this.label52.Size = new Size(2, 2);
      this.label52.TabIndex = 202;
      this.label53.BackColor = Color.White;
      this.label53.Location = new Point(247, 302);
      this.label53.Name = "label53";
      this.label53.Size = new Size(2, 2);
      this.label53.TabIndex = 201;
      this.label54.BackColor = Color.White;
      this.label54.Location = new Point(238, 302);
      this.label54.Name = "label54";
      this.label54.Size = new Size(2, 2);
      this.label54.TabIndex = 200;
      this.label55.BackColor = Color.White;
      this.label55.Location = new Point(229, 302);
      this.label55.Name = "label55";
      this.label55.Size = new Size(2, 2);
      this.label55.TabIndex = 199;
      this.label56.BackColor = Color.White;
      this.label56.Location = new Point(220, 302);
      this.label56.Name = "label56";
      this.label56.Size = new Size(2, 2);
      this.label56.TabIndex = 198;
      this.label57.BackColor = Color.White;
      this.label57.Location = new Point(211, 302);
      this.label57.Name = "label57";
      this.label57.Size = new Size(2, 2);
      this.label57.TabIndex = 197;
      this.label58.BackColor = Color.White;
      this.label58.Location = new Point(94, 293);
      this.label58.Name = "label58";
      this.label58.Size = new Size(2, 2);
      this.label58.TabIndex = 208;
      this.label59.BackColor = Color.White;
      this.label59.Location = new Point(94, 284);
      this.label59.Name = "label59";
      this.label59.Size = new Size(2, 2);
      this.label59.TabIndex = 207;
      this.label60.BackColor = Color.White;
      this.label60.Location = new Point(94, 275);
      this.label60.Name = "label60";
      this.label60.Size = new Size(2, 2);
      this.label60.TabIndex = 206;
      this.label61.BackColor = Color.White;
      this.label61.Location = new Point(274, 293);
      this.label61.Name = "label61";
      this.label61.Size = new Size(2, 2);
      this.label61.TabIndex = 211;
      this.label62.BackColor = Color.White;
      this.label62.Location = new Point(274, 284);
      this.label62.Name = "label62";
      this.label62.Size = new Size(2, 2);
      this.label62.TabIndex = 210;
      this.label63.BackColor = Color.White;
      this.label63.Location = new Point(274, 275);
      this.label63.Name = "label63";
      this.label63.Size = new Size(2, 2);
      this.label63.TabIndex = 209;
      this.label64.BackColor = Color.White;
      this.label64.Location = new Point(183, 302);
      this.label64.Name = "label64";
      this.label64.Size = new Size(2, 2);
      this.label64.TabIndex = 213;
      this.label65.BackColor = Color.White;
      this.label65.Location = new Point(174, 302);
      this.label65.Name = "label65";
      this.label65.Size = new Size(2, 2);
      this.label65.TabIndex = 212;
      this.label66.BackColor = Color.White;
      this.label66.Location = new Point(192, 302);
      this.label66.Name = "label66";
      this.label66.Size = new Size(2, 2);
      this.label66.TabIndex = 214;
      this.label67.BackColor = Color.White;
      this.label67.Location = new Point(334, 293);
      this.label67.Name = "label67";
      this.label67.Size = new Size(2, 2);
      this.label67.TabIndex = 217;
      this.label68.BackColor = Color.White;
      this.label68.Location = new Point(334, 284);
      this.label68.Name = "label68";
      this.label68.Size = new Size(2, 2);
      this.label68.TabIndex = 216;
      this.label69.BackColor = Color.White;
      this.label69.Location = new Point(334, 275);
      this.label69.Name = "label69";
      this.label69.Size = new Size(2, 2);
      this.label69.TabIndex = 215;
      this.label70.BackColor = Color.White;
      this.label70.Location = new Point(334, 266);
      this.label70.Name = "label70";
      this.label70.Size = new Size(2, 2);
      this.label70.TabIndex = 218;
      this.label71.BackColor = Color.Black;
      this.label71.Image = (Image) componentResourceManager.GetObject("label71.Image");
      this.label71.Location = new Point(330, 298);
      this.label71.Name = "label71";
      this.label71.Size = new Size(10, 10);
      this.label71.TabIndex = 222;
      this.label72.BackColor = Color.White;
      this.label72.Location = new Point(326, 302);
      this.label72.Name = "label72";
      this.label72.Size = new Size(2, 2);
      this.label72.TabIndex = 221;
      this.label73.BackColor = Color.White;
      this.label73.Location = new Point(318, 302);
      this.label73.Name = "label73";
      this.label73.Size = new Size(2, 2);
      this.label73.TabIndex = 220;
      this.label74.BackColor = Color.White;
      this.label74.Location = new Point(310, 302);
      this.label74.Name = "label74";
      this.label74.Size = new Size(2, 2);
      this.label74.TabIndex = 219;
      this.label76.BackColor = Color.White;
      this.label76.Location = new Point(310, 311);
      this.label76.Name = "label76";
      this.label76.Size = new Size(2, 2);
      this.label76.TabIndex = 226;
      this.label77.BackColor = Color.White;
      this.label77.Location = new Point(310, 338);
      this.label77.Name = "label77";
      this.label77.Size = new Size(2, 2);
      this.label77.TabIndex = 225;
      this.label78.BackColor = Color.White;
      this.label78.Location = new Point(310, 329);
      this.label78.Name = "label78";
      this.label78.Size = new Size(2, 2);
      this.label78.TabIndex = 224;
      this.label79.BackColor = Color.White;
      this.label79.Location = new Point(310, 320);
      this.label79.Name = "label79";
      this.label79.Size = new Size(2, 2);
      this.label79.TabIndex = 223;
      this.label80.BackColor = Color.White;
      this.label80.Location = new Point(301, 338);
      this.label80.Name = "label80";
      this.label80.Size = new Size(2, 2);
      this.label80.TabIndex = 230;
      this.label81.BackColor = Color.White;
      this.label81.Location = new Point(292, 338);
      this.label81.Name = "label81";
      this.label81.Size = new Size(2, 2);
      this.label81.TabIndex = 229;
      this.label82.BackColor = Color.White;
      this.label82.Location = new Point(283, 338);
      this.label82.Name = "label82";
      this.label82.Size = new Size(2, 2);
      this.label82.TabIndex = 228;
      this.label83.BackColor = Color.White;
      this.label83.Location = new Point(274, 338);
      this.label83.Name = "label83";
      this.label83.Size = new Size(2, 2);
      this.label83.TabIndex = 227;
      this.label75.BackColor = Color.White;
      this.label75.Location = new Point(274, 311);
      this.label75.Name = "label75";
      this.label75.Size = new Size(2, 2);
      this.label75.TabIndex = 233;
      this.label84.BackColor = Color.White;
      this.label84.Location = new Point(274, 329);
      this.label84.Name = "label84";
      this.label84.Size = new Size(2, 2);
      this.label84.TabIndex = 232;
      this.label85.BackColor = Color.White;
      this.label85.Location = new Point(274, 320);
      this.label85.Name = "label85";
      this.label85.Size = new Size(2, 2);
      this.label85.TabIndex = 231;
      this.label86.BackColor = Color.White;
      this.label86.Location = new Point(238, 311);
      this.label86.Name = "label86";
      this.label86.Size = new Size(2, 2);
      this.label86.TabIndex = 237;
      this.label87.BackColor = Color.White;
      this.label87.Location = new Point(238, 329);
      this.label87.Name = "label87";
      this.label87.Size = new Size(2, 2);
      this.label87.TabIndex = 236;
      this.label88.BackColor = Color.White;
      this.label88.Location = new Point(238, 320);
      this.label88.Name = "label88";
      this.label88.Size = new Size(2, 2);
      this.label88.TabIndex = 235;
      this.label89.BackColor = Color.White;
      this.label89.Location = new Point(238, 338);
      this.label89.Name = "label89";
      this.label89.Size = new Size(2, 2);
      this.label89.TabIndex = 234;
      this.label90.BackColor = Color.White;
      this.label90.Location = new Point(220, 338);
      this.label90.Name = "label90";
      this.label90.Size = new Size(2, 2);
      this.label90.TabIndex = 242;
      this.label91.BackColor = Color.White;
      this.label91.Location = new Point(211, 338);
      this.label91.Name = "label91";
      this.label91.Size = new Size(2, 2);
      this.label91.TabIndex = 241;
      this.label92.BackColor = Color.White;
      this.label92.Location = new Point(202, 338);
      this.label92.Name = "label92";
      this.label92.Size = new Size(2, 2);
      this.label92.TabIndex = 240;
      this.label94.BackColor = Color.White;
      this.label94.Location = new Point(229, 338);
      this.label94.Name = "label94";
      this.label94.Size = new Size(2, 2);
      this.label94.TabIndex = 238;
      this.label93.BackColor = Color.White;
      this.label93.Location = new Point(202, 356);
      this.label93.Name = "label93";
      this.label93.Size = new Size(2, 2);
      this.label93.TabIndex = 247;
      this.label95.BackColor = Color.White;
      this.label95.Location = new Point(202, 374);
      this.label95.Name = "label95";
      this.label95.Size = new Size(2, 2);
      this.label95.TabIndex = 246;
      this.label96.BackColor = Color.White;
      this.label96.Location = new Point(202, 365);
      this.label96.Name = "label96";
      this.label96.Size = new Size(2, 2);
      this.label96.TabIndex = 245;
      this.label98.BackColor = Color.White;
      this.label98.Location = new Point(202, 347);
      this.label98.Name = "label98";
      this.label98.Size = new Size(2, 2);
      this.label98.TabIndex = 243;
      this.label97.BackColor = Color.White;
      this.label97.Location = new Point(334, 356);
      this.label97.Name = "label97";
      this.label97.Size = new Size(2, 2);
      this.label97.TabIndex = 252;
      this.label99.BackColor = Color.White;
      this.label99.Location = new Point(334, 374);
      this.label99.Name = "label99";
      this.label99.Size = new Size(2, 2);
      this.label99.TabIndex = 251;
      this.label100.BackColor = Color.White;
      this.label100.Location = new Point(334, 365);
      this.label100.Name = "label100";
      this.label100.Size = new Size(2, 2);
      this.label100.TabIndex = 250;
      this.label101.BackColor = Color.White;
      this.label101.Location = new Point(334, 347);
      this.label101.Name = "label101";
      this.label101.Size = new Size(2, 2);
      this.label101.TabIndex = 249;
      this.label102.BackColor = Color.White;
      this.label102.Location = new Point(334, 338);
      this.label102.Name = "label102";
      this.label102.Size = new Size(2, 2);
      this.label102.TabIndex = 248;
      this.label103.BackColor = Color.White;
      this.label103.Location = new Point(326, 338);
      this.label103.Name = "label103";
      this.label103.Size = new Size(2, 2);
      this.label103.TabIndex = 254;
      this.label104.BackColor = Color.White;
      this.label104.Location = new Point(318, 338);
      this.label104.Name = "label104";
      this.label104.Size = new Size(2, 2);
      this.label104.TabIndex = 253;
      this.label105.BackColor = Color.White;
      this.label105.Location = new Point(326, 374);
      this.label105.Name = "label105";
      this.label105.Size = new Size(2, 2);
      this.label105.TabIndex = 268;
      this.label106.BackColor = Color.White;
      this.label106.Location = new Point(247, 374);
      this.label106.Name = "label106";
      this.label106.Size = new Size(2, 2);
      this.label106.TabIndex = 267;
      this.label107.BackColor = Color.White;
      this.label107.Location = new Point(238, 374);
      this.label107.Name = "label107";
      this.label107.Size = new Size(2, 2);
      this.label107.TabIndex = 266;
      this.label108.BackColor = Color.White;
      this.label108.Location = new Point(229, 374);
      this.label108.Name = "label108";
      this.label108.Size = new Size(2, 2);
      this.label108.TabIndex = 265;
      this.label109.BackColor = Color.White;
      this.label109.Location = new Point(220, 374);
      this.label109.Name = "label109";
      this.label109.Size = new Size(2, 2);
      this.label109.TabIndex = 264;
      this.label110.BackColor = Color.White;
      this.label110.Location = new Point(211, 374);
      this.label110.Name = "label110";
      this.label110.Size = new Size(2, 2);
      this.label110.TabIndex = 263;
      this.label111.BackColor = Color.White;
      this.label111.Location = new Point(318, 374);
      this.label111.Name = "label111";
      this.label111.Size = new Size(2, 2);
      this.label111.TabIndex = 262;
      this.label112.BackColor = Color.White;
      this.label112.Location = new Point(310, 374);
      this.label112.Name = "label112";
      this.label112.Size = new Size(2, 2);
      this.label112.TabIndex = 261;
      this.label113.BackColor = Color.White;
      this.label113.Location = new Point(301, 374);
      this.label113.Name = "label113";
      this.label113.Size = new Size(2, 2);
      this.label113.TabIndex = 260;
      this.label114.BackColor = Color.White;
      this.label114.Location = new Point(292, 374);
      this.label114.Name = "label114";
      this.label114.Size = new Size(2, 2);
      this.label114.TabIndex = 259;
      this.label115.BackColor = Color.White;
      this.label115.Location = new Point(283, 374);
      this.label115.Name = "label115";
      this.label115.Size = new Size(2, 2);
      this.label115.TabIndex = 258;
      this.label116.BackColor = Color.White;
      this.label116.Location = new Point(274, 374);
      this.label116.Name = "label116";
      this.label116.Size = new Size(2, 2);
      this.label116.TabIndex = 257;
      this.label117.BackColor = Color.White;
      this.label117.Location = new Point(265, 374);
      this.label117.Name = "label117";
      this.label117.Size = new Size(2, 2);
      this.label117.TabIndex = 256;
      this.label118.BackColor = Color.White;
      this.label118.Location = new Point(256, 374);
      this.label118.Name = "label118";
      this.label118.Size = new Size(2, 2);
      this.label118.TabIndex = (int) byte.MaxValue;
      this.label119.BackColor = Color.White;
      this.label119.Location = new Point(157, 374);
      this.label119.Name = "label119";
      this.label119.Size = new Size(2, 2);
      this.label119.TabIndex = 312;
      this.label120.BackColor = Color.White;
      this.label120.Location = new Point(78, 374);
      this.label120.Name = "label120";
      this.label120.Size = new Size(2, 2);
      this.label120.TabIndex = 311;
      this.label121.BackColor = Color.White;
      this.label121.Location = new Point(69, 374);
      this.label121.Name = "label121";
      this.label121.Size = new Size(2, 2);
      this.label121.TabIndex = 310;
      this.label122.BackColor = Color.White;
      this.label122.Location = new Point(60, 374);
      this.label122.Name = "label122";
      this.label122.Size = new Size(2, 2);
      this.label122.TabIndex = 309;
      this.label123.BackColor = Color.White;
      this.label123.Location = new Point(51, 374);
      this.label123.Name = "label123";
      this.label123.Size = new Size(2, 2);
      this.label123.TabIndex = 308;
      this.label125.BackColor = Color.White;
      this.label125.Location = new Point(149, 374);
      this.label125.Name = "label125";
      this.label125.Size = new Size(2, 2);
      this.label125.TabIndex = 306;
      this.label126.BackColor = Color.White;
      this.label126.Location = new Point(141, 374);
      this.label126.Name = "label126";
      this.label126.Size = new Size(2, 2);
      this.label126.TabIndex = 305;
      this.label127.BackColor = Color.White;
      this.label127.Location = new Point(132, 374);
      this.label127.Name = "label127";
      this.label127.Size = new Size(2, 2);
      this.label127.TabIndex = 304;
      this.label128.BackColor = Color.White;
      this.label128.Location = new Point(123, 374);
      this.label128.Name = "label128";
      this.label128.Size = new Size(2, 2);
      this.label128.TabIndex = 303;
      this.label129.BackColor = Color.White;
      this.label129.Location = new Point(114, 374);
      this.label129.Name = "label129";
      this.label129.Size = new Size(2, 2);
      this.label129.TabIndex = 302;
      this.label130.BackColor = Color.White;
      this.label130.Location = new Point(105, 374);
      this.label130.Name = "label130";
      this.label130.Size = new Size(2, 2);
      this.label130.TabIndex = 301;
      this.label131.BackColor = Color.White;
      this.label131.Location = new Point(96, 374);
      this.label131.Name = "label131";
      this.label131.Size = new Size(2, 2);
      this.label131.TabIndex = 300;
      this.label132.BackColor = Color.White;
      this.label132.Location = new Point(87, 374);
      this.label132.Name = "label132";
      this.label132.Size = new Size(2, 2);
      this.label132.TabIndex = 299;
      this.label133.BackColor = Color.White;
      this.label133.Location = new Point(156, 338);
      this.label133.Name = "label133";
      this.label133.Size = new Size(2, 2);
      this.label133.TabIndex = 298;
      this.label134.BackColor = Color.White;
      this.label134.Location = new Point(147, 338);
      this.label134.Name = "label134";
      this.label134.Size = new Size(2, 2);
      this.label134.TabIndex = 297;
      this.label135.BackColor = Color.White;
      this.label135.Location = new Point(165, 356);
      this.label135.Name = "label135";
      this.label135.Size = new Size(2, 2);
      this.label135.TabIndex = 296;
      this.label136.BackColor = Color.White;
      this.label136.Location = new Point(165, 374);
      this.label136.Name = "label136";
      this.label136.Size = new Size(2, 2);
      this.label136.TabIndex = 295;
      this.label137.BackColor = Color.White;
      this.label137.Location = new Point(165, 365);
      this.label137.Name = "label137";
      this.label137.Size = new Size(2, 2);
      this.label137.TabIndex = 294;
      this.label138.BackColor = Color.White;
      this.label138.Location = new Point(165, 347);
      this.label138.Name = "label138";
      this.label138.Size = new Size(2, 2);
      this.label138.TabIndex = 293;
      this.label139.BackColor = Color.White;
      this.label139.Location = new Point(165, 338);
      this.label139.Name = "label139";
      this.label139.Size = new Size(2, 2);
      this.label139.TabIndex = 292;
      this.label140.BackColor = Color.White;
      this.label140.Location = new Point(35, 356);
      this.label140.Name = "label140";
      this.label140.Size = new Size(2, 2);
      this.label140.TabIndex = 291;
      this.label143.BackColor = Color.White;
      this.label143.Location = new Point(35, 347);
      this.label143.Name = "label143";
      this.label143.Size = new Size(2, 2);
      this.label143.TabIndex = 288;
      this.label144.BackColor = Color.White;
      this.label144.Location = new Point(50, 338);
      this.label144.Name = "label144";
      this.label144.Size = new Size(2, 2);
      this.label144.TabIndex = 287;
      this.label145.BackColor = Color.White;
      this.label145.Location = new Point(42, 338);
      this.label145.Name = "label145";
      this.label145.Size = new Size(2, 2);
      this.label145.TabIndex = 286;
      this.label146.BackColor = Color.White;
      this.label146.Location = new Point(35, 338);
      this.label146.Name = "label146";
      this.label146.Size = new Size(2, 2);
      this.label146.TabIndex = 285;
      this.label147.BackColor = Color.White;
      this.label147.Location = new Point(59, 338);
      this.label147.Name = "label147";
      this.label147.Size = new Size(2, 2);
      this.label147.TabIndex = 284;
      this.label148.BackColor = Color.White;
      this.label148.Location = new Point(59, 311);
      this.label148.Name = "label148";
      this.label148.Size = new Size(2, 2);
      this.label148.TabIndex = 283;
      this.label149.BackColor = Color.White;
      this.label149.Location = new Point(59, 329);
      this.label149.Name = "label149";
      this.label149.Size = new Size(2, 2);
      this.label149.TabIndex = 282;
      this.label150.BackColor = Color.White;
      this.label150.Location = new Point(59, 320);
      this.label150.Name = "label150";
      this.label150.Size = new Size(2, 2);
      this.label150.TabIndex = 281;
      this.label151.BackColor = Color.White;
      this.label151.Location = new Point(68, 338);
      this.label151.Name = "label151";
      this.label151.Size = new Size(2, 2);
      this.label151.TabIndex = 280;
      this.label152.BackColor = Color.White;
      this.label152.Location = new Point(94, 311);
      this.label152.Name = "label152";
      this.label152.Size = new Size(2, 2);
      this.label152.TabIndex = 279;
      this.label153.BackColor = Color.White;
      this.label153.Location = new Point(94, 329);
      this.label153.Name = "label153";
      this.label153.Size = new Size(2, 2);
      this.label153.TabIndex = 278;
      this.label154.BackColor = Color.White;
      this.label154.Location = new Point(94, 320);
      this.label154.Name = "label154";
      this.label154.Size = new Size(2, 2);
      this.label154.TabIndex = 277;
      this.label155.BackColor = Color.White;
      this.label155.Location = new Point(129, 338);
      this.label155.Name = "label155";
      this.label155.Size = new Size(2, 2);
      this.label155.TabIndex = 276;
      this.label156.BackColor = Color.White;
      this.label156.Location = new Point(94, 338);
      this.label156.Name = "label156";
      this.label156.Size = new Size(2, 2);
      this.label156.TabIndex = 275;
      this.label157.BackColor = Color.White;
      this.label157.Location = new Point(85, 338);
      this.label157.Name = "label157";
      this.label157.Size = new Size(2, 2);
      this.label157.TabIndex = 274;
      this.label158.BackColor = Color.White;
      this.label158.Location = new Point(76, 338);
      this.label158.Name = "label158";
      this.label158.Size = new Size(2, 2);
      this.label158.TabIndex = 273;
      this.label159.BackColor = Color.White;
      this.label159.Location = new Point(129, 311);
      this.label159.Name = "label159";
      this.label159.Size = new Size(2, 2);
      this.label159.TabIndex = 272;
      this.label160.BackColor = Color.White;
      this.label160.Location = new Point(138, 338);
      this.label160.Name = "label160";
      this.label160.Size = new Size(2, 2);
      this.label160.TabIndex = 271;
      this.label161.BackColor = Color.White;
      this.label161.Location = new Point(129, 329);
      this.label161.Name = "label161";
      this.label161.Size = new Size(2, 2);
      this.label161.TabIndex = 270;
      this.label162.BackColor = Color.White;
      this.label162.Location = new Point(129, 320);
      this.label162.Name = "label162";
      this.label162.Size = new Size(2, 2);
      this.label162.TabIndex = 269;
      this.label163.BackColor = Color.White;
      this.label163.Location = new Point(192, 374);
      this.label163.Name = "label163";
      this.label163.Size = new Size(2, 2);
      this.label163.TabIndex = 315;
      this.label164.BackColor = Color.White;
      this.label164.Location = new Point(183, 374);
      this.label164.Name = "label164";
      this.label164.Size = new Size(2, 2);
      this.label164.TabIndex = 314;
      this.label165.BackColor = Color.White;
      this.label165.Location = new Point(174, 374);
      this.label165.Name = "label165";
      this.label165.Size = new Size(2, 2);
      this.label165.TabIndex = 313;
      this.label166.BackColor = Color.White;
      this.label166.Location = new Point(35, 293);
      this.label166.Name = "label166";
      this.label166.Size = new Size(2, 2);
      this.label166.TabIndex = 318;
      this.label167.BackColor = Color.White;
      this.label167.Location = new Point(35, 284);
      this.label167.Name = "label167";
      this.label167.Size = new Size(2, 2);
      this.label167.TabIndex = 317;
      this.label168.BackColor = Color.White;
      this.label168.Location = new Point(35, 275);
      this.label168.Name = "label168";
      this.label168.Size = new Size(2, 2);
      this.label168.TabIndex = 316;
      this.label169.BackColor = Color.White;
      this.label169.Location = new Point(86, 266);
      this.label169.Name = "label169";
      this.label169.Size = new Size(2, 2);
      this.label169.TabIndex = 319;
      this.label170.BackColor = Color.White;
      this.label170.Location = new Point(59, 302);
      this.label170.Name = "label170";
      this.label170.Size = new Size(2, 2);
      this.label170.TabIndex = 323;
      this.label171.BackColor = Color.White;
      this.label171.Location = new Point(51, 302);
      this.label171.Name = "label171";
      this.label171.Size = new Size(2, 2);
      this.label171.TabIndex = 322;
      this.label172.BackColor = Color.White;
      this.label172.Location = new Point(43, 302);
      this.label172.Name = "label172";
      this.label172.Size = new Size(2, 2);
      this.label172.TabIndex = 321;
      this.label173.BackColor = Color.Black;
      this.label173.Image = (Image) componentResourceManager.GetObject("label173.Image");
      this.label173.Location = new Point(31, 298);
      this.label173.Name = "label173";
      this.label173.Size = new Size(10, 10);
      this.label173.TabIndex = 320;
      this.label174.BackColor = Color.White;
      this.label174.Location = new Point(274, 230);
      this.label174.Name = "label174";
      this.label174.Size = new Size(2, 2);
      this.label174.TabIndex = 333;
      this.label175.BackColor = Color.White;
      this.label175.Location = new Point(274, 248);
      this.label175.Name = "label175";
      this.label175.Size = new Size(2, 2);
      this.label175.TabIndex = 332;
      this.label176.BackColor = Color.White;
      this.label176.Location = new Point(274, 239);
      this.label176.Name = "label176";
      this.label176.Size = new Size(2, 2);
      this.label176.TabIndex = 331;
      this.label177.BackColor = Color.White;
      this.label177.Location = new Point(274, 257);
      this.label177.Name = "label177";
      this.label177.Size = new Size(2, 2);
      this.label177.TabIndex = 330;
      this.label178.BackColor = Color.White;
      this.label178.Location = new Point(274, 212);
      this.label178.Name = "label178";
      this.label178.Size = new Size(2, 2);
      this.label178.TabIndex = 329;
      this.label179.BackColor = Color.White;
      this.label179.Location = new Point(274, 203);
      this.label179.Name = "label179";
      this.label179.Size = new Size(2, 2);
      this.label179.TabIndex = 328;
      this.label180.BackColor = Color.White;
      this.label180.Location = new Point(274, 194);
      this.label180.Name = "label180";
      this.label180.Size = new Size(2, 2);
      this.label180.TabIndex = 327;
      this.label181.BackColor = Color.White;
      this.label181.Location = new Point(274, 221);
      this.label181.Name = "label181";
      this.label181.Size = new Size(2, 2);
      this.label181.TabIndex = 326;
      this.label182.BackColor = Color.White;
      this.label182.Location = new Point(274, 185);
      this.label182.Name = "label182";
      this.label182.Size = new Size(2, 2);
      this.label182.TabIndex = 325;
      this.label183.BackColor = Color.White;
      this.label183.Location = new Point(274, 149);
      this.label183.Name = "label183";
      this.label183.Size = new Size(2, 2);
      this.label183.TabIndex = 342;
      this.label184.BackColor = Color.White;
      this.label184.Location = new Point(274, 167);
      this.label184.Name = "label184";
      this.label184.Size = new Size(2, 2);
      this.label184.TabIndex = 341;
      this.label185.BackColor = Color.White;
      this.label185.Location = new Point(274, 158);
      this.label185.Name = "label185";
      this.label185.Size = new Size(2, 2);
      this.label185.TabIndex = 340;
      this.label186.BackColor = Color.White;
      this.label186.Location = new Point(274, 176);
      this.label186.Name = "label186";
      this.label186.Size = new Size(2, 2);
      this.label186.TabIndex = 339;
      this.label187.BackColor = Color.White;
      this.label187.Location = new Point(274, 131);
      this.label187.Name = "label187";
      this.label187.Size = new Size(2, 2);
      this.label187.TabIndex = 338;
      this.label188.BackColor = Color.White;
      this.label188.Location = new Point(274, 122);
      this.label188.Name = "label188";
      this.label188.Size = new Size(2, 2);
      this.label188.TabIndex = 337;
      this.label189.BackColor = Color.White;
      this.label189.Location = new Point(274, 113);
      this.label189.Name = "label189";
      this.label189.Size = new Size(2, 2);
      this.label189.TabIndex = 336;
      this.label190.BackColor = Color.White;
      this.label190.Location = new Point(274, 140);
      this.label190.Name = "label190";
      this.label190.Size = new Size(2, 2);
      this.label190.TabIndex = 335;
      this.label191.BackColor = Color.White;
      this.label191.Location = new Point(274, 104);
      this.label191.Name = "label191";
      this.label191.Size = new Size(2, 2);
      this.label191.TabIndex = 334;
      this.label192.BackColor = Color.White;
      this.label192.Location = new Point(274, 66);
      this.label192.Name = "label192";
      this.label192.Size = new Size(2, 2);
      this.label192.TabIndex = 351;
      this.label193.BackColor = Color.White;
      this.label193.Location = new Point(274, 85);
      this.label193.Name = "label193";
      this.label193.Size = new Size(2, 2);
      this.label193.TabIndex = 350;
      this.label194.BackColor = Color.White;
      this.label194.Location = new Point(274, 76);
      this.label194.Name = "label194";
      this.label194.Size = new Size(2, 2);
      this.label194.TabIndex = 349;
      this.label195.BackColor = Color.White;
      this.label195.Location = new Point(274, 94);
      this.label195.Name = "label195";
      this.label195.Size = new Size(2, 2);
      this.label195.TabIndex = 348;
      this.label196.BackColor = Color.White;
      this.label196.Location = new Point(274, 47);
      this.label196.Name = "label196";
      this.label196.Size = new Size(2, 2);
      this.label196.TabIndex = 347;
      this.label199.BackColor = Color.White;
      this.label199.Location = new Point(274, 57);
      this.label199.Name = "label199";
      this.label199.Size = new Size(2, 2);
      this.label199.TabIndex = 344;
      this.label198.BackColor = Color.White;
      this.label198.Location = new Point(334, 38);
      this.label198.Name = "label198";
      this.label198.Size = new Size(2, 2);
      this.label198.TabIndex = 367;
      this.label200.BackColor = Color.White;
      this.label200.Location = new Point(326, 38);
      this.label200.Name = "label200";
      this.label200.Size = new Size(2, 2);
      this.label200.TabIndex = 366;
      this.label201.BackColor = Color.White;
      this.label201.Location = new Point(247, 38);
      this.label201.Name = "label201";
      this.label201.Size = new Size(2, 2);
      this.label201.TabIndex = 365;
      this.label202.BackColor = Color.White;
      this.label202.Location = new Point(238, 38);
      this.label202.Name = "label202";
      this.label202.Size = new Size(2, 2);
      this.label202.TabIndex = 364;
      this.label203.BackColor = Color.White;
      this.label203.Location = new Point(229, 38);
      this.label203.Name = "label203";
      this.label203.Size = new Size(2, 2);
      this.label203.TabIndex = 363;
      this.label204.BackColor = Color.White;
      this.label204.Location = new Point(220, 38);
      this.label204.Name = "label204";
      this.label204.Size = new Size(2, 2);
      this.label204.TabIndex = 362;
      this.label205.BackColor = Color.White;
      this.label205.Location = new Point(211, 38);
      this.label205.Name = "label205";
      this.label205.Size = new Size(2, 2);
      this.label205.TabIndex = 361;
      this.label206.BackColor = Color.White;
      this.label206.Location = new Point(202, 38);
      this.label206.Name = "label206";
      this.label206.Size = new Size(2, 2);
      this.label206.TabIndex = 360;
      this.label207.BackColor = Color.White;
      this.label207.Location = new Point(318, 38);
      this.label207.Name = "label207";
      this.label207.Size = new Size(2, 2);
      this.label207.TabIndex = 359;
      this.label208.BackColor = Color.White;
      this.label208.Location = new Point(310, 38);
      this.label208.Name = "label208";
      this.label208.Size = new Size(2, 2);
      this.label208.TabIndex = 358;
      this.label209.BackColor = Color.White;
      this.label209.Location = new Point(301, 38);
      this.label209.Name = "label209";
      this.label209.Size = new Size(2, 2);
      this.label209.TabIndex = 357;
      this.label210.BackColor = Color.White;
      this.label210.Location = new Point(292, 38);
      this.label210.Name = "label210";
      this.label210.Size = new Size(2, 2);
      this.label210.TabIndex = 356;
      this.label211.BackColor = Color.White;
      this.label211.Location = new Point(283, 38);
      this.label211.Name = "label211";
      this.label211.Size = new Size(2, 2);
      this.label211.TabIndex = 355;
      this.label212.BackColor = Color.White;
      this.label212.Location = new Point(274, 38);
      this.label212.Name = "label212";
      this.label212.Size = new Size(2, 2);
      this.label212.TabIndex = 354;
      this.label213.BackColor = Color.White;
      this.label213.Location = new Point(265, 38);
      this.label213.Name = "label213";
      this.label213.Size = new Size(2, 2);
      this.label213.TabIndex = 353;
      this.label214.BackColor = Color.White;
      this.label214.Location = new Point(256, 38);
      this.label214.Name = "label214";
      this.label214.Size = new Size(2, 2);
      this.label214.TabIndex = 352;
      this.label197.BackColor = Color.White;
      this.label197.Location = new Point(334, 94);
      this.label197.Name = "label197";
      this.label197.Size = new Size(2, 2);
      this.label197.TabIndex = 376;
      this.label215.BackColor = Color.White;
      this.label215.Location = new Point(334, 113);
      this.label215.Name = "label215";
      this.label215.Size = new Size(2, 2);
      this.label215.TabIndex = 375;
      this.label216.BackColor = Color.White;
      this.label216.Location = new Point(334, 104);
      this.label216.Name = "label216";
      this.label216.Size = new Size(2, 2);
      this.label216.TabIndex = 374;
      this.label217.BackColor = Color.White;
      this.label217.Location = new Point(334, 122);
      this.label217.Name = "label217";
      this.label217.Size = new Size(2, 2);
      this.label217.TabIndex = 373;
      this.label218.BackColor = Color.White;
      this.label218.Location = new Point(334, 76);
      this.label218.Name = "label218";
      this.label218.Size = new Size(2, 2);
      this.label218.TabIndex = 372;
      this.label219.BackColor = Color.White;
      this.label219.Location = new Point(334, 67);
      this.label219.Name = "label219";
      this.label219.Size = new Size(2, 2);
      this.label219.TabIndex = 371;
      this.label220.BackColor = Color.Black;
      this.label220.Image = (Image) componentResourceManager.GetObject("label220.Image");
      this.label220.Location = new Point(330, 54);
      this.label220.Name = "label220";
      this.label220.Size = new Size(10, 10);
      this.label220.TabIndex = 370;
      this.label221.BackColor = Color.White;
      this.label221.Location = new Point(334, 85);
      this.label221.Name = "label221";
      this.label221.Size = new Size(2, 2);
      this.label221.TabIndex = 369;
      this.label222.BackColor = Color.White;
      this.label222.Location = new Point(334, 48);
      this.label222.Name = "label222";
      this.label222.Size = new Size(2, 2);
      this.label222.TabIndex = 368;
      this.label223.BackColor = Color.White;
      this.label223.Location = new Point(326, 85);
      this.label223.Name = "label223";
      this.label223.Size = new Size(2, 2);
      this.label223.TabIndex = 382;
      this.label224.BackColor = Color.White;
      this.label224.Location = new Point(318, 85);
      this.label224.Name = "label224";
      this.label224.Size = new Size(2, 2);
      this.label224.TabIndex = 381;
      this.label225.BackColor = Color.White;
      this.label225.Location = new Point(310, 85);
      this.label225.Name = "label225";
      this.label225.Size = new Size(2, 2);
      this.label225.TabIndex = 380;
      this.label226.BackColor = Color.White;
      this.label226.Location = new Point(301, 85);
      this.label226.Name = "label226";
      this.label226.Size = new Size(2, 2);
      this.label226.TabIndex = 379;
      this.label227.BackColor = Color.White;
      this.label227.Location = new Point(292, 85);
      this.label227.Name = "label227";
      this.label227.Size = new Size(2, 2);
      this.label227.TabIndex = 378;
      this.label228.BackColor = Color.White;
      this.label228.Location = new Point(283, 85);
      this.label228.Name = "label228";
      this.label228.Size = new Size(2, 2);
      this.label228.TabIndex = 377;
      this.label229.BackColor = Color.White;
      this.label229.Location = new Point(326, 122);
      this.label229.Name = "label229";
      this.label229.Size = new Size(2, 2);
      this.label229.TabIndex = 388;
      this.label230.BackColor = Color.White;
      this.label230.Location = new Point(318, 122);
      this.label230.Name = "label230";
      this.label230.Size = new Size(2, 2);
      this.label230.TabIndex = 387;
      this.label231.BackColor = Color.White;
      this.label231.Location = new Point(310, 122);
      this.label231.Name = "label231";
      this.label231.Size = new Size(2, 2);
      this.label231.TabIndex = 386;
      this.label232.BackColor = Color.White;
      this.label232.Location = new Point(301, 122);
      this.label232.Name = "label232";
      this.label232.Size = new Size(2, 2);
      this.label232.TabIndex = 385;
      this.label233.BackColor = Color.White;
      this.label233.Location = new Point(292, 122);
      this.label233.Name = "label233";
      this.label233.Size = new Size(2, 2);
      this.label233.TabIndex = 384;
      this.label234.BackColor = Color.White;
      this.label234.Location = new Point(283, 122);
      this.label234.Name = "label234";
      this.label234.Size = new Size(2, 2);
      this.label234.TabIndex = 383;
      this.label235.BackColor = Color.White;
      this.label235.Location = new Point(247, 85);
      this.label235.Name = "label235";
      this.label235.Size = new Size(2, 2);
      this.label235.TabIndex = 396;
      this.label236.BackColor = Color.White;
      this.label236.Location = new Point(238, 85);
      this.label236.Name = "label236";
      this.label236.Size = new Size(2, 2);
      this.label236.TabIndex = 395;
      this.label237.BackColor = Color.White;
      this.label237.Location = new Point(229, 85);
      this.label237.Name = "label237";
      this.label237.Size = new Size(2, 2);
      this.label237.TabIndex = 394;
      this.label238.BackColor = Color.White;
      this.label238.Location = new Point(220, 85);
      this.label238.Name = "label238";
      this.label238.Size = new Size(2, 2);
      this.label238.TabIndex = 393;
      this.label239.BackColor = Color.White;
      this.label239.Location = new Point(211, 85);
      this.label239.Name = "label239";
      this.label239.Size = new Size(2, 2);
      this.label239.TabIndex = 392;
      this.label240.BackColor = Color.White;
      this.label240.Location = new Point(202, 85);
      this.label240.Name = "label240";
      this.label240.Size = new Size(2, 2);
      this.label240.TabIndex = 391;
      this.label241.BackColor = Color.White;
      this.label241.Location = new Point(265, 85);
      this.label241.Name = "label241";
      this.label241.Size = new Size(2, 2);
      this.label241.TabIndex = 390;
      this.label242.BackColor = Color.White;
      this.label242.Location = new Point(256, 85);
      this.label242.Name = "label242";
      this.label242.Size = new Size(2, 2);
      this.label242.TabIndex = 389;
      this.label243.BackColor = Color.White;
      this.label243.Location = new Point(202, 66);
      this.label243.Name = "label243";
      this.label243.Size = new Size(2, 2);
      this.label243.TabIndex = 400;
      this.label244.BackColor = Color.White;
      this.label244.Location = new Point(202, 76);
      this.label244.Name = "label244";
      this.label244.Size = new Size(2, 2);
      this.label244.TabIndex = 399;
      this.label245.BackColor = Color.White;
      this.label245.Location = new Point(202, 47);
      this.label245.Name = "label245";
      this.label245.Size = new Size(2, 2);
      this.label245.TabIndex = 398;
      this.label246.BackColor = Color.White;
      this.label246.Location = new Point(202, 57);
      this.label246.Name = "label246";
      this.label246.Size = new Size(2, 2);
      this.label246.TabIndex = 397;
      this.label247.BackColor = Color.White;
      this.label247.Location = new Point(129, 94);
      this.label247.Name = "label247";
      this.label247.Size = new Size(2, 2);
      this.label247.TabIndex = 419;
      this.label248.BackColor = Color.White;
      this.label248.Location = new Point(129, 112);
      this.label248.Name = "label248";
      this.label248.Size = new Size(2, 2);
      this.label248.TabIndex = 418;
      this.label249.BackColor = Color.White;
      this.label249.Location = new Point(129, 103);
      this.label249.Name = "label249";
      this.label249.Size = new Size(2, 2);
      this.label249.TabIndex = 417;
      this.label250.BackColor = Color.White;
      this.label250.Location = new Point(238, 94);
      this.label250.Name = "label250";
      this.label250.Size = new Size(2, 2);
      this.label250.TabIndex = 416;
      this.label251.BackColor = Color.White;
      this.label251.Location = new Point(238, 112);
      this.label251.Name = "label251";
      this.label251.Size = new Size(2, 2);
      this.label251.TabIndex = 415;
      this.label252.BackColor = Color.White;
      this.label252.Location = new Point(238, 103);
      this.label252.Name = "label252";
      this.label252.Size = new Size(2, 2);
      this.label252.TabIndex = 414;
      this.label256.BackColor = Color.White;
      this.label256.Location = new Point(202, 122);
      this.label256.Name = "label256";
      this.label256.Size = new Size(2, 2);
      this.label256.TabIndex = 410;
      this.label257.BackColor = Color.White;
      this.label257.Location = new Point(238, 122);
      this.label257.Name = "label257";
      this.label257.Size = new Size(2, 2);
      this.label257.TabIndex = 409;
      this.label258.BackColor = Color.White;
      this.label258.Location = new Point(229, 122);
      this.label258.Name = "label258";
      this.label258.Size = new Size(2, 2);
      this.label258.TabIndex = 408;
      this.label259.BackColor = Color.White;
      this.label259.Location = new Point(220, 122);
      this.label259.Name = "label259";
      this.label259.Size = new Size(2, 2);
      this.label259.TabIndex = 407;
      this.label260.BackColor = Color.White;
      this.label260.Location = new Point(211, 122);
      this.label260.Name = "label260";
      this.label260.Size = new Size(2, 2);
      this.label260.TabIndex = 406;
      this.label261.BackColor = Color.White;
      this.label261.Location = new Point(165, 122);
      this.label261.Name = "label261";
      this.label261.Size = new Size(2, 2);
      this.label261.TabIndex = 405;
      this.label262.BackColor = Color.White;
      this.label262.Location = new Point(156, 122);
      this.label262.Name = "label262";
      this.label262.Size = new Size(2, 2);
      this.label262.TabIndex = 404;
      this.label263.BackColor = Color.White;
      this.label263.Location = new Point(147, 122);
      this.label263.Name = "label263";
      this.label263.Size = new Size(2, 2);
      this.label263.TabIndex = 403;
      this.label264.BackColor = Color.White;
      this.label264.Location = new Point(138, 122);
      this.label264.Name = "label264";
      this.label264.Size = new Size(2, 2);
      this.label264.TabIndex = 402;
      this.label265.BackColor = Color.White;
      this.label265.Location = new Point(129, 122);
      this.label265.Name = "label265";
      this.label265.Size = new Size(2, 2);
      this.label265.TabIndex = 401;
      this.label272.BackColor = Color.White;
      this.label272.Location = new Point(192, 85);
      this.label272.Name = "label272";
      this.label272.Size = new Size(2, 2);
      this.label272.TabIndex = 432;
      this.label273.BackColor = Color.White;
      this.label273.Location = new Point(183, 85);
      this.label273.Name = "label273";
      this.label273.Size = new Size(2, 2);
      this.label273.TabIndex = 431;
      this.label274.BackColor = Color.White;
      this.label274.Location = new Point(174, 85);
      this.label274.Name = "label274";
      this.label274.Size = new Size(2, 2);
      this.label274.TabIndex = 430;
      this.label280.BackColor = Color.White;
      this.label280.Location = new Point(165, 85);
      this.label280.Name = "label280";
      this.label280.Size = new Size(2, 2);
      this.label280.TabIndex = 424;
      this.label281.BackColor = Color.White;
      this.label281.Location = new Point(156, 85);
      this.label281.Name = "label281";
      this.label281.Size = new Size(2, 2);
      this.label281.TabIndex = 423;
      this.label282.BackColor = Color.White;
      this.label282.Location = new Point(147, 85);
      this.label282.Name = "label282";
      this.label282.Size = new Size(2, 2);
      this.label282.TabIndex = 422;
      this.label283.BackColor = Color.White;
      this.label283.Location = new Point(138, 85);
      this.label283.Name = "label283";
      this.label283.Size = new Size(2, 2);
      this.label283.TabIndex = 421;
      this.label284.BackColor = Color.White;
      this.label284.Location = new Point(129, 85);
      this.label284.Name = "label284";
      this.label284.Size = new Size(2, 2);
      this.label284.TabIndex = 420;
      this.label266.BackColor = Color.White;
      this.label266.Location = new Point(94, 66);
      this.label266.Name = "label266";
      this.label266.Size = new Size(2, 2);
      this.label266.TabIndex = 449;
      this.label267.BackColor = Color.White;
      this.label267.Location = new Point(94, 76);
      this.label267.Name = "label267";
      this.label267.Size = new Size(2, 2);
      this.label267.TabIndex = 448;
      this.label268.BackColor = Color.White;
      this.label268.Location = new Point(94, 47);
      this.label268.Name = "label268";
      this.label268.Size = new Size(2, 2);
      this.label268.TabIndex = 447;
      this.label269.BackColor = Color.White;
      this.label269.Location = new Point(94, 57);
      this.label269.Name = "label269";
      this.label269.Size = new Size(2, 2);
      this.label269.TabIndex = 446;
      this.label270.BackColor = Color.White;
      this.label270.Location = new Point(138, 38);
      this.label270.Name = "label270";
      this.label270.Size = new Size(2, 2);
      this.label270.TabIndex = 445;
      this.label271.BackColor = Color.White;
      this.label271.Location = new Point(129, 38);
      this.label271.Name = "label271";
      this.label271.Size = new Size(2, 2);
      this.label271.TabIndex = 444;
      this.label275.BackColor = Color.White;
      this.label275.Location = new Point(120, 38);
      this.label275.Name = "label275";
      this.label275.Size = new Size(2, 2);
      this.label275.TabIndex = 443;
      this.label276.BackColor = Color.White;
      this.label276.Location = new Point(111, 38);
      this.label276.Name = "label276";
      this.label276.Size = new Size(2, 2);
      this.label276.TabIndex = 442;
      this.label277.BackColor = Color.White;
      this.label277.Location = new Point(102, 38);
      this.label277.Name = "label277";
      this.label277.Size = new Size(2, 2);
      this.label277.TabIndex = 441;
      this.label278.BackColor = Color.White;
      this.label278.Location = new Point(94, 38);
      this.label278.Name = "label278";
      this.label278.Size = new Size(2, 2);
      this.label278.TabIndex = 440;
      this.label279.BackColor = Color.White;
      this.label279.Location = new Point(165, 38);
      this.label279.Name = "label279";
      this.label279.Size = new Size(2, 2);
      this.label279.TabIndex = 439;
      this.label285.BackColor = Color.White;
      this.label285.Location = new Point(156, 38);
      this.label285.Name = "label285";
      this.label285.Size = new Size(2, 2);
      this.label285.TabIndex = 438;
      this.label286.BackColor = Color.White;
      this.label286.Location = new Point(147, 38);
      this.label286.Name = "label286";
      this.label286.Size = new Size(2, 2);
      this.label286.TabIndex = 437;
      this.label287.BackColor = Color.White;
      this.label287.Location = new Point(165, 66);
      this.label287.Name = "label287";
      this.label287.Size = new Size(2, 2);
      this.label287.TabIndex = 436;
      this.label288.BackColor = Color.White;
      this.label288.Location = new Point(165, 76);
      this.label288.Name = "label288";
      this.label288.Size = new Size(2, 2);
      this.label288.TabIndex = 435;
      this.label289.BackColor = Color.White;
      this.label289.Location = new Point(165, 47);
      this.label289.Name = "label289";
      this.label289.Size = new Size(2, 2);
      this.label289.TabIndex = 434;
      this.label290.BackColor = Color.White;
      this.label290.Location = new Point(165, 57);
      this.label290.Name = "label290";
      this.label290.Size = new Size(2, 2);
      this.label290.TabIndex = 433;
      this.label293.BackColor = Color.White;
      this.label293.Location = new Point(49, 85);
      this.label293.Name = "label293";
      this.label293.Size = new Size(2, 2);
      this.label293.TabIndex = 459;
      this.label294.BackColor = Color.White;
      this.label294.Location = new Point(40, 85);
      this.label294.Name = "label294";
      this.label294.Size = new Size(2, 2);
      this.label294.TabIndex = 458;
      this.label295.BackColor = Color.White;
      this.label295.Location = new Point(111, 85);
      this.label295.Name = "label295";
      this.label295.Size = new Size(2, 2);
      this.label295.TabIndex = 457;
      this.label296.BackColor = Color.White;
      this.label296.Location = new Point(103, 85);
      this.label296.Name = "label296";
      this.label296.Size = new Size(2, 2);
      this.label296.TabIndex = 456;
      this.label297.BackColor = Color.White;
      this.label297.Location = new Point(94, 85);
      this.label297.Name = "label297";
      this.label297.Size = new Size(2, 2);
      this.label297.TabIndex = 455;
      this.label298.BackColor = Color.White;
      this.label298.Location = new Point(85, 85);
      this.label298.Name = "label298";
      this.label298.Size = new Size(2, 2);
      this.label298.TabIndex = 454;
      this.label299.BackColor = Color.White;
      this.label299.Location = new Point(76, 85);
      this.label299.Name = "label299";
      this.label299.Size = new Size(2, 2);
      this.label299.TabIndex = 453;
      this.label300.BackColor = Color.White;
      this.label300.Location = new Point(67, 85);
      this.label300.Name = "label300";
      this.label300.Size = new Size(2, 2);
      this.label300.TabIndex = 452;
      this.label301.BackColor = Color.White;
      this.label301.Location = new Point(120, 85);
      this.label301.Name = "label301";
      this.label301.Size = new Size(2, 2);
      this.label301.TabIndex = 451;
      this.label302.BackColor = Color.White;
      this.label302.Location = new Point(58, 85);
      this.label302.Name = "label302";
      this.label302.Size = new Size(2, 2);
      this.label302.TabIndex = 450;
      this.label291.BackColor = Color.White;
      this.label291.Location = new Point(32, 94);
      this.label291.Name = "label291";
      this.label291.Size = new Size(2, 2);
      this.label291.TabIndex = 469;
      this.label292.BackColor = Color.White;
      this.label292.Location = new Point(32, 113);
      this.label292.Name = "label292";
      this.label292.Size = new Size(2, 2);
      this.label292.TabIndex = 468;
      this.label303.BackColor = Color.White;
      this.label303.Location = new Point(32, 104);
      this.label303.Name = "label303";
      this.label303.Size = new Size(2, 2);
      this.label303.TabIndex = 467;
      this.label304.BackColor = Color.White;
      this.label304.Location = new Point(32, 122);
      this.label304.Name = "label304";
      this.label304.Size = new Size(2, 2);
      this.label304.TabIndex = 466;
      this.label305.BackColor = Color.White;
      this.label305.Location = new Point(32, 76);
      this.label305.Name = "label305";
      this.label305.Size = new Size(2, 2);
      this.label305.TabIndex = 465;
      this.label306.BackColor = Color.White;
      this.label306.Location = new Point(32, 67);
      this.label306.Name = "label306";
      this.label306.Size = new Size(2, 2);
      this.label306.TabIndex = 464;
      this.label307.BackColor = Color.Black;
      this.label307.Image = (Image) componentResourceManager.GetObject("label307.Image");
      this.label307.Location = new Point(28, 54);
      this.label307.Name = "label307";
      this.label307.Size = new Size(10, 10);
      this.label307.TabIndex = 463;
      this.label308.BackColor = Color.White;
      this.label308.Location = new Point(32, 85);
      this.label308.Name = "label308";
      this.label308.Size = new Size(2, 2);
      this.label308.TabIndex = 462;
      this.label309.BackColor = Color.White;
      this.label309.Location = new Point(32, 48);
      this.label309.Name = "label309";
      this.label309.Size = new Size(2, 2);
      this.label309.TabIndex = 461;
      this.label310.BackColor = Color.White;
      this.label310.Location = new Point(32, 38);
      this.label310.Name = "label310";
      this.label310.Size = new Size(2, 2);
      this.label310.TabIndex = 460;
      this.label311.BackColor = Color.White;
      this.label311.Location = new Point(85, 38);
      this.label311.Name = "label311";
      this.label311.Size = new Size(2, 2);
      this.label311.TabIndex = 475;
      this.label312.BackColor = Color.White;
      this.label312.Location = new Point(77, 38);
      this.label312.Name = "label312";
      this.label312.Size = new Size(2, 2);
      this.label312.TabIndex = 474;
      this.label313.BackColor = Color.White;
      this.label313.Location = new Point(68, 38);
      this.label313.Name = "label313";
      this.label313.Size = new Size(2, 2);
      this.label313.TabIndex = 473;
      this.label314.BackColor = Color.White;
      this.label314.Location = new Point(59, 38);
      this.label314.Name = "label314";
      this.label314.Size = new Size(2, 2);
      this.label314.TabIndex = 472;
      this.label315.BackColor = Color.White;
      this.label315.Location = new Point(50, 38);
      this.label315.Name = "label315";
      this.label315.Size = new Size(2, 2);
      this.label315.TabIndex = 471;
      this.label316.BackColor = Color.White;
      this.label316.Location = new Point(41, 38);
      this.label316.Name = "label316";
      this.label316.Size = new Size(2, 2);
      this.label316.TabIndex = 470;
      this.label317.BackColor = Color.White;
      this.label317.Location = new Point(85, 122);
      this.label317.Name = "label317";
      this.label317.Size = new Size(2, 2);
      this.label317.TabIndex = 482;
      this.label318.BackColor = Color.White;
      this.label318.Location = new Point(76, 122);
      this.label318.Name = "label318";
      this.label318.Size = new Size(2, 2);
      this.label318.TabIndex = 481;
      this.label319.BackColor = Color.White;
      this.label319.Location = new Point(67, 122);
      this.label319.Name = "label319";
      this.label319.Size = new Size(2, 2);
      this.label319.TabIndex = 480;
      this.label320.BackColor = Color.White;
      this.label320.Location = new Point(58, 122);
      this.label320.Name = "label320";
      this.label320.Size = new Size(2, 2);
      this.label320.TabIndex = 479;
      this.label321.BackColor = Color.White;
      this.label321.Location = new Point(49, 122);
      this.label321.Name = "label321";
      this.label321.Size = new Size(2, 2);
      this.label321.TabIndex = 478;
      this.label322.BackColor = Color.White;
      this.label322.Location = new Point(40, 122);
      this.label322.Name = "label322";
      this.label322.Size = new Size(2, 2);
      this.label322.TabIndex = 477;
      this.label323.BackColor = Color.White;
      this.label323.Location = new Point(94, 122);
      this.label323.Name = "label323";
      this.label323.Size = new Size(2, 2);
      this.label323.TabIndex = 476;
      this.label324.BackColor = Color.White;
      this.label324.Location = new Point(94, 103);
      this.label324.Name = "label324";
      this.label324.Size = new Size(2, 2);
      this.label324.TabIndex = 486;
      this.label325.BackColor = Color.White;
      this.label325.Location = new Point(94, 113);
      this.label325.Name = "label325";
      this.label325.Size = new Size(2, 2);
      this.label325.TabIndex = 485;
      this.label327.BackColor = Color.White;
      this.label327.Location = new Point(94, 94);
      this.label327.Name = "label327";
      this.label327.Size = new Size(2, 2);
      this.label327.TabIndex = 483;
      this.label326.BackColor = Color.White;
      this.label326.Location = new Point(94, 149);
      this.label326.Name = "label326";
      this.label326.Size = new Size(2, 2);
      this.label326.TabIndex = 501;
      this.label328.BackColor = Color.White;
      this.label328.Location = new Point(94, 167);
      this.label328.Name = "label328";
      this.label328.Size = new Size(2, 2);
      this.label328.TabIndex = 500;
      this.label329.BackColor = Color.White;
      this.label329.Location = new Point(94, 158);
      this.label329.Name = "label329";
      this.label329.Size = new Size(2, 2);
      this.label329.TabIndex = 499;
      this.label330.BackColor = Color.White;
      this.label330.Location = new Point(94, 176);
      this.label330.Name = "label330";
      this.label330.Size = new Size(2, 2);
      this.label330.TabIndex = 498;
      this.label331.BackColor = Color.White;
      this.label331.Location = new Point(94, 131);
      this.label331.Name = "label331";
      this.label331.Size = new Size(2, 2);
      this.label331.TabIndex = 497;
      this.label332.BackColor = Color.White;
      this.label332.Location = new Point(94, 140);
      this.label332.Name = "label332";
      this.label332.Size = new Size(2, 2);
      this.label332.TabIndex = 496;
      this.label333.BackColor = Color.White;
      this.label333.Location = new Point(94, 230);
      this.label333.Name = "label333";
      this.label333.Size = new Size(2, 2);
      this.label333.TabIndex = 495;
      this.label334.BackColor = Color.White;
      this.label334.Location = new Point(94, 248);
      this.label334.Name = "label334";
      this.label334.Size = new Size(2, 2);
      this.label334.TabIndex = 494;
      this.label335.BackColor = Color.White;
      this.label335.Location = new Point(94, 239);
      this.label335.Name = "label335";
      this.label335.Size = new Size(2, 2);
      this.label335.TabIndex = 493;
      this.label336.BackColor = Color.White;
      this.label336.Location = new Point(94, 257);
      this.label336.Name = "label336";
      this.label336.Size = new Size(2, 2);
      this.label336.TabIndex = 492;
      this.label337.BackColor = Color.White;
      this.label337.Location = new Point(94, 212);
      this.label337.Name = "label337";
      this.label337.Size = new Size(2, 2);
      this.label337.TabIndex = 491;
      this.label338.BackColor = Color.White;
      this.label338.Location = new Point(94, 203);
      this.label338.Name = "label338";
      this.label338.Size = new Size(2, 2);
      this.label338.TabIndex = 490;
      this.label339.BackColor = Color.White;
      this.label339.Location = new Point(94, 194);
      this.label339.Name = "label339";
      this.label339.Size = new Size(2, 2);
      this.label339.TabIndex = 489;
      this.label340.BackColor = Color.White;
      this.label340.Location = new Point(94, 221);
      this.label340.Name = "label340";
      this.label340.Size = new Size(2, 2);
      this.label340.TabIndex = 488;
      this.label341.BackColor = Color.White;
      this.label341.Location = new Point(94, 185);
      this.label341.Name = "label341";
      this.label341.Size = new Size(2, 2);
      this.label341.TabIndex = 487;
      this.timer8.Interval = 700;
      this.timer8.Tick += new EventHandler(this.timer8_Tick);
      this.panel1.Controls.Add((Control) this.label254);
      this.panel1.Controls.Add((Control) this.label255);
      this.panel1.Controls.Add((Control) this.label253);
      this.panel1.Controls.Add((Control) this.label142);
      this.panel1.Controls.Add((Control) this.pictureBox5);
      this.panel1.Controls.Add((Control) this.pictureBox4);
      this.panel1.Controls.Add((Control) this.pictureBox3);
      this.panel1.Controls.Add((Control) this.button1);
      this.panel1.Dock = DockStyle.Fill;
      this.panel1.Location = new Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(370, 430);
      this.panel1.TabIndex = 502;
      this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
      this.pictureBox5.Image = (Image) Resources.bg_name;
      this.pictureBox5.Location = new Point(12, 226);
      this.pictureBox5.Name = "pictureBox5";
      this.pictureBox5.Size = new Size(348, 171);
      this.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
      this.pictureBox5.TabIndex = 7;
      this.pictureBox5.TabStop = false;
      this.pictureBox5.Click += new EventHandler(this.pictureBox5_Click);
      this.pictureBox4.Image = (Image) Resources.exit;
      this.pictureBox4.Location = new Point(163, 158);
      this.pictureBox4.Name = "pictureBox4";
      this.pictureBox4.Size = new Size(50, 50);
      this.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
      this.pictureBox4.TabIndex = 2;
      this.pictureBox4.TabStop = false;
      this.pictureBox4.Click += new EventHandler(this.pictureBox4_Click);
      this.pictureBox3.Image = (Image) Resources.pacman_bg;
      this.pictureBox3.Location = new Point(12, 18);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new Size(348, 101);
      this.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
      this.pictureBox3.TabIndex = 1;
      this.pictureBox3.TabStop = false;
      this.pictureBox3.Visible = false;
      this.button1.Cursor = Cursors.Hand;
      this.button1.FlatAppearance.BorderColor = Color.Black;
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatAppearance.MouseDownBackColor = Color.Black;
      this.button1.FlatAppearance.MouseOverBackColor = Color.Black;
      this.button1.FlatStyle = FlatStyle.Flat;
      this.button1.Image = (Image) Resources.playgame;
      this.button1.Location = new Point(123, 124);
      this.button1.Name = "button1";
      this.button1.Size = new Size(136, 36);
      this.button1.TabIndex = 0;
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Visible = false;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button1.MouseEnter += new EventHandler(this.button1_MouseEnter);
      this.button1.MouseLeave += new EventHandler(this.button1_MouseLeave);
      this.pacman.BackgroundImageLayout = ImageLayout.None;
      this.pacman.Cursor = Cursors.Default;
      this.pacman.Image = (Image) Resources.pacdx;
      this.pacman.Location = new Point(24, 364);
      this.pacman.Name = "pacman";
      this.pacman.Size = new Size(22, 22);
      this.pacman.TabIndex = 503;
      this.pacman.TabStop = false;
      this.powermod.Interval = 10000;
      this.powermod.Tick += new EventHandler(this.powermod_Tick);
      this.timer7.Interval = 2500;
      this.timer7.Tick += new EventHandler(this.timer7_Tick);
      this.timer9.Enabled = true;
      this.timer9.Interval = 200;
      this.timer9.Tick += new EventHandler(this.timer9_Tick);
      this.ghostmangiato.Interval = 500;
      this.ghostmangiato.Tick += new EventHandler(this.ghostmangiato_Tick);
      this.label124.BackColor = Color.Black;
      this.label124.Font = new Font("Segoe UI Black", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label124.ForeColor = Color.White;
      this.label124.Image = (Image) Resources.gameover;
      this.label124.Location = new Point(123, 222);
      this.label124.Name = "label124";
      this.label124.Size = new Size(125, 19);
      this.label124.TabIndex = 504;
      this.label124.Text = "          ";
      this.label124.TextAlign = ContentAlignment.MiddleRight;
      this.label124.Visible = false;
      this.label141.BackColor = Color.Black;
      this.label141.Font = new Font("Segoe UI Black", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label141.ForeColor = Color.White;
      this.label141.Image = (Image) Resources.gamewin1;
      this.label141.Location = new Point(125, 222);
      this.label141.Name = "label141";
      this.label141.Size = new Size(125, 19);
      this.label141.TabIndex = 505;
      this.label141.Text = "          ";
      this.label141.TextAlign = ContentAlignment.MiddleRight;
      this.label141.Visible = false;
      this.powermod1.Interval = 7000;
      this.powermod1.Tick += new EventHandler(this.powermod1_Tick);
      this.attendo.Interval = 400;
      this.attendo.Tick += new EventHandler(this.attendo_Tick);
      this.label254.AutoSize = true;
      this.label254.Font = new Font("News706 BT", 12.25f, FontStyle.Bold);
      this.label254.ForeColor = Color.White;
      this.label254.Location = new Point(128, 354);
      this.label254.Name = "label254";
      this.label254.Size = new Size(122, 20);
      this.label254.TabIndex = 11;
      this.label254.Text = "(15050623024)";
      this.label254.Click += new EventHandler(this.label254_Click_1);
      this.label255.AutoSize = true;
      this.label255.Font = new Font("News706 BT", 13.25f, FontStyle.Bold);
      this.label255.ForeColor = Color.White;
      this.label255.Location = new Point(97, 331);
      this.label255.Name = "label255";
      this.label255.Size = new Size(197, 21);
      this.label255.TabIndex = 10;
      this.label255.Text = "Fahmi Rizky Maulidy";
      this.label253.AutoSize = true;
      this.label253.Font = new Font("News706 BT", 12.25f, FontStyle.Bold);
      this.label253.ForeColor = Color.White;
      this.label253.Location = new Point(126, 277);
      this.label253.Name = "label253";
      this.label253.Size = new Size(122, 20);
      this.label253.TabIndex = 9;
      this.label253.Text = "(15050623021)";
      this.label142.AutoSize = true;
      this.label142.BackColor = Color.Transparent;
      this.label142.Font = new Font("News706 BT", 12.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label142.ForeColor = SystemColors.Window;
      this.label142.Location = new Point(53, (int) byte.MaxValue);
      this.label142.Name = "label142";
      this.label142.Size = new Size(266, 20);
      this.label142.TabIndex = 8;
      this.label142.Text = "Muhammad Akbar Priambodo ";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.Black;
      this.BackgroundImage = (Image) Resources.percorso;
      this.BackgroundImageLayout = ImageLayout.None;
      this.ClientSize = new Size(370, 430);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.ghost3);
      this.Controls.Add((Control) this.ghost4);
      this.Controls.Add((Control) this.ghost2);
      this.Controls.Add((Control) this.ghost1);
      this.Controls.Add((Control) this.label141);
      this.Controls.Add((Control) this.label124);
      this.Controls.Add((Control) this.pacman);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label326);
      this.Controls.Add((Control) this.label328);
      this.Controls.Add((Control) this.label329);
      this.Controls.Add((Control) this.label330);
      this.Controls.Add((Control) this.label331);
      this.Controls.Add((Control) this.label332);
      this.Controls.Add((Control) this.label333);
      this.Controls.Add((Control) this.label334);
      this.Controls.Add((Control) this.label335);
      this.Controls.Add((Control) this.label336);
      this.Controls.Add((Control) this.label337);
      this.Controls.Add((Control) this.label338);
      this.Controls.Add((Control) this.label339);
      this.Controls.Add((Control) this.label340);
      this.Controls.Add((Control) this.label341);
      this.Controls.Add((Control) this.label324);
      this.Controls.Add((Control) this.label325);
      this.Controls.Add((Control) this.label327);
      this.Controls.Add((Control) this.label317);
      this.Controls.Add((Control) this.label318);
      this.Controls.Add((Control) this.label319);
      this.Controls.Add((Control) this.label320);
      this.Controls.Add((Control) this.label321);
      this.Controls.Add((Control) this.label322);
      this.Controls.Add((Control) this.label323);
      this.Controls.Add((Control) this.label311);
      this.Controls.Add((Control) this.label312);
      this.Controls.Add((Control) this.label313);
      this.Controls.Add((Control) this.label314);
      this.Controls.Add((Control) this.label315);
      this.Controls.Add((Control) this.label316);
      this.Controls.Add((Control) this.label291);
      this.Controls.Add((Control) this.label292);
      this.Controls.Add((Control) this.label303);
      this.Controls.Add((Control) this.label304);
      this.Controls.Add((Control) this.label305);
      this.Controls.Add((Control) this.label306);
      this.Controls.Add((Control) this.label307);
      this.Controls.Add((Control) this.label308);
      this.Controls.Add((Control) this.label309);
      this.Controls.Add((Control) this.label310);
      this.Controls.Add((Control) this.label293);
      this.Controls.Add((Control) this.label294);
      this.Controls.Add((Control) this.label295);
      this.Controls.Add((Control) this.label296);
      this.Controls.Add((Control) this.label297);
      this.Controls.Add((Control) this.label298);
      this.Controls.Add((Control) this.label299);
      this.Controls.Add((Control) this.label300);
      this.Controls.Add((Control) this.label301);
      this.Controls.Add((Control) this.label302);
      this.Controls.Add((Control) this.label266);
      this.Controls.Add((Control) this.label267);
      this.Controls.Add((Control) this.label268);
      this.Controls.Add((Control) this.label269);
      this.Controls.Add((Control) this.label270);
      this.Controls.Add((Control) this.label271);
      this.Controls.Add((Control) this.label275);
      this.Controls.Add((Control) this.label276);
      this.Controls.Add((Control) this.label277);
      this.Controls.Add((Control) this.label278);
      this.Controls.Add((Control) this.label279);
      this.Controls.Add((Control) this.label285);
      this.Controls.Add((Control) this.label286);
      this.Controls.Add((Control) this.label287);
      this.Controls.Add((Control) this.label288);
      this.Controls.Add((Control) this.label289);
      this.Controls.Add((Control) this.label290);
      this.Controls.Add((Control) this.label272);
      this.Controls.Add((Control) this.label273);
      this.Controls.Add((Control) this.label274);
      this.Controls.Add((Control) this.label280);
      this.Controls.Add((Control) this.label281);
      this.Controls.Add((Control) this.label282);
      this.Controls.Add((Control) this.label283);
      this.Controls.Add((Control) this.label284);
      this.Controls.Add((Control) this.label247);
      this.Controls.Add((Control) this.label248);
      this.Controls.Add((Control) this.label249);
      this.Controls.Add((Control) this.label250);
      this.Controls.Add((Control) this.label251);
      this.Controls.Add((Control) this.label252);
      this.Controls.Add((Control) this.label256);
      this.Controls.Add((Control) this.label257);
      this.Controls.Add((Control) this.label258);
      this.Controls.Add((Control) this.label259);
      this.Controls.Add((Control) this.label260);
      this.Controls.Add((Control) this.label261);
      this.Controls.Add((Control) this.label262);
      this.Controls.Add((Control) this.label263);
      this.Controls.Add((Control) this.label264);
      this.Controls.Add((Control) this.label265);
      this.Controls.Add((Control) this.label243);
      this.Controls.Add((Control) this.label244);
      this.Controls.Add((Control) this.label245);
      this.Controls.Add((Control) this.label246);
      this.Controls.Add((Control) this.label235);
      this.Controls.Add((Control) this.label236);
      this.Controls.Add((Control) this.label237);
      this.Controls.Add((Control) this.label238);
      this.Controls.Add((Control) this.label239);
      this.Controls.Add((Control) this.label240);
      this.Controls.Add((Control) this.label241);
      this.Controls.Add((Control) this.label242);
      this.Controls.Add((Control) this.label229);
      this.Controls.Add((Control) this.label230);
      this.Controls.Add((Control) this.label231);
      this.Controls.Add((Control) this.label232);
      this.Controls.Add((Control) this.label233);
      this.Controls.Add((Control) this.label234);
      this.Controls.Add((Control) this.label223);
      this.Controls.Add((Control) this.label224);
      this.Controls.Add((Control) this.label225);
      this.Controls.Add((Control) this.label226);
      this.Controls.Add((Control) this.label227);
      this.Controls.Add((Control) this.label228);
      this.Controls.Add((Control) this.label197);
      this.Controls.Add((Control) this.label215);
      this.Controls.Add((Control) this.label216);
      this.Controls.Add((Control) this.label217);
      this.Controls.Add((Control) this.label218);
      this.Controls.Add((Control) this.label219);
      this.Controls.Add((Control) this.label220);
      this.Controls.Add((Control) this.label221);
      this.Controls.Add((Control) this.label222);
      this.Controls.Add((Control) this.label198);
      this.Controls.Add((Control) this.label200);
      this.Controls.Add((Control) this.label201);
      this.Controls.Add((Control) this.label202);
      this.Controls.Add((Control) this.label203);
      this.Controls.Add((Control) this.label204);
      this.Controls.Add((Control) this.label205);
      this.Controls.Add((Control) this.label206);
      this.Controls.Add((Control) this.label207);
      this.Controls.Add((Control) this.label208);
      this.Controls.Add((Control) this.label209);
      this.Controls.Add((Control) this.label210);
      this.Controls.Add((Control) this.label211);
      this.Controls.Add((Control) this.label212);
      this.Controls.Add((Control) this.label213);
      this.Controls.Add((Control) this.label214);
      this.Controls.Add((Control) this.label192);
      this.Controls.Add((Control) this.label193);
      this.Controls.Add((Control) this.label194);
      this.Controls.Add((Control) this.label195);
      this.Controls.Add((Control) this.label196);
      this.Controls.Add((Control) this.label199);
      this.Controls.Add((Control) this.label183);
      this.Controls.Add((Control) this.label184);
      this.Controls.Add((Control) this.label185);
      this.Controls.Add((Control) this.label186);
      this.Controls.Add((Control) this.label187);
      this.Controls.Add((Control) this.label188);
      this.Controls.Add((Control) this.label189);
      this.Controls.Add((Control) this.label190);
      this.Controls.Add((Control) this.label191);
      this.Controls.Add((Control) this.label174);
      this.Controls.Add((Control) this.label175);
      this.Controls.Add((Control) this.label176);
      this.Controls.Add((Control) this.label177);
      this.Controls.Add((Control) this.label178);
      this.Controls.Add((Control) this.label179);
      this.Controls.Add((Control) this.label180);
      this.Controls.Add((Control) this.label181);
      this.Controls.Add((Control) this.label182);
      this.Controls.Add((Control) this.label170);
      this.Controls.Add((Control) this.label171);
      this.Controls.Add((Control) this.label172);
      this.Controls.Add((Control) this.label173);
      this.Controls.Add((Control) this.label169);
      this.Controls.Add((Control) this.label166);
      this.Controls.Add((Control) this.label167);
      this.Controls.Add((Control) this.label168);
      this.Controls.Add((Control) this.label163);
      this.Controls.Add((Control) this.label164);
      this.Controls.Add((Control) this.label165);
      this.Controls.Add((Control) this.label119);
      this.Controls.Add((Control) this.label120);
      this.Controls.Add((Control) this.label121);
      this.Controls.Add((Control) this.label122);
      this.Controls.Add((Control) this.label123);
      this.Controls.Add((Control) this.label125);
      this.Controls.Add((Control) this.label126);
      this.Controls.Add((Control) this.label127);
      this.Controls.Add((Control) this.label128);
      this.Controls.Add((Control) this.label129);
      this.Controls.Add((Control) this.label130);
      this.Controls.Add((Control) this.label131);
      this.Controls.Add((Control) this.label132);
      this.Controls.Add((Control) this.label133);
      this.Controls.Add((Control) this.label134);
      this.Controls.Add((Control) this.label135);
      this.Controls.Add((Control) this.label136);
      this.Controls.Add((Control) this.label137);
      this.Controls.Add((Control) this.label138);
      this.Controls.Add((Control) this.label139);
      this.Controls.Add((Control) this.label140);
      this.Controls.Add((Control) this.label143);
      this.Controls.Add((Control) this.label144);
      this.Controls.Add((Control) this.label145);
      this.Controls.Add((Control) this.label146);
      this.Controls.Add((Control) this.label147);
      this.Controls.Add((Control) this.label148);
      this.Controls.Add((Control) this.label149);
      this.Controls.Add((Control) this.label150);
      this.Controls.Add((Control) this.label151);
      this.Controls.Add((Control) this.label152);
      this.Controls.Add((Control) this.label153);
      this.Controls.Add((Control) this.label154);
      this.Controls.Add((Control) this.label155);
      this.Controls.Add((Control) this.label156);
      this.Controls.Add((Control) this.label157);
      this.Controls.Add((Control) this.label158);
      this.Controls.Add((Control) this.label159);
      this.Controls.Add((Control) this.label160);
      this.Controls.Add((Control) this.label161);
      this.Controls.Add((Control) this.label162);
      this.Controls.Add((Control) this.label105);
      this.Controls.Add((Control) this.label106);
      this.Controls.Add((Control) this.label107);
      this.Controls.Add((Control) this.label108);
      this.Controls.Add((Control) this.label109);
      this.Controls.Add((Control) this.label110);
      this.Controls.Add((Control) this.label111);
      this.Controls.Add((Control) this.label112);
      this.Controls.Add((Control) this.label113);
      this.Controls.Add((Control) this.label114);
      this.Controls.Add((Control) this.label115);
      this.Controls.Add((Control) this.label116);
      this.Controls.Add((Control) this.label117);
      this.Controls.Add((Control) this.label118);
      this.Controls.Add((Control) this.label103);
      this.Controls.Add((Control) this.label104);
      this.Controls.Add((Control) this.label97);
      this.Controls.Add((Control) this.label99);
      this.Controls.Add((Control) this.label100);
      this.Controls.Add((Control) this.label101);
      this.Controls.Add((Control) this.label102);
      this.Controls.Add((Control) this.label93);
      this.Controls.Add((Control) this.label95);
      this.Controls.Add((Control) this.label96);
      this.Controls.Add((Control) this.label98);
      this.Controls.Add((Control) this.label90);
      this.Controls.Add((Control) this.label91);
      this.Controls.Add((Control) this.label92);
      this.Controls.Add((Control) this.label94);
      this.Controls.Add((Control) this.label86);
      this.Controls.Add((Control) this.label87);
      this.Controls.Add((Control) this.label88);
      this.Controls.Add((Control) this.label89);
      this.Controls.Add((Control) this.label75);
      this.Controls.Add((Control) this.label84);
      this.Controls.Add((Control) this.label85);
      this.Controls.Add((Control) this.label80);
      this.Controls.Add((Control) this.label81);
      this.Controls.Add((Control) this.label82);
      this.Controls.Add((Control) this.label83);
      this.Controls.Add((Control) this.label76);
      this.Controls.Add((Control) this.label77);
      this.Controls.Add((Control) this.label78);
      this.Controls.Add((Control) this.label79);
      this.Controls.Add((Control) this.label71);
      this.Controls.Add((Control) this.label72);
      this.Controls.Add((Control) this.label73);
      this.Controls.Add((Control) this.label74);
      this.Controls.Add((Control) this.label70);
      this.Controls.Add((Control) this.label67);
      this.Controls.Add((Control) this.label68);
      this.Controls.Add((Control) this.label69);
      this.Controls.Add((Control) this.label66);
      this.Controls.Add((Control) this.label64);
      this.Controls.Add((Control) this.label65);
      this.Controls.Add((Control) this.label61);
      this.Controls.Add((Control) this.label62);
      this.Controls.Add((Control) this.label63);
      this.Controls.Add((Control) this.label58);
      this.Controls.Add((Control) this.label59);
      this.Controls.Add((Control) this.label60);
      this.Controls.Add((Control) this.label42);
      this.Controls.Add((Control) this.label48);
      this.Controls.Add((Control) this.label51);
      this.Controls.Add((Control) this.label52);
      this.Controls.Add((Control) this.label53);
      this.Controls.Add((Control) this.label54);
      this.Controls.Add((Control) this.label55);
      this.Controls.Add((Control) this.label56);
      this.Controls.Add((Control) this.label57);
      this.Controls.Add((Control) this.label33);
      this.Controls.Add((Control) this.label34);
      this.Controls.Add((Control) this.label35);
      this.Controls.Add((Control) this.label36);
      this.Controls.Add((Control) this.label37);
      this.Controls.Add((Control) this.label38);
      this.Controls.Add((Control) this.label39);
      this.Controls.Add((Control) this.label40);
      this.Controls.Add((Control) this.label41);
      this.Controls.Add((Control) this.label50);
      this.Controls.Add((Control) this.label49);
      this.Controls.Add((Control) this.label45);
      this.Controls.Add((Control) this.label46);
      this.Controls.Add((Control) this.label47);
      this.Controls.Add((Control) this.label44);
      this.Controls.Add((Control) this.label43);
      this.Controls.Add((Control) this.label32);
      this.Controls.Add((Control) this.label18);
      this.Controls.Add((Control) this.label19);
      this.Controls.Add((Control) this.label20);
      this.Controls.Add((Control) this.label21);
      this.Controls.Add((Control) this.label22);
      this.Controls.Add((Control) this.label23);
      this.Controls.Add((Control) this.label24);
      this.Controls.Add((Control) this.label25);
      this.Controls.Add((Control) this.label26);
      this.Controls.Add((Control) this.label27);
      this.Controls.Add((Control) this.label28);
      this.Controls.Add((Control) this.label29);
      this.Controls.Add((Control) this.label30);
      this.Controls.Add((Control) this.label31);
      this.Controls.Add((Control) this.label12);
      this.Controls.Add((Control) this.label13);
      this.Controls.Add((Control) this.label14);
      this.Controls.Add((Control) this.label15);
      this.Controls.Add((Control) this.label16);
      this.Controls.Add((Control) this.label17);
      this.Controls.Add((Control) this.label8);
      this.Controls.Add((Control) this.label9);
      this.Controls.Add((Control) this.label10);
      this.Controls.Add((Control) this.label11);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.label7);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.score);
      this.Controls.Add((Control) this.pictureBox2);
      this.Controls.Add((Control) this.pictureBox1);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Cursor = Cursors.Default;
      this.DoubleBuffered = true;
      this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ForeColor = Color.Black;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MaximumSize = new Size(386, 469);
      this.MinimizeBox = false;
      this.MinimumSize = new Size(386, 469);
      this.Name = nameof (Form1);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Pac-Man";
      this.TransparencyKey = Color.Fuchsia;
      this.KeyDown += new KeyEventHandler(this.Form1_KeyDown);
      ((ISupportInitialize) this.pictureBox2).EndInit();
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((ISupportInitialize) this.pictureBox5).EndInit();
      ((ISupportInitialize) this.pictureBox4).EndInit();
      ((ISupportInitialize) this.pictureBox3).EndInit();
      ((ISupportInitialize) this.pacman).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
