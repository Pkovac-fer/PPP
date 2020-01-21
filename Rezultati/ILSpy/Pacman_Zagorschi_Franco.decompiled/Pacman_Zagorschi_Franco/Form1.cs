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

		public int temp = 1;

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

		public bool tresec = true;

		public int random1;

		public int random2;

		public int random3;

		public int random4;

		public int vita = 3;

		public int tic4;

		public int tic5;

		public int tic6;

		public int point;

		public int prec1;

		public int prec2;

		public int prec3;

		public int prec4;

		public int startdirection = 1;

		public int ghost1velocity = 2;

		public int ghost2velocity = 2;

		public int ghost3velocity = 2;

		public int ghost4velocity = 2;

		public Random rand = new Random();

		public List<object> oggetti = new List<object>();

		private IContainer components = null;

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
			Close();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
		}

		public Form1()
		{
			InitializeComponent();
			oggetti.Add(label4);
			oggetti.Add(label5);
			oggetti.Add(label6);
			oggetti.Add(label7);
			oggetti.Add(label8);
			oggetti.Add(label9);
			oggetti.Add(label10);
			oggetti.Add(label11);
			oggetti.Add(label12);
			oggetti.Add(label13);
			oggetti.Add(label14);
			oggetti.Add(label15);
			oggetti.Add(label16);
			oggetti.Add(label17);
			oggetti.Add(label18);
			oggetti.Add(label19);
			oggetti.Add(label20);
			oggetti.Add(label21);
			oggetti.Add(label22);
			oggetti.Add(label23);
			oggetti.Add(label24);
			oggetti.Add(label25);
			oggetti.Add(label26);
			oggetti.Add(label27);
			oggetti.Add(label28);
			oggetti.Add(label29);
			oggetti.Add(label30);
			oggetti.Add(label31);
			oggetti.Add(label32);
			oggetti.Add(label33);
			oggetti.Add(label34);
			oggetti.Add(label35);
			oggetti.Add(label36);
			oggetti.Add(label37);
			oggetti.Add(label38);
			oggetti.Add(label39);
			oggetti.Add(label40);
			oggetti.Add(label41);
			oggetti.Add(label42);
			oggetti.Add(label43);
			oggetti.Add(label44);
			oggetti.Add(label45);
			oggetti.Add(label46);
			oggetti.Add(label47);
			oggetti.Add(label48);
			oggetti.Add(label49);
			oggetti.Add(label50);
			oggetti.Add(label51);
			oggetti.Add(label52);
			oggetti.Add(label53);
			oggetti.Add(label54);
			oggetti.Add(label55);
			oggetti.Add(label56);
			oggetti.Add(label57);
			oggetti.Add(label58);
			oggetti.Add(label59);
			oggetti.Add(label60);
			oggetti.Add(label61);
			oggetti.Add(label62);
			oggetti.Add(label63);
			oggetti.Add(label64);
			oggetti.Add(label65);
			oggetti.Add(label66);
			oggetti.Add(label67);
			oggetti.Add(label68);
			oggetti.Add(label69);
			oggetti.Add(label70);
			oggetti.Add(label71);
			oggetti.Add(label72);
			oggetti.Add(label73);
			oggetti.Add(label74);
			oggetti.Add(label75);
			oggetti.Add(label76);
			oggetti.Add(label77);
			oggetti.Add(label78);
			oggetti.Add(label79);
			oggetti.Add(label80);
			oggetti.Add(label81);
			oggetti.Add(label82);
			oggetti.Add(label83);
			oggetti.Add(label84);
			oggetti.Add(label85);
			oggetti.Add(label86);
			oggetti.Add(label87);
			oggetti.Add(label88);
			oggetti.Add(label89);
			oggetti.Add(label90);
			oggetti.Add(label91);
			oggetti.Add(label92);
			oggetti.Add(label93);
			oggetti.Add(label94);
			oggetti.Add(label95);
			oggetti.Add(label96);
			oggetti.Add(label97);
			oggetti.Add(label98);
			oggetti.Add(label99);
			oggetti.Add(label100);
			oggetti.Add(label101);
			oggetti.Add(label102);
			oggetti.Add(label103);
			oggetti.Add(label104);
			oggetti.Add(label105);
			oggetti.Add(label106);
			oggetti.Add(label107);
			oggetti.Add(label108);
			oggetti.Add(label109);
			oggetti.Add(label110);
			oggetti.Add(label111);
			oggetti.Add(label112);
			oggetti.Add(label113);
			oggetti.Add(label114);
			oggetti.Add(label115);
			oggetti.Add(label116);
			oggetti.Add(label117);
			oggetti.Add(label118);
			oggetti.Add(label119);
			oggetti.Add(label120);
			oggetti.Add(label121);
			oggetti.Add(label122);
			oggetti.Add(label123);
			oggetti.Add(label125);
			oggetti.Add(label126);
			oggetti.Add(label127);
			oggetti.Add(label128);
			oggetti.Add(label129);
			oggetti.Add(label130);
			oggetti.Add(label131);
			oggetti.Add(label132);
			oggetti.Add(label133);
			oggetti.Add(label134);
			oggetti.Add(label135);
			oggetti.Add(label136);
			oggetti.Add(label137);
			oggetti.Add(label138);
			oggetti.Add(label139);
			oggetti.Add(label140);
			oggetti.Add(label143);
			oggetti.Add(label144);
			oggetti.Add(label145);
			oggetti.Add(label146);
			oggetti.Add(label147);
			oggetti.Add(label148);
			oggetti.Add(label149);
			oggetti.Add(label150);
			oggetti.Add(label151);
			oggetti.Add(label152);
			oggetti.Add(label153);
			oggetti.Add(label154);
			oggetti.Add(label155);
			oggetti.Add(label156);
			oggetti.Add(label157);
			oggetti.Add(label158);
			oggetti.Add(label159);
			oggetti.Add(label160);
			oggetti.Add(label161);
			oggetti.Add(label162);
			oggetti.Add(label163);
			oggetti.Add(label164);
			oggetti.Add(label165);
			oggetti.Add(label166);
			oggetti.Add(label167);
			oggetti.Add(label168);
			oggetti.Add(label169);
			oggetti.Add(label170);
			oggetti.Add(label171);
			oggetti.Add(label172);
			oggetti.Add(label173);
			oggetti.Add(label174);
			oggetti.Add(label175);
			oggetti.Add(label176);
			oggetti.Add(label177);
			oggetti.Add(label178);
			oggetti.Add(label179);
			oggetti.Add(label180);
			oggetti.Add(label181);
			oggetti.Add(label182);
			oggetti.Add(label183);
			oggetti.Add(label184);
			oggetti.Add(label185);
			oggetti.Add(label186);
			oggetti.Add(label187);
			oggetti.Add(label188);
			oggetti.Add(label189);
			oggetti.Add(label190);
			oggetti.Add(label191);
			oggetti.Add(label192);
			oggetti.Add(label193);
			oggetti.Add(label194);
			oggetti.Add(label195);
			oggetti.Add(label196);
			oggetti.Add(label197);
			oggetti.Add(label198);
			oggetti.Add(label199);
			oggetti.Add(label200);
			oggetti.Add(label201);
			oggetti.Add(label202);
			oggetti.Add(label203);
			oggetti.Add(label204);
			oggetti.Add(label205);
			oggetti.Add(label206);
			oggetti.Add(label207);
			oggetti.Add(label208);
			oggetti.Add(label209);
			oggetti.Add(label210);
			oggetti.Add(label211);
			oggetti.Add(label212);
			oggetti.Add(label213);
			oggetti.Add(label214);
			oggetti.Add(label215);
			oggetti.Add(label216);
			oggetti.Add(label217);
			oggetti.Add(label218);
			oggetti.Add(label219);
			oggetti.Add(label220);
			oggetti.Add(label221);
			oggetti.Add(label222);
			oggetti.Add(label223);
			oggetti.Add(label224);
			oggetti.Add(label225);
			oggetti.Add(label226);
			oggetti.Add(label227);
			oggetti.Add(label228);
			oggetti.Add(label229);
			oggetti.Add(label230);
			oggetti.Add(label231);
			oggetti.Add(label232);
			oggetti.Add(label233);
			oggetti.Add(label234);
			oggetti.Add(label235);
			oggetti.Add(label236);
			oggetti.Add(label237);
			oggetti.Add(label238);
			oggetti.Add(label239);
			oggetti.Add(label240);
			oggetti.Add(label241);
			oggetti.Add(label242);
			oggetti.Add(label243);
			oggetti.Add(label244);
			oggetti.Add(label245);
			oggetti.Add(label246);
			oggetti.Add(label247);
			oggetti.Add(label248);
			oggetti.Add(label249);
			oggetti.Add(label250);
			oggetti.Add(label251);
			oggetti.Add(label252);
			oggetti.Add(label256);
			oggetti.Add(label257);
			oggetti.Add(label258);
			oggetti.Add(label259);
			oggetti.Add(label260);
			oggetti.Add(label261);
			oggetti.Add(label262);
			oggetti.Add(label263);
			oggetti.Add(label264);
			oggetti.Add(label265);
			oggetti.Add(label266);
			oggetti.Add(label267);
			oggetti.Add(label268);
			oggetti.Add(label269);
			oggetti.Add(label270);
			oggetti.Add(label271);
			oggetti.Add(label272);
			oggetti.Add(label273);
			oggetti.Add(label274);
			oggetti.Add(label275);
			oggetti.Add(label276);
			oggetti.Add(label277);
			oggetti.Add(label278);
			oggetti.Add(label279);
			oggetti.Add(label280);
			oggetti.Add(label281);
			oggetti.Add(label282);
			oggetti.Add(label283);
			oggetti.Add(label284);
			oggetti.Add(label285);
			oggetti.Add(label286);
			oggetti.Add(label287);
			oggetti.Add(label288);
			oggetti.Add(label289);
			oggetti.Add(label290);
			oggetti.Add(label291);
			oggetti.Add(label292);
			oggetti.Add(label293);
			oggetti.Add(label294);
			oggetti.Add(label295);
			oggetti.Add(label296);
			oggetti.Add(label297);
			oggetti.Add(label298);
			oggetti.Add(label299);
			oggetti.Add(label300);
			oggetti.Add(label301);
			oggetti.Add(label302);
			oggetti.Add(label303);
			oggetti.Add(label304);
			oggetti.Add(label305);
			oggetti.Add(label306);
			oggetti.Add(label307);
			oggetti.Add(label308);
			oggetti.Add(label309);
			oggetti.Add(label310);
			oggetti.Add(label311);
			oggetti.Add(label312);
			oggetti.Add(label313);
			oggetti.Add(label314);
			oggetti.Add(label315);
			oggetti.Add(label316);
			oggetti.Add(label317);
			oggetti.Add(label318);
			oggetti.Add(label319);
			oggetti.Add(label320);
			oggetti.Add(label321);
			oggetti.Add(label322);
			oggetti.Add(label323);
			oggetti.Add(label324);
			oggetti.Add(label325);
			oggetti.Add(label326);
			oggetti.Add(label327);
			oggetti.Add(label328);
			oggetti.Add(label329);
			oggetti.Add(label330);
			oggetti.Add(label331);
			oggetti.Add(label332);
			oggetti.Add(label333);
			oggetti.Add(label334);
			oggetti.Add(label335);
			oggetti.Add(label336);
			oggetti.Add(label337);
			oggetti.Add(label338);
			oggetti.Add(label339);
			oggetti.Add(label340);
			oggetti.Add(label341);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			start = true;
			life();
			points();
			panel1.Visible = false;
			resetall();
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Left)
			{
				next = 1;
			}
			if (e.KeyCode == Keys.Right)
			{
				next = 2;
			}
			if (e.KeyCode == Keys.Up)
			{
				next = 3;
			}
			if (e.KeyCode == Keys.Down)
			{
				next = 4;
			}
			if (e.KeyCode == Keys.Escape)
			{
				Close();
			}
			temp = next;
		}

		private void button1_MouseLeave(object sender, EventArgs e)
		{
			button1.Image = Resources.playgame;
		}

		private void button1_MouseEnter(object sender, EventArgs e)
		{
			button1.Image = Resources.playgame2;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (pacman.Enabled)
			{
				direction();
				freedirection();
			}
			if (ghost1.Enabled || ghost2.Enabled || ghost3.Enabled || ghost4.Enabled)
			{
				ghost();
			}
			if (c)
			{
				control();
			}
			supermod();
			points();
			collision();
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			label3.Visible = false;
			timer1.Enabled = true;
			timer2.Enabled = false;
			c = true;
		}

		private void timer3_Tick(object sender, EventArgs e)
		{
			if (ghost2.Top == 180)
			{
				startdirection = 2;
			}
			if (ghost2.Top == 192)
			{
				startdirection = 1;
			}
			if (startdirection == 1)
			{
				ghost2.Top--;
				ghost4.Top--;
			}
			if (startdirection == 2)
			{
				ghost2.Top++;
				ghost4.Top++;
			}
		}

		private void timer4_Tick(object sender, EventArgs e)
		{
			tic4++;
			if (ghost3.Top > 150 && tic4 > 100)
			{
				prec1 = 3;
				ghost3.Top--;
			}
			if (ghost3.Top == 150)
			{
				timer4.Enabled = false;
			}
		}

		private void timer5_Tick(object sender, EventArgs e)
		{
			tic5++;
			if (ghost2.Left > 153 && ghost2.Left < 176 && tic5 > 300)
			{
				ghost2.Left++;
			}
			if (ghost2.Top > 150 && ghost2.Left == 176)
			{
				ghost2.Top--;
			}
			if (ghost2.Top == 150)
			{
				timer6.Enabled = true;
				timer5.Enabled = false;
			}
		}

		private void timer6_Tick(object sender, EventArgs e)
		{
			tic6++;
			if (ghost4.Left > 176 && ghost4.Left < 200 && tic6 > 100)
			{
				ghost4.Left--;
			}
			if (ghost4.Top > 150 && ghost4.Left == 176)
			{
				ghost4.Top--;
			}
			if (ghost4.Top == 150)
			{
				timer6.Enabled = false;
			}
		}

		private void powermod_Tick(object sender, EventArgs e)
		{
			tresec = false;
			if (!g1mangiato)
			{
				v1 = false;
				ghost1puomangiare = true;
				Supermod1 = false;
				ghost1velocity = 2;
			}
			if (!g2mangiato)
			{
				v2 = false;
				ghost2puomangiare = true;
				Supermod2 = false;
				ghost2velocity = 2;
			}
			if (!g3mangiato)
			{
				v3 = false;
				ghost3puomangiare = true;
				Supermod3 = false;
				ghost3velocity = 2;
			}
			if (!g4mangiato)
			{
				v4 = false;
				ghost4puomangiare = true;
				Supermod4 = false;
				ghost4velocity = 2;
			}
			Supermod = false;
			powermod.Enabled = false;
			powermod1.Enabled = false;
			if (prec1 == 1 && !g1mangiato)
			{
				if (ghost1.Left % 2 == 0)
				{
					leftghost1 = ghost1velocity;
				}
				ghost1.Image = Resources.rdx;
			}
			if (prec1 == 2 && !g1mangiato)
			{
				if (ghost1.Left % 2 == 0)
				{
					leftghost1 = -ghost1velocity;
				}
				ghost1.Image = Resources.rsx;
			}
			if (prec1 == 3 && !g1mangiato)
			{
				if (ghost1.Top % 2 == 0)
				{
					topghost1 = -ghost1velocity;
				}
				ghost1.Image = Resources.rup;
			}
			if (prec1 == 4 && !g1mangiato)
			{
				if (ghost1.Top % 2 == 0)
				{
					topghost1 = ghost1velocity;
				}
				ghost1.Image = Resources.rdown;
			}
			if (prec2 == 1 && !g2mangiato)
			{
				if (ghost2.Left % 2 == 0)
				{
					leftghost2 = ghost2velocity;
				}
				ghost2.Image = Resources.adx;
			}
			if (prec2 == 2 && !g2mangiato)
			{
				if (ghost2.Left % 2 == 0)
				{
					leftghost2 = -ghost2velocity;
				}
				ghost2.Image = Resources.asx;
			}
			if (prec2 == 3 && !g2mangiato)
			{
				if (ghost2.Top % 2 == 0)
				{
					topghost2 = -ghost2velocity;
				}
				ghost2.Image = Resources.aup;
			}
			if (prec2 == 4 && !g2mangiato)
			{
				if (ghost2.Top % 2 == 0)
				{
					topghost2 = ghost2velocity;
				}
				ghost2.Image = Resources.adown;
			}
			if (prec3 == 1 && !g3mangiato)
			{
				if (ghost3.Left % 2 == 0)
				{
					leftghost3 = ghost3velocity;
				}
				ghost3.Image = Resources.vdx;
			}
			if (prec3 == 2 && !g3mangiato)
			{
				if (ghost3.Left % 2 == 0)
				{
					leftghost3 = -ghost3velocity;
				}
				ghost3.Image = Resources.vsx;
			}
			if (prec3 == 3 && !g3mangiato)
			{
				if (ghost3.Top % 2 == 0)
				{
					topghost3 = -ghost3velocity;
				}
				ghost3.Image = Resources.vup;
			}
			if (prec3 == 4 && !g3mangiato)
			{
				if (ghost3.Top % 2 == 0)
				{
					topghost3 = ghost3velocity;
				}
				ghost3.Image = Resources.vdown;
			}
			if (prec4 == 1 && !g4mangiato)
			{
				if (ghost4.Left % 2 == 0)
				{
					leftghost4 = ghost4velocity;
				}
				ghost4.Image = Resources.gdx;
			}
			if (prec4 == 2 && !g4mangiato)
			{
				if (ghost4.Left % 2 == 0)
				{
					leftghost4 = -ghost4velocity;
				}
				ghost4.Image = Resources.gsx;
			}
			if (prec4 == 3 && !g4mangiato)
			{
				if (ghost4.Top % 2 == 0)
				{
					topghost4 = -ghost4velocity;
				}
				ghost4.Image = Resources.gup;
			}
			if (prec4 == 4 && !g4mangiato)
			{
				if (ghost4.Top % 2 == 0)
				{
					topghost4 = ghost4velocity;
				}
				ghost1.Image = Resources.gdown;
			}
		}

		private void timer8_Tick(object sender, EventArgs e)
		{
			pacman.SetBounds(pacman.Left, pacman.Top, 0, 0);
			g1mangiato = false;
			g2mangiato = false;
			g3mangiato = false;
			g4mangiato = false;
			v1 = false;
			v2 = false;
			v3 = false;
			v4 = false;
			ghost1puomangiare = true;
			ghost2puomangiare = true;
			ghost3puomangiare = true;
			ghost4puomangiare = true;
			ghost1.Visible = false;
			ghost2.Visible = false;
			ghost3.Visible = false;
			ghost4.Visible = false;
			pacman.Visible = false;
			tic4 = 0;
			tic5 = 0;
			tic6 = 0;
			Supermod = false;
			Supermod1 = false;
			Supermod2 = false;
			Supermod3 = false;
			Supermod4 = false;
			ghost1velocity = 2;
			ghost2velocity = 2;
			ghost3velocity = 2;
			ghost4velocity = 2;
			vita--;
			life();
			prec1 = 0;
			prec2 = 0;
			prec3 = 0;
			prec4 = 0;
			startdirection = 1;
			dir1 = false;
			dir2 = false;
			dir3 = false;
			dir4 = false;
			c = false;
			next = 0;
			temp = 1;
			direzione = 0;
			pacman.Left = 24;
			pacman.Top = 364;
			ghost1.Left = 176;
			ghost1.Top = 150;
			ghost2.Left = 154;
			ghost2.Top = 185;
			ghost3.Left = 176;
			ghost3.Top = 185;
			ghost4.Left = 199;
			ghost4.Top = 185;
			leftghost1 = 0;
			leftghost2 = 0;
			leftghost3 = 0;
			leftghost4 = 0;
			topghost1 = 0;
			topghost2 = 0;
			topghost3 = 0;
			topghost4 = 0;
			left = 0;
			top = 0;
			timer8.Enabled = false;
			pacman.Image = Resources._1dx;
			ghost1.Image = Resources.rup;
			ghost2.Image = Resources.aup;
			ghost3.Image = Resources.vup;
			ghost4.Image = Resources.gup;
			ghost1.Visible = true;
			ghost2.Visible = true;
			ghost3.Visible = true;
			ghost4.Visible = true;
			pacman.SetBounds(pacman.Left, pacman.Top, 22, 22);
			pacman.Visible = true;
			timer2.Enabled = true;
			timer3.Enabled = true;
			timer8.Interval = 1900;
		}

		private void timer9_Tick(object sender, EventArgs e)
		{
			pictureBox3.Visible = true;
			button1.Visible = true;
			timer9.Enabled = false;
		}

		private void resetall()
		{
			g1mangiato = false;
			g2mangiato = false;
			g3mangiato = false;
			g4mangiato = false;
			v1 = false;
			v2 = false;
			v3 = false;
			v4 = false;
			ghost1puomangiare = true;
			ghost2puomangiare = true;
			ghost3puomangiare = true;
			ghost4puomangiare = true;
			label124.Visible = false;
			label141.Visible = false;
			pacman.SetBounds(pacman.Left, pacman.Top, 22, 22);
			tic4 = 0;
			tic5 = 0;
			tic6 = 0;
			Supermod = false;
			Supermod1 = false;
			Supermod2 = false;
			Supermod3 = false;
			Supermod4 = false;
			ghost1velocity = 2;
			ghost2velocity = 2;
			ghost3velocity = 2;
			ghost4velocity = 2;
			life();
			prec1 = 0;
			prec2 = 0;
			prec3 = 0;
			prec4 = 0;
			startdirection = 1;
			dir1 = false;
			dir2 = false;
			dir3 = false;
			dir4 = false;
			c = false;
			next = 0;
			temp = 1;
			direzione = 0;
			pacman.Left = 24;
			pacman.Top = 364;
			ghost1.Left = 176;
			ghost1.Top = 150;
			ghost2.Left = 154;
			ghost2.Top = 185;
			ghost3.Left = 176;
			ghost3.Top = 185;
			ghost4.Left = 199;
			ghost4.Top = 185;
			leftghost1 = 0;
			leftghost2 = 0;
			leftghost3 = 0;
			leftghost4 = 0;
			topghost1 = 0;
			topghost2 = 0;
			topghost3 = 0;
			topghost4 = 0;
			left = 0;
			top = 0;
			pacman.Image = Resources._1dx;
			ghost1.Image = Resources.rup;
			ghost2.Image = Resources.aup;
			ghost3.Image = Resources.vup;
			ghost4.Image = Resources.gup;
			timer1.Enabled = false;
			timer4.Enabled = false;
			timer5.Enabled = false;
			timer6.Enabled = false;
			timer7.Enabled = false;
			timer8.Enabled = false;
			powermod.Enabled = false;
			powermod1.Enabled = false;
			if (start)
			{
				timer2.Enabled = true;
				timer3.Enabled = true;
			}
			start = false;
			for (int i = 0; i < 332; i++)
			{
				((Label)oggetti[i]).Visible = true;
			}
		}

		private void timer7_Tick(object sender, EventArgs e)
		{
			timer7.Enabled = false;
			panel1.Visible = true;
			attendo.Enabled = true;
		}

		private void attendo_Tick(object sender, EventArgs e)
		{
			resetall();
			attendo.Enabled = false;
		}

		private void control()
		{
			if (ghost2.Top == 185)
			{
				timer3.Enabled = false;
				timer4.Enabled = true;
				c = false;
				timer5.Enabled = true;
			}
		}

		private void life()
		{
			if (vita == 3)
			{
				pictureBox1.Visible = true;
				pictureBox2.Visible = true;
			}
			if (vita == 2)
			{
				pictureBox1.Visible = true;
				pictureBox2.Visible = false;
			}
			if (vita == 1)
			{
				pictureBox1.Visible = false;
				pictureBox2.Visible = false;
			}
		}

		private void supermod()
		{
			if (pacman.Bounds.IntersectsWith(label173.Bounds) && label173.Visible)
			{
				supermod2();
			}
			if (pacman.Bounds.IntersectsWith(label307.Bounds) && label307.Visible)
			{
				supermod2();
			}
			if (pacman.Bounds.IntersectsWith(label220.Bounds) && label220.Visible)
			{
				supermod2();
			}
			if (pacman.Bounds.IntersectsWith(label71.Bounds) && label71.Visible)
			{
				supermod2();
			}
		}

		private void supermod2()
		{
			if (!g1mangiato)
			{
				v1 = false;
				ghost1velocity = 2;
				Supermod1 = true;
				ghost1.Image = Resources.crazy;
				ghost1puomangiare = true;
			}
			if (!g2mangiato)
			{
				v2 = false;
				ghost2velocity = 2;
				Supermod2 = true;
				ghost2.Image = Resources.crazy;
				ghost2puomangiare = true;
			}
			if (!g3mangiato)
			{
				v3 = false;
				ghost3velocity = 2;
				Supermod3 = true;
				ghost3.Image = Resources.crazy;
				ghost3puomangiare = true;
			}
			if (!g4mangiato)
			{
				v4 = false;
				ghost4velocity = 2;
				Supermod4 = true;
				ghost4.Image = Resources.crazy;
				ghost4puomangiare = true;
			}
			powermod.Enabled = false;
			powermod1.Enabled = false;
			powermod1.Enabled = true;
			tresec = false;
			powermod.Enabled = true;
			Supermod = true;
		}

		private void powermod1_Tick(object sender, EventArgs e)
		{
			tresec = true;
			powermod1.Enabled = false;
		}

		private void collision()
		{
			if (!pacman.Bounds.IntersectsWith(ghost1.Bounds) && !pacman.Bounds.IntersectsWith(ghost2.Bounds) && !pacman.Bounds.IntersectsWith(ghost3.Bounds) && !pacman.Bounds.IntersectsWith(ghost4.Bounds))
			{
				return;
			}
			if (pacman.Bounds.IntersectsWith(ghost1.Bounds) && !Supermod1)
			{
				mangiato();
			}
			if (pacman.Bounds.IntersectsWith(ghost2.Bounds) && !Supermod2)
			{
				mangiato();
			}
			if (pacman.Bounds.IntersectsWith(ghost3.Bounds) && !Supermod3)
			{
				mangiato();
			}
			if (pacman.Bounds.IntersectsWith(ghost4.Bounds) && !Supermod4)
			{
				mangiato();
			}
			if (Supermod)
			{
				if (pacman.Bounds.IntersectsWith(ghost1.Bounds) && !Supermod1)
				{
					mangiato();
				}
				if (pacman.Bounds.IntersectsWith(ghost2.Bounds) && !Supermod2)
				{
					mangiato();
				}
				if (pacman.Bounds.IntersectsWith(ghost3.Bounds) && !Supermod3)
				{
					mangiato();
				}
				if (pacman.Bounds.IntersectsWith(ghost4.Bounds) && !Supermod4)
				{
					mangiato();
				}
			}
			if (pacman.Bounds.IntersectsWith(ghost1.Bounds) && ghost1puomangiare && Supermod1)
			{
				g1mangiato = true;
				v1 = true;
				ghost1puomangiare = false;
				timer1.Enabled = false;
				ghostmangiato.Enabled = true;
				ghost1velocity = 4;
			}
			if (pacman.Bounds.IntersectsWith(ghost2.Bounds) && ghost2puomangiare && Supermod2)
			{
				g2mangiato = true;
				v2 = true;
				ghost2puomangiare = false;
				timer1.Enabled = false;
				ghostmangiato.Enabled = true;
				ghost2velocity = 4;
			}
			if (pacman.Bounds.IntersectsWith(ghost3.Bounds) && ghost3puomangiare && Supermod3)
			{
				g3mangiato = true;
				v3 = true;
				ghost3puomangiare = false;
				timer1.Enabled = false;
				ghostmangiato.Enabled = true;
				ghost3velocity = 4;
			}
			if (pacman.Bounds.IntersectsWith(ghost4.Bounds) && ghost4puomangiare && Supermod4)
			{
				g4mangiato = true;
				v4 = true;
				ghost4puomangiare = false;
				timer1.Enabled = false;
				ghostmangiato.Enabled = true;
				ghost4velocity = 4;
			}
		}

		private void ghostmangiato_Tick(object sender, EventArgs e)
		{
			timer1.Enabled = true;
			ghostmangiato.Enabled = false;
		}

		private void mangiato()
		{
			pacman.Image = Resources.pacmorto;
			if (vita - 1 <= 0)
			{
				label124.Visible = true;
				finepartita();
				return;
			}
			top = 0;
			left = 0;
			topghost1 = 0;
			topghost2 = 0;
			topghost3 = 0;
			topghost4 = 0;
			leftghost1 = 0;
			leftghost2 = 0;
			leftghost3 = 0;
			leftghost4 = 0;
			timer1.Enabled = false;
			timer4.Enabled = false;
			timer5.Enabled = false;
			timer6.Enabled = false;
			pacturn = false;
			ghost1turn = false;
			ghost2turn = false;
			ghost3turn = false;
			ghost4turn = false;
			timer8.Enabled = true;
		}

		private void points()
		{
			for (int i = 0; i < 332; i++)
			{
				if (((Label)oggetti[i]).Visible && pacman.Bounds.IntersectsWith(((Label)oggetti[i]).Bounds))
				{
					point++;
					((Label)oggetti[i]).Visible = false;
				}
			}
			score.Text = point.ToString();
			if (point >= 332)
			{
				finepartita();
				label141.Visible = true;
			}
		}

		private void finepartita()
		{
			point = 0;
			vita = 3;
			timer1.Enabled = false;
			timer2.Enabled = false;
			timer3.Enabled = false;
			timer4.Enabled = false;
			timer5.Enabled = false;
			timer6.Enabled = false;
			powermod1.Enabled = false;
			powermod.Enabled = false;
			timer7.Enabled = true;
		}

		private void freedirection()
		{
			switch (direzione)
			{
			case 1:
				if (next == 2)
				{
					left = 2;
					pacman.Image = Resources.pacdx;
					direzione = next;
					temp = next;
				}
				break;
			case 2:
				if (next == 1)
				{
					left = -2;
					pacman.Image = Resources.pacsx;
					direzione = next;
					temp = next;
				}
				break;
			case 3:
				if (next == 4)
				{
					top = 2;
					pacman.Image = Resources.pacdown;
					direzione = next;
					temp = next;
				}
				break;
			case 4:
				if (next == 3)
				{
					top = -2;
					pacman.Image = Resources.pacup;
					direzione = next;
					temp = next;
				}
				break;
			}
		}

		private void leftright(int i, int y, int n, int m)
		{
			if (ghost1turn)
			{
				if (Supermod1 && !ghost1puomangiare)
				{
					if ((ghost1.Left < 180 && ghost1.Top == 150) || (ghost1.Left > 170 && ghost1.Top == 150))
					{
						ghost1velocity = 2;
						Supermod1 = false;
						v1 = false;
						ghost1puomangiare = true;
						g1mangiato = false;
					}
					else
					{
						if (ghost1.Top < 150 && n == 1 && m == 1)
						{
							n = 0;
						}
						if (ghost1.Top > 150 && n == 1 && m == 1)
						{
							m = 0;
						}
						if (ghost1.Left < 176 && i == 1 && y == 1)
						{
							i = 0;
						}
						if (ghost1.Left > 176 && i == 1 && y == 1)
						{
							y = 0;
						}
					}
				}
				topghost1 = 0;
				leftghost1 = 0;
				while (!dir1)
				{
					random1 = rand.Next(1, 5);
					if (random1 == 1 && !dir1 && random1 != prec1 && i == 1)
					{
						leftghost1 = -ghost1velocity;
						dir1 = true;
						if (!Supermod1 && ghost1puomangiare)
						{
							ghost1.Image = Resources.rsx;
						}
						else if (!tresec || g1mangiato)
						{
							if (!tresec)
							{
								ghost1.Image = Resources.crazy;
							}
							if (g1mangiato)
							{
								ghost1.Image = Resources.msx;
							}
						}
						else
						{
							ghost1.Image = Resources.tempo;
						}
					}
					if (random1 == 2 && !dir1 && random1 != prec1 && y == 1)
					{
						leftghost1 = ghost1velocity;
						dir1 = true;
						if (!Supermod1 && ghost1puomangiare)
						{
							ghost1.Image = Resources.rdx;
						}
						else if (!tresec || g1mangiato)
						{
							if (!tresec)
							{
								ghost1.Image = Resources.crazy;
							}
							if (g1mangiato)
							{
								ghost1.Image = Resources.mdx;
							}
						}
						else
						{
							ghost1.Image = Resources.tempo;
						}
					}
					if (random1 == 3 && !dir1 && random1 != prec1 && m == 1)
					{
						topghost1 = ghost1velocity;
						dir1 = true;
						if (!Supermod1 && ghost1puomangiare)
						{
							ghost1.Image = Resources.rdown;
						}
						else if (!tresec || g1mangiato)
						{
							if (!tresec)
							{
								ghost1.Image = Resources.crazy;
							}
							if (g1mangiato)
							{
								ghost1.Image = Resources.mdown;
							}
						}
						else
						{
							ghost1.Image = Resources.tempo;
						}
					}
					if (random1 != 4 || dir1 || random1 == prec1 || n != 1)
					{
						continue;
					}
					topghost1 = -ghost1velocity;
					dir1 = true;
					if (!Supermod1 && ghost1puomangiare)
					{
						ghost1.Image = Resources.rup;
					}
					else if (!tresec || g1mangiato)
					{
						if (!tresec)
						{
							ghost1.Image = Resources.crazy;
						}
						if (g1mangiato)
						{
							ghost1.Image = Resources.mup1;
						}
					}
					else
					{
						ghost1.Image = Resources.tempo;
					}
				}
				if (random1 == 1)
				{
					prec1 = 2;
				}
				if (random1 == 2)
				{
					prec1 = 1;
				}
				if (random1 == 3)
				{
					prec1 = 4;
				}
				if (random1 == 4)
				{
					prec1 = 3;
				}
				dir1 = false;
			}
			if (ghost2turn)
			{
				if (Supermod2 && !ghost2puomangiare)
				{
					if ((ghost2.Left < 180 && ghost2.Top == 150) || (ghost2.Left > 170 && ghost2.Top == 150))
					{
						ghost2velocity = 2;
						Supermod2 = false;
						v2 = false;
						ghost2puomangiare = true;
						g2mangiato = false;
					}
					else
					{
						if (ghost2.Top < 150 && n == 1 && m == 1)
						{
							n = 0;
						}
						if (ghost2.Top > 150 && n == 1 && m == 1)
						{
							m = 0;
						}
						if (ghost2.Left < 176 && i == 1 && y == 1)
						{
							i = 0;
						}
						if (ghost2.Left > 176 && i == 1 && y == 1)
						{
							y = 0;
						}
					}
				}
				topghost2 = 0;
				leftghost2 = 0;
				while (!dir2)
				{
					random2 = rand.Next(1, 5);
					if (random2 == 1 && !dir2 && random2 != prec2 && i == 1)
					{
						leftghost2 = -ghost2velocity;
						dir2 = true;
						if (!Supermod2 && ghost2puomangiare)
						{
							ghost2.Image = Resources.asx;
						}
						else if (!tresec || g2mangiato)
						{
							if (!tresec)
							{
								ghost2.Image = Resources.crazy;
							}
							if (g2mangiato)
							{
								ghost2.Image = Resources.msx;
							}
						}
						else
						{
							ghost2.Image = Resources.tempo;
						}
					}
					if (random2 == 2 && !dir2 && random2 != prec2 && y == 1)
					{
						leftghost2 = ghost2velocity;
						dir2 = true;
						if (!Supermod2 && ghost2puomangiare)
						{
							ghost2.Image = Resources.adx;
						}
						else if (!tresec || g2mangiato)
						{
							if (!tresec)
							{
								ghost2.Image = Resources.crazy;
							}
							if (g2mangiato)
							{
								ghost2.Image = Resources.mdx;
							}
						}
						else
						{
							ghost2.Image = Resources.tempo;
						}
					}
					if (random2 == 3 && !dir2 && random2 != prec2 && m == 1)
					{
						topghost2 = ghost2velocity;
						dir2 = true;
						if (!Supermod2 && ghost2puomangiare)
						{
							ghost2.Image = Resources.adown;
						}
						else if (!tresec || g2mangiato)
						{
							if (!tresec)
							{
								ghost2.Image = Resources.crazy;
							}
							if (g2mangiato)
							{
								ghost2.Image = Resources.mdown;
							}
						}
						else
						{
							ghost2.Image = Resources.tempo;
						}
					}
					if (random2 != 4 || dir2 || random2 == prec2 || n != 1)
					{
						continue;
					}
					topghost2 = -ghost2velocity;
					dir2 = true;
					if (!Supermod2 && ghost2puomangiare)
					{
						ghost2.Image = Resources.aup;
					}
					else if (!tresec || g2mangiato)
					{
						if (!tresec)
						{
							ghost2.Image = Resources.crazy;
						}
						if (g2mangiato)
						{
							ghost2.Image = Resources.mup1;
						}
					}
					else
					{
						ghost2.Image = Resources.tempo;
					}
				}
				if (random2 == 1)
				{
					prec2 = 2;
				}
				if (random2 == 2)
				{
					prec2 = 1;
				}
				if (random2 == 3)
				{
					prec2 = 4;
				}
				if (random2 == 4)
				{
					prec2 = 3;
				}
				dir2 = false;
			}
			if (ghost3turn)
			{
				if (Supermod3 && !ghost3puomangiare)
				{
					if ((ghost3.Left < 180 && ghost3.Top == 150) || (ghost3.Left > 170 && ghost3.Top == 150))
					{
						ghost3velocity = 2;
						Supermod3 = false;
						v3 = false;
						ghost3puomangiare = true;
						g3mangiato = false;
					}
					else
					{
						if (ghost3.Top > 150 && n == 1 && m == 1)
						{
							m = 0;
						}
						if (ghost3.Top < 150 && n == 1 && m == 1)
						{
							n = 0;
						}
						if (ghost3.Left < 176 && i == 1 && y == 1)
						{
							i = 0;
						}
						if (ghost3.Left > 176 && i == 1 && y == 1)
						{
							y = 0;
						}
					}
				}
				topghost3 = 0;
				leftghost3 = 0;
				while (!dir3)
				{
					random3 = rand.Next(1, 5);
					if (random3 == 1 && !dir3 && random3 != prec3 && i == 1)
					{
						leftghost3 = -ghost3velocity;
						dir3 = true;
						if (!Supermod3 && ghost3puomangiare)
						{
							ghost3.Image = Resources.vsx;
						}
						else if (!tresec || g3mangiato)
						{
							if (!tresec)
							{
								ghost3.Image = Resources.crazy;
							}
							if (g3mangiato)
							{
								ghost3.Image = Resources.msx;
							}
						}
						else
						{
							ghost3.Image = Resources.tempo;
						}
					}
					if (random3 == 2 && !dir3 && random3 != prec3 && y == 1)
					{
						leftghost3 = ghost3velocity;
						dir3 = true;
						if (!Supermod3 && ghost3puomangiare)
						{
							ghost3.Image = Resources.vdx;
						}
						else if (!tresec || g3mangiato)
						{
							if (!tresec)
							{
								ghost3.Image = Resources.crazy;
							}
							if (g3mangiato)
							{
								ghost3.Image = Resources.mdx;
							}
						}
						else
						{
							ghost3.Image = Resources.tempo;
						}
					}
					if (random3 == 3 && !dir3 && random3 != prec3 && m == 1)
					{
						topghost3 = ghost3velocity;
						dir3 = true;
						if (!Supermod3 && ghost3puomangiare)
						{
							ghost3.Image = Resources.vdown;
						}
						else if (!tresec || g3mangiato)
						{
							if (!tresec)
							{
								ghost3.Image = Resources.crazy;
							}
							if (g3mangiato)
							{
								ghost3.Image = Resources.mdown;
							}
						}
						else
						{
							ghost3.Image = Resources.tempo;
						}
					}
					if (random3 != 4 || dir3 || random3 == prec3 || n != 1)
					{
						continue;
					}
					topghost3 = -ghost3velocity;
					dir3 = true;
					if (!Supermod3 && ghost3puomangiare)
					{
						ghost3.Image = Resources.vup;
					}
					else if (!tresec || g3mangiato)
					{
						if (!tresec)
						{
							ghost3.Image = Resources.crazy;
						}
						if (g3mangiato)
						{
							ghost3.Image = Resources.mup1;
						}
					}
					else
					{
						ghost3.Image = Resources.tempo;
					}
				}
				if (random3 == 1)
				{
					prec3 = 2;
				}
				if (random3 == 2)
				{
					prec3 = 1;
				}
				if (random3 == 3)
				{
					prec3 = 4;
				}
				if (random3 == 4)
				{
					prec3 = 3;
				}
				dir3 = false;
			}
			if (ghost4turn)
			{
				if (Supermod4 && !ghost4puomangiare)
				{
					if ((ghost4.Left < 180 && ghost4.Top == 150) || (ghost4.Left > 170 && ghost4.Top == 150))
					{
						ghost4velocity = 2;
						Supermod4 = false;
						v4 = false;
						ghost4puomangiare = true;
						g4mangiato = false;
					}
					else
					{
						if (ghost4.Top > 150 && n == 1 && m == 1)
						{
							m = 0;
						}
						if (ghost4.Top < 150 && n == 1 && m == 1)
						{
							n = 0;
						}
						if (ghost4.Left < 176 && i == 1 && y == 1)
						{
							i = 0;
						}
						if (ghost4.Left > 176 && i == 1 && y == 1)
						{
							y = 0;
						}
					}
				}
				topghost4 = 0;
				leftghost4 = 0;
				while (!dir4)
				{
					random4 = rand.Next(1, 5);
					if (random4 == 1 && !dir4 && random4 != prec4 && i == 1)
					{
						leftghost4 = -ghost4velocity;
						dir4 = true;
						if (!Supermod4 && ghost4puomangiare)
						{
							ghost4.Image = Resources.gsx;
						}
						else if (!tresec || g4mangiato)
						{
							if (!tresec)
							{
								ghost4.Image = Resources.crazy;
							}
							if (g4mangiato)
							{
								ghost4.Image = Resources.msx;
							}
						}
						else
						{
							ghost4.Image = Resources.tempo;
						}
					}
					if (random4 == 2 && !dir4 && random4 != prec4 && y == 1)
					{
						leftghost4 = ghost4velocity;
						dir4 = true;
						if (!Supermod4 && ghost4puomangiare)
						{
							ghost4.Image = Resources.gdx;
						}
						else if (!tresec || g4mangiato)
						{
							if (!tresec)
							{
								ghost4.Image = Resources.crazy;
							}
							if (g4mangiato)
							{
								ghost4.Image = Resources.mdx;
							}
						}
						else
						{
							ghost4.Image = Resources.tempo;
						}
					}
					if (random4 == 3 && !dir4 && random4 != prec4 && m == 1)
					{
						topghost4 = ghost4velocity;
						dir4 = true;
						if (!Supermod4 && ghost4puomangiare)
						{
							ghost4.Image = Resources.gdown;
						}
						else if (!tresec || g4mangiato)
						{
							if (!tresec)
							{
								ghost4.Image = Resources.crazy;
							}
							if (g4mangiato)
							{
								ghost4.Image = Resources.mdown;
							}
						}
						else
						{
							ghost4.Image = Resources.tempo;
						}
					}
					if (random4 != 4 || dir4 || random4 == prec4 || n != 1)
					{
						continue;
					}
					topghost4 = -ghost4velocity;
					dir4 = true;
					if (!Supermod4 && ghost4puomangiare)
					{
						ghost4.Image = Resources.gup;
					}
					else if (!tresec || g4mangiato)
					{
						if (!tresec)
						{
							ghost4.Image = Resources.crazy;
						}
						if (g4mangiato)
						{
							ghost4.Image = Resources.mup1;
						}
					}
					else
					{
						ghost4.Image = Resources.tempo;
					}
				}
				if (random4 == 1)
				{
					prec4 = 2;
				}
				if (random4 == 2)
				{
					prec4 = 1;
				}
				if (random4 == 3)
				{
					prec4 = 4;
				}
				if (random4 == 4)
				{
					prec4 = 3;
				}
				dir4 = false;
			}
			if (!pacturn)
			{
				return;
			}
			top = 0;
			left = 0;
			if ((temp == 1 && i == 1) || (temp == 2 && y == 1) || (temp == 3 && n == 1) || (temp == 4 && m == 1))
			{
				next = temp;
			}
			if (next == 1 && i == 1)
			{
				left = -2;
				pacman.Image = Resources.pacsx;
				direzione = next;
			}
			if (next == 2 && y == 1)
			{
				left = 2;
				pacman.Image = Resources.pacdx;
				direzione = next;
			}
			if (next == 3 && n == 1)
			{
				top = -2;
				pacman.Image = Resources.pacup;
				direzione = next;
			}
			if (next == 4 && m == 1)
			{
				top = 2;
				pacman.Image = Resources.pacdown;
				direzione = next;
			}
			if (top == 0 && left == 0)
			{
				temp = next;
				next = direzione;
				if (next == 1)
				{
					pacman.Image = Resources._1sx;
				}
				if (next == 2)
				{
					pacman.Image = Resources._1dx;
				}
				if (next == 3)
				{
					pacman.Image = Resources._1up;
				}
				if (next == 4)
				{
					pacman.Image = Resources._1down;
				}
			}
		}

		private void direction()
		{
			pacturn = true;
			a(pacman.Left, pacman.Top);
			pacman.Left += left;
			pacman.Top += top;
		}

		private void a(int left, int top)
		{
			if (pacturn)
			{
				switch (left)
				{
				case 174:
					if (top == 148)
					{
						leftright(1, 1, 0, 0);
					}
					break;
				case 24:
					switch (top)
					{
					case 364:
						leftright(0, 1, 1, 0);
						break;
					case 328:
						leftright(0, 1, 0, 1);
						break;
					case 292:
						leftright(0, 1, 1, 0);
						break;
					case 256:
						leftright(0, 1, 0, 1);
						break;
					case 112:
						leftright(0, 1, 1, 0);
						break;
					case 76:
						leftright(0, 1, 1, 1);
						break;
					case 28:
						leftright(0, 1, 0, 1);
						break;
					}
					break;
				case 48:
					switch (top)
					{
					case 328:
						leftright(1, 1, 1, 0);
						break;
					case 292:
						leftright(1, 0, 0, 1);
						break;
					}
					break;
				case 84:
					switch (top)
					{
					case 256:
						leftright(1, 1, 1, 1);
						break;
					case 328:
						leftright(1, 0, 1, 0);
						break;
					case 292:
						leftright(0, 1, 1, 1);
						break;
					case 184:
						leftright(1, 1, 1, 1);
						break;
					case 112:
						leftright(1, 0, 1, 1);
						break;
					case 28:
						leftright(1, 1, 0, 1);
						break;
					case 76:
						leftright(1, 1, 1, 1);
						break;
					}
					break;
				case 120:
					switch (top)
					{
					case 292:
						leftright(1, 1, 0, 1);
						break;
					case 328:
						leftright(0, 1, 1, 0);
						break;
					case 256:
						leftright(1, 1, 1, 0);
						break;
					case 220:
						leftright(0, 1, 1, 1);
						break;
					case 76:
						leftright(1, 1, 0, 1);
						break;
					case 112:
						leftright(0, 1, 1, 0);
						break;
					case 148:
						leftright(0, 1, 0, 1);
						break;
					case 184:
						leftright(1, 0, 1, 1);
						break;
					}
					break;
				case 156:
					switch (top)
					{
					case 328:
						leftright(1, 0, 0, 1);
						break;
					case 364:
						leftright(1, 1, 1, 0);
						break;
					case 256:
						leftright(1, 0, 0, 1);
						break;
					case 292:
						leftright(1, 1, 1, 0);
						break;
					case 76:
						leftright(1, 1, 1, 0);
						break;
					case 112:
						leftright(1, 0, 0, 1);
						break;
					case 148:
						leftright(1, 1, 1, 0);
						break;
					case 28:
						leftright(1, 0, 0, 1);
						break;
					}
					break;
				case 192:
					switch (top)
					{
					case 292:
						leftright(1, 1, 1, 0);
						break;
					case 256:
						leftright(0, 1, 0, 1);
						break;
					case 364:
						leftright(1, 1, 1, 0);
						break;
					case 328:
						leftright(0, 1, 0, 1);
						break;
					case 28:
						leftright(0, 1, 0, 1);
						break;
					case 76:
						leftright(1, 1, 1, 0);
						break;
					case 112:
						leftright(0, 1, 0, 1);
						break;
					case 148:
						leftright(1, 1, 1, 0);
						break;
					}
					break;
				case 228:
					switch (top)
					{
					case 256:
						leftright(1, 1, 1, 0);
						break;
					case 328:
						leftright(1, 0, 1, 0);
						break;
					case 292:
						leftright(1, 1, 0, 1);
						break;
					case 220:
						leftright(1, 0, 1, 1);
						break;
					case 184:
						leftright(0, 1, 1, 1);
						break;
					case 76:
						leftright(1, 1, 0, 1);
						break;
					case 112:
						leftright(1, 0, 1, 0);
						break;
					case 148:
						leftright(1, 0, 0, 1);
						break;
					}
					break;
				case 264:
					switch (top)
					{
					case 256:
						leftright(1, 1, 1, 1);
						break;
					case 292:
						leftright(1, 0, 1, 1);
						break;
					case 328:
						leftright(0, 1, 1, 0);
						break;
					case 184:
						leftright(1, 1, 1, 1);
						break;
					case 112:
						leftright(0, 1, 1, 1);
						break;
					case 28:
						leftright(1, 1, 0, 1);
						break;
					case 76:
						leftright(1, 1, 1, 1);
						break;
					}
					break;
				case 324:
					switch (top)
					{
					case 256:
						leftright(1, 0, 0, 1);
						break;
					case 292:
						leftright(1, 0, 1, 0);
						break;
					case 328:
						leftright(1, 0, 0, 1);
						break;
					case 364:
						leftright(1, 0, 1, 0);
						break;
					case 112:
						leftright(1, 0, 1, 0);
						break;
					case 76:
						leftright(1, 0, 1, 1);
						break;
					case 28:
						leftright(1, 0, 0, 1);
						break;
					}
					break;
				case 300:
					switch (top)
					{
					case 292:
						leftright(0, 1, 0, 1);
						break;
					case 328:
						leftright(1, 1, 1, 0);
						break;
					}
					break;
				case 374:
					if (top == 184)
					{
						transport(0, 1);
					}
					break;
				case -26:
					if (top == 184)
					{
						transport(1, 0);
					}
					break;
				}
			}
			else
			{
				switch (left)
				{
				case 176:
					if (top == 150)
					{
						leftright(1, 1, 0, 0);
					}
					break;
				case 26:
					switch (top)
					{
					case 366:
						leftright(0, 1, 1, 0);
						break;
					case 330:
						leftright(0, 1, 0, 1);
						break;
					case 294:
						leftright(0, 1, 1, 0);
						break;
					case 258:
						leftright(0, 1, 0, 1);
						break;
					case 114:
						leftright(0, 1, 1, 0);
						break;
					case 78:
						leftright(0, 1, 1, 1);
						break;
					case 30:
						leftright(0, 1, 0, 1);
						break;
					}
					break;
				case 50:
					switch (top)
					{
					case 330:
						leftright(1, 1, 1, 0);
						break;
					case 294:
						leftright(1, 0, 0, 1);
						break;
					}
					break;
				case 86:
					switch (top)
					{
					case 258:
						leftright(1, 1, 1, 1);
						break;
					case 330:
						leftright(1, 0, 1, 0);
						break;
					case 294:
						leftright(0, 1, 1, 1);
						break;
					case 186:
						leftright(1, 1, 1, 1);
						break;
					case 114:
						leftright(1, 0, 1, 1);
						break;
					case 30:
						leftright(1, 1, 0, 1);
						break;
					case 78:
						leftright(1, 1, 1, 1);
						break;
					}
					break;
				case 122:
					switch (top)
					{
					case 294:
						leftright(1, 1, 0, 1);
						break;
					case 330:
						leftright(0, 1, 1, 0);
						break;
					case 258:
						leftright(1, 1, 1, 0);
						break;
					case 222:
						leftright(0, 1, 1, 1);
						break;
					case 78:
						leftright(1, 1, 0, 1);
						break;
					case 114:
						leftright(0, 1, 1, 0);
						break;
					case 150:
						leftright(0, 1, 0, 1);
						break;
					case 186:
						leftright(1, 0, 1, 1);
						break;
					}
					break;
				case 158:
					switch (top)
					{
					case 330:
						leftright(1, 0, 0, 1);
						break;
					case 366:
						leftright(1, 1, 1, 0);
						break;
					case 258:
						leftright(1, 0, 0, 1);
						break;
					case 294:
						leftright(1, 1, 1, 0);
						break;
					case 78:
						leftright(1, 1, 1, 0);
						break;
					case 114:
						leftright(1, 0, 0, 1);
						break;
					case 150:
						leftright(1, 1, 1, 0);
						break;
					case 30:
						leftright(1, 0, 0, 1);
						break;
					}
					break;
				case 194:
					switch (top)
					{
					case 294:
						leftright(1, 1, 1, 0);
						break;
					case 258:
						leftright(0, 1, 0, 1);
						break;
					case 366:
						leftright(1, 1, 1, 0);
						break;
					case 330:
						leftright(0, 1, 0, 1);
						break;
					case 30:
						leftright(0, 1, 0, 1);
						break;
					case 78:
						leftright(1, 1, 1, 0);
						break;
					case 114:
						leftright(0, 1, 0, 1);
						break;
					case 150:
						leftright(1, 1, 1, 0);
						break;
					}
					break;
				case 230:
					switch (top)
					{
					case 258:
						leftright(1, 1, 1, 0);
						break;
					case 330:
						leftright(1, 0, 1, 0);
						break;
					case 294:
						leftright(1, 1, 0, 1);
						break;
					case 222:
						leftright(1, 0, 1, 1);
						break;
					case 186:
						leftright(0, 1, 1, 1);
						break;
					case 78:
						leftright(1, 1, 0, 1);
						break;
					case 114:
						leftright(1, 0, 1, 0);
						break;
					case 150:
						leftright(1, 0, 0, 1);
						break;
					}
					break;
				case 266:
					switch (top)
					{
					case 258:
						leftright(1, 1, 1, 1);
						break;
					case 294:
						leftright(1, 0, 1, 1);
						break;
					case 330:
						leftright(0, 1, 1, 0);
						break;
					case 186:
						leftright(1, 1, 1, 1);
						break;
					case 114:
						leftright(0, 1, 1, 1);
						break;
					case 30:
						leftright(1, 1, 0, 1);
						break;
					case 78:
						leftright(1, 1, 1, 1);
						break;
					}
					break;
				case 326:
					switch (top)
					{
					case 258:
						leftright(1, 0, 0, 1);
						break;
					case 294:
						leftright(1, 0, 1, 0);
						break;
					case 330:
						leftright(1, 0, 0, 1);
						break;
					case 366:
						leftright(1, 0, 1, 0);
						break;
					case 114:
						leftright(1, 0, 1, 0);
						break;
					case 78:
						leftright(1, 0, 1, 1);
						break;
					case 30:
						leftright(1, 0, 0, 1);
						break;
					}
					break;
				case 302:
					switch (top)
					{
					case 294:
						leftright(0, 1, 0, 1);
						break;
					case 330:
						leftright(1, 1, 1, 0);
						break;
					}
					break;
				case 376:
					if (top == 186)
					{
						transport(0, 1);
					}
					break;
				case -28:
					if (top == 186)
					{
						transport(1, 0);
					}
					break;
				}
			}
			pacturn = false;
			ghost1turn = false;
			ghost2turn = false;
			ghost3turn = false;
			ghost4turn = false;
		}

		private void transport(int i, int n)
		{
			if (pacturn)
			{
				if (i == 0)
				{
					pacman.Left = -26;
				}
				if (n == 0)
				{
					pacman.Left = 374;
				}
			}
			if (ghost1turn)
			{
				if (i == 0)
				{
					ghost1.Left = -26;
				}
				if (n == 0)
				{
					ghost1.Left = 374;
				}
			}
			if (ghost2turn)
			{
				if (i == 0)
				{
					ghost2.Left = -26;
				}
				if (n == 0)
				{
					ghost2.Left = 374;
				}
			}
			if (ghost3turn)
			{
				if (i == 0)
				{
					ghost3.Left = -26;
				}
				if (n == 0)
				{
					ghost3.Left = 374;
				}
			}
			if (ghost4turn)
			{
				if (i == 0)
				{
					ghost4.Left = -26;
				}
				if (n == 0)
				{
					ghost4.Left = 374;
				}
			}
		}

		private void ghost()
		{
			if (ghost1.Enabled)
			{
				ghost1.Left += leftghost1;
				ghost1.Top += topghost1;
				ghost1turn = true;
				a(ghost1.Left, ghost1.Top);
			}
			if (ghost2.Enabled)
			{
				ghost2.Left += leftghost2;
				ghost2.Top += topghost2;
				ghost2turn = true;
				a(ghost2.Left, ghost2.Top);
			}
			if (ghost3.Enabled)
			{
				ghost3.Left += leftghost3;
				ghost3.Top += topghost3;
				ghost3turn = true;
				a(ghost3.Left, ghost3.Top);
			}
			if (ghost4.Enabled)
			{
				ghost4.Left += leftghost4;
				ghost4.Top += topghost4;
				ghost4turn = true;
				a(ghost4.Left, ghost4.Top);
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pacman_Zagorschi_Franco.Form1));
			timer1 = new System.Windows.Forms.Timer(components);
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			timer2 = new System.Windows.Forms.Timer(components);
			timer3 = new System.Windows.Forms.Timer(components);
			timer4 = new System.Windows.Forms.Timer(components);
			timer5 = new System.Windows.Forms.Timer(components);
			timer6 = new System.Windows.Forms.Timer(components);
			pictureBox2 = new System.Windows.Forms.PictureBox();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			ghost3 = new System.Windows.Forms.Label();
			ghost4 = new System.Windows.Forms.Label();
			ghost2 = new System.Windows.Forms.Label();
			ghost1 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			label6 = new System.Windows.Forms.Label();
			label7 = new System.Windows.Forms.Label();
			label8 = new System.Windows.Forms.Label();
			label9 = new System.Windows.Forms.Label();
			label10 = new System.Windows.Forms.Label();
			label11 = new System.Windows.Forms.Label();
			label12 = new System.Windows.Forms.Label();
			label13 = new System.Windows.Forms.Label();
			label14 = new System.Windows.Forms.Label();
			label15 = new System.Windows.Forms.Label();
			label16 = new System.Windows.Forms.Label();
			label17 = new System.Windows.Forms.Label();
			label18 = new System.Windows.Forms.Label();
			label19 = new System.Windows.Forms.Label();
			label20 = new System.Windows.Forms.Label();
			label21 = new System.Windows.Forms.Label();
			label22 = new System.Windows.Forms.Label();
			label23 = new System.Windows.Forms.Label();
			label24 = new System.Windows.Forms.Label();
			label25 = new System.Windows.Forms.Label();
			label26 = new System.Windows.Forms.Label();
			label27 = new System.Windows.Forms.Label();
			label28 = new System.Windows.Forms.Label();
			label29 = new System.Windows.Forms.Label();
			label30 = new System.Windows.Forms.Label();
			label31 = new System.Windows.Forms.Label();
			score = new System.Windows.Forms.Label();
			label43 = new System.Windows.Forms.Label();
			label44 = new System.Windows.Forms.Label();
			label32 = new System.Windows.Forms.Label();
			label45 = new System.Windows.Forms.Label();
			label46 = new System.Windows.Forms.Label();
			label47 = new System.Windows.Forms.Label();
			label49 = new System.Windows.Forms.Label();
			label50 = new System.Windows.Forms.Label();
			label33 = new System.Windows.Forms.Label();
			label34 = new System.Windows.Forms.Label();
			label35 = new System.Windows.Forms.Label();
			label36 = new System.Windows.Forms.Label();
			label37 = new System.Windows.Forms.Label();
			label38 = new System.Windows.Forms.Label();
			label39 = new System.Windows.Forms.Label();
			label40 = new System.Windows.Forms.Label();
			label41 = new System.Windows.Forms.Label();
			label42 = new System.Windows.Forms.Label();
			label48 = new System.Windows.Forms.Label();
			label51 = new System.Windows.Forms.Label();
			label52 = new System.Windows.Forms.Label();
			label53 = new System.Windows.Forms.Label();
			label54 = new System.Windows.Forms.Label();
			label55 = new System.Windows.Forms.Label();
			label56 = new System.Windows.Forms.Label();
			label57 = new System.Windows.Forms.Label();
			label58 = new System.Windows.Forms.Label();
			label59 = new System.Windows.Forms.Label();
			label60 = new System.Windows.Forms.Label();
			label61 = new System.Windows.Forms.Label();
			label62 = new System.Windows.Forms.Label();
			label63 = new System.Windows.Forms.Label();
			label64 = new System.Windows.Forms.Label();
			label65 = new System.Windows.Forms.Label();
			label66 = new System.Windows.Forms.Label();
			label67 = new System.Windows.Forms.Label();
			label68 = new System.Windows.Forms.Label();
			label69 = new System.Windows.Forms.Label();
			label70 = new System.Windows.Forms.Label();
			label71 = new System.Windows.Forms.Label();
			label72 = new System.Windows.Forms.Label();
			label73 = new System.Windows.Forms.Label();
			label74 = new System.Windows.Forms.Label();
			label76 = new System.Windows.Forms.Label();
			label77 = new System.Windows.Forms.Label();
			label78 = new System.Windows.Forms.Label();
			label79 = new System.Windows.Forms.Label();
			label80 = new System.Windows.Forms.Label();
			label81 = new System.Windows.Forms.Label();
			label82 = new System.Windows.Forms.Label();
			label83 = new System.Windows.Forms.Label();
			label75 = new System.Windows.Forms.Label();
			label84 = new System.Windows.Forms.Label();
			label85 = new System.Windows.Forms.Label();
			label86 = new System.Windows.Forms.Label();
			label87 = new System.Windows.Forms.Label();
			label88 = new System.Windows.Forms.Label();
			label89 = new System.Windows.Forms.Label();
			label90 = new System.Windows.Forms.Label();
			label91 = new System.Windows.Forms.Label();
			label92 = new System.Windows.Forms.Label();
			label94 = new System.Windows.Forms.Label();
			label93 = new System.Windows.Forms.Label();
			label95 = new System.Windows.Forms.Label();
			label96 = new System.Windows.Forms.Label();
			label98 = new System.Windows.Forms.Label();
			label97 = new System.Windows.Forms.Label();
			label99 = new System.Windows.Forms.Label();
			label100 = new System.Windows.Forms.Label();
			label101 = new System.Windows.Forms.Label();
			label102 = new System.Windows.Forms.Label();
			label103 = new System.Windows.Forms.Label();
			label104 = new System.Windows.Forms.Label();
			label105 = new System.Windows.Forms.Label();
			label106 = new System.Windows.Forms.Label();
			label107 = new System.Windows.Forms.Label();
			label108 = new System.Windows.Forms.Label();
			label109 = new System.Windows.Forms.Label();
			label110 = new System.Windows.Forms.Label();
			label111 = new System.Windows.Forms.Label();
			label112 = new System.Windows.Forms.Label();
			label113 = new System.Windows.Forms.Label();
			label114 = new System.Windows.Forms.Label();
			label115 = new System.Windows.Forms.Label();
			label116 = new System.Windows.Forms.Label();
			label117 = new System.Windows.Forms.Label();
			label118 = new System.Windows.Forms.Label();
			label119 = new System.Windows.Forms.Label();
			label120 = new System.Windows.Forms.Label();
			label121 = new System.Windows.Forms.Label();
			label122 = new System.Windows.Forms.Label();
			label123 = new System.Windows.Forms.Label();
			label125 = new System.Windows.Forms.Label();
			label126 = new System.Windows.Forms.Label();
			label127 = new System.Windows.Forms.Label();
			label128 = new System.Windows.Forms.Label();
			label129 = new System.Windows.Forms.Label();
			label130 = new System.Windows.Forms.Label();
			label131 = new System.Windows.Forms.Label();
			label132 = new System.Windows.Forms.Label();
			label133 = new System.Windows.Forms.Label();
			label134 = new System.Windows.Forms.Label();
			label135 = new System.Windows.Forms.Label();
			label136 = new System.Windows.Forms.Label();
			label137 = new System.Windows.Forms.Label();
			label138 = new System.Windows.Forms.Label();
			label139 = new System.Windows.Forms.Label();
			label140 = new System.Windows.Forms.Label();
			label143 = new System.Windows.Forms.Label();
			label144 = new System.Windows.Forms.Label();
			label145 = new System.Windows.Forms.Label();
			label146 = new System.Windows.Forms.Label();
			label147 = new System.Windows.Forms.Label();
			label148 = new System.Windows.Forms.Label();
			label149 = new System.Windows.Forms.Label();
			label150 = new System.Windows.Forms.Label();
			label151 = new System.Windows.Forms.Label();
			label152 = new System.Windows.Forms.Label();
			label153 = new System.Windows.Forms.Label();
			label154 = new System.Windows.Forms.Label();
			label155 = new System.Windows.Forms.Label();
			label156 = new System.Windows.Forms.Label();
			label157 = new System.Windows.Forms.Label();
			label158 = new System.Windows.Forms.Label();
			label159 = new System.Windows.Forms.Label();
			label160 = new System.Windows.Forms.Label();
			label161 = new System.Windows.Forms.Label();
			label162 = new System.Windows.Forms.Label();
			label163 = new System.Windows.Forms.Label();
			label164 = new System.Windows.Forms.Label();
			label165 = new System.Windows.Forms.Label();
			label166 = new System.Windows.Forms.Label();
			label167 = new System.Windows.Forms.Label();
			label168 = new System.Windows.Forms.Label();
			label169 = new System.Windows.Forms.Label();
			label170 = new System.Windows.Forms.Label();
			label171 = new System.Windows.Forms.Label();
			label172 = new System.Windows.Forms.Label();
			label173 = new System.Windows.Forms.Label();
			label174 = new System.Windows.Forms.Label();
			label175 = new System.Windows.Forms.Label();
			label176 = new System.Windows.Forms.Label();
			label177 = new System.Windows.Forms.Label();
			label178 = new System.Windows.Forms.Label();
			label179 = new System.Windows.Forms.Label();
			label180 = new System.Windows.Forms.Label();
			label181 = new System.Windows.Forms.Label();
			label182 = new System.Windows.Forms.Label();
			label183 = new System.Windows.Forms.Label();
			label184 = new System.Windows.Forms.Label();
			label185 = new System.Windows.Forms.Label();
			label186 = new System.Windows.Forms.Label();
			label187 = new System.Windows.Forms.Label();
			label188 = new System.Windows.Forms.Label();
			label189 = new System.Windows.Forms.Label();
			label190 = new System.Windows.Forms.Label();
			label191 = new System.Windows.Forms.Label();
			label192 = new System.Windows.Forms.Label();
			label193 = new System.Windows.Forms.Label();
			label194 = new System.Windows.Forms.Label();
			label195 = new System.Windows.Forms.Label();
			label196 = new System.Windows.Forms.Label();
			label199 = new System.Windows.Forms.Label();
			label198 = new System.Windows.Forms.Label();
			label200 = new System.Windows.Forms.Label();
			label201 = new System.Windows.Forms.Label();
			label202 = new System.Windows.Forms.Label();
			label203 = new System.Windows.Forms.Label();
			label204 = new System.Windows.Forms.Label();
			label205 = new System.Windows.Forms.Label();
			label206 = new System.Windows.Forms.Label();
			label207 = new System.Windows.Forms.Label();
			label208 = new System.Windows.Forms.Label();
			label209 = new System.Windows.Forms.Label();
			label210 = new System.Windows.Forms.Label();
			label211 = new System.Windows.Forms.Label();
			label212 = new System.Windows.Forms.Label();
			label213 = new System.Windows.Forms.Label();
			label214 = new System.Windows.Forms.Label();
			label197 = new System.Windows.Forms.Label();
			label215 = new System.Windows.Forms.Label();
			label216 = new System.Windows.Forms.Label();
			label217 = new System.Windows.Forms.Label();
			label218 = new System.Windows.Forms.Label();
			label219 = new System.Windows.Forms.Label();
			label220 = new System.Windows.Forms.Label();
			label221 = new System.Windows.Forms.Label();
			label222 = new System.Windows.Forms.Label();
			label223 = new System.Windows.Forms.Label();
			label224 = new System.Windows.Forms.Label();
			label225 = new System.Windows.Forms.Label();
			label226 = new System.Windows.Forms.Label();
			label227 = new System.Windows.Forms.Label();
			label228 = new System.Windows.Forms.Label();
			label229 = new System.Windows.Forms.Label();
			label230 = new System.Windows.Forms.Label();
			label231 = new System.Windows.Forms.Label();
			label232 = new System.Windows.Forms.Label();
			label233 = new System.Windows.Forms.Label();
			label234 = new System.Windows.Forms.Label();
			label235 = new System.Windows.Forms.Label();
			label236 = new System.Windows.Forms.Label();
			label237 = new System.Windows.Forms.Label();
			label238 = new System.Windows.Forms.Label();
			label239 = new System.Windows.Forms.Label();
			label240 = new System.Windows.Forms.Label();
			label241 = new System.Windows.Forms.Label();
			label242 = new System.Windows.Forms.Label();
			label243 = new System.Windows.Forms.Label();
			label244 = new System.Windows.Forms.Label();
			label245 = new System.Windows.Forms.Label();
			label246 = new System.Windows.Forms.Label();
			label247 = new System.Windows.Forms.Label();
			label248 = new System.Windows.Forms.Label();
			label249 = new System.Windows.Forms.Label();
			label250 = new System.Windows.Forms.Label();
			label251 = new System.Windows.Forms.Label();
			label252 = new System.Windows.Forms.Label();
			label256 = new System.Windows.Forms.Label();
			label257 = new System.Windows.Forms.Label();
			label258 = new System.Windows.Forms.Label();
			label259 = new System.Windows.Forms.Label();
			label260 = new System.Windows.Forms.Label();
			label261 = new System.Windows.Forms.Label();
			label262 = new System.Windows.Forms.Label();
			label263 = new System.Windows.Forms.Label();
			label264 = new System.Windows.Forms.Label();
			label265 = new System.Windows.Forms.Label();
			label272 = new System.Windows.Forms.Label();
			label273 = new System.Windows.Forms.Label();
			label274 = new System.Windows.Forms.Label();
			label280 = new System.Windows.Forms.Label();
			label281 = new System.Windows.Forms.Label();
			label282 = new System.Windows.Forms.Label();
			label283 = new System.Windows.Forms.Label();
			label284 = new System.Windows.Forms.Label();
			label266 = new System.Windows.Forms.Label();
			label267 = new System.Windows.Forms.Label();
			label268 = new System.Windows.Forms.Label();
			label269 = new System.Windows.Forms.Label();
			label270 = new System.Windows.Forms.Label();
			label271 = new System.Windows.Forms.Label();
			label275 = new System.Windows.Forms.Label();
			label276 = new System.Windows.Forms.Label();
			label277 = new System.Windows.Forms.Label();
			label278 = new System.Windows.Forms.Label();
			label279 = new System.Windows.Forms.Label();
			label285 = new System.Windows.Forms.Label();
			label286 = new System.Windows.Forms.Label();
			label287 = new System.Windows.Forms.Label();
			label288 = new System.Windows.Forms.Label();
			label289 = new System.Windows.Forms.Label();
			label290 = new System.Windows.Forms.Label();
			label293 = new System.Windows.Forms.Label();
			label294 = new System.Windows.Forms.Label();
			label295 = new System.Windows.Forms.Label();
			label296 = new System.Windows.Forms.Label();
			label297 = new System.Windows.Forms.Label();
			label298 = new System.Windows.Forms.Label();
			label299 = new System.Windows.Forms.Label();
			label300 = new System.Windows.Forms.Label();
			label301 = new System.Windows.Forms.Label();
			label302 = new System.Windows.Forms.Label();
			label291 = new System.Windows.Forms.Label();
			label292 = new System.Windows.Forms.Label();
			label303 = new System.Windows.Forms.Label();
			label304 = new System.Windows.Forms.Label();
			label305 = new System.Windows.Forms.Label();
			label306 = new System.Windows.Forms.Label();
			label307 = new System.Windows.Forms.Label();
			label308 = new System.Windows.Forms.Label();
			label309 = new System.Windows.Forms.Label();
			label310 = new System.Windows.Forms.Label();
			label311 = new System.Windows.Forms.Label();
			label312 = new System.Windows.Forms.Label();
			label313 = new System.Windows.Forms.Label();
			label314 = new System.Windows.Forms.Label();
			label315 = new System.Windows.Forms.Label();
			label316 = new System.Windows.Forms.Label();
			label317 = new System.Windows.Forms.Label();
			label318 = new System.Windows.Forms.Label();
			label319 = new System.Windows.Forms.Label();
			label320 = new System.Windows.Forms.Label();
			label321 = new System.Windows.Forms.Label();
			label322 = new System.Windows.Forms.Label();
			label323 = new System.Windows.Forms.Label();
			label324 = new System.Windows.Forms.Label();
			label325 = new System.Windows.Forms.Label();
			label327 = new System.Windows.Forms.Label();
			label326 = new System.Windows.Forms.Label();
			label328 = new System.Windows.Forms.Label();
			label329 = new System.Windows.Forms.Label();
			label330 = new System.Windows.Forms.Label();
			label331 = new System.Windows.Forms.Label();
			label332 = new System.Windows.Forms.Label();
			label333 = new System.Windows.Forms.Label();
			label334 = new System.Windows.Forms.Label();
			label335 = new System.Windows.Forms.Label();
			label336 = new System.Windows.Forms.Label();
			label337 = new System.Windows.Forms.Label();
			label338 = new System.Windows.Forms.Label();
			label339 = new System.Windows.Forms.Label();
			label340 = new System.Windows.Forms.Label();
			label341 = new System.Windows.Forms.Label();
			timer8 = new System.Windows.Forms.Timer(components);
			panel1 = new System.Windows.Forms.Panel();
			pictureBox5 = new System.Windows.Forms.PictureBox();
			pictureBox4 = new System.Windows.Forms.PictureBox();
			pictureBox3 = new System.Windows.Forms.PictureBox();
			button1 = new System.Windows.Forms.Button();
			pacman = new System.Windows.Forms.PictureBox();
			powermod = new System.Windows.Forms.Timer(components);
			timer7 = new System.Windows.Forms.Timer(components);
			timer9 = new System.Windows.Forms.Timer(components);
			ghostmangiato = new System.Windows.Forms.Timer(components);
			label124 = new System.Windows.Forms.Label();
			label141 = new System.Windows.Forms.Label();
			powermod1 = new System.Windows.Forms.Timer(components);
			attendo = new System.Windows.Forms.Timer(components);
			label254 = new System.Windows.Forms.Label();
			label255 = new System.Windows.Forms.Label();
			label253 = new System.Windows.Forms.Label();
			label142 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pacman).BeginInit();
			SuspendLayout();
			timer1.Interval = 16;
			timer1.Tick += new System.EventHandler(timer1_Tick);
			label1.BackColor = System.Drawing.Color.Black;
			label1.Font = new System.Drawing.Font("Segoe UI Black", 16f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label1.ForeColor = System.Drawing.Color.White;
			label1.Image = Pacman_Zagorschi_Franco.Properties.Resources.score;
			label1.Location = new System.Drawing.Point(16, 400);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(84, 30);
			label1.TabIndex = 129;
			label2.BackColor = System.Drawing.Color.Black;
			label2.Font = new System.Drawing.Font("Segoe UI Black", 16f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label2.ForeColor = System.Drawing.Color.White;
			label2.Image = Pacman_Zagorschi_Franco.Properties.Resources.lives;
			label2.Location = new System.Drawing.Point(226, 399);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(69, 30);
			label2.TabIndex = 130;
			label3.BackColor = System.Drawing.Color.Black;
			label3.Font = new System.Drawing.Font("Segoe UI Black", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label3.ForeColor = System.Drawing.Color.White;
			label3.Image = Pacman_Zagorschi_Franco.Properties.Resources.getready;
			label3.Location = new System.Drawing.Point(123, 222);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(125, 19);
			label3.TabIndex = 133;
			label3.Text = "          ";
			label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			timer2.Interval = 3000;
			timer2.Tick += new System.EventHandler(timer2_Tick);
			timer3.Interval = 1;
			timer3.Tick += new System.EventHandler(timer3_Tick);
			timer4.Interval = 1;
			timer4.Tick += new System.EventHandler(timer4_Tick);
			timer5.Interval = 1;
			timer5.Tick += new System.EventHandler(timer5_Tick);
			timer6.Interval = 1;
			timer6.Tick += new System.EventHandler(timer6_Tick);
			pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			pictureBox2.Image = Pacman_Zagorschi_Franco.Properties.Resources._1sx;
			pictureBox2.Location = new System.Drawing.Point(318, 402);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new System.Drawing.Size(22, 22);
			pictureBox2.TabIndex = 132;
			pictureBox2.TabStop = false;
			pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			pictureBox1.Image = Pacman_Zagorschi_Franco.Properties.Resources._1sx;
			pictureBox1.Location = new System.Drawing.Point(297, 402);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(22, 22);
			pictureBox1.TabIndex = 131;
			pictureBox1.TabStop = false;
			ghost3.BackColor = System.Drawing.Color.Transparent;
			ghost3.Cursor = System.Windows.Forms.Cursors.Default;
			ghost3.ForeColor = System.Drawing.Color.Transparent;
			ghost3.Image = Pacman_Zagorschi_Franco.Properties.Resources.vup;
			ghost3.Location = new System.Drawing.Point(176, 185);
			ghost3.Margin = new System.Windows.Forms.Padding(0);
			ghost3.Name = "ghost3";
			ghost3.Size = new System.Drawing.Size(18, 18);
			ghost3.TabIndex = 127;
			ghost4.BackColor = System.Drawing.Color.Transparent;
			ghost4.Cursor = System.Windows.Forms.Cursors.Default;
			ghost4.ForeColor = System.Drawing.Color.Transparent;
			ghost4.Image = Pacman_Zagorschi_Franco.Properties.Resources.gup;
			ghost4.Location = new System.Drawing.Point(199, 185);
			ghost4.Margin = new System.Windows.Forms.Padding(0);
			ghost4.Name = "ghost4";
			ghost4.Size = new System.Drawing.Size(18, 18);
			ghost4.TabIndex = 126;
			ghost2.BackColor = System.Drawing.Color.Transparent;
			ghost2.Cursor = System.Windows.Forms.Cursors.Default;
			ghost2.ForeColor = System.Drawing.Color.Transparent;
			ghost2.Image = Pacman_Zagorschi_Franco.Properties.Resources.aup;
			ghost2.Location = new System.Drawing.Point(154, 185);
			ghost2.Margin = new System.Windows.Forms.Padding(0);
			ghost2.Name = "ghost2";
			ghost2.Size = new System.Drawing.Size(18, 18);
			ghost2.TabIndex = 125;
			ghost1.BackColor = System.Drawing.Color.Transparent;
			ghost1.Cursor = System.Windows.Forms.Cursors.Default;
			ghost1.ForeColor = System.Drawing.Color.Transparent;
			ghost1.Image = Pacman_Zagorschi_Franco.Properties.Resources.rup;
			ghost1.Location = new System.Drawing.Point(176, 150);
			ghost1.Margin = new System.Windows.Forms.Padding(0);
			ghost1.Name = "ghost1";
			ghost1.Size = new System.Drawing.Size(18, 18);
			ghost1.TabIndex = 124;
			label4.BackColor = System.Drawing.Color.White;
			label4.Location = new System.Drawing.Point(102, 266);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(2, 2);
			label4.TabIndex = 134;
			label5.BackColor = System.Drawing.Color.White;
			label5.Location = new System.Drawing.Point(111, 266);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(2, 2);
			label5.TabIndex = 135;
			label6.BackColor = System.Drawing.Color.White;
			label6.Location = new System.Drawing.Point(129, 266);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(2, 2);
			label6.TabIndex = 137;
			label7.BackColor = System.Drawing.Color.White;
			label7.Location = new System.Drawing.Point(120, 266);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(2, 2);
			label7.TabIndex = 136;
			label8.BackColor = System.Drawing.Color.White;
			label8.Location = new System.Drawing.Point(165, 266);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(2, 2);
			label8.TabIndex = 141;
			label9.BackColor = System.Drawing.Color.White;
			label9.Location = new System.Drawing.Point(156, 266);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(2, 2);
			label9.TabIndex = 140;
			label10.BackColor = System.Drawing.Color.White;
			label10.Location = new System.Drawing.Point(147, 266);
			label10.Name = "label10";
			label10.Size = new System.Drawing.Size(2, 2);
			label10.TabIndex = 139;
			label11.BackColor = System.Drawing.Color.White;
			label11.Location = new System.Drawing.Point(138, 266);
			label11.Name = "label11";
			label11.Size = new System.Drawing.Size(2, 2);
			label11.TabIndex = 138;
			label12.BackColor = System.Drawing.Color.White;
			label12.Location = new System.Drawing.Point(94, 266);
			label12.Name = "label12";
			label12.Size = new System.Drawing.Size(2, 2);
			label12.TabIndex = 149;
			label13.BackColor = System.Drawing.Color.White;
			label13.Location = new System.Drawing.Point(78, 266);
			label13.Name = "label13";
			label13.Size = new System.Drawing.Size(2, 2);
			label13.TabIndex = 148;
			label14.BackColor = System.Drawing.Color.White;
			label14.Location = new System.Drawing.Point(69, 266);
			label14.Name = "label14";
			label14.Size = new System.Drawing.Size(2, 2);
			label14.TabIndex = 147;
			label15.BackColor = System.Drawing.Color.White;
			label15.Location = new System.Drawing.Point(60, 266);
			label15.Name = "label15";
			label15.Size = new System.Drawing.Size(2, 2);
			label15.TabIndex = 146;
			label16.BackColor = System.Drawing.Color.White;
			label16.Location = new System.Drawing.Point(52, 266);
			label16.Name = "label16";
			label16.Size = new System.Drawing.Size(2, 2);
			label16.TabIndex = 145;
			label17.BackColor = System.Drawing.Color.White;
			label17.Location = new System.Drawing.Point(43, 266);
			label17.Name = "label17";
			label17.Size = new System.Drawing.Size(2, 2);
			label17.TabIndex = 144;
			label18.BackColor = System.Drawing.Color.White;
			label18.Location = new System.Drawing.Point(247, 266);
			label18.Name = "label18";
			label18.Size = new System.Drawing.Size(2, 2);
			label18.TabIndex = 163;
			label19.BackColor = System.Drawing.Color.White;
			label19.Location = new System.Drawing.Point(238, 266);
			label19.Name = "label19";
			label19.Size = new System.Drawing.Size(2, 2);
			label19.TabIndex = 162;
			label20.BackColor = System.Drawing.Color.White;
			label20.Location = new System.Drawing.Point(229, 266);
			label20.Name = "label20";
			label20.Size = new System.Drawing.Size(2, 2);
			label20.TabIndex = 161;
			label21.BackColor = System.Drawing.Color.White;
			label21.Location = new System.Drawing.Point(220, 266);
			label21.Name = "label21";
			label21.Size = new System.Drawing.Size(2, 2);
			label21.TabIndex = 160;
			label22.BackColor = System.Drawing.Color.White;
			label22.Location = new System.Drawing.Point(211, 266);
			label22.Name = "label22";
			label22.Size = new System.Drawing.Size(2, 2);
			label22.TabIndex = 159;
			label23.BackColor = System.Drawing.Color.White;
			label23.Location = new System.Drawing.Point(202, 266);
			label23.Name = "label23";
			label23.Size = new System.Drawing.Size(2, 2);
			label23.TabIndex = 158;
			label24.BackColor = System.Drawing.Color.White;
			label24.Location = new System.Drawing.Point(318, 266);
			label24.Name = "label24";
			label24.Size = new System.Drawing.Size(2, 2);
			label24.TabIndex = 157;
			label25.BackColor = System.Drawing.Color.White;
			label25.Location = new System.Drawing.Point(310, 266);
			label25.Name = "label25";
			label25.Size = new System.Drawing.Size(2, 2);
			label25.TabIndex = 156;
			label26.BackColor = System.Drawing.Color.White;
			label26.Location = new System.Drawing.Point(301, 266);
			label26.Name = "label26";
			label26.Size = new System.Drawing.Size(2, 2);
			label26.TabIndex = 155;
			label27.BackColor = System.Drawing.Color.White;
			label27.Location = new System.Drawing.Point(292, 266);
			label27.Name = "label27";
			label27.Size = new System.Drawing.Size(2, 2);
			label27.TabIndex = 154;
			label28.BackColor = System.Drawing.Color.White;
			label28.Location = new System.Drawing.Point(283, 266);
			label28.Name = "label28";
			label28.Size = new System.Drawing.Size(2, 2);
			label28.TabIndex = 153;
			label29.BackColor = System.Drawing.Color.White;
			label29.Location = new System.Drawing.Point(274, 266);
			label29.Name = "label29";
			label29.Size = new System.Drawing.Size(2, 2);
			label29.TabIndex = 152;
			label30.BackColor = System.Drawing.Color.White;
			label30.Location = new System.Drawing.Point(265, 266);
			label30.Name = "label30";
			label30.Size = new System.Drawing.Size(2, 2);
			label30.TabIndex = 151;
			label31.BackColor = System.Drawing.Color.White;
			label31.Location = new System.Drawing.Point(256, 266);
			label31.Name = "label31";
			label31.Size = new System.Drawing.Size(2, 2);
			label31.TabIndex = 150;
			score.AutoSize = true;
			score.Font = new System.Drawing.Font("Segoe UI Black", 15f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			score.ForeColor = System.Drawing.Color.FromArgb(255, 255, 51);
			score.Location = new System.Drawing.Point(93, 399);
			score.Name = "score";
			score.Size = new System.Drawing.Size(24, 28);
			score.TabIndex = 164;
			score.Text = "0";
			label43.BackColor = System.Drawing.Color.White;
			label43.Location = new System.Drawing.Point(165, 284);
			label43.Name = "label43";
			label43.Size = new System.Drawing.Size(2, 2);
			label43.TabIndex = 180;
			label44.BackColor = System.Drawing.Color.White;
			label44.Location = new System.Drawing.Point(165, 293);
			label44.Name = "label44";
			label44.Size = new System.Drawing.Size(2, 2);
			label44.TabIndex = 181;
			label32.BackColor = System.Drawing.Color.White;
			label32.Location = new System.Drawing.Point(165, 275);
			label32.Name = "label32";
			label32.Size = new System.Drawing.Size(2, 2);
			label32.TabIndex = 179;
			label45.BackColor = System.Drawing.Color.White;
			label45.Location = new System.Drawing.Point(202, 293);
			label45.Name = "label45";
			label45.Size = new System.Drawing.Size(2, 2);
			label45.TabIndex = 185;
			label46.BackColor = System.Drawing.Color.White;
			label46.Location = new System.Drawing.Point(202, 284);
			label46.Name = "label46";
			label46.Size = new System.Drawing.Size(2, 2);
			label46.TabIndex = 184;
			label47.BackColor = System.Drawing.Color.White;
			label47.Location = new System.Drawing.Point(202, 275);
			label47.Name = "label47";
			label47.Size = new System.Drawing.Size(2, 2);
			label47.TabIndex = 183;
			label49.BackColor = System.Drawing.Color.White;
			label49.Location = new System.Drawing.Point(326, 266);
			label49.Name = "label49";
			label49.Size = new System.Drawing.Size(2, 2);
			label49.TabIndex = 186;
			label50.BackColor = System.Drawing.Color.White;
			label50.Location = new System.Drawing.Point(35, 266);
			label50.Name = "label50";
			label50.Size = new System.Drawing.Size(2, 2);
			label50.TabIndex = 187;
			label33.BackColor = System.Drawing.Color.White;
			label33.Location = new System.Drawing.Point(94, 302);
			label33.Name = "label33";
			label33.Size = new System.Drawing.Size(2, 2);
			label33.TabIndex = 196;
			label34.BackColor = System.Drawing.Color.White;
			label34.Location = new System.Drawing.Point(165, 302);
			label34.Name = "label34";
			label34.Size = new System.Drawing.Size(2, 2);
			label34.TabIndex = 195;
			label35.BackColor = System.Drawing.Color.White;
			label35.Location = new System.Drawing.Point(156, 302);
			label35.Name = "label35";
			label35.Size = new System.Drawing.Size(2, 2);
			label35.TabIndex = 194;
			label36.BackColor = System.Drawing.Color.White;
			label36.Location = new System.Drawing.Point(147, 302);
			label36.Name = "label36";
			label36.Size = new System.Drawing.Size(2, 2);
			label36.TabIndex = 193;
			label37.BackColor = System.Drawing.Color.White;
			label37.Location = new System.Drawing.Point(138, 302);
			label37.Name = "label37";
			label37.Size = new System.Drawing.Size(2, 2);
			label37.TabIndex = 192;
			label38.BackColor = System.Drawing.Color.White;
			label38.Location = new System.Drawing.Point(129, 302);
			label38.Name = "label38";
			label38.Size = new System.Drawing.Size(2, 2);
			label38.TabIndex = 191;
			label39.BackColor = System.Drawing.Color.White;
			label39.Location = new System.Drawing.Point(120, 302);
			label39.Name = "label39";
			label39.Size = new System.Drawing.Size(2, 2);
			label39.TabIndex = 190;
			label40.BackColor = System.Drawing.Color.White;
			label40.Location = new System.Drawing.Point(111, 302);
			label40.Name = "label40";
			label40.Size = new System.Drawing.Size(2, 2);
			label40.TabIndex = 189;
			label41.BackColor = System.Drawing.Color.White;
			label41.Location = new System.Drawing.Point(102, 302);
			label41.Name = "label41";
			label41.Size = new System.Drawing.Size(2, 2);
			label41.TabIndex = 188;
			label42.BackColor = System.Drawing.Color.White;
			label42.Location = new System.Drawing.Point(202, 302);
			label42.Name = "label42";
			label42.Size = new System.Drawing.Size(2, 2);
			label42.TabIndex = 205;
			label48.BackColor = System.Drawing.Color.White;
			label48.Location = new System.Drawing.Point(274, 302);
			label48.Name = "label48";
			label48.Size = new System.Drawing.Size(2, 2);
			label48.TabIndex = 204;
			label51.BackColor = System.Drawing.Color.White;
			label51.Location = new System.Drawing.Point(265, 302);
			label51.Name = "label51";
			label51.Size = new System.Drawing.Size(2, 2);
			label51.TabIndex = 203;
			label52.BackColor = System.Drawing.Color.White;
			label52.Location = new System.Drawing.Point(256, 302);
			label52.Name = "label52";
			label52.Size = new System.Drawing.Size(2, 2);
			label52.TabIndex = 202;
			label53.BackColor = System.Drawing.Color.White;
			label53.Location = new System.Drawing.Point(247, 302);
			label53.Name = "label53";
			label53.Size = new System.Drawing.Size(2, 2);
			label53.TabIndex = 201;
			label54.BackColor = System.Drawing.Color.White;
			label54.Location = new System.Drawing.Point(238, 302);
			label54.Name = "label54";
			label54.Size = new System.Drawing.Size(2, 2);
			label54.TabIndex = 200;
			label55.BackColor = System.Drawing.Color.White;
			label55.Location = new System.Drawing.Point(229, 302);
			label55.Name = "label55";
			label55.Size = new System.Drawing.Size(2, 2);
			label55.TabIndex = 199;
			label56.BackColor = System.Drawing.Color.White;
			label56.Location = new System.Drawing.Point(220, 302);
			label56.Name = "label56";
			label56.Size = new System.Drawing.Size(2, 2);
			label56.TabIndex = 198;
			label57.BackColor = System.Drawing.Color.White;
			label57.Location = new System.Drawing.Point(211, 302);
			label57.Name = "label57";
			label57.Size = new System.Drawing.Size(2, 2);
			label57.TabIndex = 197;
			label58.BackColor = System.Drawing.Color.White;
			label58.Location = new System.Drawing.Point(94, 293);
			label58.Name = "label58";
			label58.Size = new System.Drawing.Size(2, 2);
			label58.TabIndex = 208;
			label59.BackColor = System.Drawing.Color.White;
			label59.Location = new System.Drawing.Point(94, 284);
			label59.Name = "label59";
			label59.Size = new System.Drawing.Size(2, 2);
			label59.TabIndex = 207;
			label60.BackColor = System.Drawing.Color.White;
			label60.Location = new System.Drawing.Point(94, 275);
			label60.Name = "label60";
			label60.Size = new System.Drawing.Size(2, 2);
			label60.TabIndex = 206;
			label61.BackColor = System.Drawing.Color.White;
			label61.Location = new System.Drawing.Point(274, 293);
			label61.Name = "label61";
			label61.Size = new System.Drawing.Size(2, 2);
			label61.TabIndex = 211;
			label62.BackColor = System.Drawing.Color.White;
			label62.Location = new System.Drawing.Point(274, 284);
			label62.Name = "label62";
			label62.Size = new System.Drawing.Size(2, 2);
			label62.TabIndex = 210;
			label63.BackColor = System.Drawing.Color.White;
			label63.Location = new System.Drawing.Point(274, 275);
			label63.Name = "label63";
			label63.Size = new System.Drawing.Size(2, 2);
			label63.TabIndex = 209;
			label64.BackColor = System.Drawing.Color.White;
			label64.Location = new System.Drawing.Point(183, 302);
			label64.Name = "label64";
			label64.Size = new System.Drawing.Size(2, 2);
			label64.TabIndex = 213;
			label65.BackColor = System.Drawing.Color.White;
			label65.Location = new System.Drawing.Point(174, 302);
			label65.Name = "label65";
			label65.Size = new System.Drawing.Size(2, 2);
			label65.TabIndex = 212;
			label66.BackColor = System.Drawing.Color.White;
			label66.Location = new System.Drawing.Point(192, 302);
			label66.Name = "label66";
			label66.Size = new System.Drawing.Size(2, 2);
			label66.TabIndex = 214;
			label67.BackColor = System.Drawing.Color.White;
			label67.Location = new System.Drawing.Point(334, 293);
			label67.Name = "label67";
			label67.Size = new System.Drawing.Size(2, 2);
			label67.TabIndex = 217;
			label68.BackColor = System.Drawing.Color.White;
			label68.Location = new System.Drawing.Point(334, 284);
			label68.Name = "label68";
			label68.Size = new System.Drawing.Size(2, 2);
			label68.TabIndex = 216;
			label69.BackColor = System.Drawing.Color.White;
			label69.Location = new System.Drawing.Point(334, 275);
			label69.Name = "label69";
			label69.Size = new System.Drawing.Size(2, 2);
			label69.TabIndex = 215;
			label70.BackColor = System.Drawing.Color.White;
			label70.Location = new System.Drawing.Point(334, 266);
			label70.Name = "label70";
			label70.Size = new System.Drawing.Size(2, 2);
			label70.TabIndex = 218;
			label71.BackColor = System.Drawing.Color.Black;
			label71.Image = (System.Drawing.Image)resources.GetObject("label71.Image");
			label71.Location = new System.Drawing.Point(330, 298);
			label71.Name = "label71";
			label71.Size = new System.Drawing.Size(10, 10);
			label71.TabIndex = 222;
			label72.BackColor = System.Drawing.Color.White;
			label72.Location = new System.Drawing.Point(326, 302);
			label72.Name = "label72";
			label72.Size = new System.Drawing.Size(2, 2);
			label72.TabIndex = 221;
			label73.BackColor = System.Drawing.Color.White;
			label73.Location = new System.Drawing.Point(318, 302);
			label73.Name = "label73";
			label73.Size = new System.Drawing.Size(2, 2);
			label73.TabIndex = 220;
			label74.BackColor = System.Drawing.Color.White;
			label74.Location = new System.Drawing.Point(310, 302);
			label74.Name = "label74";
			label74.Size = new System.Drawing.Size(2, 2);
			label74.TabIndex = 219;
			label76.BackColor = System.Drawing.Color.White;
			label76.Location = new System.Drawing.Point(310, 311);
			label76.Name = "label76";
			label76.Size = new System.Drawing.Size(2, 2);
			label76.TabIndex = 226;
			label77.BackColor = System.Drawing.Color.White;
			label77.Location = new System.Drawing.Point(310, 338);
			label77.Name = "label77";
			label77.Size = new System.Drawing.Size(2, 2);
			label77.TabIndex = 225;
			label78.BackColor = System.Drawing.Color.White;
			label78.Location = new System.Drawing.Point(310, 329);
			label78.Name = "label78";
			label78.Size = new System.Drawing.Size(2, 2);
			label78.TabIndex = 224;
			label79.BackColor = System.Drawing.Color.White;
			label79.Location = new System.Drawing.Point(310, 320);
			label79.Name = "label79";
			label79.Size = new System.Drawing.Size(2, 2);
			label79.TabIndex = 223;
			label80.BackColor = System.Drawing.Color.White;
			label80.Location = new System.Drawing.Point(301, 338);
			label80.Name = "label80";
			label80.Size = new System.Drawing.Size(2, 2);
			label80.TabIndex = 230;
			label81.BackColor = System.Drawing.Color.White;
			label81.Location = new System.Drawing.Point(292, 338);
			label81.Name = "label81";
			label81.Size = new System.Drawing.Size(2, 2);
			label81.TabIndex = 229;
			label82.BackColor = System.Drawing.Color.White;
			label82.Location = new System.Drawing.Point(283, 338);
			label82.Name = "label82";
			label82.Size = new System.Drawing.Size(2, 2);
			label82.TabIndex = 228;
			label83.BackColor = System.Drawing.Color.White;
			label83.Location = new System.Drawing.Point(274, 338);
			label83.Name = "label83";
			label83.Size = new System.Drawing.Size(2, 2);
			label83.TabIndex = 227;
			label75.BackColor = System.Drawing.Color.White;
			label75.Location = new System.Drawing.Point(274, 311);
			label75.Name = "label75";
			label75.Size = new System.Drawing.Size(2, 2);
			label75.TabIndex = 233;
			label84.BackColor = System.Drawing.Color.White;
			label84.Location = new System.Drawing.Point(274, 329);
			label84.Name = "label84";
			label84.Size = new System.Drawing.Size(2, 2);
			label84.TabIndex = 232;
			label85.BackColor = System.Drawing.Color.White;
			label85.Location = new System.Drawing.Point(274, 320);
			label85.Name = "label85";
			label85.Size = new System.Drawing.Size(2, 2);
			label85.TabIndex = 231;
			label86.BackColor = System.Drawing.Color.White;
			label86.Location = new System.Drawing.Point(238, 311);
			label86.Name = "label86";
			label86.Size = new System.Drawing.Size(2, 2);
			label86.TabIndex = 237;
			label87.BackColor = System.Drawing.Color.White;
			label87.Location = new System.Drawing.Point(238, 329);
			label87.Name = "label87";
			label87.Size = new System.Drawing.Size(2, 2);
			label87.TabIndex = 236;
			label88.BackColor = System.Drawing.Color.White;
			label88.Location = new System.Drawing.Point(238, 320);
			label88.Name = "label88";
			label88.Size = new System.Drawing.Size(2, 2);
			label88.TabIndex = 235;
			label89.BackColor = System.Drawing.Color.White;
			label89.Location = new System.Drawing.Point(238, 338);
			label89.Name = "label89";
			label89.Size = new System.Drawing.Size(2, 2);
			label89.TabIndex = 234;
			label90.BackColor = System.Drawing.Color.White;
			label90.Location = new System.Drawing.Point(220, 338);
			label90.Name = "label90";
			label90.Size = new System.Drawing.Size(2, 2);
			label90.TabIndex = 242;
			label91.BackColor = System.Drawing.Color.White;
			label91.Location = new System.Drawing.Point(211, 338);
			label91.Name = "label91";
			label91.Size = new System.Drawing.Size(2, 2);
			label91.TabIndex = 241;
			label92.BackColor = System.Drawing.Color.White;
			label92.Location = new System.Drawing.Point(202, 338);
			label92.Name = "label92";
			label92.Size = new System.Drawing.Size(2, 2);
			label92.TabIndex = 240;
			label94.BackColor = System.Drawing.Color.White;
			label94.Location = new System.Drawing.Point(229, 338);
			label94.Name = "label94";
			label94.Size = new System.Drawing.Size(2, 2);
			label94.TabIndex = 238;
			label93.BackColor = System.Drawing.Color.White;
			label93.Location = new System.Drawing.Point(202, 356);
			label93.Name = "label93";
			label93.Size = new System.Drawing.Size(2, 2);
			label93.TabIndex = 247;
			label95.BackColor = System.Drawing.Color.White;
			label95.Location = new System.Drawing.Point(202, 374);
			label95.Name = "label95";
			label95.Size = new System.Drawing.Size(2, 2);
			label95.TabIndex = 246;
			label96.BackColor = System.Drawing.Color.White;
			label96.Location = new System.Drawing.Point(202, 365);
			label96.Name = "label96";
			label96.Size = new System.Drawing.Size(2, 2);
			label96.TabIndex = 245;
			label98.BackColor = System.Drawing.Color.White;
			label98.Location = new System.Drawing.Point(202, 347);
			label98.Name = "label98";
			label98.Size = new System.Drawing.Size(2, 2);
			label98.TabIndex = 243;
			label97.BackColor = System.Drawing.Color.White;
			label97.Location = new System.Drawing.Point(334, 356);
			label97.Name = "label97";
			label97.Size = new System.Drawing.Size(2, 2);
			label97.TabIndex = 252;
			label99.BackColor = System.Drawing.Color.White;
			label99.Location = new System.Drawing.Point(334, 374);
			label99.Name = "label99";
			label99.Size = new System.Drawing.Size(2, 2);
			label99.TabIndex = 251;
			label100.BackColor = System.Drawing.Color.White;
			label100.Location = new System.Drawing.Point(334, 365);
			label100.Name = "label100";
			label100.Size = new System.Drawing.Size(2, 2);
			label100.TabIndex = 250;
			label101.BackColor = System.Drawing.Color.White;
			label101.Location = new System.Drawing.Point(334, 347);
			label101.Name = "label101";
			label101.Size = new System.Drawing.Size(2, 2);
			label101.TabIndex = 249;
			label102.BackColor = System.Drawing.Color.White;
			label102.Location = new System.Drawing.Point(334, 338);
			label102.Name = "label102";
			label102.Size = new System.Drawing.Size(2, 2);
			label102.TabIndex = 248;
			label103.BackColor = System.Drawing.Color.White;
			label103.Location = new System.Drawing.Point(326, 338);
			label103.Name = "label103";
			label103.Size = new System.Drawing.Size(2, 2);
			label103.TabIndex = 254;
			label104.BackColor = System.Drawing.Color.White;
			label104.Location = new System.Drawing.Point(318, 338);
			label104.Name = "label104";
			label104.Size = new System.Drawing.Size(2, 2);
			label104.TabIndex = 253;
			label105.BackColor = System.Drawing.Color.White;
			label105.Location = new System.Drawing.Point(326, 374);
			label105.Name = "label105";
			label105.Size = new System.Drawing.Size(2, 2);
			label105.TabIndex = 268;
			label106.BackColor = System.Drawing.Color.White;
			label106.Location = new System.Drawing.Point(247, 374);
			label106.Name = "label106";
			label106.Size = new System.Drawing.Size(2, 2);
			label106.TabIndex = 267;
			label107.BackColor = System.Drawing.Color.White;
			label107.Location = new System.Drawing.Point(238, 374);
			label107.Name = "label107";
			label107.Size = new System.Drawing.Size(2, 2);
			label107.TabIndex = 266;
			label108.BackColor = System.Drawing.Color.White;
			label108.Location = new System.Drawing.Point(229, 374);
			label108.Name = "label108";
			label108.Size = new System.Drawing.Size(2, 2);
			label108.TabIndex = 265;
			label109.BackColor = System.Drawing.Color.White;
			label109.Location = new System.Drawing.Point(220, 374);
			label109.Name = "label109";
			label109.Size = new System.Drawing.Size(2, 2);
			label109.TabIndex = 264;
			label110.BackColor = System.Drawing.Color.White;
			label110.Location = new System.Drawing.Point(211, 374);
			label110.Name = "label110";
			label110.Size = new System.Drawing.Size(2, 2);
			label110.TabIndex = 263;
			label111.BackColor = System.Drawing.Color.White;
			label111.Location = new System.Drawing.Point(318, 374);
			label111.Name = "label111";
			label111.Size = new System.Drawing.Size(2, 2);
			label111.TabIndex = 262;
			label112.BackColor = System.Drawing.Color.White;
			label112.Location = new System.Drawing.Point(310, 374);
			label112.Name = "label112";
			label112.Size = new System.Drawing.Size(2, 2);
			label112.TabIndex = 261;
			label113.BackColor = System.Drawing.Color.White;
			label113.Location = new System.Drawing.Point(301, 374);
			label113.Name = "label113";
			label113.Size = new System.Drawing.Size(2, 2);
			label113.TabIndex = 260;
			label114.BackColor = System.Drawing.Color.White;
			label114.Location = new System.Drawing.Point(292, 374);
			label114.Name = "label114";
			label114.Size = new System.Drawing.Size(2, 2);
			label114.TabIndex = 259;
			label115.BackColor = System.Drawing.Color.White;
			label115.Location = new System.Drawing.Point(283, 374);
			label115.Name = "label115";
			label115.Size = new System.Drawing.Size(2, 2);
			label115.TabIndex = 258;
			label116.BackColor = System.Drawing.Color.White;
			label116.Location = new System.Drawing.Point(274, 374);
			label116.Name = "label116";
			label116.Size = new System.Drawing.Size(2, 2);
			label116.TabIndex = 257;
			label117.BackColor = System.Drawing.Color.White;
			label117.Location = new System.Drawing.Point(265, 374);
			label117.Name = "label117";
			label117.Size = new System.Drawing.Size(2, 2);
			label117.TabIndex = 256;
			label118.BackColor = System.Drawing.Color.White;
			label118.Location = new System.Drawing.Point(256, 374);
			label118.Name = "label118";
			label118.Size = new System.Drawing.Size(2, 2);
			label118.TabIndex = 255;
			label119.BackColor = System.Drawing.Color.White;
			label119.Location = new System.Drawing.Point(157, 374);
			label119.Name = "label119";
			label119.Size = new System.Drawing.Size(2, 2);
			label119.TabIndex = 312;
			label120.BackColor = System.Drawing.Color.White;
			label120.Location = new System.Drawing.Point(78, 374);
			label120.Name = "label120";
			label120.Size = new System.Drawing.Size(2, 2);
			label120.TabIndex = 311;
			label121.BackColor = System.Drawing.Color.White;
			label121.Location = new System.Drawing.Point(69, 374);
			label121.Name = "label121";
			label121.Size = new System.Drawing.Size(2, 2);
			label121.TabIndex = 310;
			label122.BackColor = System.Drawing.Color.White;
			label122.Location = new System.Drawing.Point(60, 374);
			label122.Name = "label122";
			label122.Size = new System.Drawing.Size(2, 2);
			label122.TabIndex = 309;
			label123.BackColor = System.Drawing.Color.White;
			label123.Location = new System.Drawing.Point(51, 374);
			label123.Name = "label123";
			label123.Size = new System.Drawing.Size(2, 2);
			label123.TabIndex = 308;
			label125.BackColor = System.Drawing.Color.White;
			label125.Location = new System.Drawing.Point(149, 374);
			label125.Name = "label125";
			label125.Size = new System.Drawing.Size(2, 2);
			label125.TabIndex = 306;
			label126.BackColor = System.Drawing.Color.White;
			label126.Location = new System.Drawing.Point(141, 374);
			label126.Name = "label126";
			label126.Size = new System.Drawing.Size(2, 2);
			label126.TabIndex = 305;
			label127.BackColor = System.Drawing.Color.White;
			label127.Location = new System.Drawing.Point(132, 374);
			label127.Name = "label127";
			label127.Size = new System.Drawing.Size(2, 2);
			label127.TabIndex = 304;
			label128.BackColor = System.Drawing.Color.White;
			label128.Location = new System.Drawing.Point(123, 374);
			label128.Name = "label128";
			label128.Size = new System.Drawing.Size(2, 2);
			label128.TabIndex = 303;
			label129.BackColor = System.Drawing.Color.White;
			label129.Location = new System.Drawing.Point(114, 374);
			label129.Name = "label129";
			label129.Size = new System.Drawing.Size(2, 2);
			label129.TabIndex = 302;
			label130.BackColor = System.Drawing.Color.White;
			label130.Location = new System.Drawing.Point(105, 374);
			label130.Name = "label130";
			label130.Size = new System.Drawing.Size(2, 2);
			label130.TabIndex = 301;
			label131.BackColor = System.Drawing.Color.White;
			label131.Location = new System.Drawing.Point(96, 374);
			label131.Name = "label131";
			label131.Size = new System.Drawing.Size(2, 2);
			label131.TabIndex = 300;
			label132.BackColor = System.Drawing.Color.White;
			label132.Location = new System.Drawing.Point(87, 374);
			label132.Name = "label132";
			label132.Size = new System.Drawing.Size(2, 2);
			label132.TabIndex = 299;
			label133.BackColor = System.Drawing.Color.White;
			label133.Location = new System.Drawing.Point(156, 338);
			label133.Name = "label133";
			label133.Size = new System.Drawing.Size(2, 2);
			label133.TabIndex = 298;
			label134.BackColor = System.Drawing.Color.White;
			label134.Location = new System.Drawing.Point(147, 338);
			label134.Name = "label134";
			label134.Size = new System.Drawing.Size(2, 2);
			label134.TabIndex = 297;
			label135.BackColor = System.Drawing.Color.White;
			label135.Location = new System.Drawing.Point(165, 356);
			label135.Name = "label135";
			label135.Size = new System.Drawing.Size(2, 2);
			label135.TabIndex = 296;
			label136.BackColor = System.Drawing.Color.White;
			label136.Location = new System.Drawing.Point(165, 374);
			label136.Name = "label136";
			label136.Size = new System.Drawing.Size(2, 2);
			label136.TabIndex = 295;
			label137.BackColor = System.Drawing.Color.White;
			label137.Location = new System.Drawing.Point(165, 365);
			label137.Name = "label137";
			label137.Size = new System.Drawing.Size(2, 2);
			label137.TabIndex = 294;
			label138.BackColor = System.Drawing.Color.White;
			label138.Location = new System.Drawing.Point(165, 347);
			label138.Name = "label138";
			label138.Size = new System.Drawing.Size(2, 2);
			label138.TabIndex = 293;
			label139.BackColor = System.Drawing.Color.White;
			label139.Location = new System.Drawing.Point(165, 338);
			label139.Name = "label139";
			label139.Size = new System.Drawing.Size(2, 2);
			label139.TabIndex = 292;
			label140.BackColor = System.Drawing.Color.White;
			label140.Location = new System.Drawing.Point(35, 356);
			label140.Name = "label140";
			label140.Size = new System.Drawing.Size(2, 2);
			label140.TabIndex = 291;
			label143.BackColor = System.Drawing.Color.White;
			label143.Location = new System.Drawing.Point(35, 347);
			label143.Name = "label143";
			label143.Size = new System.Drawing.Size(2, 2);
			label143.TabIndex = 288;
			label144.BackColor = System.Drawing.Color.White;
			label144.Location = new System.Drawing.Point(50, 338);
			label144.Name = "label144";
			label144.Size = new System.Drawing.Size(2, 2);
			label144.TabIndex = 287;
			label145.BackColor = System.Drawing.Color.White;
			label145.Location = new System.Drawing.Point(42, 338);
			label145.Name = "label145";
			label145.Size = new System.Drawing.Size(2, 2);
			label145.TabIndex = 286;
			label146.BackColor = System.Drawing.Color.White;
			label146.Location = new System.Drawing.Point(35, 338);
			label146.Name = "label146";
			label146.Size = new System.Drawing.Size(2, 2);
			label146.TabIndex = 285;
			label147.BackColor = System.Drawing.Color.White;
			label147.Location = new System.Drawing.Point(59, 338);
			label147.Name = "label147";
			label147.Size = new System.Drawing.Size(2, 2);
			label147.TabIndex = 284;
			label148.BackColor = System.Drawing.Color.White;
			label148.Location = new System.Drawing.Point(59, 311);
			label148.Name = "label148";
			label148.Size = new System.Drawing.Size(2, 2);
			label148.TabIndex = 283;
			label149.BackColor = System.Drawing.Color.White;
			label149.Location = new System.Drawing.Point(59, 329);
			label149.Name = "label149";
			label149.Size = new System.Drawing.Size(2, 2);
			label149.TabIndex = 282;
			label150.BackColor = System.Drawing.Color.White;
			label150.Location = new System.Drawing.Point(59, 320);
			label150.Name = "label150";
			label150.Size = new System.Drawing.Size(2, 2);
			label150.TabIndex = 281;
			label151.BackColor = System.Drawing.Color.White;
			label151.Location = new System.Drawing.Point(68, 338);
			label151.Name = "label151";
			label151.Size = new System.Drawing.Size(2, 2);
			label151.TabIndex = 280;
			label152.BackColor = System.Drawing.Color.White;
			label152.Location = new System.Drawing.Point(94, 311);
			label152.Name = "label152";
			label152.Size = new System.Drawing.Size(2, 2);
			label152.TabIndex = 279;
			label153.BackColor = System.Drawing.Color.White;
			label153.Location = new System.Drawing.Point(94, 329);
			label153.Name = "label153";
			label153.Size = new System.Drawing.Size(2, 2);
			label153.TabIndex = 278;
			label154.BackColor = System.Drawing.Color.White;
			label154.Location = new System.Drawing.Point(94, 320);
			label154.Name = "label154";
			label154.Size = new System.Drawing.Size(2, 2);
			label154.TabIndex = 277;
			label155.BackColor = System.Drawing.Color.White;
			label155.Location = new System.Drawing.Point(129, 338);
			label155.Name = "label155";
			label155.Size = new System.Drawing.Size(2, 2);
			label155.TabIndex = 276;
			label156.BackColor = System.Drawing.Color.White;
			label156.Location = new System.Drawing.Point(94, 338);
			label156.Name = "label156";
			label156.Size = new System.Drawing.Size(2, 2);
			label156.TabIndex = 275;
			label157.BackColor = System.Drawing.Color.White;
			label157.Location = new System.Drawing.Point(85, 338);
			label157.Name = "label157";
			label157.Size = new System.Drawing.Size(2, 2);
			label157.TabIndex = 274;
			label158.BackColor = System.Drawing.Color.White;
			label158.Location = new System.Drawing.Point(76, 338);
			label158.Name = "label158";
			label158.Size = new System.Drawing.Size(2, 2);
			label158.TabIndex = 273;
			label159.BackColor = System.Drawing.Color.White;
			label159.Location = new System.Drawing.Point(129, 311);
			label159.Name = "label159";
			label159.Size = new System.Drawing.Size(2, 2);
			label159.TabIndex = 272;
			label160.BackColor = System.Drawing.Color.White;
			label160.Location = new System.Drawing.Point(138, 338);
			label160.Name = "label160";
			label160.Size = new System.Drawing.Size(2, 2);
			label160.TabIndex = 271;
			label161.BackColor = System.Drawing.Color.White;
			label161.Location = new System.Drawing.Point(129, 329);
			label161.Name = "label161";
			label161.Size = new System.Drawing.Size(2, 2);
			label161.TabIndex = 270;
			label162.BackColor = System.Drawing.Color.White;
			label162.Location = new System.Drawing.Point(129, 320);
			label162.Name = "label162";
			label162.Size = new System.Drawing.Size(2, 2);
			label162.TabIndex = 269;
			label163.BackColor = System.Drawing.Color.White;
			label163.Location = new System.Drawing.Point(192, 374);
			label163.Name = "label163";
			label163.Size = new System.Drawing.Size(2, 2);
			label163.TabIndex = 315;
			label164.BackColor = System.Drawing.Color.White;
			label164.Location = new System.Drawing.Point(183, 374);
			label164.Name = "label164";
			label164.Size = new System.Drawing.Size(2, 2);
			label164.TabIndex = 314;
			label165.BackColor = System.Drawing.Color.White;
			label165.Location = new System.Drawing.Point(174, 374);
			label165.Name = "label165";
			label165.Size = new System.Drawing.Size(2, 2);
			label165.TabIndex = 313;
			label166.BackColor = System.Drawing.Color.White;
			label166.Location = new System.Drawing.Point(35, 293);
			label166.Name = "label166";
			label166.Size = new System.Drawing.Size(2, 2);
			label166.TabIndex = 318;
			label167.BackColor = System.Drawing.Color.White;
			label167.Location = new System.Drawing.Point(35, 284);
			label167.Name = "label167";
			label167.Size = new System.Drawing.Size(2, 2);
			label167.TabIndex = 317;
			label168.BackColor = System.Drawing.Color.White;
			label168.Location = new System.Drawing.Point(35, 275);
			label168.Name = "label168";
			label168.Size = new System.Drawing.Size(2, 2);
			label168.TabIndex = 316;
			label169.BackColor = System.Drawing.Color.White;
			label169.Location = new System.Drawing.Point(86, 266);
			label169.Name = "label169";
			label169.Size = new System.Drawing.Size(2, 2);
			label169.TabIndex = 319;
			label170.BackColor = System.Drawing.Color.White;
			label170.Location = new System.Drawing.Point(59, 302);
			label170.Name = "label170";
			label170.Size = new System.Drawing.Size(2, 2);
			label170.TabIndex = 323;
			label171.BackColor = System.Drawing.Color.White;
			label171.Location = new System.Drawing.Point(51, 302);
			label171.Name = "label171";
			label171.Size = new System.Drawing.Size(2, 2);
			label171.TabIndex = 322;
			label172.BackColor = System.Drawing.Color.White;
			label172.Location = new System.Drawing.Point(43, 302);
			label172.Name = "label172";
			label172.Size = new System.Drawing.Size(2, 2);
			label172.TabIndex = 321;
			label173.BackColor = System.Drawing.Color.Black;
			label173.Image = (System.Drawing.Image)resources.GetObject("label173.Image");
			label173.Location = new System.Drawing.Point(31, 298);
			label173.Name = "label173";
			label173.Size = new System.Drawing.Size(10, 10);
			label173.TabIndex = 320;
			label174.BackColor = System.Drawing.Color.White;
			label174.Location = new System.Drawing.Point(274, 230);
			label174.Name = "label174";
			label174.Size = new System.Drawing.Size(2, 2);
			label174.TabIndex = 333;
			label175.BackColor = System.Drawing.Color.White;
			label175.Location = new System.Drawing.Point(274, 248);
			label175.Name = "label175";
			label175.Size = new System.Drawing.Size(2, 2);
			label175.TabIndex = 332;
			label176.BackColor = System.Drawing.Color.White;
			label176.Location = new System.Drawing.Point(274, 239);
			label176.Name = "label176";
			label176.Size = new System.Drawing.Size(2, 2);
			label176.TabIndex = 331;
			label177.BackColor = System.Drawing.Color.White;
			label177.Location = new System.Drawing.Point(274, 257);
			label177.Name = "label177";
			label177.Size = new System.Drawing.Size(2, 2);
			label177.TabIndex = 330;
			label178.BackColor = System.Drawing.Color.White;
			label178.Location = new System.Drawing.Point(274, 212);
			label178.Name = "label178";
			label178.Size = new System.Drawing.Size(2, 2);
			label178.TabIndex = 329;
			label179.BackColor = System.Drawing.Color.White;
			label179.Location = new System.Drawing.Point(274, 203);
			label179.Name = "label179";
			label179.Size = new System.Drawing.Size(2, 2);
			label179.TabIndex = 328;
			label180.BackColor = System.Drawing.Color.White;
			label180.Location = new System.Drawing.Point(274, 194);
			label180.Name = "label180";
			label180.Size = new System.Drawing.Size(2, 2);
			label180.TabIndex = 327;
			label181.BackColor = System.Drawing.Color.White;
			label181.Location = new System.Drawing.Point(274, 221);
			label181.Name = "label181";
			label181.Size = new System.Drawing.Size(2, 2);
			label181.TabIndex = 326;
			label182.BackColor = System.Drawing.Color.White;
			label182.Location = new System.Drawing.Point(274, 185);
			label182.Name = "label182";
			label182.Size = new System.Drawing.Size(2, 2);
			label182.TabIndex = 325;
			label183.BackColor = System.Drawing.Color.White;
			label183.Location = new System.Drawing.Point(274, 149);
			label183.Name = "label183";
			label183.Size = new System.Drawing.Size(2, 2);
			label183.TabIndex = 342;
			label184.BackColor = System.Drawing.Color.White;
			label184.Location = new System.Drawing.Point(274, 167);
			label184.Name = "label184";
			label184.Size = new System.Drawing.Size(2, 2);
			label184.TabIndex = 341;
			label185.BackColor = System.Drawing.Color.White;
			label185.Location = new System.Drawing.Point(274, 158);
			label185.Name = "label185";
			label185.Size = new System.Drawing.Size(2, 2);
			label185.TabIndex = 340;
			label186.BackColor = System.Drawing.Color.White;
			label186.Location = new System.Drawing.Point(274, 176);
			label186.Name = "label186";
			label186.Size = new System.Drawing.Size(2, 2);
			label186.TabIndex = 339;
			label187.BackColor = System.Drawing.Color.White;
			label187.Location = new System.Drawing.Point(274, 131);
			label187.Name = "label187";
			label187.Size = new System.Drawing.Size(2, 2);
			label187.TabIndex = 338;
			label188.BackColor = System.Drawing.Color.White;
			label188.Location = new System.Drawing.Point(274, 122);
			label188.Name = "label188";
			label188.Size = new System.Drawing.Size(2, 2);
			label188.TabIndex = 337;
			label189.BackColor = System.Drawing.Color.White;
			label189.Location = new System.Drawing.Point(274, 113);
			label189.Name = "label189";
			label189.Size = new System.Drawing.Size(2, 2);
			label189.TabIndex = 336;
			label190.BackColor = System.Drawing.Color.White;
			label190.Location = new System.Drawing.Point(274, 140);
			label190.Name = "label190";
			label190.Size = new System.Drawing.Size(2, 2);
			label190.TabIndex = 335;
			label191.BackColor = System.Drawing.Color.White;
			label191.Location = new System.Drawing.Point(274, 104);
			label191.Name = "label191";
			label191.Size = new System.Drawing.Size(2, 2);
			label191.TabIndex = 334;
			label192.BackColor = System.Drawing.Color.White;
			label192.Location = new System.Drawing.Point(274, 66);
			label192.Name = "label192";
			label192.Size = new System.Drawing.Size(2, 2);
			label192.TabIndex = 351;
			label193.BackColor = System.Drawing.Color.White;
			label193.Location = new System.Drawing.Point(274, 85);
			label193.Name = "label193";
			label193.Size = new System.Drawing.Size(2, 2);
			label193.TabIndex = 350;
			label194.BackColor = System.Drawing.Color.White;
			label194.Location = new System.Drawing.Point(274, 76);
			label194.Name = "label194";
			label194.Size = new System.Drawing.Size(2, 2);
			label194.TabIndex = 349;
			label195.BackColor = System.Drawing.Color.White;
			label195.Location = new System.Drawing.Point(274, 94);
			label195.Name = "label195";
			label195.Size = new System.Drawing.Size(2, 2);
			label195.TabIndex = 348;
			label196.BackColor = System.Drawing.Color.White;
			label196.Location = new System.Drawing.Point(274, 47);
			label196.Name = "label196";
			label196.Size = new System.Drawing.Size(2, 2);
			label196.TabIndex = 347;
			label199.BackColor = System.Drawing.Color.White;
			label199.Location = new System.Drawing.Point(274, 57);
			label199.Name = "label199";
			label199.Size = new System.Drawing.Size(2, 2);
			label199.TabIndex = 344;
			label198.BackColor = System.Drawing.Color.White;
			label198.Location = new System.Drawing.Point(334, 38);
			label198.Name = "label198";
			label198.Size = new System.Drawing.Size(2, 2);
			label198.TabIndex = 367;
			label200.BackColor = System.Drawing.Color.White;
			label200.Location = new System.Drawing.Point(326, 38);
			label200.Name = "label200";
			label200.Size = new System.Drawing.Size(2, 2);
			label200.TabIndex = 366;
			label201.BackColor = System.Drawing.Color.White;
			label201.Location = new System.Drawing.Point(247, 38);
			label201.Name = "label201";
			label201.Size = new System.Drawing.Size(2, 2);
			label201.TabIndex = 365;
			label202.BackColor = System.Drawing.Color.White;
			label202.Location = new System.Drawing.Point(238, 38);
			label202.Name = "label202";
			label202.Size = new System.Drawing.Size(2, 2);
			label202.TabIndex = 364;
			label203.BackColor = System.Drawing.Color.White;
			label203.Location = new System.Drawing.Point(229, 38);
			label203.Name = "label203";
			label203.Size = new System.Drawing.Size(2, 2);
			label203.TabIndex = 363;
			label204.BackColor = System.Drawing.Color.White;
			label204.Location = new System.Drawing.Point(220, 38);
			label204.Name = "label204";
			label204.Size = new System.Drawing.Size(2, 2);
			label204.TabIndex = 362;
			label205.BackColor = System.Drawing.Color.White;
			label205.Location = new System.Drawing.Point(211, 38);
			label205.Name = "label205";
			label205.Size = new System.Drawing.Size(2, 2);
			label205.TabIndex = 361;
			label206.BackColor = System.Drawing.Color.White;
			label206.Location = new System.Drawing.Point(202, 38);
			label206.Name = "label206";
			label206.Size = new System.Drawing.Size(2, 2);
			label206.TabIndex = 360;
			label207.BackColor = System.Drawing.Color.White;
			label207.Location = new System.Drawing.Point(318, 38);
			label207.Name = "label207";
			label207.Size = new System.Drawing.Size(2, 2);
			label207.TabIndex = 359;
			label208.BackColor = System.Drawing.Color.White;
			label208.Location = new System.Drawing.Point(310, 38);
			label208.Name = "label208";
			label208.Size = new System.Drawing.Size(2, 2);
			label208.TabIndex = 358;
			label209.BackColor = System.Drawing.Color.White;
			label209.Location = new System.Drawing.Point(301, 38);
			label209.Name = "label209";
			label209.Size = new System.Drawing.Size(2, 2);
			label209.TabIndex = 357;
			label210.BackColor = System.Drawing.Color.White;
			label210.Location = new System.Drawing.Point(292, 38);
			label210.Name = "label210";
			label210.Size = new System.Drawing.Size(2, 2);
			label210.TabIndex = 356;
			label211.BackColor = System.Drawing.Color.White;
			label211.Location = new System.Drawing.Point(283, 38);
			label211.Name = "label211";
			label211.Size = new System.Drawing.Size(2, 2);
			label211.TabIndex = 355;
			label212.BackColor = System.Drawing.Color.White;
			label212.Location = new System.Drawing.Point(274, 38);
			label212.Name = "label212";
			label212.Size = new System.Drawing.Size(2, 2);
			label212.TabIndex = 354;
			label213.BackColor = System.Drawing.Color.White;
			label213.Location = new System.Drawing.Point(265, 38);
			label213.Name = "label213";
			label213.Size = new System.Drawing.Size(2, 2);
			label213.TabIndex = 353;
			label214.BackColor = System.Drawing.Color.White;
			label214.Location = new System.Drawing.Point(256, 38);
			label214.Name = "label214";
			label214.Size = new System.Drawing.Size(2, 2);
			label214.TabIndex = 352;
			label197.BackColor = System.Drawing.Color.White;
			label197.Location = new System.Drawing.Point(334, 94);
			label197.Name = "label197";
			label197.Size = new System.Drawing.Size(2, 2);
			label197.TabIndex = 376;
			label215.BackColor = System.Drawing.Color.White;
			label215.Location = new System.Drawing.Point(334, 113);
			label215.Name = "label215";
			label215.Size = new System.Drawing.Size(2, 2);
			label215.TabIndex = 375;
			label216.BackColor = System.Drawing.Color.White;
			label216.Location = new System.Drawing.Point(334, 104);
			label216.Name = "label216";
			label216.Size = new System.Drawing.Size(2, 2);
			label216.TabIndex = 374;
			label217.BackColor = System.Drawing.Color.White;
			label217.Location = new System.Drawing.Point(334, 122);
			label217.Name = "label217";
			label217.Size = new System.Drawing.Size(2, 2);
			label217.TabIndex = 373;
			label218.BackColor = System.Drawing.Color.White;
			label218.Location = new System.Drawing.Point(334, 76);
			label218.Name = "label218";
			label218.Size = new System.Drawing.Size(2, 2);
			label218.TabIndex = 372;
			label219.BackColor = System.Drawing.Color.White;
			label219.Location = new System.Drawing.Point(334, 67);
			label219.Name = "label219";
			label219.Size = new System.Drawing.Size(2, 2);
			label219.TabIndex = 371;
			label220.BackColor = System.Drawing.Color.Black;
			label220.Image = (System.Drawing.Image)resources.GetObject("label220.Image");
			label220.Location = new System.Drawing.Point(330, 54);
			label220.Name = "label220";
			label220.Size = new System.Drawing.Size(10, 10);
			label220.TabIndex = 370;
			label221.BackColor = System.Drawing.Color.White;
			label221.Location = new System.Drawing.Point(334, 85);
			label221.Name = "label221";
			label221.Size = new System.Drawing.Size(2, 2);
			label221.TabIndex = 369;
			label222.BackColor = System.Drawing.Color.White;
			label222.Location = new System.Drawing.Point(334, 48);
			label222.Name = "label222";
			label222.Size = new System.Drawing.Size(2, 2);
			label222.TabIndex = 368;
			label223.BackColor = System.Drawing.Color.White;
			label223.Location = new System.Drawing.Point(326, 85);
			label223.Name = "label223";
			label223.Size = new System.Drawing.Size(2, 2);
			label223.TabIndex = 382;
			label224.BackColor = System.Drawing.Color.White;
			label224.Location = new System.Drawing.Point(318, 85);
			label224.Name = "label224";
			label224.Size = new System.Drawing.Size(2, 2);
			label224.TabIndex = 381;
			label225.BackColor = System.Drawing.Color.White;
			label225.Location = new System.Drawing.Point(310, 85);
			label225.Name = "label225";
			label225.Size = new System.Drawing.Size(2, 2);
			label225.TabIndex = 380;
			label226.BackColor = System.Drawing.Color.White;
			label226.Location = new System.Drawing.Point(301, 85);
			label226.Name = "label226";
			label226.Size = new System.Drawing.Size(2, 2);
			label226.TabIndex = 379;
			label227.BackColor = System.Drawing.Color.White;
			label227.Location = new System.Drawing.Point(292, 85);
			label227.Name = "label227";
			label227.Size = new System.Drawing.Size(2, 2);
			label227.TabIndex = 378;
			label228.BackColor = System.Drawing.Color.White;
			label228.Location = new System.Drawing.Point(283, 85);
			label228.Name = "label228";
			label228.Size = new System.Drawing.Size(2, 2);
			label228.TabIndex = 377;
			label229.BackColor = System.Drawing.Color.White;
			label229.Location = new System.Drawing.Point(326, 122);
			label229.Name = "label229";
			label229.Size = new System.Drawing.Size(2, 2);
			label229.TabIndex = 388;
			label230.BackColor = System.Drawing.Color.White;
			label230.Location = new System.Drawing.Point(318, 122);
			label230.Name = "label230";
			label230.Size = new System.Drawing.Size(2, 2);
			label230.TabIndex = 387;
			label231.BackColor = System.Drawing.Color.White;
			label231.Location = new System.Drawing.Point(310, 122);
			label231.Name = "label231";
			label231.Size = new System.Drawing.Size(2, 2);
			label231.TabIndex = 386;
			label232.BackColor = System.Drawing.Color.White;
			label232.Location = new System.Drawing.Point(301, 122);
			label232.Name = "label232";
			label232.Size = new System.Drawing.Size(2, 2);
			label232.TabIndex = 385;
			label233.BackColor = System.Drawing.Color.White;
			label233.Location = new System.Drawing.Point(292, 122);
			label233.Name = "label233";
			label233.Size = new System.Drawing.Size(2, 2);
			label233.TabIndex = 384;
			label234.BackColor = System.Drawing.Color.White;
			label234.Location = new System.Drawing.Point(283, 122);
			label234.Name = "label234";
			label234.Size = new System.Drawing.Size(2, 2);
			label234.TabIndex = 383;
			label235.BackColor = System.Drawing.Color.White;
			label235.Location = new System.Drawing.Point(247, 85);
			label235.Name = "label235";
			label235.Size = new System.Drawing.Size(2, 2);
			label235.TabIndex = 396;
			label236.BackColor = System.Drawing.Color.White;
			label236.Location = new System.Drawing.Point(238, 85);
			label236.Name = "label236";
			label236.Size = new System.Drawing.Size(2, 2);
			label236.TabIndex = 395;
			label237.BackColor = System.Drawing.Color.White;
			label237.Location = new System.Drawing.Point(229, 85);
			label237.Name = "label237";
			label237.Size = new System.Drawing.Size(2, 2);
			label237.TabIndex = 394;
			label238.BackColor = System.Drawing.Color.White;
			label238.Location = new System.Drawing.Point(220, 85);
			label238.Name = "label238";
			label238.Size = new System.Drawing.Size(2, 2);
			label238.TabIndex = 393;
			label239.BackColor = System.Drawing.Color.White;
			label239.Location = new System.Drawing.Point(211, 85);
			label239.Name = "label239";
			label239.Size = new System.Drawing.Size(2, 2);
			label239.TabIndex = 392;
			label240.BackColor = System.Drawing.Color.White;
			label240.Location = new System.Drawing.Point(202, 85);
			label240.Name = "label240";
			label240.Size = new System.Drawing.Size(2, 2);
			label240.TabIndex = 391;
			label241.BackColor = System.Drawing.Color.White;
			label241.Location = new System.Drawing.Point(265, 85);
			label241.Name = "label241";
			label241.Size = new System.Drawing.Size(2, 2);
			label241.TabIndex = 390;
			label242.BackColor = System.Drawing.Color.White;
			label242.Location = new System.Drawing.Point(256, 85);
			label242.Name = "label242";
			label242.Size = new System.Drawing.Size(2, 2);
			label242.TabIndex = 389;
			label243.BackColor = System.Drawing.Color.White;
			label243.Location = new System.Drawing.Point(202, 66);
			label243.Name = "label243";
			label243.Size = new System.Drawing.Size(2, 2);
			label243.TabIndex = 400;
			label244.BackColor = System.Drawing.Color.White;
			label244.Location = new System.Drawing.Point(202, 76);
			label244.Name = "label244";
			label244.Size = new System.Drawing.Size(2, 2);
			label244.TabIndex = 399;
			label245.BackColor = System.Drawing.Color.White;
			label245.Location = new System.Drawing.Point(202, 47);
			label245.Name = "label245";
			label245.Size = new System.Drawing.Size(2, 2);
			label245.TabIndex = 398;
			label246.BackColor = System.Drawing.Color.White;
			label246.Location = new System.Drawing.Point(202, 57);
			label246.Name = "label246";
			label246.Size = new System.Drawing.Size(2, 2);
			label246.TabIndex = 397;
			label247.BackColor = System.Drawing.Color.White;
			label247.Location = new System.Drawing.Point(129, 94);
			label247.Name = "label247";
			label247.Size = new System.Drawing.Size(2, 2);
			label247.TabIndex = 419;
			label248.BackColor = System.Drawing.Color.White;
			label248.Location = new System.Drawing.Point(129, 112);
			label248.Name = "label248";
			label248.Size = new System.Drawing.Size(2, 2);
			label248.TabIndex = 418;
			label249.BackColor = System.Drawing.Color.White;
			label249.Location = new System.Drawing.Point(129, 103);
			label249.Name = "label249";
			label249.Size = new System.Drawing.Size(2, 2);
			label249.TabIndex = 417;
			label250.BackColor = System.Drawing.Color.White;
			label250.Location = new System.Drawing.Point(238, 94);
			label250.Name = "label250";
			label250.Size = new System.Drawing.Size(2, 2);
			label250.TabIndex = 416;
			label251.BackColor = System.Drawing.Color.White;
			label251.Location = new System.Drawing.Point(238, 112);
			label251.Name = "label251";
			label251.Size = new System.Drawing.Size(2, 2);
			label251.TabIndex = 415;
			label252.BackColor = System.Drawing.Color.White;
			label252.Location = new System.Drawing.Point(238, 103);
			label252.Name = "label252";
			label252.Size = new System.Drawing.Size(2, 2);
			label252.TabIndex = 414;
			label256.BackColor = System.Drawing.Color.White;
			label256.Location = new System.Drawing.Point(202, 122);
			label256.Name = "label256";
			label256.Size = new System.Drawing.Size(2, 2);
			label256.TabIndex = 410;
			label257.BackColor = System.Drawing.Color.White;
			label257.Location = new System.Drawing.Point(238, 122);
			label257.Name = "label257";
			label257.Size = new System.Drawing.Size(2, 2);
			label257.TabIndex = 409;
			label258.BackColor = System.Drawing.Color.White;
			label258.Location = new System.Drawing.Point(229, 122);
			label258.Name = "label258";
			label258.Size = new System.Drawing.Size(2, 2);
			label258.TabIndex = 408;
			label259.BackColor = System.Drawing.Color.White;
			label259.Location = new System.Drawing.Point(220, 122);
			label259.Name = "label259";
			label259.Size = new System.Drawing.Size(2, 2);
			label259.TabIndex = 407;
			label260.BackColor = System.Drawing.Color.White;
			label260.Location = new System.Drawing.Point(211, 122);
			label260.Name = "label260";
			label260.Size = new System.Drawing.Size(2, 2);
			label260.TabIndex = 406;
			label261.BackColor = System.Drawing.Color.White;
			label261.Location = new System.Drawing.Point(165, 122);
			label261.Name = "label261";
			label261.Size = new System.Drawing.Size(2, 2);
			label261.TabIndex = 405;
			label262.BackColor = System.Drawing.Color.White;
			label262.Location = new System.Drawing.Point(156, 122);
			label262.Name = "label262";
			label262.Size = new System.Drawing.Size(2, 2);
			label262.TabIndex = 404;
			label263.BackColor = System.Drawing.Color.White;
			label263.Location = new System.Drawing.Point(147, 122);
			label263.Name = "label263";
			label263.Size = new System.Drawing.Size(2, 2);
			label263.TabIndex = 403;
			label264.BackColor = System.Drawing.Color.White;
			label264.Location = new System.Drawing.Point(138, 122);
			label264.Name = "label264";
			label264.Size = new System.Drawing.Size(2, 2);
			label264.TabIndex = 402;
			label265.BackColor = System.Drawing.Color.White;
			label265.Location = new System.Drawing.Point(129, 122);
			label265.Name = "label265";
			label265.Size = new System.Drawing.Size(2, 2);
			label265.TabIndex = 401;
			label272.BackColor = System.Drawing.Color.White;
			label272.Location = new System.Drawing.Point(192, 85);
			label272.Name = "label272";
			label272.Size = new System.Drawing.Size(2, 2);
			label272.TabIndex = 432;
			label273.BackColor = System.Drawing.Color.White;
			label273.Location = new System.Drawing.Point(183, 85);
			label273.Name = "label273";
			label273.Size = new System.Drawing.Size(2, 2);
			label273.TabIndex = 431;
			label274.BackColor = System.Drawing.Color.White;
			label274.Location = new System.Drawing.Point(174, 85);
			label274.Name = "label274";
			label274.Size = new System.Drawing.Size(2, 2);
			label274.TabIndex = 430;
			label280.BackColor = System.Drawing.Color.White;
			label280.Location = new System.Drawing.Point(165, 85);
			label280.Name = "label280";
			label280.Size = new System.Drawing.Size(2, 2);
			label280.TabIndex = 424;
			label281.BackColor = System.Drawing.Color.White;
			label281.Location = new System.Drawing.Point(156, 85);
			label281.Name = "label281";
			label281.Size = new System.Drawing.Size(2, 2);
			label281.TabIndex = 423;
			label282.BackColor = System.Drawing.Color.White;
			label282.Location = new System.Drawing.Point(147, 85);
			label282.Name = "label282";
			label282.Size = new System.Drawing.Size(2, 2);
			label282.TabIndex = 422;
			label283.BackColor = System.Drawing.Color.White;
			label283.Location = new System.Drawing.Point(138, 85);
			label283.Name = "label283";
			label283.Size = new System.Drawing.Size(2, 2);
			label283.TabIndex = 421;
			label284.BackColor = System.Drawing.Color.White;
			label284.Location = new System.Drawing.Point(129, 85);
			label284.Name = "label284";
			label284.Size = new System.Drawing.Size(2, 2);
			label284.TabIndex = 420;
			label266.BackColor = System.Drawing.Color.White;
			label266.Location = new System.Drawing.Point(94, 66);
			label266.Name = "label266";
			label266.Size = new System.Drawing.Size(2, 2);
			label266.TabIndex = 449;
			label267.BackColor = System.Drawing.Color.White;
			label267.Location = new System.Drawing.Point(94, 76);
			label267.Name = "label267";
			label267.Size = new System.Drawing.Size(2, 2);
			label267.TabIndex = 448;
			label268.BackColor = System.Drawing.Color.White;
			label268.Location = new System.Drawing.Point(94, 47);
			label268.Name = "label268";
			label268.Size = new System.Drawing.Size(2, 2);
			label268.TabIndex = 447;
			label269.BackColor = System.Drawing.Color.White;
			label269.Location = new System.Drawing.Point(94, 57);
			label269.Name = "label269";
			label269.Size = new System.Drawing.Size(2, 2);
			label269.TabIndex = 446;
			label270.BackColor = System.Drawing.Color.White;
			label270.Location = new System.Drawing.Point(138, 38);
			label270.Name = "label270";
			label270.Size = new System.Drawing.Size(2, 2);
			label270.TabIndex = 445;
			label271.BackColor = System.Drawing.Color.White;
			label271.Location = new System.Drawing.Point(129, 38);
			label271.Name = "label271";
			label271.Size = new System.Drawing.Size(2, 2);
			label271.TabIndex = 444;
			label275.BackColor = System.Drawing.Color.White;
			label275.Location = new System.Drawing.Point(120, 38);
			label275.Name = "label275";
			label275.Size = new System.Drawing.Size(2, 2);
			label275.TabIndex = 443;
			label276.BackColor = System.Drawing.Color.White;
			label276.Location = new System.Drawing.Point(111, 38);
			label276.Name = "label276";
			label276.Size = new System.Drawing.Size(2, 2);
			label276.TabIndex = 442;
			label277.BackColor = System.Drawing.Color.White;
			label277.Location = new System.Drawing.Point(102, 38);
			label277.Name = "label277";
			label277.Size = new System.Drawing.Size(2, 2);
			label277.TabIndex = 441;
			label278.BackColor = System.Drawing.Color.White;
			label278.Location = new System.Drawing.Point(94, 38);
			label278.Name = "label278";
			label278.Size = new System.Drawing.Size(2, 2);
			label278.TabIndex = 440;
			label279.BackColor = System.Drawing.Color.White;
			label279.Location = new System.Drawing.Point(165, 38);
			label279.Name = "label279";
			label279.Size = new System.Drawing.Size(2, 2);
			label279.TabIndex = 439;
			label285.BackColor = System.Drawing.Color.White;
			label285.Location = new System.Drawing.Point(156, 38);
			label285.Name = "label285";
			label285.Size = new System.Drawing.Size(2, 2);
			label285.TabIndex = 438;
			label286.BackColor = System.Drawing.Color.White;
			label286.Location = new System.Drawing.Point(147, 38);
			label286.Name = "label286";
			label286.Size = new System.Drawing.Size(2, 2);
			label286.TabIndex = 437;
			label287.BackColor = System.Drawing.Color.White;
			label287.Location = new System.Drawing.Point(165, 66);
			label287.Name = "label287";
			label287.Size = new System.Drawing.Size(2, 2);
			label287.TabIndex = 436;
			label288.BackColor = System.Drawing.Color.White;
			label288.Location = new System.Drawing.Point(165, 76);
			label288.Name = "label288";
			label288.Size = new System.Drawing.Size(2, 2);
			label288.TabIndex = 435;
			label289.BackColor = System.Drawing.Color.White;
			label289.Location = new System.Drawing.Point(165, 47);
			label289.Name = "label289";
			label289.Size = new System.Drawing.Size(2, 2);
			label289.TabIndex = 434;
			label290.BackColor = System.Drawing.Color.White;
			label290.Location = new System.Drawing.Point(165, 57);
			label290.Name = "label290";
			label290.Size = new System.Drawing.Size(2, 2);
			label290.TabIndex = 433;
			label293.BackColor = System.Drawing.Color.White;
			label293.Location = new System.Drawing.Point(49, 85);
			label293.Name = "label293";
			label293.Size = new System.Drawing.Size(2, 2);
			label293.TabIndex = 459;
			label294.BackColor = System.Drawing.Color.White;
			label294.Location = new System.Drawing.Point(40, 85);
			label294.Name = "label294";
			label294.Size = new System.Drawing.Size(2, 2);
			label294.TabIndex = 458;
			label295.BackColor = System.Drawing.Color.White;
			label295.Location = new System.Drawing.Point(111, 85);
			label295.Name = "label295";
			label295.Size = new System.Drawing.Size(2, 2);
			label295.TabIndex = 457;
			label296.BackColor = System.Drawing.Color.White;
			label296.Location = new System.Drawing.Point(103, 85);
			label296.Name = "label296";
			label296.Size = new System.Drawing.Size(2, 2);
			label296.TabIndex = 456;
			label297.BackColor = System.Drawing.Color.White;
			label297.Location = new System.Drawing.Point(94, 85);
			label297.Name = "label297";
			label297.Size = new System.Drawing.Size(2, 2);
			label297.TabIndex = 455;
			label298.BackColor = System.Drawing.Color.White;
			label298.Location = new System.Drawing.Point(85, 85);
			label298.Name = "label298";
			label298.Size = new System.Drawing.Size(2, 2);
			label298.TabIndex = 454;
			label299.BackColor = System.Drawing.Color.White;
			label299.Location = new System.Drawing.Point(76, 85);
			label299.Name = "label299";
			label299.Size = new System.Drawing.Size(2, 2);
			label299.TabIndex = 453;
			label300.BackColor = System.Drawing.Color.White;
			label300.Location = new System.Drawing.Point(67, 85);
			label300.Name = "label300";
			label300.Size = new System.Drawing.Size(2, 2);
			label300.TabIndex = 452;
			label301.BackColor = System.Drawing.Color.White;
			label301.Location = new System.Drawing.Point(120, 85);
			label301.Name = "label301";
			label301.Size = new System.Drawing.Size(2, 2);
			label301.TabIndex = 451;
			label302.BackColor = System.Drawing.Color.White;
			label302.Location = new System.Drawing.Point(58, 85);
			label302.Name = "label302";
			label302.Size = new System.Drawing.Size(2, 2);
			label302.TabIndex = 450;
			label291.BackColor = System.Drawing.Color.White;
			label291.Location = new System.Drawing.Point(32, 94);
			label291.Name = "label291";
			label291.Size = new System.Drawing.Size(2, 2);
			label291.TabIndex = 469;
			label292.BackColor = System.Drawing.Color.White;
			label292.Location = new System.Drawing.Point(32, 113);
			label292.Name = "label292";
			label292.Size = new System.Drawing.Size(2, 2);
			label292.TabIndex = 468;
			label303.BackColor = System.Drawing.Color.White;
			label303.Location = new System.Drawing.Point(32, 104);
			label303.Name = "label303";
			label303.Size = new System.Drawing.Size(2, 2);
			label303.TabIndex = 467;
			label304.BackColor = System.Drawing.Color.White;
			label304.Location = new System.Drawing.Point(32, 122);
			label304.Name = "label304";
			label304.Size = new System.Drawing.Size(2, 2);
			label304.TabIndex = 466;
			label305.BackColor = System.Drawing.Color.White;
			label305.Location = new System.Drawing.Point(32, 76);
			label305.Name = "label305";
			label305.Size = new System.Drawing.Size(2, 2);
			label305.TabIndex = 465;
			label306.BackColor = System.Drawing.Color.White;
			label306.Location = new System.Drawing.Point(32, 67);
			label306.Name = "label306";
			label306.Size = new System.Drawing.Size(2, 2);
			label306.TabIndex = 464;
			label307.BackColor = System.Drawing.Color.Black;
			label307.Image = (System.Drawing.Image)resources.GetObject("label307.Image");
			label307.Location = new System.Drawing.Point(28, 54);
			label307.Name = "label307";
			label307.Size = new System.Drawing.Size(10, 10);
			label307.TabIndex = 463;
			label308.BackColor = System.Drawing.Color.White;
			label308.Location = new System.Drawing.Point(32, 85);
			label308.Name = "label308";
			label308.Size = new System.Drawing.Size(2, 2);
			label308.TabIndex = 462;
			label309.BackColor = System.Drawing.Color.White;
			label309.Location = new System.Drawing.Point(32, 48);
			label309.Name = "label309";
			label309.Size = new System.Drawing.Size(2, 2);
			label309.TabIndex = 461;
			label310.BackColor = System.Drawing.Color.White;
			label310.Location = new System.Drawing.Point(32, 38);
			label310.Name = "label310";
			label310.Size = new System.Drawing.Size(2, 2);
			label310.TabIndex = 460;
			label311.BackColor = System.Drawing.Color.White;
			label311.Location = new System.Drawing.Point(85, 38);
			label311.Name = "label311";
			label311.Size = new System.Drawing.Size(2, 2);
			label311.TabIndex = 475;
			label312.BackColor = System.Drawing.Color.White;
			label312.Location = new System.Drawing.Point(77, 38);
			label312.Name = "label312";
			label312.Size = new System.Drawing.Size(2, 2);
			label312.TabIndex = 474;
			label313.BackColor = System.Drawing.Color.White;
			label313.Location = new System.Drawing.Point(68, 38);
			label313.Name = "label313";
			label313.Size = new System.Drawing.Size(2, 2);
			label313.TabIndex = 473;
			label314.BackColor = System.Drawing.Color.White;
			label314.Location = new System.Drawing.Point(59, 38);
			label314.Name = "label314";
			label314.Size = new System.Drawing.Size(2, 2);
			label314.TabIndex = 472;
			label315.BackColor = System.Drawing.Color.White;
			label315.Location = new System.Drawing.Point(50, 38);
			label315.Name = "label315";
			label315.Size = new System.Drawing.Size(2, 2);
			label315.TabIndex = 471;
			label316.BackColor = System.Drawing.Color.White;
			label316.Location = new System.Drawing.Point(41, 38);
			label316.Name = "label316";
			label316.Size = new System.Drawing.Size(2, 2);
			label316.TabIndex = 470;
			label317.BackColor = System.Drawing.Color.White;
			label317.Location = new System.Drawing.Point(85, 122);
			label317.Name = "label317";
			label317.Size = new System.Drawing.Size(2, 2);
			label317.TabIndex = 482;
			label318.BackColor = System.Drawing.Color.White;
			label318.Location = new System.Drawing.Point(76, 122);
			label318.Name = "label318";
			label318.Size = new System.Drawing.Size(2, 2);
			label318.TabIndex = 481;
			label319.BackColor = System.Drawing.Color.White;
			label319.Location = new System.Drawing.Point(67, 122);
			label319.Name = "label319";
			label319.Size = new System.Drawing.Size(2, 2);
			label319.TabIndex = 480;
			label320.BackColor = System.Drawing.Color.White;
			label320.Location = new System.Drawing.Point(58, 122);
			label320.Name = "label320";
			label320.Size = new System.Drawing.Size(2, 2);
			label320.TabIndex = 479;
			label321.BackColor = System.Drawing.Color.White;
			label321.Location = new System.Drawing.Point(49, 122);
			label321.Name = "label321";
			label321.Size = new System.Drawing.Size(2, 2);
			label321.TabIndex = 478;
			label322.BackColor = System.Drawing.Color.White;
			label322.Location = new System.Drawing.Point(40, 122);
			label322.Name = "label322";
			label322.Size = new System.Drawing.Size(2, 2);
			label322.TabIndex = 477;
			label323.BackColor = System.Drawing.Color.White;
			label323.Location = new System.Drawing.Point(94, 122);
			label323.Name = "label323";
			label323.Size = new System.Drawing.Size(2, 2);
			label323.TabIndex = 476;
			label324.BackColor = System.Drawing.Color.White;
			label324.Location = new System.Drawing.Point(94, 103);
			label324.Name = "label324";
			label324.Size = new System.Drawing.Size(2, 2);
			label324.TabIndex = 486;
			label325.BackColor = System.Drawing.Color.White;
			label325.Location = new System.Drawing.Point(94, 113);
			label325.Name = "label325";
			label325.Size = new System.Drawing.Size(2, 2);
			label325.TabIndex = 485;
			label327.BackColor = System.Drawing.Color.White;
			label327.Location = new System.Drawing.Point(94, 94);
			label327.Name = "label327";
			label327.Size = new System.Drawing.Size(2, 2);
			label327.TabIndex = 483;
			label326.BackColor = System.Drawing.Color.White;
			label326.Location = new System.Drawing.Point(94, 149);
			label326.Name = "label326";
			label326.Size = new System.Drawing.Size(2, 2);
			label326.TabIndex = 501;
			label328.BackColor = System.Drawing.Color.White;
			label328.Location = new System.Drawing.Point(94, 167);
			label328.Name = "label328";
			label328.Size = new System.Drawing.Size(2, 2);
			label328.TabIndex = 500;
			label329.BackColor = System.Drawing.Color.White;
			label329.Location = new System.Drawing.Point(94, 158);
			label329.Name = "label329";
			label329.Size = new System.Drawing.Size(2, 2);
			label329.TabIndex = 499;
			label330.BackColor = System.Drawing.Color.White;
			label330.Location = new System.Drawing.Point(94, 176);
			label330.Name = "label330";
			label330.Size = new System.Drawing.Size(2, 2);
			label330.TabIndex = 498;
			label331.BackColor = System.Drawing.Color.White;
			label331.Location = new System.Drawing.Point(94, 131);
			label331.Name = "label331";
			label331.Size = new System.Drawing.Size(2, 2);
			label331.TabIndex = 497;
			label332.BackColor = System.Drawing.Color.White;
			label332.Location = new System.Drawing.Point(94, 140);
			label332.Name = "label332";
			label332.Size = new System.Drawing.Size(2, 2);
			label332.TabIndex = 496;
			label333.BackColor = System.Drawing.Color.White;
			label333.Location = new System.Drawing.Point(94, 230);
			label333.Name = "label333";
			label333.Size = new System.Drawing.Size(2, 2);
			label333.TabIndex = 495;
			label334.BackColor = System.Drawing.Color.White;
			label334.Location = new System.Drawing.Point(94, 248);
			label334.Name = "label334";
			label334.Size = new System.Drawing.Size(2, 2);
			label334.TabIndex = 494;
			label335.BackColor = System.Drawing.Color.White;
			label335.Location = new System.Drawing.Point(94, 239);
			label335.Name = "label335";
			label335.Size = new System.Drawing.Size(2, 2);
			label335.TabIndex = 493;
			label336.BackColor = System.Drawing.Color.White;
			label336.Location = new System.Drawing.Point(94, 257);
			label336.Name = "label336";
			label336.Size = new System.Drawing.Size(2, 2);
			label336.TabIndex = 492;
			label337.BackColor = System.Drawing.Color.White;
			label337.Location = new System.Drawing.Point(94, 212);
			label337.Name = "label337";
			label337.Size = new System.Drawing.Size(2, 2);
			label337.TabIndex = 491;
			label338.BackColor = System.Drawing.Color.White;
			label338.Location = new System.Drawing.Point(94, 203);
			label338.Name = "label338";
			label338.Size = new System.Drawing.Size(2, 2);
			label338.TabIndex = 490;
			label339.BackColor = System.Drawing.Color.White;
			label339.Location = new System.Drawing.Point(94, 194);
			label339.Name = "label339";
			label339.Size = new System.Drawing.Size(2, 2);
			label339.TabIndex = 489;
			label340.BackColor = System.Drawing.Color.White;
			label340.Location = new System.Drawing.Point(94, 221);
			label340.Name = "label340";
			label340.Size = new System.Drawing.Size(2, 2);
			label340.TabIndex = 488;
			label341.BackColor = System.Drawing.Color.White;
			label341.Location = new System.Drawing.Point(94, 185);
			label341.Name = "label341";
			label341.Size = new System.Drawing.Size(2, 2);
			label341.TabIndex = 487;
			timer8.Interval = 700;
			timer8.Tick += new System.EventHandler(timer8_Tick);
			panel1.Controls.Add(label254);
			panel1.Controls.Add(label255);
			panel1.Controls.Add(label253);
			panel1.Controls.Add(label142);
			panel1.Controls.Add(pictureBox5);
			panel1.Controls.Add(pictureBox4);
			panel1.Controls.Add(pictureBox3);
			panel1.Controls.Add(button1);
			panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			panel1.Location = new System.Drawing.Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(370, 430);
			panel1.TabIndex = 502;
			panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
			pictureBox5.Image = Pacman_Zagorschi_Franco.Properties.Resources.bg_name;
			pictureBox5.Location = new System.Drawing.Point(12, 226);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new System.Drawing.Size(348, 171);
			pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			pictureBox5.TabIndex = 7;
			pictureBox5.TabStop = false;
			pictureBox5.Click += new System.EventHandler(pictureBox5_Click);
			pictureBox4.Image = Pacman_Zagorschi_Franco.Properties.Resources.exit;
			pictureBox4.Location = new System.Drawing.Point(163, 158);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new System.Drawing.Size(50, 50);
			pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			pictureBox4.TabIndex = 2;
			pictureBox4.TabStop = false;
			pictureBox4.Click += new System.EventHandler(pictureBox4_Click);
			pictureBox3.Image = Pacman_Zagorschi_Franco.Properties.Resources.pacman_bg;
			pictureBox3.Location = new System.Drawing.Point(12, 18);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new System.Drawing.Size(348, 101);
			pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			pictureBox3.TabIndex = 1;
			pictureBox3.TabStop = false;
			pictureBox3.Visible = false;
			button1.Cursor = System.Windows.Forms.Cursors.Hand;
			button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
			button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
			button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button1.Image = Pacman_Zagorschi_Franco.Properties.Resources.playgame;
			button1.Location = new System.Drawing.Point(123, 124);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(136, 36);
			button1.TabIndex = 0;
			button1.UseVisualStyleBackColor = true;
			button1.Visible = false;
			button1.Click += new System.EventHandler(button1_Click);
			button1.MouseEnter += new System.EventHandler(button1_MouseEnter);
			button1.MouseLeave += new System.EventHandler(button1_MouseLeave);
			pacman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			pacman.Cursor = System.Windows.Forms.Cursors.Default;
			pacman.Image = Pacman_Zagorschi_Franco.Properties.Resources.pacdx;
			pacman.Location = new System.Drawing.Point(24, 364);
			pacman.Name = "pacman";
			pacman.Size = new System.Drawing.Size(22, 22);
			pacman.TabIndex = 503;
			pacman.TabStop = false;
			powermod.Interval = 10000;
			powermod.Tick += new System.EventHandler(powermod_Tick);
			timer7.Interval = 2500;
			timer7.Tick += new System.EventHandler(timer7_Tick);
			timer9.Enabled = true;
			timer9.Interval = 200;
			timer9.Tick += new System.EventHandler(timer9_Tick);
			ghostmangiato.Interval = 500;
			ghostmangiato.Tick += new System.EventHandler(ghostmangiato_Tick);
			label124.BackColor = System.Drawing.Color.Black;
			label124.Font = new System.Drawing.Font("Segoe UI Black", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label124.ForeColor = System.Drawing.Color.White;
			label124.Image = Pacman_Zagorschi_Franco.Properties.Resources.gameover;
			label124.Location = new System.Drawing.Point(123, 222);
			label124.Name = "label124";
			label124.Size = new System.Drawing.Size(125, 19);
			label124.TabIndex = 504;
			label124.Text = "          ";
			label124.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			label124.Visible = false;
			label141.BackColor = System.Drawing.Color.Black;
			label141.Font = new System.Drawing.Font("Segoe UI Black", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label141.ForeColor = System.Drawing.Color.White;
			label141.Image = Pacman_Zagorschi_Franco.Properties.Resources.gamewin1;
			label141.Location = new System.Drawing.Point(125, 222);
			label141.Name = "label141";
			label141.Size = new System.Drawing.Size(125, 19);
			label141.TabIndex = 505;
			label141.Text = "          ";
			label141.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			label141.Visible = false;
			powermod1.Interval = 7000;
			powermod1.Tick += new System.EventHandler(powermod1_Tick);
			attendo.Interval = 400;
			attendo.Tick += new System.EventHandler(attendo_Tick);
			label254.AutoSize = true;
			label254.Font = new System.Drawing.Font("News706 BT", 12.25f, System.Drawing.FontStyle.Bold);
			label254.ForeColor = System.Drawing.Color.White;
			label254.Location = new System.Drawing.Point(128, 354);
			label254.Name = "label254";
			label254.Size = new System.Drawing.Size(122, 20);
			label254.TabIndex = 11;
			label254.Text = "(15050623024)";
			label254.Click += new System.EventHandler(label254_Click_1);
			label255.AutoSize = true;
			label255.Font = new System.Drawing.Font("News706 BT", 13.25f, System.Drawing.FontStyle.Bold);
			label255.ForeColor = System.Drawing.Color.White;
			label255.Location = new System.Drawing.Point(97, 331);
			label255.Name = "label255";
			label255.Size = new System.Drawing.Size(197, 21);
			label255.TabIndex = 10;
			label255.Text = "Fahmi Rizky Maulidy";
			label253.AutoSize = true;
			label253.Font = new System.Drawing.Font("News706 BT", 12.25f, System.Drawing.FontStyle.Bold);
			label253.ForeColor = System.Drawing.Color.White;
			label253.Location = new System.Drawing.Point(126, 277);
			label253.Name = "label253";
			label253.Size = new System.Drawing.Size(122, 20);
			label253.TabIndex = 9;
			label253.Text = "(15050623021)";
			label142.AutoSize = true;
			label142.BackColor = System.Drawing.Color.Transparent;
			label142.Font = new System.Drawing.Font("News706 BT", 12.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label142.ForeColor = System.Drawing.SystemColors.Window;
			label142.Location = new System.Drawing.Point(53, 255);
			label142.Name = "label142";
			label142.Size = new System.Drawing.Size(266, 20);
			label142.TabIndex = 8;
			label142.Text = "Muhammad Akbar Priambodo ";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.Color.Black;
			BackgroundImage = Pacman_Zagorschi_Franco.Properties.Resources.percorso;
			BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			base.ClientSize = new System.Drawing.Size(370, 430);
			base.Controls.Add(panel1);
			base.Controls.Add(ghost3);
			base.Controls.Add(ghost4);
			base.Controls.Add(ghost2);
			base.Controls.Add(ghost1);
			base.Controls.Add(label141);
			base.Controls.Add(label124);
			base.Controls.Add(pacman);
			base.Controls.Add(label3);
			base.Controls.Add(label326);
			base.Controls.Add(label328);
			base.Controls.Add(label329);
			base.Controls.Add(label330);
			base.Controls.Add(label331);
			base.Controls.Add(label332);
			base.Controls.Add(label333);
			base.Controls.Add(label334);
			base.Controls.Add(label335);
			base.Controls.Add(label336);
			base.Controls.Add(label337);
			base.Controls.Add(label338);
			base.Controls.Add(label339);
			base.Controls.Add(label340);
			base.Controls.Add(label341);
			base.Controls.Add(label324);
			base.Controls.Add(label325);
			base.Controls.Add(label327);
			base.Controls.Add(label317);
			base.Controls.Add(label318);
			base.Controls.Add(label319);
			base.Controls.Add(label320);
			base.Controls.Add(label321);
			base.Controls.Add(label322);
			base.Controls.Add(label323);
			base.Controls.Add(label311);
			base.Controls.Add(label312);
			base.Controls.Add(label313);
			base.Controls.Add(label314);
			base.Controls.Add(label315);
			base.Controls.Add(label316);
			base.Controls.Add(label291);
			base.Controls.Add(label292);
			base.Controls.Add(label303);
			base.Controls.Add(label304);
			base.Controls.Add(label305);
			base.Controls.Add(label306);
			base.Controls.Add(label307);
			base.Controls.Add(label308);
			base.Controls.Add(label309);
			base.Controls.Add(label310);
			base.Controls.Add(label293);
			base.Controls.Add(label294);
			base.Controls.Add(label295);
			base.Controls.Add(label296);
			base.Controls.Add(label297);
			base.Controls.Add(label298);
			base.Controls.Add(label299);
			base.Controls.Add(label300);
			base.Controls.Add(label301);
			base.Controls.Add(label302);
			base.Controls.Add(label266);
			base.Controls.Add(label267);
			base.Controls.Add(label268);
			base.Controls.Add(label269);
			base.Controls.Add(label270);
			base.Controls.Add(label271);
			base.Controls.Add(label275);
			base.Controls.Add(label276);
			base.Controls.Add(label277);
			base.Controls.Add(label278);
			base.Controls.Add(label279);
			base.Controls.Add(label285);
			base.Controls.Add(label286);
			base.Controls.Add(label287);
			base.Controls.Add(label288);
			base.Controls.Add(label289);
			base.Controls.Add(label290);
			base.Controls.Add(label272);
			base.Controls.Add(label273);
			base.Controls.Add(label274);
			base.Controls.Add(label280);
			base.Controls.Add(label281);
			base.Controls.Add(label282);
			base.Controls.Add(label283);
			base.Controls.Add(label284);
			base.Controls.Add(label247);
			base.Controls.Add(label248);
			base.Controls.Add(label249);
			base.Controls.Add(label250);
			base.Controls.Add(label251);
			base.Controls.Add(label252);
			base.Controls.Add(label256);
			base.Controls.Add(label257);
			base.Controls.Add(label258);
			base.Controls.Add(label259);
			base.Controls.Add(label260);
			base.Controls.Add(label261);
			base.Controls.Add(label262);
			base.Controls.Add(label263);
			base.Controls.Add(label264);
			base.Controls.Add(label265);
			base.Controls.Add(label243);
			base.Controls.Add(label244);
			base.Controls.Add(label245);
			base.Controls.Add(label246);
			base.Controls.Add(label235);
			base.Controls.Add(label236);
			base.Controls.Add(label237);
			base.Controls.Add(label238);
			base.Controls.Add(label239);
			base.Controls.Add(label240);
			base.Controls.Add(label241);
			base.Controls.Add(label242);
			base.Controls.Add(label229);
			base.Controls.Add(label230);
			base.Controls.Add(label231);
			base.Controls.Add(label232);
			base.Controls.Add(label233);
			base.Controls.Add(label234);
			base.Controls.Add(label223);
			base.Controls.Add(label224);
			base.Controls.Add(label225);
			base.Controls.Add(label226);
			base.Controls.Add(label227);
			base.Controls.Add(label228);
			base.Controls.Add(label197);
			base.Controls.Add(label215);
			base.Controls.Add(label216);
			base.Controls.Add(label217);
			base.Controls.Add(label218);
			base.Controls.Add(label219);
			base.Controls.Add(label220);
			base.Controls.Add(label221);
			base.Controls.Add(label222);
			base.Controls.Add(label198);
			base.Controls.Add(label200);
			base.Controls.Add(label201);
			base.Controls.Add(label202);
			base.Controls.Add(label203);
			base.Controls.Add(label204);
			base.Controls.Add(label205);
			base.Controls.Add(label206);
			base.Controls.Add(label207);
			base.Controls.Add(label208);
			base.Controls.Add(label209);
			base.Controls.Add(label210);
			base.Controls.Add(label211);
			base.Controls.Add(label212);
			base.Controls.Add(label213);
			base.Controls.Add(label214);
			base.Controls.Add(label192);
			base.Controls.Add(label193);
			base.Controls.Add(label194);
			base.Controls.Add(label195);
			base.Controls.Add(label196);
			base.Controls.Add(label199);
			base.Controls.Add(label183);
			base.Controls.Add(label184);
			base.Controls.Add(label185);
			base.Controls.Add(label186);
			base.Controls.Add(label187);
			base.Controls.Add(label188);
			base.Controls.Add(label189);
			base.Controls.Add(label190);
			base.Controls.Add(label191);
			base.Controls.Add(label174);
			base.Controls.Add(label175);
			base.Controls.Add(label176);
			base.Controls.Add(label177);
			base.Controls.Add(label178);
			base.Controls.Add(label179);
			base.Controls.Add(label180);
			base.Controls.Add(label181);
			base.Controls.Add(label182);
			base.Controls.Add(label170);
			base.Controls.Add(label171);
			base.Controls.Add(label172);
			base.Controls.Add(label173);
			base.Controls.Add(label169);
			base.Controls.Add(label166);
			base.Controls.Add(label167);
			base.Controls.Add(label168);
			base.Controls.Add(label163);
			base.Controls.Add(label164);
			base.Controls.Add(label165);
			base.Controls.Add(label119);
			base.Controls.Add(label120);
			base.Controls.Add(label121);
			base.Controls.Add(label122);
			base.Controls.Add(label123);
			base.Controls.Add(label125);
			base.Controls.Add(label126);
			base.Controls.Add(label127);
			base.Controls.Add(label128);
			base.Controls.Add(label129);
			base.Controls.Add(label130);
			base.Controls.Add(label131);
			base.Controls.Add(label132);
			base.Controls.Add(label133);
			base.Controls.Add(label134);
			base.Controls.Add(label135);
			base.Controls.Add(label136);
			base.Controls.Add(label137);
			base.Controls.Add(label138);
			base.Controls.Add(label139);
			base.Controls.Add(label140);
			base.Controls.Add(label143);
			base.Controls.Add(label144);
			base.Controls.Add(label145);
			base.Controls.Add(label146);
			base.Controls.Add(label147);
			base.Controls.Add(label148);
			base.Controls.Add(label149);
			base.Controls.Add(label150);
			base.Controls.Add(label151);
			base.Controls.Add(label152);
			base.Controls.Add(label153);
			base.Controls.Add(label154);
			base.Controls.Add(label155);
			base.Controls.Add(label156);
			base.Controls.Add(label157);
			base.Controls.Add(label158);
			base.Controls.Add(label159);
			base.Controls.Add(label160);
			base.Controls.Add(label161);
			base.Controls.Add(label162);
			base.Controls.Add(label105);
			base.Controls.Add(label106);
			base.Controls.Add(label107);
			base.Controls.Add(label108);
			base.Controls.Add(label109);
			base.Controls.Add(label110);
			base.Controls.Add(label111);
			base.Controls.Add(label112);
			base.Controls.Add(label113);
			base.Controls.Add(label114);
			base.Controls.Add(label115);
			base.Controls.Add(label116);
			base.Controls.Add(label117);
			base.Controls.Add(label118);
			base.Controls.Add(label103);
			base.Controls.Add(label104);
			base.Controls.Add(label97);
			base.Controls.Add(label99);
			base.Controls.Add(label100);
			base.Controls.Add(label101);
			base.Controls.Add(label102);
			base.Controls.Add(label93);
			base.Controls.Add(label95);
			base.Controls.Add(label96);
			base.Controls.Add(label98);
			base.Controls.Add(label90);
			base.Controls.Add(label91);
			base.Controls.Add(label92);
			base.Controls.Add(label94);
			base.Controls.Add(label86);
			base.Controls.Add(label87);
			base.Controls.Add(label88);
			base.Controls.Add(label89);
			base.Controls.Add(label75);
			base.Controls.Add(label84);
			base.Controls.Add(label85);
			base.Controls.Add(label80);
			base.Controls.Add(label81);
			base.Controls.Add(label82);
			base.Controls.Add(label83);
			base.Controls.Add(label76);
			base.Controls.Add(label77);
			base.Controls.Add(label78);
			base.Controls.Add(label79);
			base.Controls.Add(label71);
			base.Controls.Add(label72);
			base.Controls.Add(label73);
			base.Controls.Add(label74);
			base.Controls.Add(label70);
			base.Controls.Add(label67);
			base.Controls.Add(label68);
			base.Controls.Add(label69);
			base.Controls.Add(label66);
			base.Controls.Add(label64);
			base.Controls.Add(label65);
			base.Controls.Add(label61);
			base.Controls.Add(label62);
			base.Controls.Add(label63);
			base.Controls.Add(label58);
			base.Controls.Add(label59);
			base.Controls.Add(label60);
			base.Controls.Add(label42);
			base.Controls.Add(label48);
			base.Controls.Add(label51);
			base.Controls.Add(label52);
			base.Controls.Add(label53);
			base.Controls.Add(label54);
			base.Controls.Add(label55);
			base.Controls.Add(label56);
			base.Controls.Add(label57);
			base.Controls.Add(label33);
			base.Controls.Add(label34);
			base.Controls.Add(label35);
			base.Controls.Add(label36);
			base.Controls.Add(label37);
			base.Controls.Add(label38);
			base.Controls.Add(label39);
			base.Controls.Add(label40);
			base.Controls.Add(label41);
			base.Controls.Add(label50);
			base.Controls.Add(label49);
			base.Controls.Add(label45);
			base.Controls.Add(label46);
			base.Controls.Add(label47);
			base.Controls.Add(label44);
			base.Controls.Add(label43);
			base.Controls.Add(label32);
			base.Controls.Add(label18);
			base.Controls.Add(label19);
			base.Controls.Add(label20);
			base.Controls.Add(label21);
			base.Controls.Add(label22);
			base.Controls.Add(label23);
			base.Controls.Add(label24);
			base.Controls.Add(label25);
			base.Controls.Add(label26);
			base.Controls.Add(label27);
			base.Controls.Add(label28);
			base.Controls.Add(label29);
			base.Controls.Add(label30);
			base.Controls.Add(label31);
			base.Controls.Add(label12);
			base.Controls.Add(label13);
			base.Controls.Add(label14);
			base.Controls.Add(label15);
			base.Controls.Add(label16);
			base.Controls.Add(label17);
			base.Controls.Add(label8);
			base.Controls.Add(label9);
			base.Controls.Add(label10);
			base.Controls.Add(label11);
			base.Controls.Add(label6);
			base.Controls.Add(label7);
			base.Controls.Add(label5);
			base.Controls.Add(label4);
			base.Controls.Add(score);
			base.Controls.Add(pictureBox2);
			base.Controls.Add(pictureBox1);
			base.Controls.Add(label2);
			base.Controls.Add(label1);
			Cursor = System.Windows.Forms.Cursors.Default;
			DoubleBuffered = true;
			Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			ForeColor = System.Drawing.Color.Black;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.KeyPreview = true;
			base.MaximizeBox = false;
			MaximumSize = new System.Drawing.Size(386, 469);
			base.MinimizeBox = false;
			MinimumSize = new System.Drawing.Size(386, 469);
			base.Name = "Form1";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Pac-Man";
			base.TransparencyKey = System.Drawing.Color.Fuchsia;
			base.KeyDown += new System.Windows.Forms.KeyEventHandler(Form1_KeyDown);
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pacman).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
