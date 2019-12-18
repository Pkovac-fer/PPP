using Pacman_Zagorschi_Franco.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
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

		public Form1()
		{
			this.InitializeComponent();
			this.oggetti.Add(this.label4);
			this.oggetti.Add(this.label5);
			this.oggetti.Add(this.label6);
			this.oggetti.Add(this.label7);
			this.oggetti.Add(this.label8);
			this.oggetti.Add(this.label9);
			this.oggetti.Add(this.label10);
			this.oggetti.Add(this.label11);
			this.oggetti.Add(this.label12);
			this.oggetti.Add(this.label13);
			this.oggetti.Add(this.label14);
			this.oggetti.Add(this.label15);
			this.oggetti.Add(this.label16);
			this.oggetti.Add(this.label17);
			this.oggetti.Add(this.label18);
			this.oggetti.Add(this.label19);
			this.oggetti.Add(this.label20);
			this.oggetti.Add(this.label21);
			this.oggetti.Add(this.label22);
			this.oggetti.Add(this.label23);
			this.oggetti.Add(this.label24);
			this.oggetti.Add(this.label25);
			this.oggetti.Add(this.label26);
			this.oggetti.Add(this.label27);
			this.oggetti.Add(this.label28);
			this.oggetti.Add(this.label29);
			this.oggetti.Add(this.label30);
			this.oggetti.Add(this.label31);
			this.oggetti.Add(this.label32);
			this.oggetti.Add(this.label33);
			this.oggetti.Add(this.label34);
			this.oggetti.Add(this.label35);
			this.oggetti.Add(this.label36);
			this.oggetti.Add(this.label37);
			this.oggetti.Add(this.label38);
			this.oggetti.Add(this.label39);
			this.oggetti.Add(this.label40);
			this.oggetti.Add(this.label41);
			this.oggetti.Add(this.label42);
			this.oggetti.Add(this.label43);
			this.oggetti.Add(this.label44);
			this.oggetti.Add(this.label45);
			this.oggetti.Add(this.label46);
			this.oggetti.Add(this.label47);
			this.oggetti.Add(this.label48);
			this.oggetti.Add(this.label49);
			this.oggetti.Add(this.label50);
			this.oggetti.Add(this.label51);
			this.oggetti.Add(this.label52);
			this.oggetti.Add(this.label53);
			this.oggetti.Add(this.label54);
			this.oggetti.Add(this.label55);
			this.oggetti.Add(this.label56);
			this.oggetti.Add(this.label57);
			this.oggetti.Add(this.label58);
			this.oggetti.Add(this.label59);
			this.oggetti.Add(this.label60);
			this.oggetti.Add(this.label61);
			this.oggetti.Add(this.label62);
			this.oggetti.Add(this.label63);
			this.oggetti.Add(this.label64);
			this.oggetti.Add(this.label65);
			this.oggetti.Add(this.label66);
			this.oggetti.Add(this.label67);
			this.oggetti.Add(this.label68);
			this.oggetti.Add(this.label69);
			this.oggetti.Add(this.label70);
			this.oggetti.Add(this.label71);
			this.oggetti.Add(this.label72);
			this.oggetti.Add(this.label73);
			this.oggetti.Add(this.label74);
			this.oggetti.Add(this.label75);
			this.oggetti.Add(this.label76);
			this.oggetti.Add(this.label77);
			this.oggetti.Add(this.label78);
			this.oggetti.Add(this.label79);
			this.oggetti.Add(this.label80);
			this.oggetti.Add(this.label81);
			this.oggetti.Add(this.label82);
			this.oggetti.Add(this.label83);
			this.oggetti.Add(this.label84);
			this.oggetti.Add(this.label85);
			this.oggetti.Add(this.label86);
			this.oggetti.Add(this.label87);
			this.oggetti.Add(this.label88);
			this.oggetti.Add(this.label89);
			this.oggetti.Add(this.label90);
			this.oggetti.Add(this.label91);
			this.oggetti.Add(this.label92);
			this.oggetti.Add(this.label93);
			this.oggetti.Add(this.label94);
			this.oggetti.Add(this.label95);
			this.oggetti.Add(this.label96);
			this.oggetti.Add(this.label97);
			this.oggetti.Add(this.label98);
			this.oggetti.Add(this.label99);
			this.oggetti.Add(this.label100);
			this.oggetti.Add(this.label101);
			this.oggetti.Add(this.label102);
			this.oggetti.Add(this.label103);
			this.oggetti.Add(this.label104);
			this.oggetti.Add(this.label105);
			this.oggetti.Add(this.label106);
			this.oggetti.Add(this.label107);
			this.oggetti.Add(this.label108);
			this.oggetti.Add(this.label109);
			this.oggetti.Add(this.label110);
			this.oggetti.Add(this.label111);
			this.oggetti.Add(this.label112);
			this.oggetti.Add(this.label113);
			this.oggetti.Add(this.label114);
			this.oggetti.Add(this.label115);
			this.oggetti.Add(this.label116);
			this.oggetti.Add(this.label117);
			this.oggetti.Add(this.label118);
			this.oggetti.Add(this.label119);
			this.oggetti.Add(this.label120);
			this.oggetti.Add(this.label121);
			this.oggetti.Add(this.label122);
			this.oggetti.Add(this.label123);
			this.oggetti.Add(this.label125);
			this.oggetti.Add(this.label126);
			this.oggetti.Add(this.label127);
			this.oggetti.Add(this.label128);
			this.oggetti.Add(this.label129);
			this.oggetti.Add(this.label130);
			this.oggetti.Add(this.label131);
			this.oggetti.Add(this.label132);
			this.oggetti.Add(this.label133);
			this.oggetti.Add(this.label134);
			this.oggetti.Add(this.label135);
			this.oggetti.Add(this.label136);
			this.oggetti.Add(this.label137);
			this.oggetti.Add(this.label138);
			this.oggetti.Add(this.label139);
			this.oggetti.Add(this.label140);
			this.oggetti.Add(this.label143);
			this.oggetti.Add(this.label144);
			this.oggetti.Add(this.label145);
			this.oggetti.Add(this.label146);
			this.oggetti.Add(this.label147);
			this.oggetti.Add(this.label148);
			this.oggetti.Add(this.label149);
			this.oggetti.Add(this.label150);
			this.oggetti.Add(this.label151);
			this.oggetti.Add(this.label152);
			this.oggetti.Add(this.label153);
			this.oggetti.Add(this.label154);
			this.oggetti.Add(this.label155);
			this.oggetti.Add(this.label156);
			this.oggetti.Add(this.label157);
			this.oggetti.Add(this.label158);
			this.oggetti.Add(this.label159);
			this.oggetti.Add(this.label160);
			this.oggetti.Add(this.label161);
			this.oggetti.Add(this.label162);
			this.oggetti.Add(this.label163);
			this.oggetti.Add(this.label164);
			this.oggetti.Add(this.label165);
			this.oggetti.Add(this.label166);
			this.oggetti.Add(this.label167);
			this.oggetti.Add(this.label168);
			this.oggetti.Add(this.label169);
			this.oggetti.Add(this.label170);
			this.oggetti.Add(this.label171);
			this.oggetti.Add(this.label172);
			this.oggetti.Add(this.label173);
			this.oggetti.Add(this.label174);
			this.oggetti.Add(this.label175);
			this.oggetti.Add(this.label176);
			this.oggetti.Add(this.label177);
			this.oggetti.Add(this.label178);
			this.oggetti.Add(this.label179);
			this.oggetti.Add(this.label180);
			this.oggetti.Add(this.label181);
			this.oggetti.Add(this.label182);
			this.oggetti.Add(this.label183);
			this.oggetti.Add(this.label184);
			this.oggetti.Add(this.label185);
			this.oggetti.Add(this.label186);
			this.oggetti.Add(this.label187);
			this.oggetti.Add(this.label188);
			this.oggetti.Add(this.label189);
			this.oggetti.Add(this.label190);
			this.oggetti.Add(this.label191);
			this.oggetti.Add(this.label192);
			this.oggetti.Add(this.label193);
			this.oggetti.Add(this.label194);
			this.oggetti.Add(this.label195);
			this.oggetti.Add(this.label196);
			this.oggetti.Add(this.label197);
			this.oggetti.Add(this.label198);
			this.oggetti.Add(this.label199);
			this.oggetti.Add(this.label200);
			this.oggetti.Add(this.label201);
			this.oggetti.Add(this.label202);
			this.oggetti.Add(this.label203);
			this.oggetti.Add(this.label204);
			this.oggetti.Add(this.label205);
			this.oggetti.Add(this.label206);
			this.oggetti.Add(this.label207);
			this.oggetti.Add(this.label208);
			this.oggetti.Add(this.label209);
			this.oggetti.Add(this.label210);
			this.oggetti.Add(this.label211);
			this.oggetti.Add(this.label212);
			this.oggetti.Add(this.label213);
			this.oggetti.Add(this.label214);
			this.oggetti.Add(this.label215);
			this.oggetti.Add(this.label216);
			this.oggetti.Add(this.label217);
			this.oggetti.Add(this.label218);
			this.oggetti.Add(this.label219);
			this.oggetti.Add(this.label220);
			this.oggetti.Add(this.label221);
			this.oggetti.Add(this.label222);
			this.oggetti.Add(this.label223);
			this.oggetti.Add(this.label224);
			this.oggetti.Add(this.label225);
			this.oggetti.Add(this.label226);
			this.oggetti.Add(this.label227);
			this.oggetti.Add(this.label228);
			this.oggetti.Add(this.label229);
			this.oggetti.Add(this.label230);
			this.oggetti.Add(this.label231);
			this.oggetti.Add(this.label232);
			this.oggetti.Add(this.label233);
			this.oggetti.Add(this.label234);
			this.oggetti.Add(this.label235);
			this.oggetti.Add(this.label236);
			this.oggetti.Add(this.label237);
			this.oggetti.Add(this.label238);
			this.oggetti.Add(this.label239);
			this.oggetti.Add(this.label240);
			this.oggetti.Add(this.label241);
			this.oggetti.Add(this.label242);
			this.oggetti.Add(this.label243);
			this.oggetti.Add(this.label244);
			this.oggetti.Add(this.label245);
			this.oggetti.Add(this.label246);
			this.oggetti.Add(this.label247);
			this.oggetti.Add(this.label248);
			this.oggetti.Add(this.label249);
			this.oggetti.Add(this.label250);
			this.oggetti.Add(this.label251);
			this.oggetti.Add(this.label252);
			this.oggetti.Add(this.label256);
			this.oggetti.Add(this.label257);
			this.oggetti.Add(this.label258);
			this.oggetti.Add(this.label259);
			this.oggetti.Add(this.label260);
			this.oggetti.Add(this.label261);
			this.oggetti.Add(this.label262);
			this.oggetti.Add(this.label263);
			this.oggetti.Add(this.label264);
			this.oggetti.Add(this.label265);
			this.oggetti.Add(this.label266);
			this.oggetti.Add(this.label267);
			this.oggetti.Add(this.label268);
			this.oggetti.Add(this.label269);
			this.oggetti.Add(this.label270);
			this.oggetti.Add(this.label271);
			this.oggetti.Add(this.label272);
			this.oggetti.Add(this.label273);
			this.oggetti.Add(this.label274);
			this.oggetti.Add(this.label275);
			this.oggetti.Add(this.label276);
			this.oggetti.Add(this.label277);
			this.oggetti.Add(this.label278);
			this.oggetti.Add(this.label279);
			this.oggetti.Add(this.label280);
			this.oggetti.Add(this.label281);
			this.oggetti.Add(this.label282);
			this.oggetti.Add(this.label283);
			this.oggetti.Add(this.label284);
			this.oggetti.Add(this.label285);
			this.oggetti.Add(this.label286);
			this.oggetti.Add(this.label287);
			this.oggetti.Add(this.label288);
			this.oggetti.Add(this.label289);
			this.oggetti.Add(this.label290);
			this.oggetti.Add(this.label291);
			this.oggetti.Add(this.label292);
			this.oggetti.Add(this.label293);
			this.oggetti.Add(this.label294);
			this.oggetti.Add(this.label295);
			this.oggetti.Add(this.label296);
			this.oggetti.Add(this.label297);
			this.oggetti.Add(this.label298);
			this.oggetti.Add(this.label299);
			this.oggetti.Add(this.label300);
			this.oggetti.Add(this.label301);
			this.oggetti.Add(this.label302);
			this.oggetti.Add(this.label303);
			this.oggetti.Add(this.label304);
			this.oggetti.Add(this.label305);
			this.oggetti.Add(this.label306);
			this.oggetti.Add(this.label307);
			this.oggetti.Add(this.label308);
			this.oggetti.Add(this.label309);
			this.oggetti.Add(this.label310);
			this.oggetti.Add(this.label311);
			this.oggetti.Add(this.label312);
			this.oggetti.Add(this.label313);
			this.oggetti.Add(this.label314);
			this.oggetti.Add(this.label315);
			this.oggetti.Add(this.label316);
			this.oggetti.Add(this.label317);
			this.oggetti.Add(this.label318);
			this.oggetti.Add(this.label319);
			this.oggetti.Add(this.label320);
			this.oggetti.Add(this.label321);
			this.oggetti.Add(this.label322);
			this.oggetti.Add(this.label323);
			this.oggetti.Add(this.label324);
			this.oggetti.Add(this.label325);
			this.oggetti.Add(this.label326);
			this.oggetti.Add(this.label327);
			this.oggetti.Add(this.label328);
			this.oggetti.Add(this.label329);
			this.oggetti.Add(this.label330);
			this.oggetti.Add(this.label331);
			this.oggetti.Add(this.label332);
			this.oggetti.Add(this.label333);
			this.oggetti.Add(this.label334);
			this.oggetti.Add(this.label335);
			this.oggetti.Add(this.label336);
			this.oggetti.Add(this.label337);
			this.oggetti.Add(this.label338);
			this.oggetti.Add(this.label339);
			this.oggetti.Add(this.label340);
			this.oggetti.Add(this.label341);
		}

		private void a(int left, int top)
		{
			if (!this.pacturn)
			{
				int num = left;
				if (num <= 158)
				{
					if (num <= 50)
					{
						if (num == -28)
						{
							if (top == 186)
							{
								this.transport(1, 0);
							}
						}
						else if (num != 26)
						{
							if (num == 50)
							{
								if (top == 0x14a)
								{
									this.leftright(1, 1, 1, 0);
								}
								else if (top == 0x126)
								{
									this.leftright(1, 0, 0, 1);
								}
							}
						}
						else if (top == 0x16e)
						{
							this.leftright(0, 1, 1, 0);
						}
						else if (top == 0x14a)
						{
							this.leftright(0, 1, 0, 1);
						}
						else if (top == 0x126)
						{
							this.leftright(0, 1, 1, 0);
						}
						else if (top == 0x102)
						{
							this.leftright(0, 1, 0, 1);
						}
						else if (top == 114)
						{
							this.leftright(0, 1, 1, 0);
						}
						else if (top == 78)
						{
							this.leftright(0, 1, 1, 1);
						}
						else if (top == 30)
						{
							this.leftright(0, 1, 0, 1);
						}
					}
					else if (num == 86)
					{
						if (top == 0x102)
						{
							this.leftright(1, 1, 1, 1);
						}
						else if (top == 0x14a)
						{
							this.leftright(1, 0, 1, 0);
						}
						else if (top == 0x126)
						{
							this.leftright(0, 1, 1, 1);
						}
						else if (top == 186)
						{
							this.leftright(1, 1, 1, 1);
						}
						else if (top == 114)
						{
							this.leftright(1, 0, 1, 1);
						}
						else if (top == 30)
						{
							this.leftright(1, 1, 0, 1);
						}
						else if (top == 78)
						{
							this.leftright(1, 1, 1, 1);
						}
					}
					else if (num != 122)
					{
						if (num == 158)
						{
							if (top == 0x14a)
							{
								this.leftright(1, 0, 0, 1);
							}
							else if (top == 0x16e)
							{
								this.leftright(1, 1, 1, 0);
							}
							else if (top == 0x102)
							{
								this.leftright(1, 0, 0, 1);
							}
							else if (top == 0x126)
							{
								this.leftright(1, 1, 1, 0);
							}
							else if (top == 78)
							{
								this.leftright(1, 1, 1, 0);
							}
							else if (top == 114)
							{
								this.leftright(1, 0, 0, 1);
							}
							else if (top == 150)
							{
								this.leftright(1, 1, 1, 0);
							}
							else if (top == 30)
							{
								this.leftright(1, 0, 0, 1);
							}
						}
					}
					else if (top == 0x126)
					{
						this.leftright(1, 1, 0, 1);
					}
					else if (top == 0x14a)
					{
						this.leftright(0, 1, 1, 0);
					}
					else if (top == 0x102)
					{
						this.leftright(1, 1, 1, 0);
					}
					else if (top == 222)
					{
						this.leftright(0, 1, 1, 1);
					}
					else if (top == 78)
					{
						this.leftright(1, 1, 0, 1);
					}
					else if (top == 114)
					{
						this.leftright(0, 1, 1, 0);
					}
					else if (top == 150)
					{
						this.leftright(0, 1, 0, 1);
					}
					else if (top == 186)
					{
						this.leftright(1, 0, 1, 1);
					}
				}
				else if (num > 230)
				{
					if (num <= 0x12e)
					{
						if (num != 0x10a)
						{
							if (num == 0x12e)
							{
								if (top == 0x126)
								{
									this.leftright(0, 1, 0, 1);
								}
								else if (top == 0x14a)
								{
									this.leftright(1, 1, 1, 0);
								}
							}
						}
						else if (top == 0x102)
						{
							this.leftright(1, 1, 1, 1);
						}
						else if (top == 0x126)
						{
							this.leftright(1, 0, 1, 1);
						}
						else if (top == 0x14a)
						{
							this.leftright(0, 1, 1, 0);
						}
						else if (top == 186)
						{
							this.leftright(1, 1, 1, 1);
						}
						else if (top == 114)
						{
							this.leftright(0, 1, 1, 1);
						}
						else if (top == 30)
						{
							this.leftright(1, 1, 0, 1);
						}
						else if (top == 78)
						{
							this.leftright(1, 1, 1, 1);
						}
					}
					else if (num != 0x146)
					{
						if (num == 0x178)
						{
							if (top == 186)
							{
								this.transport(0, 1);
							}
						}
					}
					else if (top == 0x102)
					{
						this.leftright(1, 0, 0, 1);
					}
					else if (top == 0x126)
					{
						this.leftright(1, 0, 1, 0);
					}
					else if (top == 0x14a)
					{
						this.leftright(1, 0, 0, 1);
					}
					else if (top == 0x16e)
					{
						this.leftright(1, 0, 1, 0);
					}
					else if (top == 114)
					{
						this.leftright(1, 0, 1, 0);
					}
					else if (top == 78)
					{
						this.leftright(1, 0, 1, 1);
					}
					else if (top == 30)
					{
						this.leftright(1, 0, 0, 1);
					}
				}
				else if (num == 176)
				{
					if (top == 150)
					{
						this.leftright(1, 1, 0, 0);
					}
				}
				else if (num != 194)
				{
					if (num == 230)
					{
						if (top == 0x102)
						{
							this.leftright(1, 1, 1, 0);
						}
						else if (top == 0x14a)
						{
							this.leftright(1, 0, 1, 0);
						}
						else if (top == 0x126)
						{
							this.leftright(1, 1, 0, 1);
						}
						else if (top == 222)
						{
							this.leftright(1, 0, 1, 1);
						}
						else if (top == 186)
						{
							this.leftright(0, 1, 1, 1);
						}
						else if (top == 78)
						{
							this.leftright(1, 1, 0, 1);
						}
						else if (top == 114)
						{
							this.leftright(1, 0, 1, 0);
						}
						else if (top == 150)
						{
							this.leftright(1, 0, 0, 1);
						}
					}
				}
				else if (top == 0x126)
				{
					this.leftright(1, 1, 1, 0);
				}
				else if (top == 0x102)
				{
					this.leftright(0, 1, 0, 1);
				}
				else if (top == 0x16e)
				{
					this.leftright(1, 1, 1, 0);
				}
				else if (top == 0x14a)
				{
					this.leftright(0, 1, 0, 1);
				}
				else if (top == 30)
				{
					this.leftright(0, 1, 0, 1);
				}
				else if (top == 78)
				{
					this.leftright(1, 1, 1, 0);
				}
				else if (top == 114)
				{
					this.leftright(0, 1, 0, 1);
				}
				else if (top == 150)
				{
					this.leftright(1, 1, 1, 0);
				}
			}
			else
			{
				int num1 = left;
				if (num1 <= 156)
				{
					if (num1 <= 48)
					{
						if (num1 == -26)
						{
							if (top == 184)
							{
								this.transport(1, 0);
							}
						}
						else if (num1 != 24)
						{
							if (num1 == 48)
							{
								if (top == 0x148)
								{
									this.leftright(1, 1, 1, 0);
								}
								else if (top == 0x124)
								{
									this.leftright(1, 0, 0, 1);
								}
							}
						}
						else if (top == 0x16c)
						{
							this.leftright(0, 1, 1, 0);
						}
						else if (top == 0x148)
						{
							this.leftright(0, 1, 0, 1);
						}
						else if (top == 0x124)
						{
							this.leftright(0, 1, 1, 0);
						}
						else if (top == 0x100)
						{
							this.leftright(0, 1, 0, 1);
						}
						else if (top == 112)
						{
							this.leftright(0, 1, 1, 0);
						}
						else if (top == 76)
						{
							this.leftright(0, 1, 1, 1);
						}
						else if (top == 28)
						{
							this.leftright(0, 1, 0, 1);
						}
					}
					else if (num1 == 84)
					{
						if (top == 0x100)
						{
							this.leftright(1, 1, 1, 1);
						}
						else if (top == 0x148)
						{
							this.leftright(1, 0, 1, 0);
						}
						else if (top == 0x124)
						{
							this.leftright(0, 1, 1, 1);
						}
						else if (top == 184)
						{
							this.leftright(1, 1, 1, 1);
						}
						else if (top == 112)
						{
							this.leftright(1, 0, 1, 1);
						}
						else if (top == 28)
						{
							this.leftright(1, 1, 0, 1);
						}
						else if (top == 76)
						{
							this.leftright(1, 1, 1, 1);
						}
					}
					else if (num1 != 120)
					{
						if (num1 == 156)
						{
							if (top == 0x148)
							{
								this.leftright(1, 0, 0, 1);
							}
							else if (top == 0x16c)
							{
								this.leftright(1, 1, 1, 0);
							}
							else if (top == 0x100)
							{
								this.leftright(1, 0, 0, 1);
							}
							else if (top == 0x124)
							{
								this.leftright(1, 1, 1, 0);
							}
							else if (top == 76)
							{
								this.leftright(1, 1, 1, 0);
							}
							else if (top == 112)
							{
								this.leftright(1, 0, 0, 1);
							}
							else if (top == 148)
							{
								this.leftright(1, 1, 1, 0);
							}
							else if (top == 28)
							{
								this.leftright(1, 0, 0, 1);
							}
						}
					}
					else if (top == 0x124)
					{
						this.leftright(1, 1, 0, 1);
					}
					else if (top == 0x148)
					{
						this.leftright(0, 1, 1, 0);
					}
					else if (top == 0x100)
					{
						this.leftright(1, 1, 1, 0);
					}
					else if (top == 220)
					{
						this.leftright(0, 1, 1, 1);
					}
					else if (top == 76)
					{
						this.leftright(1, 1, 0, 1);
					}
					else if (top == 112)
					{
						this.leftright(0, 1, 1, 0);
					}
					else if (top == 148)
					{
						this.leftright(0, 1, 0, 1);
					}
					else if (top == 184)
					{
						this.leftright(1, 0, 1, 1);
					}
				}
				else if (num1 > 228)
				{
					if (num1 <= 0x12c)
					{
						if (num1 != 0x108)
						{
							if (num1 == 0x12c)
							{
								if (top == 0x124)
								{
									this.leftright(0, 1, 0, 1);
								}
								else if (top == 0x148)
								{
									this.leftright(1, 1, 1, 0);
								}
							}
						}
						else if (top == 0x100)
						{
							this.leftright(1, 1, 1, 1);
						}
						else if (top == 0x124)
						{
							this.leftright(1, 0, 1, 1);
						}
						else if (top == 0x148)
						{
							this.leftright(0, 1, 1, 0);
						}
						else if (top == 184)
						{
							this.leftright(1, 1, 1, 1);
						}
						else if (top == 112)
						{
							this.leftright(0, 1, 1, 1);
						}
						else if (top == 28)
						{
							this.leftright(1, 1, 0, 1);
						}
						else if (top == 76)
						{
							this.leftright(1, 1, 1, 1);
						}
					}
					else if (num1 != 0x144)
					{
						if (num1 == 0x176)
						{
							if (top == 184)
							{
								this.transport(0, 1);
							}
						}
					}
					else if (top == 0x100)
					{
						this.leftright(1, 0, 0, 1);
					}
					else if (top == 0x124)
					{
						this.leftright(1, 0, 1, 0);
					}
					else if (top == 0x148)
					{
						this.leftright(1, 0, 0, 1);
					}
					else if (top == 0x16c)
					{
						this.leftright(1, 0, 1, 0);
					}
					else if (top == 112)
					{
						this.leftright(1, 0, 1, 0);
					}
					else if (top == 76)
					{
						this.leftright(1, 0, 1, 1);
					}
					else if (top == 28)
					{
						this.leftright(1, 0, 0, 1);
					}
				}
				else if (num1 == 174)
				{
					if (top == 148)
					{
						this.leftright(1, 1, 0, 0);
					}
				}
				else if (num1 != 192)
				{
					if (num1 == 228)
					{
						if (top == 0x100)
						{
							this.leftright(1, 1, 1, 0);
						}
						else if (top == 0x148)
						{
							this.leftright(1, 0, 1, 0);
						}
						else if (top == 0x124)
						{
							this.leftright(1, 1, 0, 1);
						}
						else if (top == 220)
						{
							this.leftright(1, 0, 1, 1);
						}
						else if (top == 184)
						{
							this.leftright(0, 1, 1, 1);
						}
						else if (top == 76)
						{
							this.leftright(1, 1, 0, 1);
						}
						else if (top == 112)
						{
							this.leftright(1, 0, 1, 0);
						}
						else if (top == 148)
						{
							this.leftright(1, 0, 0, 1);
						}
					}
				}
				else if (top == 0x124)
				{
					this.leftright(1, 1, 1, 0);
				}
				else if (top == 0x100)
				{
					this.leftright(0, 1, 0, 1);
				}
				else if (top == 0x16c)
				{
					this.leftright(1, 1, 1, 0);
				}
				else if (top == 0x148)
				{
					this.leftright(0, 1, 0, 1);
				}
				else if (top == 28)
				{
					this.leftright(0, 1, 0, 1);
				}
				else if (top == 76)
				{
					this.leftright(1, 1, 1, 0);
				}
				else if (top == 112)
				{
					this.leftright(0, 1, 0, 1);
				}
				else if (top == 148)
				{
					this.leftright(1, 1, 1, 0);
				}
			}
			this.pacturn = false;
			this.ghost1turn = false;
			this.ghost2turn = false;
			this.ghost3turn = false;
			this.ghost4turn = false;
		}

		private void attendo_Tick(object sender, EventArgs e)
		{
			this.resetall();
			this.attendo.Enabled = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.start = true;
			this.life();
			this.points();
			this.panel1.Visible = false;
			this.resetall();
		}

		private void button1_MouseEnter(object sender, EventArgs e)
		{
			this.button1.Image = Resources.playgame2;
		}

		private void button1_MouseLeave(object sender, EventArgs e)
		{
			this.button1.Image = Resources.playgame;
		}

		private void collision()
		{
			bool flag;
			if (this.pacman.Bounds.IntersectsWith(this.ghost1.Bounds) || this.pacman.Bounds.IntersectsWith(this.ghost2.Bounds) || this.pacman.Bounds.IntersectsWith(this.ghost3.Bounds))
			{
				flag = true;
			}
			else
			{
				Rectangle bounds = this.pacman.Bounds;
				flag = bounds.IntersectsWith(this.ghost4.Bounds);
			}
			if (flag)
			{
				if ((!this.pacman.Bounds.IntersectsWith(this.ghost1.Bounds) ? false : !this.Supermod1))
				{
					this.mangiato();
				}
				if ((!this.pacman.Bounds.IntersectsWith(this.ghost2.Bounds) ? false : !this.Supermod2))
				{
					this.mangiato();
				}
				if ((!this.pacman.Bounds.IntersectsWith(this.ghost3.Bounds) ? false : !this.Supermod3))
				{
					this.mangiato();
				}
				if ((!this.pacman.Bounds.IntersectsWith(this.ghost4.Bounds) ? false : !this.Supermod4))
				{
					this.mangiato();
				}
				if (this.Supermod)
				{
					if ((!this.pacman.Bounds.IntersectsWith(this.ghost1.Bounds) ? false : !this.Supermod1))
					{
						this.mangiato();
					}
					if ((!this.pacman.Bounds.IntersectsWith(this.ghost2.Bounds) ? false : !this.Supermod2))
					{
						this.mangiato();
					}
					if ((!this.pacman.Bounds.IntersectsWith(this.ghost3.Bounds) ? false : !this.Supermod3))
					{
						this.mangiato();
					}
					if ((!this.pacman.Bounds.IntersectsWith(this.ghost4.Bounds) ? false : !this.Supermod4))
					{
						this.mangiato();
					}
				}
				if ((!this.pacman.Bounds.IntersectsWith(this.ghost1.Bounds) || !this.ghost1puomangiare ? false : this.Supermod1))
				{
					this.g1mangiato = true;
					this.v1 = true;
					this.ghost1puomangiare = false;
					this.timer1.Enabled = false;
					this.ghostmangiato.Enabled = true;
					this.ghost1velocity = 4;
				}
				if ((!this.pacman.Bounds.IntersectsWith(this.ghost2.Bounds) || !this.ghost2puomangiare ? false : this.Supermod2))
				{
					this.g2mangiato = true;
					this.v2 = true;
					this.ghost2puomangiare = false;
					this.timer1.Enabled = false;
					this.ghostmangiato.Enabled = true;
					this.ghost2velocity = 4;
				}
				if ((!this.pacman.Bounds.IntersectsWith(this.ghost3.Bounds) || !this.ghost3puomangiare ? false : this.Supermod3))
				{
					this.g3mangiato = true;
					this.v3 = true;
					this.ghost3puomangiare = false;
					this.timer1.Enabled = false;
					this.ghostmangiato.Enabled = true;
					this.ghost3velocity = 4;
				}
				if ((!this.pacman.Bounds.IntersectsWith(this.ghost4.Bounds) || !this.ghost4puomangiare ? false : this.Supermod4))
				{
					this.g4mangiato = true;
					this.v4 = true;
					this.ghost4puomangiare = false;
					this.timer1.Enabled = false;
					this.ghostmangiato.Enabled = true;
					this.ghost4velocity = 4;
				}
			}
		}

		private void control()
		{
			if (this.ghost2.Top == 185)
			{
				this.timer3.Enabled = false;
				this.timer4.Enabled = true;
				this.c = false;
				this.timer5.Enabled = true;
			}
		}

		private void direction()
		{
			this.pacturn = true;
			this.a(this.pacman.Left, this.pacman.Top);
			PictureBox left = this.pacman;
			left.Left = left.Left + this.left;
			PictureBox top = this.pacman;
			top.Top = top.Top + this.top;
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
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

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Left)
			{
				this.next = 1;
			}
			if (e.KeyCode == Keys.Right)
			{
				this.next = 2;
			}
			if (e.KeyCode == Keys.Up)
			{
				this.next = 3;
			}
			if (e.KeyCode == Keys.Down)
			{
				this.next = 4;
			}
			if (e.KeyCode == Keys.Escape)
			{
				base.Close();
			}
			this.temp = this.next;
		}

		private void freedirection()
		{
			switch (this.direzione)
			{
				case 1:
				{
					if (this.next == 2)
					{
						this.left = 2;
						this.pacman.Image = Resources.pacdx;
						this.direzione = this.next;
						this.temp = this.next;
					}
					break;
				}
				case 2:
				{
					if (this.next == 1)
					{
						this.left = -2;
						this.pacman.Image = Resources.pacsx;
						this.direzione = this.next;
						this.temp = this.next;
					}
					break;
				}
				case 3:
				{
					if (this.next == 4)
					{
						this.top = 2;
						this.pacman.Image = Resources.pacdown;
						this.direzione = this.next;
						this.temp = this.next;
					}
					break;
				}
				case 4:
				{
					if (this.next == 3)
					{
						this.top = -2;
						this.pacman.Image = Resources.pacup;
						this.direzione = this.next;
						this.temp = this.next;
					}
					break;
				}
			}
		}

		private void ghost()
		{
			if (this.ghost1.Enabled)
			{
				Label left = this.ghost1;
				left.Left = left.Left + this.leftghost1;
				Label top = this.ghost1;
				top.Top = top.Top + this.topghost1;
				this.ghost1turn = true;
				this.a(this.ghost1.Left, this.ghost1.Top);
			}
			if (this.ghost2.Enabled)
			{
				Label label = this.ghost2;
				label.Left = label.Left + this.leftghost2;
				Label top1 = this.ghost2;
				top1.Top = top1.Top + this.topghost2;
				this.ghost2turn = true;
				this.a(this.ghost2.Left, this.ghost2.Top);
			}
			if (this.ghost3.Enabled)
			{
				Label left1 = this.ghost3;
				left1.Left = left1.Left + this.leftghost3;
				Label label1 = this.ghost3;
				label1.Top = label1.Top + this.topghost3;
				this.ghost3turn = true;
				this.a(this.ghost3.Left, this.ghost3.Top);
			}
			if (this.ghost4.Enabled)
			{
				Label left2 = this.ghost4;
				left2.Left = left2.Left + this.leftghost4;
				Label top2 = this.ghost4;
				top2.Top = top2.Top + this.topghost4;
				this.ghost4turn = true;
				this.a(this.ghost4.Left, this.ghost4.Top);
			}
		}

		private void ghostmangiato_Tick(object sender, EventArgs e)
		{
			this.timer1.Enabled = true;
			this.ghostmangiato.Enabled = false;
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
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
			((ISupportInitialize)this.pictureBox2).BeginInit();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
			((ISupportInitialize)this.pictureBox5).BeginInit();
			((ISupportInitialize)this.pictureBox4).BeginInit();
			((ISupportInitialize)this.pictureBox3).BeginInit();
			((ISupportInitialize)this.pacman).BeginInit();
			base.SuspendLayout();
			this.timer1.Interval = 16;
			this.timer1.Tick += new EventHandler(this.timer1_Tick);
			this.label1.BackColor = Color.Black;
			this.label1.Font = new System.Drawing.Font("Segoe UI Black", 16f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.White;
			this.label1.Image = Resources.score;
			this.label1.Location = new Point(16, 0x190);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 30);
			this.label1.TabIndex = 129;
			this.label2.BackColor = Color.Black;
			this.label2.Font = new System.Drawing.Font("Segoe UI Black", 16f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.White;
			this.label2.Image = Resources.lives;
			this.label2.Location = new Point(226, 0x18f);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 30);
			this.label2.TabIndex = 130;
			this.label3.BackColor = Color.Black;
			this.label3.Font = new System.Drawing.Font("Segoe UI Black", 10f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label3.ForeColor = Color.White;
			this.label3.Image = Resources.getready;
			this.label3.Location = new Point(123, 222);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(125, 19);
			this.label3.TabIndex = 133;
			this.label3.Text = "          ";
			this.label3.TextAlign = ContentAlignment.MiddleRight;
			this.timer2.Interval = 0xbb8;
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
			this.pictureBox2.Image = Resources._1sx;
			this.pictureBox2.Location = new Point(0x13e, 0x192);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(22, 22);
			this.pictureBox2.TabIndex = 132;
			this.pictureBox2.TabStop = false;
			this.pictureBox1.BackgroundImageLayout = ImageLayout.Center;
			this.pictureBox1.Image = Resources._1sx;
			this.pictureBox1.Location = new Point(0x129, 0x192);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(22, 22);
			this.pictureBox1.TabIndex = 131;
			this.pictureBox1.TabStop = false;
			this.ghost3.BackColor = Color.Transparent;
			this.ghost3.Cursor = Cursors.Default;
			this.ghost3.ForeColor = Color.Transparent;
			this.ghost3.Image = Resources.vup;
			this.ghost3.Location = new Point(176, 185);
			this.ghost3.Margin = new System.Windows.Forms.Padding(0);
			this.ghost3.Name = "ghost3";
			this.ghost3.Size = new System.Drawing.Size(18, 18);
			this.ghost3.TabIndex = 127;
			this.ghost4.BackColor = Color.Transparent;
			this.ghost4.Cursor = Cursors.Default;
			this.ghost4.ForeColor = Color.Transparent;
			this.ghost4.Image = Resources.gup;
			this.ghost4.Location = new Point(199, 185);
			this.ghost4.Margin = new System.Windows.Forms.Padding(0);
			this.ghost4.Name = "ghost4";
			this.ghost4.Size = new System.Drawing.Size(18, 18);
			this.ghost4.TabIndex = 126;
			this.ghost2.BackColor = Color.Transparent;
			this.ghost2.Cursor = Cursors.Default;
			this.ghost2.ForeColor = Color.Transparent;
			this.ghost2.Image = Resources.aup;
			this.ghost2.Location = new Point(154, 185);
			this.ghost2.Margin = new System.Windows.Forms.Padding(0);
			this.ghost2.Name = "ghost2";
			this.ghost2.Size = new System.Drawing.Size(18, 18);
			this.ghost2.TabIndex = 125;
			this.ghost1.BackColor = Color.Transparent;
			this.ghost1.Cursor = Cursors.Default;
			this.ghost1.ForeColor = Color.Transparent;
			this.ghost1.Image = Resources.rup;
			this.ghost1.Location = new Point(176, 150);
			this.ghost1.Margin = new System.Windows.Forms.Padding(0);
			this.ghost1.Name = "ghost1";
			this.ghost1.Size = new System.Drawing.Size(18, 18);
			this.ghost1.TabIndex = 124;
			this.label4.BackColor = Color.White;
			this.label4.Location = new Point(102, 0x10a);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(2, 2);
			this.label4.TabIndex = 134;
			this.label5.BackColor = Color.White;
			this.label5.Location = new Point(111, 0x10a);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(2, 2);
			this.label5.TabIndex = 135;
			this.label6.BackColor = Color.White;
			this.label6.Location = new Point(129, 0x10a);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(2, 2);
			this.label6.TabIndex = 137;
			this.label7.BackColor = Color.White;
			this.label7.Location = new Point(120, 0x10a);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(2, 2);
			this.label7.TabIndex = 136;
			this.label8.BackColor = Color.White;
			this.label8.Location = new Point(165, 0x10a);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(2, 2);
			this.label8.TabIndex = 141;
			this.label9.BackColor = Color.White;
			this.label9.Location = new Point(156, 0x10a);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(2, 2);
			this.label9.TabIndex = 140;
			this.label10.BackColor = Color.White;
			this.label10.Location = new Point(147, 0x10a);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(2, 2);
			this.label10.TabIndex = 139;
			this.label11.BackColor = Color.White;
			this.label11.Location = new Point(138, 0x10a);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(2, 2);
			this.label11.TabIndex = 138;
			this.label12.BackColor = Color.White;
			this.label12.Location = new Point(94, 0x10a);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(2, 2);
			this.label12.TabIndex = 149;
			this.label13.BackColor = Color.White;
			this.label13.Location = new Point(78, 0x10a);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(2, 2);
			this.label13.TabIndex = 148;
			this.label14.BackColor = Color.White;
			this.label14.Location = new Point(69, 0x10a);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(2, 2);
			this.label14.TabIndex = 147;
			this.label15.BackColor = Color.White;
			this.label15.Location = new Point(60, 0x10a);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(2, 2);
			this.label15.TabIndex = 146;
			this.label16.BackColor = Color.White;
			this.label16.Location = new Point(52, 0x10a);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(2, 2);
			this.label16.TabIndex = 145;
			this.label17.BackColor = Color.White;
			this.label17.Location = new Point(43, 0x10a);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(2, 2);
			this.label17.TabIndex = 144;
			this.label18.BackColor = Color.White;
			this.label18.Location = new Point(247, 0x10a);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(2, 2);
			this.label18.TabIndex = 163;
			this.label19.BackColor = Color.White;
			this.label19.Location = new Point(238, 0x10a);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(2, 2);
			this.label19.TabIndex = 162;
			this.label20.BackColor = Color.White;
			this.label20.Location = new Point(229, 0x10a);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(2, 2);
			this.label20.TabIndex = 161;
			this.label21.BackColor = Color.White;
			this.label21.Location = new Point(220, 0x10a);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(2, 2);
			this.label21.TabIndex = 160;
			this.label22.BackColor = Color.White;
			this.label22.Location = new Point(211, 0x10a);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(2, 2);
			this.label22.TabIndex = 159;
			this.label23.BackColor = Color.White;
			this.label23.Location = new Point(202, 0x10a);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(2, 2);
			this.label23.TabIndex = 158;
			this.label24.BackColor = Color.White;
			this.label24.Location = new Point(0x13e, 0x10a);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(2, 2);
			this.label24.TabIndex = 157;
			this.label25.BackColor = Color.White;
			this.label25.Location = new Point(0x136, 0x10a);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(2, 2);
			this.label25.TabIndex = 156;
			this.label26.BackColor = Color.White;
			this.label26.Location = new Point(0x12d, 0x10a);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(2, 2);
			this.label26.TabIndex = 155;
			this.label27.BackColor = Color.White;
			this.label27.Location = new Point(0x124, 0x10a);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(2, 2);
			this.label27.TabIndex = 154;
			this.label28.BackColor = Color.White;
			this.label28.Location = new Point(0x11b, 0x10a);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(2, 2);
			this.label28.TabIndex = 153;
			this.label29.BackColor = Color.White;
			this.label29.Location = new Point(0x112, 0x10a);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(2, 2);
			this.label29.TabIndex = 152;
			this.label30.BackColor = Color.White;
			this.label30.Location = new Point(0x109, 0x10a);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(2, 2);
			this.label30.TabIndex = 151;
			this.label31.BackColor = Color.White;
			this.label31.Location = new Point(0x100, 0x10a);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(2, 2);
			this.label31.TabIndex = 150;
			this.score.AutoSize = true;
			this.score.Font = new System.Drawing.Font("Segoe UI Black", 15f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.score.ForeColor = Color.FromArgb(0xff, 0xff, 51);
			this.score.Location = new Point(93, 0x18f);
			this.score.Name = "score";
			this.score.Size = new System.Drawing.Size(24, 28);
			this.score.TabIndex = 164;
			this.score.Text = "0";
			this.label43.BackColor = Color.White;
			this.label43.Location = new Point(165, 0x11c);
			this.label43.Name = "label43";
			this.label43.Size = new System.Drawing.Size(2, 2);
			this.label43.TabIndex = 180;
			this.label44.BackColor = Color.White;
			this.label44.Location = new Point(165, 0x125);
			this.label44.Name = "label44";
			this.label44.Size = new System.Drawing.Size(2, 2);
			this.label44.TabIndex = 181;
			this.label32.BackColor = Color.White;
			this.label32.Location = new Point(165, 0x113);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(2, 2);
			this.label32.TabIndex = 179;
			this.label45.BackColor = Color.White;
			this.label45.Location = new Point(202, 0x125);
			this.label45.Name = "label45";
			this.label45.Size = new System.Drawing.Size(2, 2);
			this.label45.TabIndex = 185;
			this.label46.BackColor = Color.White;
			this.label46.Location = new Point(202, 0x11c);
			this.label46.Name = "label46";
			this.label46.Size = new System.Drawing.Size(2, 2);
			this.label46.TabIndex = 184;
			this.label47.BackColor = Color.White;
			this.label47.Location = new Point(202, 0x113);
			this.label47.Name = "label47";
			this.label47.Size = new System.Drawing.Size(2, 2);
			this.label47.TabIndex = 183;
			this.label49.BackColor = Color.White;
			this.label49.Location = new Point(0x146, 0x10a);
			this.label49.Name = "label49";
			this.label49.Size = new System.Drawing.Size(2, 2);
			this.label49.TabIndex = 186;
			this.label50.BackColor = Color.White;
			this.label50.Location = new Point(35, 0x10a);
			this.label50.Name = "label50";
			this.label50.Size = new System.Drawing.Size(2, 2);
			this.label50.TabIndex = 187;
			this.label33.BackColor = Color.White;
			this.label33.Location = new Point(94, 0x12e);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(2, 2);
			this.label33.TabIndex = 196;
			this.label34.BackColor = Color.White;
			this.label34.Location = new Point(165, 0x12e);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(2, 2);
			this.label34.TabIndex = 195;
			this.label35.BackColor = Color.White;
			this.label35.Location = new Point(156, 0x12e);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(2, 2);
			this.label35.TabIndex = 194;
			this.label36.BackColor = Color.White;
			this.label36.Location = new Point(147, 0x12e);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(2, 2);
			this.label36.TabIndex = 193;
			this.label37.BackColor = Color.White;
			this.label37.Location = new Point(138, 0x12e);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(2, 2);
			this.label37.TabIndex = 192;
			this.label38.BackColor = Color.White;
			this.label38.Location = new Point(129, 0x12e);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(2, 2);
			this.label38.TabIndex = 191;
			this.label39.BackColor = Color.White;
			this.label39.Location = new Point(120, 0x12e);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(2, 2);
			this.label39.TabIndex = 190;
			this.label40.BackColor = Color.White;
			this.label40.Location = new Point(111, 0x12e);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(2, 2);
			this.label40.TabIndex = 189;
			this.label41.BackColor = Color.White;
			this.label41.Location = new Point(102, 0x12e);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(2, 2);
			this.label41.TabIndex = 188;
			this.label42.BackColor = Color.White;
			this.label42.Location = new Point(202, 0x12e);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(2, 2);
			this.label42.TabIndex = 205;
			this.label48.BackColor = Color.White;
			this.label48.Location = new Point(0x112, 0x12e);
			this.label48.Name = "label48";
			this.label48.Size = new System.Drawing.Size(2, 2);
			this.label48.TabIndex = 204;
			this.label51.BackColor = Color.White;
			this.label51.Location = new Point(0x109, 0x12e);
			this.label51.Name = "label51";
			this.label51.Size = new System.Drawing.Size(2, 2);
			this.label51.TabIndex = 203;
			this.label52.BackColor = Color.White;
			this.label52.Location = new Point(0x100, 0x12e);
			this.label52.Name = "label52";
			this.label52.Size = new System.Drawing.Size(2, 2);
			this.label52.TabIndex = 202;
			this.label53.BackColor = Color.White;
			this.label53.Location = new Point(247, 0x12e);
			this.label53.Name = "label53";
			this.label53.Size = new System.Drawing.Size(2, 2);
			this.label53.TabIndex = 201;
			this.label54.BackColor = Color.White;
			this.label54.Location = new Point(238, 0x12e);
			this.label54.Name = "label54";
			this.label54.Size = new System.Drawing.Size(2, 2);
			this.label54.TabIndex = 200;
			this.label55.BackColor = Color.White;
			this.label55.Location = new Point(229, 0x12e);
			this.label55.Name = "label55";
			this.label55.Size = new System.Drawing.Size(2, 2);
			this.label55.TabIndex = 199;
			this.label56.BackColor = Color.White;
			this.label56.Location = new Point(220, 0x12e);
			this.label56.Name = "label56";
			this.label56.Size = new System.Drawing.Size(2, 2);
			this.label56.TabIndex = 198;
			this.label57.BackColor = Color.White;
			this.label57.Location = new Point(211, 0x12e);
			this.label57.Name = "label57";
			this.label57.Size = new System.Drawing.Size(2, 2);
			this.label57.TabIndex = 197;
			this.label58.BackColor = Color.White;
			this.label58.Location = new Point(94, 0x125);
			this.label58.Name = "label58";
			this.label58.Size = new System.Drawing.Size(2, 2);
			this.label58.TabIndex = 208;
			this.label59.BackColor = Color.White;
			this.label59.Location = new Point(94, 0x11c);
			this.label59.Name = "label59";
			this.label59.Size = new System.Drawing.Size(2, 2);
			this.label59.TabIndex = 207;
			this.label60.BackColor = Color.White;
			this.label60.Location = new Point(94, 0x113);
			this.label60.Name = "label60";
			this.label60.Size = new System.Drawing.Size(2, 2);
			this.label60.TabIndex = 206;
			this.label61.BackColor = Color.White;
			this.label61.Location = new Point(0x112, 0x125);
			this.label61.Name = "label61";
			this.label61.Size = new System.Drawing.Size(2, 2);
			this.label61.TabIndex = 211;
			this.label62.BackColor = Color.White;
			this.label62.Location = new Point(0x112, 0x11c);
			this.label62.Name = "label62";
			this.label62.Size = new System.Drawing.Size(2, 2);
			this.label62.TabIndex = 210;
			this.label63.BackColor = Color.White;
			this.label63.Location = new Point(0x112, 0x113);
			this.label63.Name = "label63";
			this.label63.Size = new System.Drawing.Size(2, 2);
			this.label63.TabIndex = 209;
			this.label64.BackColor = Color.White;
			this.label64.Location = new Point(183, 0x12e);
			this.label64.Name = "label64";
			this.label64.Size = new System.Drawing.Size(2, 2);
			this.label64.TabIndex = 213;
			this.label65.BackColor = Color.White;
			this.label65.Location = new Point(174, 0x12e);
			this.label65.Name = "label65";
			this.label65.Size = new System.Drawing.Size(2, 2);
			this.label65.TabIndex = 212;
			this.label66.BackColor = Color.White;
			this.label66.Location = new Point(192, 0x12e);
			this.label66.Name = "label66";
			this.label66.Size = new System.Drawing.Size(2, 2);
			this.label66.TabIndex = 214;
			this.label67.BackColor = Color.White;
			this.label67.Location = new Point(0x14e, 0x125);
			this.label67.Name = "label67";
			this.label67.Size = new System.Drawing.Size(2, 2);
			this.label67.TabIndex = 217;
			this.label68.BackColor = Color.White;
			this.label68.Location = new Point(0x14e, 0x11c);
			this.label68.Name = "label68";
			this.label68.Size = new System.Drawing.Size(2, 2);
			this.label68.TabIndex = 216;
			this.label69.BackColor = Color.White;
			this.label69.Location = new Point(0x14e, 0x113);
			this.label69.Name = "label69";
			this.label69.Size = new System.Drawing.Size(2, 2);
			this.label69.TabIndex = 215;
			this.label70.BackColor = Color.White;
			this.label70.Location = new Point(0x14e, 0x10a);
			this.label70.Name = "label70";
			this.label70.Size = new System.Drawing.Size(2, 2);
			this.label70.TabIndex = 218;
			this.label71.BackColor = Color.Black;
			this.label71.Image = (Image)resources.GetObject("label71.Image");
			this.label71.Location = new Point(0x14a, 0x12a);
			this.label71.Name = "label71";
			this.label71.Size = new System.Drawing.Size(10, 10);
			this.label71.TabIndex = 222;
			this.label72.BackColor = Color.White;
			this.label72.Location = new Point(0x146, 0x12e);
			this.label72.Name = "label72";
			this.label72.Size = new System.Drawing.Size(2, 2);
			this.label72.TabIndex = 221;
			this.label73.BackColor = Color.White;
			this.label73.Location = new Point(0x13e, 0x12e);
			this.label73.Name = "label73";
			this.label73.Size = new System.Drawing.Size(2, 2);
			this.label73.TabIndex = 220;
			this.label74.BackColor = Color.White;
			this.label74.Location = new Point(0x136, 0x12e);
			this.label74.Name = "label74";
			this.label74.Size = new System.Drawing.Size(2, 2);
			this.label74.TabIndex = 219;
			this.label76.BackColor = Color.White;
			this.label76.Location = new Point(0x136, 0x137);
			this.label76.Name = "label76";
			this.label76.Size = new System.Drawing.Size(2, 2);
			this.label76.TabIndex = 226;
			this.label77.BackColor = Color.White;
			this.label77.Location = new Point(0x136, 0x152);
			this.label77.Name = "label77";
			this.label77.Size = new System.Drawing.Size(2, 2);
			this.label77.TabIndex = 225;
			this.label78.BackColor = Color.White;
			this.label78.Location = new Point(0x136, 0x149);
			this.label78.Name = "label78";
			this.label78.Size = new System.Drawing.Size(2, 2);
			this.label78.TabIndex = 224;
			this.label79.BackColor = Color.White;
			this.label79.Location = new Point(0x136, 0x140);
			this.label79.Name = "label79";
			this.label79.Size = new System.Drawing.Size(2, 2);
			this.label79.TabIndex = 223;
			this.label80.BackColor = Color.White;
			this.label80.Location = new Point(0x12d, 0x152);
			this.label80.Name = "label80";
			this.label80.Size = new System.Drawing.Size(2, 2);
			this.label80.TabIndex = 230;
			this.label81.BackColor = Color.White;
			this.label81.Location = new Point(0x124, 0x152);
			this.label81.Name = "label81";
			this.label81.Size = new System.Drawing.Size(2, 2);
			this.label81.TabIndex = 229;
			this.label82.BackColor = Color.White;
			this.label82.Location = new Point(0x11b, 0x152);
			this.label82.Name = "label82";
			this.label82.Size = new System.Drawing.Size(2, 2);
			this.label82.TabIndex = 228;
			this.label83.BackColor = Color.White;
			this.label83.Location = new Point(0x112, 0x152);
			this.label83.Name = "label83";
			this.label83.Size = new System.Drawing.Size(2, 2);
			this.label83.TabIndex = 227;
			this.label75.BackColor = Color.White;
			this.label75.Location = new Point(0x112, 0x137);
			this.label75.Name = "label75";
			this.label75.Size = new System.Drawing.Size(2, 2);
			this.label75.TabIndex = 233;
			this.label84.BackColor = Color.White;
			this.label84.Location = new Point(0x112, 0x149);
			this.label84.Name = "label84";
			this.label84.Size = new System.Drawing.Size(2, 2);
			this.label84.TabIndex = 232;
			this.label85.BackColor = Color.White;
			this.label85.Location = new Point(0x112, 0x140);
			this.label85.Name = "label85";
			this.label85.Size = new System.Drawing.Size(2, 2);
			this.label85.TabIndex = 231;
			this.label86.BackColor = Color.White;
			this.label86.Location = new Point(238, 0x137);
			this.label86.Name = "label86";
			this.label86.Size = new System.Drawing.Size(2, 2);
			this.label86.TabIndex = 237;
			this.label87.BackColor = Color.White;
			this.label87.Location = new Point(238, 0x149);
			this.label87.Name = "label87";
			this.label87.Size = new System.Drawing.Size(2, 2);
			this.label87.TabIndex = 236;
			this.label88.BackColor = Color.White;
			this.label88.Location = new Point(238, 0x140);
			this.label88.Name = "label88";
			this.label88.Size = new System.Drawing.Size(2, 2);
			this.label88.TabIndex = 235;
			this.label89.BackColor = Color.White;
			this.label89.Location = new Point(238, 0x152);
			this.label89.Name = "label89";
			this.label89.Size = new System.Drawing.Size(2, 2);
			this.label89.TabIndex = 234;
			this.label90.BackColor = Color.White;
			this.label90.Location = new Point(220, 0x152);
			this.label90.Name = "label90";
			this.label90.Size = new System.Drawing.Size(2, 2);
			this.label90.TabIndex = 242;
			this.label91.BackColor = Color.White;
			this.label91.Location = new Point(211, 0x152);
			this.label91.Name = "label91";
			this.label91.Size = new System.Drawing.Size(2, 2);
			this.label91.TabIndex = 241;
			this.label92.BackColor = Color.White;
			this.label92.Location = new Point(202, 0x152);
			this.label92.Name = "label92";
			this.label92.Size = new System.Drawing.Size(2, 2);
			this.label92.TabIndex = 240;
			this.label94.BackColor = Color.White;
			this.label94.Location = new Point(229, 0x152);
			this.label94.Name = "label94";
			this.label94.Size = new System.Drawing.Size(2, 2);
			this.label94.TabIndex = 238;
			this.label93.BackColor = Color.White;
			this.label93.Location = new Point(202, 0x164);
			this.label93.Name = "label93";
			this.label93.Size = new System.Drawing.Size(2, 2);
			this.label93.TabIndex = 247;
			this.label95.BackColor = Color.White;
			this.label95.Location = new Point(202, 0x176);
			this.label95.Name = "label95";
			this.label95.Size = new System.Drawing.Size(2, 2);
			this.label95.TabIndex = 246;
			this.label96.BackColor = Color.White;
			this.label96.Location = new Point(202, 0x16d);
			this.label96.Name = "label96";
			this.label96.Size = new System.Drawing.Size(2, 2);
			this.label96.TabIndex = 245;
			this.label98.BackColor = Color.White;
			this.label98.Location = new Point(202, 0x15b);
			this.label98.Name = "label98";
			this.label98.Size = new System.Drawing.Size(2, 2);
			this.label98.TabIndex = 243;
			this.label97.BackColor = Color.White;
			this.label97.Location = new Point(0x14e, 0x164);
			this.label97.Name = "label97";
			this.label97.Size = new System.Drawing.Size(2, 2);
			this.label97.TabIndex = 252;
			this.label99.BackColor = Color.White;
			this.label99.Location = new Point(0x14e, 0x176);
			this.label99.Name = "label99";
			this.label99.Size = new System.Drawing.Size(2, 2);
			this.label99.TabIndex = 251;
			this.label100.BackColor = Color.White;
			this.label100.Location = new Point(0x14e, 0x16d);
			this.label100.Name = "label100";
			this.label100.Size = new System.Drawing.Size(2, 2);
			this.label100.TabIndex = 250;
			this.label101.BackColor = Color.White;
			this.label101.Location = new Point(0x14e, 0x15b);
			this.label101.Name = "label101";
			this.label101.Size = new System.Drawing.Size(2, 2);
			this.label101.TabIndex = 249;
			this.label102.BackColor = Color.White;
			this.label102.Location = new Point(0x14e, 0x152);
			this.label102.Name = "label102";
			this.label102.Size = new System.Drawing.Size(2, 2);
			this.label102.TabIndex = 248;
			this.label103.BackColor = Color.White;
			this.label103.Location = new Point(0x146, 0x152);
			this.label103.Name = "label103";
			this.label103.Size = new System.Drawing.Size(2, 2);
			this.label103.TabIndex = 254;
			this.label104.BackColor = Color.White;
			this.label104.Location = new Point(0x13e, 0x152);
			this.label104.Name = "label104";
			this.label104.Size = new System.Drawing.Size(2, 2);
			this.label104.TabIndex = 253;
			this.label105.BackColor = Color.White;
			this.label105.Location = new Point(0x146, 0x176);
			this.label105.Name = "label105";
			this.label105.Size = new System.Drawing.Size(2, 2);
			this.label105.TabIndex = 0x10c;
			this.label106.BackColor = Color.White;
			this.label106.Location = new Point(247, 0x176);
			this.label106.Name = "label106";
			this.label106.Size = new System.Drawing.Size(2, 2);
			this.label106.TabIndex = 0x10b;
			this.label107.BackColor = Color.White;
			this.label107.Location = new Point(238, 0x176);
			this.label107.Name = "label107";
			this.label107.Size = new System.Drawing.Size(2, 2);
			this.label107.TabIndex = 0x10a;
			this.label108.BackColor = Color.White;
			this.label108.Location = new Point(229, 0x176);
			this.label108.Name = "label108";
			this.label108.Size = new System.Drawing.Size(2, 2);
			this.label108.TabIndex = 0x109;
			this.label109.BackColor = Color.White;
			this.label109.Location = new Point(220, 0x176);
			this.label109.Name = "label109";
			this.label109.Size = new System.Drawing.Size(2, 2);
			this.label109.TabIndex = 0x108;
			this.label110.BackColor = Color.White;
			this.label110.Location = new Point(211, 0x176);
			this.label110.Name = "label110";
			this.label110.Size = new System.Drawing.Size(2, 2);
			this.label110.TabIndex = 0x107;
			this.label111.BackColor = Color.White;
			this.label111.Location = new Point(0x13e, 0x176);
			this.label111.Name = "label111";
			this.label111.Size = new System.Drawing.Size(2, 2);
			this.label111.TabIndex = 0x106;
			this.label112.BackColor = Color.White;
			this.label112.Location = new Point(0x136, 0x176);
			this.label112.Name = "label112";
			this.label112.Size = new System.Drawing.Size(2, 2);
			this.label112.TabIndex = 0x105;
			this.label113.BackColor = Color.White;
			this.label113.Location = new Point(0x12d, 0x176);
			this.label113.Name = "label113";
			this.label113.Size = new System.Drawing.Size(2, 2);
			this.label113.TabIndex = 0x104;
			this.label114.BackColor = Color.White;
			this.label114.Location = new Point(0x124, 0x176);
			this.label114.Name = "label114";
			this.label114.Size = new System.Drawing.Size(2, 2);
			this.label114.TabIndex = 0x103;
			this.label115.BackColor = Color.White;
			this.label115.Location = new Point(0x11b, 0x176);
			this.label115.Name = "label115";
			this.label115.Size = new System.Drawing.Size(2, 2);
			this.label115.TabIndex = 0x102;
			this.label116.BackColor = Color.White;
			this.label116.Location = new Point(0x112, 0x176);
			this.label116.Name = "label116";
			this.label116.Size = new System.Drawing.Size(2, 2);
			this.label116.TabIndex = 0x101;
			this.label117.BackColor = Color.White;
			this.label117.Location = new Point(0x109, 0x176);
			this.label117.Name = "label117";
			this.label117.Size = new System.Drawing.Size(2, 2);
			this.label117.TabIndex = 0x100;
			this.label118.BackColor = Color.White;
			this.label118.Location = new Point(0x100, 0x176);
			this.label118.Name = "label118";
			this.label118.Size = new System.Drawing.Size(2, 2);
			this.label118.TabIndex = 0xff;
			this.label119.BackColor = Color.White;
			this.label119.Location = new Point(157, 0x176);
			this.label119.Name = "label119";
			this.label119.Size = new System.Drawing.Size(2, 2);
			this.label119.TabIndex = 0x138;
			this.label120.BackColor = Color.White;
			this.label120.Location = new Point(78, 0x176);
			this.label120.Name = "label120";
			this.label120.Size = new System.Drawing.Size(2, 2);
			this.label120.TabIndex = 0x137;
			this.label121.BackColor = Color.White;
			this.label121.Location = new Point(69, 0x176);
			this.label121.Name = "label121";
			this.label121.Size = new System.Drawing.Size(2, 2);
			this.label121.TabIndex = 0x136;
			this.label122.BackColor = Color.White;
			this.label122.Location = new Point(60, 0x176);
			this.label122.Name = "label122";
			this.label122.Size = new System.Drawing.Size(2, 2);
			this.label122.TabIndex = 0x135;
			this.label123.BackColor = Color.White;
			this.label123.Location = new Point(51, 0x176);
			this.label123.Name = "label123";
			this.label123.Size = new System.Drawing.Size(2, 2);
			this.label123.TabIndex = 0x134;
			this.label125.BackColor = Color.White;
			this.label125.Location = new Point(149, 0x176);
			this.label125.Name = "label125";
			this.label125.Size = new System.Drawing.Size(2, 2);
			this.label125.TabIndex = 0x132;
			this.label126.BackColor = Color.White;
			this.label126.Location = new Point(141, 0x176);
			this.label126.Name = "label126";
			this.label126.Size = new System.Drawing.Size(2, 2);
			this.label126.TabIndex = 0x131;
			this.label127.BackColor = Color.White;
			this.label127.Location = new Point(132, 0x176);
			this.label127.Name = "label127";
			this.label127.Size = new System.Drawing.Size(2, 2);
			this.label127.TabIndex = 0x130;
			this.label128.BackColor = Color.White;
			this.label128.Location = new Point(123, 0x176);
			this.label128.Name = "label128";
			this.label128.Size = new System.Drawing.Size(2, 2);
			this.label128.TabIndex = 0x12f;
			this.label129.BackColor = Color.White;
			this.label129.Location = new Point(114, 0x176);
			this.label129.Name = "label129";
			this.label129.Size = new System.Drawing.Size(2, 2);
			this.label129.TabIndex = 0x12e;
			this.label130.BackColor = Color.White;
			this.label130.Location = new Point(105, 0x176);
			this.label130.Name = "label130";
			this.label130.Size = new System.Drawing.Size(2, 2);
			this.label130.TabIndex = 0x12d;
			this.label131.BackColor = Color.White;
			this.label131.Location = new Point(96, 0x176);
			this.label131.Name = "label131";
			this.label131.Size = new System.Drawing.Size(2, 2);
			this.label131.TabIndex = 0x12c;
			this.label132.BackColor = Color.White;
			this.label132.Location = new Point(87, 0x176);
			this.label132.Name = "label132";
			this.label132.Size = new System.Drawing.Size(2, 2);
			this.label132.TabIndex = 0x12b;
			this.label133.BackColor = Color.White;
			this.label133.Location = new Point(156, 0x152);
			this.label133.Name = "label133";
			this.label133.Size = new System.Drawing.Size(2, 2);
			this.label133.TabIndex = 0x12a;
			this.label134.BackColor = Color.White;
			this.label134.Location = new Point(147, 0x152);
			this.label134.Name = "label134";
			this.label134.Size = new System.Drawing.Size(2, 2);
			this.label134.TabIndex = 0x129;
			this.label135.BackColor = Color.White;
			this.label135.Location = new Point(165, 0x164);
			this.label135.Name = "label135";
			this.label135.Size = new System.Drawing.Size(2, 2);
			this.label135.TabIndex = 0x128;
			this.label136.BackColor = Color.White;
			this.label136.Location = new Point(165, 0x176);
			this.label136.Name = "label136";
			this.label136.Size = new System.Drawing.Size(2, 2);
			this.label136.TabIndex = 0x127;
			this.label137.BackColor = Color.White;
			this.label137.Location = new Point(165, 0x16d);
			this.label137.Name = "label137";
			this.label137.Size = new System.Drawing.Size(2, 2);
			this.label137.TabIndex = 0x126;
			this.label138.BackColor = Color.White;
			this.label138.Location = new Point(165, 0x15b);
			this.label138.Name = "label138";
			this.label138.Size = new System.Drawing.Size(2, 2);
			this.label138.TabIndex = 0x125;
			this.label139.BackColor = Color.White;
			this.label139.Location = new Point(165, 0x152);
			this.label139.Name = "label139";
			this.label139.Size = new System.Drawing.Size(2, 2);
			this.label139.TabIndex = 0x124;
			this.label140.BackColor = Color.White;
			this.label140.Location = new Point(35, 0x164);
			this.label140.Name = "label140";
			this.label140.Size = new System.Drawing.Size(2, 2);
			this.label140.TabIndex = 0x123;
			this.label143.BackColor = Color.White;
			this.label143.Location = new Point(35, 0x15b);
			this.label143.Name = "label143";
			this.label143.Size = new System.Drawing.Size(2, 2);
			this.label143.TabIndex = 0x120;
			this.label144.BackColor = Color.White;
			this.label144.Location = new Point(50, 0x152);
			this.label144.Name = "label144";
			this.label144.Size = new System.Drawing.Size(2, 2);
			this.label144.TabIndex = 0x11f;
			this.label145.BackColor = Color.White;
			this.label145.Location = new Point(42, 0x152);
			this.label145.Name = "label145";
			this.label145.Size = new System.Drawing.Size(2, 2);
			this.label145.TabIndex = 0x11e;
			this.label146.BackColor = Color.White;
			this.label146.Location = new Point(35, 0x152);
			this.label146.Name = "label146";
			this.label146.Size = new System.Drawing.Size(2, 2);
			this.label146.TabIndex = 0x11d;
			this.label147.BackColor = Color.White;
			this.label147.Location = new Point(59, 0x152);
			this.label147.Name = "label147";
			this.label147.Size = new System.Drawing.Size(2, 2);
			this.label147.TabIndex = 0x11c;
			this.label148.BackColor = Color.White;
			this.label148.Location = new Point(59, 0x137);
			this.label148.Name = "label148";
			this.label148.Size = new System.Drawing.Size(2, 2);
			this.label148.TabIndex = 0x11b;
			this.label149.BackColor = Color.White;
			this.label149.Location = new Point(59, 0x149);
			this.label149.Name = "label149";
			this.label149.Size = new System.Drawing.Size(2, 2);
			this.label149.TabIndex = 0x11a;
			this.label150.BackColor = Color.White;
			this.label150.Location = new Point(59, 0x140);
			this.label150.Name = "label150";
			this.label150.Size = new System.Drawing.Size(2, 2);
			this.label150.TabIndex = 0x119;
			this.label151.BackColor = Color.White;
			this.label151.Location = new Point(68, 0x152);
			this.label151.Name = "label151";
			this.label151.Size = new System.Drawing.Size(2, 2);
			this.label151.TabIndex = 0x118;
			this.label152.BackColor = Color.White;
			this.label152.Location = new Point(94, 0x137);
			this.label152.Name = "label152";
			this.label152.Size = new System.Drawing.Size(2, 2);
			this.label152.TabIndex = 0x117;
			this.label153.BackColor = Color.White;
			this.label153.Location = new Point(94, 0x149);
			this.label153.Name = "label153";
			this.label153.Size = new System.Drawing.Size(2, 2);
			this.label153.TabIndex = 0x116;
			this.label154.BackColor = Color.White;
			this.label154.Location = new Point(94, 0x140);
			this.label154.Name = "label154";
			this.label154.Size = new System.Drawing.Size(2, 2);
			this.label154.TabIndex = 0x115;
			this.label155.BackColor = Color.White;
			this.label155.Location = new Point(129, 0x152);
			this.label155.Name = "label155";
			this.label155.Size = new System.Drawing.Size(2, 2);
			this.label155.TabIndex = 0x114;
			this.label156.BackColor = Color.White;
			this.label156.Location = new Point(94, 0x152);
			this.label156.Name = "label156";
			this.label156.Size = new System.Drawing.Size(2, 2);
			this.label156.TabIndex = 0x113;
			this.label157.BackColor = Color.White;
			this.label157.Location = new Point(85, 0x152);
			this.label157.Name = "label157";
			this.label157.Size = new System.Drawing.Size(2, 2);
			this.label157.TabIndex = 0x112;
			this.label158.BackColor = Color.White;
			this.label158.Location = new Point(76, 0x152);
			this.label158.Name = "label158";
			this.label158.Size = new System.Drawing.Size(2, 2);
			this.label158.TabIndex = 0x111;
			this.label159.BackColor = Color.White;
			this.label159.Location = new Point(129, 0x137);
			this.label159.Name = "label159";
			this.label159.Size = new System.Drawing.Size(2, 2);
			this.label159.TabIndex = 0x110;
			this.label160.BackColor = Color.White;
			this.label160.Location = new Point(138, 0x152);
			this.label160.Name = "label160";
			this.label160.Size = new System.Drawing.Size(2, 2);
			this.label160.TabIndex = 0x10f;
			this.label161.BackColor = Color.White;
			this.label161.Location = new Point(129, 0x149);
			this.label161.Name = "label161";
			this.label161.Size = new System.Drawing.Size(2, 2);
			this.label161.TabIndex = 0x10e;
			this.label162.BackColor = Color.White;
			this.label162.Location = new Point(129, 0x140);
			this.label162.Name = "label162";
			this.label162.Size = new System.Drawing.Size(2, 2);
			this.label162.TabIndex = 0x10d;
			this.label163.BackColor = Color.White;
			this.label163.Location = new Point(192, 0x176);
			this.label163.Name = "label163";
			this.label163.Size = new System.Drawing.Size(2, 2);
			this.label163.TabIndex = 0x13b;
			this.label164.BackColor = Color.White;
			this.label164.Location = new Point(183, 0x176);
			this.label164.Name = "label164";
			this.label164.Size = new System.Drawing.Size(2, 2);
			this.label164.TabIndex = 0x13a;
			this.label165.BackColor = Color.White;
			this.label165.Location = new Point(174, 0x176);
			this.label165.Name = "label165";
			this.label165.Size = new System.Drawing.Size(2, 2);
			this.label165.TabIndex = 0x139;
			this.label166.BackColor = Color.White;
			this.label166.Location = new Point(35, 0x125);
			this.label166.Name = "label166";
			this.label166.Size = new System.Drawing.Size(2, 2);
			this.label166.TabIndex = 0x13e;
			this.label167.BackColor = Color.White;
			this.label167.Location = new Point(35, 0x11c);
			this.label167.Name = "label167";
			this.label167.Size = new System.Drawing.Size(2, 2);
			this.label167.TabIndex = 0x13d;
			this.label168.BackColor = Color.White;
			this.label168.Location = new Point(35, 0x113);
			this.label168.Name = "label168";
			this.label168.Size = new System.Drawing.Size(2, 2);
			this.label168.TabIndex = 0x13c;
			this.label169.BackColor = Color.White;
			this.label169.Location = new Point(86, 0x10a);
			this.label169.Name = "label169";
			this.label169.Size = new System.Drawing.Size(2, 2);
			this.label169.TabIndex = 0x13f;
			this.label170.BackColor = Color.White;
			this.label170.Location = new Point(59, 0x12e);
			this.label170.Name = "label170";
			this.label170.Size = new System.Drawing.Size(2, 2);
			this.label170.TabIndex = 0x143;
			this.label171.BackColor = Color.White;
			this.label171.Location = new Point(51, 0x12e);
			this.label171.Name = "label171";
			this.label171.Size = new System.Drawing.Size(2, 2);
			this.label171.TabIndex = 0x142;
			this.label172.BackColor = Color.White;
			this.label172.Location = new Point(43, 0x12e);
			this.label172.Name = "label172";
			this.label172.Size = new System.Drawing.Size(2, 2);
			this.label172.TabIndex = 0x141;
			this.label173.BackColor = Color.Black;
			this.label173.Image = (Image)resources.GetObject("label173.Image");
			this.label173.Location = new Point(31, 0x12a);
			this.label173.Name = "label173";
			this.label173.Size = new System.Drawing.Size(10, 10);
			this.label173.TabIndex = 0x140;
			this.label174.BackColor = Color.White;
			this.label174.Location = new Point(0x112, 230);
			this.label174.Name = "label174";
			this.label174.Size = new System.Drawing.Size(2, 2);
			this.label174.TabIndex = 0x14d;
			this.label175.BackColor = Color.White;
			this.label175.Location = new Point(0x112, 248);
			this.label175.Name = "label175";
			this.label175.Size = new System.Drawing.Size(2, 2);
			this.label175.TabIndex = 0x14c;
			this.label176.BackColor = Color.White;
			this.label176.Location = new Point(0x112, 239);
			this.label176.Name = "label176";
			this.label176.Size = new System.Drawing.Size(2, 2);
			this.label176.TabIndex = 0x14b;
			this.label177.BackColor = Color.White;
			this.label177.Location = new Point(0x112, 0x101);
			this.label177.Name = "label177";
			this.label177.Size = new System.Drawing.Size(2, 2);
			this.label177.TabIndex = 0x14a;
			this.label178.BackColor = Color.White;
			this.label178.Location = new Point(0x112, 212);
			this.label178.Name = "label178";
			this.label178.Size = new System.Drawing.Size(2, 2);
			this.label178.TabIndex = 0x149;
			this.label179.BackColor = Color.White;
			this.label179.Location = new Point(0x112, 203);
			this.label179.Name = "label179";
			this.label179.Size = new System.Drawing.Size(2, 2);
			this.label179.TabIndex = 0x148;
			this.label180.BackColor = Color.White;
			this.label180.Location = new Point(0x112, 194);
			this.label180.Name = "label180";
			this.label180.Size = new System.Drawing.Size(2, 2);
			this.label180.TabIndex = 0x147;
			this.label181.BackColor = Color.White;
			this.label181.Location = new Point(0x112, 221);
			this.label181.Name = "label181";
			this.label181.Size = new System.Drawing.Size(2, 2);
			this.label181.TabIndex = 0x146;
			this.label182.BackColor = Color.White;
			this.label182.Location = new Point(0x112, 185);
			this.label182.Name = "label182";
			this.label182.Size = new System.Drawing.Size(2, 2);
			this.label182.TabIndex = 0x145;
			this.label183.BackColor = Color.White;
			this.label183.Location = new Point(0x112, 149);
			this.label183.Name = "label183";
			this.label183.Size = new System.Drawing.Size(2, 2);
			this.label183.TabIndex = 0x156;
			this.label184.BackColor = Color.White;
			this.label184.Location = new Point(0x112, 167);
			this.label184.Name = "label184";
			this.label184.Size = new System.Drawing.Size(2, 2);
			this.label184.TabIndex = 0x155;
			this.label185.BackColor = Color.White;
			this.label185.Location = new Point(0x112, 158);
			this.label185.Name = "label185";
			this.label185.Size = new System.Drawing.Size(2, 2);
			this.label185.TabIndex = 0x154;
			this.label186.BackColor = Color.White;
			this.label186.Location = new Point(0x112, 176);
			this.label186.Name = "label186";
			this.label186.Size = new System.Drawing.Size(2, 2);
			this.label186.TabIndex = 0x153;
			this.label187.BackColor = Color.White;
			this.label187.Location = new Point(0x112, 131);
			this.label187.Name = "label187";
			this.label187.Size = new System.Drawing.Size(2, 2);
			this.label187.TabIndex = 0x152;
			this.label188.BackColor = Color.White;
			this.label188.Location = new Point(0x112, 122);
			this.label188.Name = "label188";
			this.label188.Size = new System.Drawing.Size(2, 2);
			this.label188.TabIndex = 0x151;
			this.label189.BackColor = Color.White;
			this.label189.Location = new Point(0x112, 113);
			this.label189.Name = "label189";
			this.label189.Size = new System.Drawing.Size(2, 2);
			this.label189.TabIndex = 0x150;
			this.label190.BackColor = Color.White;
			this.label190.Location = new Point(0x112, 140);
			this.label190.Name = "label190";
			this.label190.Size = new System.Drawing.Size(2, 2);
			this.label190.TabIndex = 0x14f;
			this.label191.BackColor = Color.White;
			this.label191.Location = new Point(0x112, 104);
			this.label191.Name = "label191";
			this.label191.Size = new System.Drawing.Size(2, 2);
			this.label191.TabIndex = 0x14e;
			this.label192.BackColor = Color.White;
			this.label192.Location = new Point(0x112, 66);
			this.label192.Name = "label192";
			this.label192.Size = new System.Drawing.Size(2, 2);
			this.label192.TabIndex = 0x15f;
			this.label193.BackColor = Color.White;
			this.label193.Location = new Point(0x112, 85);
			this.label193.Name = "label193";
			this.label193.Size = new System.Drawing.Size(2, 2);
			this.label193.TabIndex = 0x15e;
			this.label194.BackColor = Color.White;
			this.label194.Location = new Point(0x112, 76);
			this.label194.Name = "label194";
			this.label194.Size = new System.Drawing.Size(2, 2);
			this.label194.TabIndex = 0x15d;
			this.label195.BackColor = Color.White;
			this.label195.Location = new Point(0x112, 94);
			this.label195.Name = "label195";
			this.label195.Size = new System.Drawing.Size(2, 2);
			this.label195.TabIndex = 0x15c;
			this.label196.BackColor = Color.White;
			this.label196.Location = new Point(0x112, 47);
			this.label196.Name = "label196";
			this.label196.Size = new System.Drawing.Size(2, 2);
			this.label196.TabIndex = 0x15b;
			this.label199.BackColor = Color.White;
			this.label199.Location = new Point(0x112, 57);
			this.label199.Name = "label199";
			this.label199.Size = new System.Drawing.Size(2, 2);
			this.label199.TabIndex = 0x158;
			this.label198.BackColor = Color.White;
			this.label198.Location = new Point(0x14e, 38);
			this.label198.Name = "label198";
			this.label198.Size = new System.Drawing.Size(2, 2);
			this.label198.TabIndex = 0x16f;
			this.label200.BackColor = Color.White;
			this.label200.Location = new Point(0x146, 38);
			this.label200.Name = "label200";
			this.label200.Size = new System.Drawing.Size(2, 2);
			this.label200.TabIndex = 0x16e;
			this.label201.BackColor = Color.White;
			this.label201.Location = new Point(247, 38);
			this.label201.Name = "label201";
			this.label201.Size = new System.Drawing.Size(2, 2);
			this.label201.TabIndex = 0x16d;
			this.label202.BackColor = Color.White;
			this.label202.Location = new Point(238, 38);
			this.label202.Name = "label202";
			this.label202.Size = new System.Drawing.Size(2, 2);
			this.label202.TabIndex = 0x16c;
			this.label203.BackColor = Color.White;
			this.label203.Location = new Point(229, 38);
			this.label203.Name = "label203";
			this.label203.Size = new System.Drawing.Size(2, 2);
			this.label203.TabIndex = 0x16b;
			this.label204.BackColor = Color.White;
			this.label204.Location = new Point(220, 38);
			this.label204.Name = "label204";
			this.label204.Size = new System.Drawing.Size(2, 2);
			this.label204.TabIndex = 0x16a;
			this.label205.BackColor = Color.White;
			this.label205.Location = new Point(211, 38);
			this.label205.Name = "label205";
			this.label205.Size = new System.Drawing.Size(2, 2);
			this.label205.TabIndex = 0x169;
			this.label206.BackColor = Color.White;
			this.label206.Location = new Point(202, 38);
			this.label206.Name = "label206";
			this.label206.Size = new System.Drawing.Size(2, 2);
			this.label206.TabIndex = 0x168;
			this.label207.BackColor = Color.White;
			this.label207.Location = new Point(0x13e, 38);
			this.label207.Name = "label207";
			this.label207.Size = new System.Drawing.Size(2, 2);
			this.label207.TabIndex = 0x167;
			this.label208.BackColor = Color.White;
			this.label208.Location = new Point(0x136, 38);
			this.label208.Name = "label208";
			this.label208.Size = new System.Drawing.Size(2, 2);
			this.label208.TabIndex = 0x166;
			this.label209.BackColor = Color.White;
			this.label209.Location = new Point(0x12d, 38);
			this.label209.Name = "label209";
			this.label209.Size = new System.Drawing.Size(2, 2);
			this.label209.TabIndex = 0x165;
			this.label210.BackColor = Color.White;
			this.label210.Location = new Point(0x124, 38);
			this.label210.Name = "label210";
			this.label210.Size = new System.Drawing.Size(2, 2);
			this.label210.TabIndex = 0x164;
			this.label211.BackColor = Color.White;
			this.label211.Location = new Point(0x11b, 38);
			this.label211.Name = "label211";
			this.label211.Size = new System.Drawing.Size(2, 2);
			this.label211.TabIndex = 0x163;
			this.label212.BackColor = Color.White;
			this.label212.Location = new Point(0x112, 38);
			this.label212.Name = "label212";
			this.label212.Size = new System.Drawing.Size(2, 2);
			this.label212.TabIndex = 0x162;
			this.label213.BackColor = Color.White;
			this.label213.Location = new Point(0x109, 38);
			this.label213.Name = "label213";
			this.label213.Size = new System.Drawing.Size(2, 2);
			this.label213.TabIndex = 0x161;
			this.label214.BackColor = Color.White;
			this.label214.Location = new Point(0x100, 38);
			this.label214.Name = "label214";
			this.label214.Size = new System.Drawing.Size(2, 2);
			this.label214.TabIndex = 0x160;
			this.label197.BackColor = Color.White;
			this.label197.Location = new Point(0x14e, 94);
			this.label197.Name = "label197";
			this.label197.Size = new System.Drawing.Size(2, 2);
			this.label197.TabIndex = 0x178;
			this.label215.BackColor = Color.White;
			this.label215.Location = new Point(0x14e, 113);
			this.label215.Name = "label215";
			this.label215.Size = new System.Drawing.Size(2, 2);
			this.label215.TabIndex = 0x177;
			this.label216.BackColor = Color.White;
			this.label216.Location = new Point(0x14e, 104);
			this.label216.Name = "label216";
			this.label216.Size = new System.Drawing.Size(2, 2);
			this.label216.TabIndex = 0x176;
			this.label217.BackColor = Color.White;
			this.label217.Location = new Point(0x14e, 122);
			this.label217.Name = "label217";
			this.label217.Size = new System.Drawing.Size(2, 2);
			this.label217.TabIndex = 0x175;
			this.label218.BackColor = Color.White;
			this.label218.Location = new Point(0x14e, 76);
			this.label218.Name = "label218";
			this.label218.Size = new System.Drawing.Size(2, 2);
			this.label218.TabIndex = 0x174;
			this.label219.BackColor = Color.White;
			this.label219.Location = new Point(0x14e, 67);
			this.label219.Name = "label219";
			this.label219.Size = new System.Drawing.Size(2, 2);
			this.label219.TabIndex = 0x173;
			this.label220.BackColor = Color.Black;
			this.label220.Image = (Image)resources.GetObject("label220.Image");
			this.label220.Location = new Point(0x14a, 54);
			this.label220.Name = "label220";
			this.label220.Size = new System.Drawing.Size(10, 10);
			this.label220.TabIndex = 0x172;
			this.label221.BackColor = Color.White;
			this.label221.Location = new Point(0x14e, 85);
			this.label221.Name = "label221";
			this.label221.Size = new System.Drawing.Size(2, 2);
			this.label221.TabIndex = 0x171;
			this.label222.BackColor = Color.White;
			this.label222.Location = new Point(0x14e, 48);
			this.label222.Name = "label222";
			this.label222.Size = new System.Drawing.Size(2, 2);
			this.label222.TabIndex = 0x170;
			this.label223.BackColor = Color.White;
			this.label223.Location = new Point(0x146, 85);
			this.label223.Name = "label223";
			this.label223.Size = new System.Drawing.Size(2, 2);
			this.label223.TabIndex = 0x17e;
			this.label224.BackColor = Color.White;
			this.label224.Location = new Point(0x13e, 85);
			this.label224.Name = "label224";
			this.label224.Size = new System.Drawing.Size(2, 2);
			this.label224.TabIndex = 0x17d;
			this.label225.BackColor = Color.White;
			this.label225.Location = new Point(0x136, 85);
			this.label225.Name = "label225";
			this.label225.Size = new System.Drawing.Size(2, 2);
			this.label225.TabIndex = 0x17c;
			this.label226.BackColor = Color.White;
			this.label226.Location = new Point(0x12d, 85);
			this.label226.Name = "label226";
			this.label226.Size = new System.Drawing.Size(2, 2);
			this.label226.TabIndex = 0x17b;
			this.label227.BackColor = Color.White;
			this.label227.Location = new Point(0x124, 85);
			this.label227.Name = "label227";
			this.label227.Size = new System.Drawing.Size(2, 2);
			this.label227.TabIndex = 0x17a;
			this.label228.BackColor = Color.White;
			this.label228.Location = new Point(0x11b, 85);
			this.label228.Name = "label228";
			this.label228.Size = new System.Drawing.Size(2, 2);
			this.label228.TabIndex = 0x179;
			this.label229.BackColor = Color.White;
			this.label229.Location = new Point(0x146, 122);
			this.label229.Name = "label229";
			this.label229.Size = new System.Drawing.Size(2, 2);
			this.label229.TabIndex = 0x184;
			this.label230.BackColor = Color.White;
			this.label230.Location = new Point(0x13e, 122);
			this.label230.Name = "label230";
			this.label230.Size = new System.Drawing.Size(2, 2);
			this.label230.TabIndex = 0x183;
			this.label231.BackColor = Color.White;
			this.label231.Location = new Point(0x136, 122);
			this.label231.Name = "label231";
			this.label231.Size = new System.Drawing.Size(2, 2);
			this.label231.TabIndex = 0x182;
			this.label232.BackColor = Color.White;
			this.label232.Location = new Point(0x12d, 122);
			this.label232.Name = "label232";
			this.label232.Size = new System.Drawing.Size(2, 2);
			this.label232.TabIndex = 0x181;
			this.label233.BackColor = Color.White;
			this.label233.Location = new Point(0x124, 122);
			this.label233.Name = "label233";
			this.label233.Size = new System.Drawing.Size(2, 2);
			this.label233.TabIndex = 0x180;
			this.label234.BackColor = Color.White;
			this.label234.Location = new Point(0x11b, 122);
			this.label234.Name = "label234";
			this.label234.Size = new System.Drawing.Size(2, 2);
			this.label234.TabIndex = 0x17f;
			this.label235.BackColor = Color.White;
			this.label235.Location = new Point(247, 85);
			this.label235.Name = "label235";
			this.label235.Size = new System.Drawing.Size(2, 2);
			this.label235.TabIndex = 0x18c;
			this.label236.BackColor = Color.White;
			this.label236.Location = new Point(238, 85);
			this.label236.Name = "label236";
			this.label236.Size = new System.Drawing.Size(2, 2);
			this.label236.TabIndex = 0x18b;
			this.label237.BackColor = Color.White;
			this.label237.Location = new Point(229, 85);
			this.label237.Name = "label237";
			this.label237.Size = new System.Drawing.Size(2, 2);
			this.label237.TabIndex = 0x18a;
			this.label238.BackColor = Color.White;
			this.label238.Location = new Point(220, 85);
			this.label238.Name = "label238";
			this.label238.Size = new System.Drawing.Size(2, 2);
			this.label238.TabIndex = 0x189;
			this.label239.BackColor = Color.White;
			this.label239.Location = new Point(211, 85);
			this.label239.Name = "label239";
			this.label239.Size = new System.Drawing.Size(2, 2);
			this.label239.TabIndex = 0x188;
			this.label240.BackColor = Color.White;
			this.label240.Location = new Point(202, 85);
			this.label240.Name = "label240";
			this.label240.Size = new System.Drawing.Size(2, 2);
			this.label240.TabIndex = 0x187;
			this.label241.BackColor = Color.White;
			this.label241.Location = new Point(0x109, 85);
			this.label241.Name = "label241";
			this.label241.Size = new System.Drawing.Size(2, 2);
			this.label241.TabIndex = 0x186;
			this.label242.BackColor = Color.White;
			this.label242.Location = new Point(0x100, 85);
			this.label242.Name = "label242";
			this.label242.Size = new System.Drawing.Size(2, 2);
			this.label242.TabIndex = 0x185;
			this.label243.BackColor = Color.White;
			this.label243.Location = new Point(202, 66);
			this.label243.Name = "label243";
			this.label243.Size = new System.Drawing.Size(2, 2);
			this.label243.TabIndex = 0x190;
			this.label244.BackColor = Color.White;
			this.label244.Location = new Point(202, 76);
			this.label244.Name = "label244";
			this.label244.Size = new System.Drawing.Size(2, 2);
			this.label244.TabIndex = 0x18f;
			this.label245.BackColor = Color.White;
			this.label245.Location = new Point(202, 47);
			this.label245.Name = "label245";
			this.label245.Size = new System.Drawing.Size(2, 2);
			this.label245.TabIndex = 0x18e;
			this.label246.BackColor = Color.White;
			this.label246.Location = new Point(202, 57);
			this.label246.Name = "label246";
			this.label246.Size = new System.Drawing.Size(2, 2);
			this.label246.TabIndex = 0x18d;
			this.label247.BackColor = Color.White;
			this.label247.Location = new Point(129, 94);
			this.label247.Name = "label247";
			this.label247.Size = new System.Drawing.Size(2, 2);
			this.label247.TabIndex = 0x1a3;
			this.label248.BackColor = Color.White;
			this.label248.Location = new Point(129, 112);
			this.label248.Name = "label248";
			this.label248.Size = new System.Drawing.Size(2, 2);
			this.label248.TabIndex = 0x1a2;
			this.label249.BackColor = Color.White;
			this.label249.Location = new Point(129, 103);
			this.label249.Name = "label249";
			this.label249.Size = new System.Drawing.Size(2, 2);
			this.label249.TabIndex = 0x1a1;
			this.label250.BackColor = Color.White;
			this.label250.Location = new Point(238, 94);
			this.label250.Name = "label250";
			this.label250.Size = new System.Drawing.Size(2, 2);
			this.label250.TabIndex = 0x1a0;
			this.label251.BackColor = Color.White;
			this.label251.Location = new Point(238, 112);
			this.label251.Name = "label251";
			this.label251.Size = new System.Drawing.Size(2, 2);
			this.label251.TabIndex = 0x19f;
			this.label252.BackColor = Color.White;
			this.label252.Location = new Point(238, 103);
			this.label252.Name = "label252";
			this.label252.Size = new System.Drawing.Size(2, 2);
			this.label252.TabIndex = 0x19e;
			this.label256.BackColor = Color.White;
			this.label256.Location = new Point(202, 122);
			this.label256.Name = "label256";
			this.label256.Size = new System.Drawing.Size(2, 2);
			this.label256.TabIndex = 0x19a;
			this.label257.BackColor = Color.White;
			this.label257.Location = new Point(238, 122);
			this.label257.Name = "label257";
			this.label257.Size = new System.Drawing.Size(2, 2);
			this.label257.TabIndex = 0x199;
			this.label258.BackColor = Color.White;
			this.label258.Location = new Point(229, 122);
			this.label258.Name = "label258";
			this.label258.Size = new System.Drawing.Size(2, 2);
			this.label258.TabIndex = 0x198;
			this.label259.BackColor = Color.White;
			this.label259.Location = new Point(220, 122);
			this.label259.Name = "label259";
			this.label259.Size = new System.Drawing.Size(2, 2);
			this.label259.TabIndex = 0x197;
			this.label260.BackColor = Color.White;
			this.label260.Location = new Point(211, 122);
			this.label260.Name = "label260";
			this.label260.Size = new System.Drawing.Size(2, 2);
			this.label260.TabIndex = 0x196;
			this.label261.BackColor = Color.White;
			this.label261.Location = new Point(165, 122);
			this.label261.Name = "label261";
			this.label261.Size = new System.Drawing.Size(2, 2);
			this.label261.TabIndex = 0x195;
			this.label262.BackColor = Color.White;
			this.label262.Location = new Point(156, 122);
			this.label262.Name = "label262";
			this.label262.Size = new System.Drawing.Size(2, 2);
			this.label262.TabIndex = 0x194;
			this.label263.BackColor = Color.White;
			this.label263.Location = new Point(147, 122);
			this.label263.Name = "label263";
			this.label263.Size = new System.Drawing.Size(2, 2);
			this.label263.TabIndex = 0x193;
			this.label264.BackColor = Color.White;
			this.label264.Location = new Point(138, 122);
			this.label264.Name = "label264";
			this.label264.Size = new System.Drawing.Size(2, 2);
			this.label264.TabIndex = 0x192;
			this.label265.BackColor = Color.White;
			this.label265.Location = new Point(129, 122);
			this.label265.Name = "label265";
			this.label265.Size = new System.Drawing.Size(2, 2);
			this.label265.TabIndex = 0x191;
			this.label272.BackColor = Color.White;
			this.label272.Location = new Point(192, 85);
			this.label272.Name = "label272";
			this.label272.Size = new System.Drawing.Size(2, 2);
			this.label272.TabIndex = 0x1b0;
			this.label273.BackColor = Color.White;
			this.label273.Location = new Point(183, 85);
			this.label273.Name = "label273";
			this.label273.Size = new System.Drawing.Size(2, 2);
			this.label273.TabIndex = 0x1af;
			this.label274.BackColor = Color.White;
			this.label274.Location = new Point(174, 85);
			this.label274.Name = "label274";
			this.label274.Size = new System.Drawing.Size(2, 2);
			this.label274.TabIndex = 0x1ae;
			this.label280.BackColor = Color.White;
			this.label280.Location = new Point(165, 85);
			this.label280.Name = "label280";
			this.label280.Size = new System.Drawing.Size(2, 2);
			this.label280.TabIndex = 0x1a8;
			this.label281.BackColor = Color.White;
			this.label281.Location = new Point(156, 85);
			this.label281.Name = "label281";
			this.label281.Size = new System.Drawing.Size(2, 2);
			this.label281.TabIndex = 0x1a7;
			this.label282.BackColor = Color.White;
			this.label282.Location = new Point(147, 85);
			this.label282.Name = "label282";
			this.label282.Size = new System.Drawing.Size(2, 2);
			this.label282.TabIndex = 0x1a6;
			this.label283.BackColor = Color.White;
			this.label283.Location = new Point(138, 85);
			this.label283.Name = "label283";
			this.label283.Size = new System.Drawing.Size(2, 2);
			this.label283.TabIndex = 0x1a5;
			this.label284.BackColor = Color.White;
			this.label284.Location = new Point(129, 85);
			this.label284.Name = "label284";
			this.label284.Size = new System.Drawing.Size(2, 2);
			this.label284.TabIndex = 0x1a4;
			this.label266.BackColor = Color.White;
			this.label266.Location = new Point(94, 66);
			this.label266.Name = "label266";
			this.label266.Size = new System.Drawing.Size(2, 2);
			this.label266.TabIndex = 0x1c1;
			this.label267.BackColor = Color.White;
			this.label267.Location = new Point(94, 76);
			this.label267.Name = "label267";
			this.label267.Size = new System.Drawing.Size(2, 2);
			this.label267.TabIndex = 0x1c0;
			this.label268.BackColor = Color.White;
			this.label268.Location = new Point(94, 47);
			this.label268.Name = "label268";
			this.label268.Size = new System.Drawing.Size(2, 2);
			this.label268.TabIndex = 0x1bf;
			this.label269.BackColor = Color.White;
			this.label269.Location = new Point(94, 57);
			this.label269.Name = "label269";
			this.label269.Size = new System.Drawing.Size(2, 2);
			this.label269.TabIndex = 0x1be;
			this.label270.BackColor = Color.White;
			this.label270.Location = new Point(138, 38);
			this.label270.Name = "label270";
			this.label270.Size = new System.Drawing.Size(2, 2);
			this.label270.TabIndex = 0x1bd;
			this.label271.BackColor = Color.White;
			this.label271.Location = new Point(129, 38);
			this.label271.Name = "label271";
			this.label271.Size = new System.Drawing.Size(2, 2);
			this.label271.TabIndex = 0x1bc;
			this.label275.BackColor = Color.White;
			this.label275.Location = new Point(120, 38);
			this.label275.Name = "label275";
			this.label275.Size = new System.Drawing.Size(2, 2);
			this.label275.TabIndex = 0x1bb;
			this.label276.BackColor = Color.White;
			this.label276.Location = new Point(111, 38);
			this.label276.Name = "label276";
			this.label276.Size = new System.Drawing.Size(2, 2);
			this.label276.TabIndex = 0x1ba;
			this.label277.BackColor = Color.White;
			this.label277.Location = new Point(102, 38);
			this.label277.Name = "label277";
			this.label277.Size = new System.Drawing.Size(2, 2);
			this.label277.TabIndex = 0x1b9;
			this.label278.BackColor = Color.White;
			this.label278.Location = new Point(94, 38);
			this.label278.Name = "label278";
			this.label278.Size = new System.Drawing.Size(2, 2);
			this.label278.TabIndex = 0x1b8;
			this.label279.BackColor = Color.White;
			this.label279.Location = new Point(165, 38);
			this.label279.Name = "label279";
			this.label279.Size = new System.Drawing.Size(2, 2);
			this.label279.TabIndex = 0x1b7;
			this.label285.BackColor = Color.White;
			this.label285.Location = new Point(156, 38);
			this.label285.Name = "label285";
			this.label285.Size = new System.Drawing.Size(2, 2);
			this.label285.TabIndex = 0x1b6;
			this.label286.BackColor = Color.White;
			this.label286.Location = new Point(147, 38);
			this.label286.Name = "label286";
			this.label286.Size = new System.Drawing.Size(2, 2);
			this.label286.TabIndex = 0x1b5;
			this.label287.BackColor = Color.White;
			this.label287.Location = new Point(165, 66);
			this.label287.Name = "label287";
			this.label287.Size = new System.Drawing.Size(2, 2);
			this.label287.TabIndex = 0x1b4;
			this.label288.BackColor = Color.White;
			this.label288.Location = new Point(165, 76);
			this.label288.Name = "label288";
			this.label288.Size = new System.Drawing.Size(2, 2);
			this.label288.TabIndex = 0x1b3;
			this.label289.BackColor = Color.White;
			this.label289.Location = new Point(165, 47);
			this.label289.Name = "label289";
			this.label289.Size = new System.Drawing.Size(2, 2);
			this.label289.TabIndex = 0x1b2;
			this.label290.BackColor = Color.White;
			this.label290.Location = new Point(165, 57);
			this.label290.Name = "label290";
			this.label290.Size = new System.Drawing.Size(2, 2);
			this.label290.TabIndex = 0x1b1;
			this.label293.BackColor = Color.White;
			this.label293.Location = new Point(49, 85);
			this.label293.Name = "label293";
			this.label293.Size = new System.Drawing.Size(2, 2);
			this.label293.TabIndex = 0x1cb;
			this.label294.BackColor = Color.White;
			this.label294.Location = new Point(40, 85);
			this.label294.Name = "label294";
			this.label294.Size = new System.Drawing.Size(2, 2);
			this.label294.TabIndex = 0x1ca;
			this.label295.BackColor = Color.White;
			this.label295.Location = new Point(111, 85);
			this.label295.Name = "label295";
			this.label295.Size = new System.Drawing.Size(2, 2);
			this.label295.TabIndex = 0x1c9;
			this.label296.BackColor = Color.White;
			this.label296.Location = new Point(103, 85);
			this.label296.Name = "label296";
			this.label296.Size = new System.Drawing.Size(2, 2);
			this.label296.TabIndex = 0x1c8;
			this.label297.BackColor = Color.White;
			this.label297.Location = new Point(94, 85);
			this.label297.Name = "label297";
			this.label297.Size = new System.Drawing.Size(2, 2);
			this.label297.TabIndex = 0x1c7;
			this.label298.BackColor = Color.White;
			this.label298.Location = new Point(85, 85);
			this.label298.Name = "label298";
			this.label298.Size = new System.Drawing.Size(2, 2);
			this.label298.TabIndex = 0x1c6;
			this.label299.BackColor = Color.White;
			this.label299.Location = new Point(76, 85);
			this.label299.Name = "label299";
			this.label299.Size = new System.Drawing.Size(2, 2);
			this.label299.TabIndex = 0x1c5;
			this.label300.BackColor = Color.White;
			this.label300.Location = new Point(67, 85);
			this.label300.Name = "label300";
			this.label300.Size = new System.Drawing.Size(2, 2);
			this.label300.TabIndex = 0x1c4;
			this.label301.BackColor = Color.White;
			this.label301.Location = new Point(120, 85);
			this.label301.Name = "label301";
			this.label301.Size = new System.Drawing.Size(2, 2);
			this.label301.TabIndex = 0x1c3;
			this.label302.BackColor = Color.White;
			this.label302.Location = new Point(58, 85);
			this.label302.Name = "label302";
			this.label302.Size = new System.Drawing.Size(2, 2);
			this.label302.TabIndex = 0x1c2;
			this.label291.BackColor = Color.White;
			this.label291.Location = new Point(32, 94);
			this.label291.Name = "label291";
			this.label291.Size = new System.Drawing.Size(2, 2);
			this.label291.TabIndex = 0x1d5;
			this.label292.BackColor = Color.White;
			this.label292.Location = new Point(32, 113);
			this.label292.Name = "label292";
			this.label292.Size = new System.Drawing.Size(2, 2);
			this.label292.TabIndex = 0x1d4;
			this.label303.BackColor = Color.White;
			this.label303.Location = new Point(32, 104);
			this.label303.Name = "label303";
			this.label303.Size = new System.Drawing.Size(2, 2);
			this.label303.TabIndex = 0x1d3;
			this.label304.BackColor = Color.White;
			this.label304.Location = new Point(32, 122);
			this.label304.Name = "label304";
			this.label304.Size = new System.Drawing.Size(2, 2);
			this.label304.TabIndex = 0x1d2;
			this.label305.BackColor = Color.White;
			this.label305.Location = new Point(32, 76);
			this.label305.Name = "label305";
			this.label305.Size = new System.Drawing.Size(2, 2);
			this.label305.TabIndex = 0x1d1;
			this.label306.BackColor = Color.White;
			this.label306.Location = new Point(32, 67);
			this.label306.Name = "label306";
			this.label306.Size = new System.Drawing.Size(2, 2);
			this.label306.TabIndex = 0x1d0;
			this.label307.BackColor = Color.Black;
			this.label307.Image = (Image)resources.GetObject("label307.Image");
			this.label307.Location = new Point(28, 54);
			this.label307.Name = "label307";
			this.label307.Size = new System.Drawing.Size(10, 10);
			this.label307.TabIndex = 0x1cf;
			this.label308.BackColor = Color.White;
			this.label308.Location = new Point(32, 85);
			this.label308.Name = "label308";
			this.label308.Size = new System.Drawing.Size(2, 2);
			this.label308.TabIndex = 0x1ce;
			this.label309.BackColor = Color.White;
			this.label309.Location = new Point(32, 48);
			this.label309.Name = "label309";
			this.label309.Size = new System.Drawing.Size(2, 2);
			this.label309.TabIndex = 0x1cd;
			this.label310.BackColor = Color.White;
			this.label310.Location = new Point(32, 38);
			this.label310.Name = "label310";
			this.label310.Size = new System.Drawing.Size(2, 2);
			this.label310.TabIndex = 0x1cc;
			this.label311.BackColor = Color.White;
			this.label311.Location = new Point(85, 38);
			this.label311.Name = "label311";
			this.label311.Size = new System.Drawing.Size(2, 2);
			this.label311.TabIndex = 0x1db;
			this.label312.BackColor = Color.White;
			this.label312.Location = new Point(77, 38);
			this.label312.Name = "label312";
			this.label312.Size = new System.Drawing.Size(2, 2);
			this.label312.TabIndex = 0x1da;
			this.label313.BackColor = Color.White;
			this.label313.Location = new Point(68, 38);
			this.label313.Name = "label313";
			this.label313.Size = new System.Drawing.Size(2, 2);
			this.label313.TabIndex = 0x1d9;
			this.label314.BackColor = Color.White;
			this.label314.Location = new Point(59, 38);
			this.label314.Name = "label314";
			this.label314.Size = new System.Drawing.Size(2, 2);
			this.label314.TabIndex = 0x1d8;
			this.label315.BackColor = Color.White;
			this.label315.Location = new Point(50, 38);
			this.label315.Name = "label315";
			this.label315.Size = new System.Drawing.Size(2, 2);
			this.label315.TabIndex = 0x1d7;
			this.label316.BackColor = Color.White;
			this.label316.Location = new Point(41, 38);
			this.label316.Name = "label316";
			this.label316.Size = new System.Drawing.Size(2, 2);
			this.label316.TabIndex = 0x1d6;
			this.label317.BackColor = Color.White;
			this.label317.Location = new Point(85, 122);
			this.label317.Name = "label317";
			this.label317.Size = new System.Drawing.Size(2, 2);
			this.label317.TabIndex = 0x1e2;
			this.label318.BackColor = Color.White;
			this.label318.Location = new Point(76, 122);
			this.label318.Name = "label318";
			this.label318.Size = new System.Drawing.Size(2, 2);
			this.label318.TabIndex = 0x1e1;
			this.label319.BackColor = Color.White;
			this.label319.Location = new Point(67, 122);
			this.label319.Name = "label319";
			this.label319.Size = new System.Drawing.Size(2, 2);
			this.label319.TabIndex = 0x1e0;
			this.label320.BackColor = Color.White;
			this.label320.Location = new Point(58, 122);
			this.label320.Name = "label320";
			this.label320.Size = new System.Drawing.Size(2, 2);
			this.label320.TabIndex = 0x1df;
			this.label321.BackColor = Color.White;
			this.label321.Location = new Point(49, 122);
			this.label321.Name = "label321";
			this.label321.Size = new System.Drawing.Size(2, 2);
			this.label321.TabIndex = 0x1de;
			this.label322.BackColor = Color.White;
			this.label322.Location = new Point(40, 122);
			this.label322.Name = "label322";
			this.label322.Size = new System.Drawing.Size(2, 2);
			this.label322.TabIndex = 0x1dd;
			this.label323.BackColor = Color.White;
			this.label323.Location = new Point(94, 122);
			this.label323.Name = "label323";
			this.label323.Size = new System.Drawing.Size(2, 2);
			this.label323.TabIndex = 0x1dc;
			this.label324.BackColor = Color.White;
			this.label324.Location = new Point(94, 103);
			this.label324.Name = "label324";
			this.label324.Size = new System.Drawing.Size(2, 2);
			this.label324.TabIndex = 0x1e6;
			this.label325.BackColor = Color.White;
			this.label325.Location = new Point(94, 113);
			this.label325.Name = "label325";
			this.label325.Size = new System.Drawing.Size(2, 2);
			this.label325.TabIndex = 0x1e5;
			this.label327.BackColor = Color.White;
			this.label327.Location = new Point(94, 94);
			this.label327.Name = "label327";
			this.label327.Size = new System.Drawing.Size(2, 2);
			this.label327.TabIndex = 0x1e3;
			this.label326.BackColor = Color.White;
			this.label326.Location = new Point(94, 149);
			this.label326.Name = "label326";
			this.label326.Size = new System.Drawing.Size(2, 2);
			this.label326.TabIndex = 0x1f5;
			this.label328.BackColor = Color.White;
			this.label328.Location = new Point(94, 167);
			this.label328.Name = "label328";
			this.label328.Size = new System.Drawing.Size(2, 2);
			this.label328.TabIndex = 0x1f4;
			this.label329.BackColor = Color.White;
			this.label329.Location = new Point(94, 158);
			this.label329.Name = "label329";
			this.label329.Size = new System.Drawing.Size(2, 2);
			this.label329.TabIndex = 0x1f3;
			this.label330.BackColor = Color.White;
			this.label330.Location = new Point(94, 176);
			this.label330.Name = "label330";
			this.label330.Size = new System.Drawing.Size(2, 2);
			this.label330.TabIndex = 0x1f2;
			this.label331.BackColor = Color.White;
			this.label331.Location = new Point(94, 131);
			this.label331.Name = "label331";
			this.label331.Size = new System.Drawing.Size(2, 2);
			this.label331.TabIndex = 0x1f1;
			this.label332.BackColor = Color.White;
			this.label332.Location = new Point(94, 140);
			this.label332.Name = "label332";
			this.label332.Size = new System.Drawing.Size(2, 2);
			this.label332.TabIndex = 0x1f0;
			this.label333.BackColor = Color.White;
			this.label333.Location = new Point(94, 230);
			this.label333.Name = "label333";
			this.label333.Size = new System.Drawing.Size(2, 2);
			this.label333.TabIndex = 0x1ef;
			this.label334.BackColor = Color.White;
			this.label334.Location = new Point(94, 248);
			this.label334.Name = "label334";
			this.label334.Size = new System.Drawing.Size(2, 2);
			this.label334.TabIndex = 0x1ee;
			this.label335.BackColor = Color.White;
			this.label335.Location = new Point(94, 239);
			this.label335.Name = "label335";
			this.label335.Size = new System.Drawing.Size(2, 2);
			this.label335.TabIndex = 0x1ed;
			this.label336.BackColor = Color.White;
			this.label336.Location = new Point(94, 0x101);
			this.label336.Name = "label336";
			this.label336.Size = new System.Drawing.Size(2, 2);
			this.label336.TabIndex = 0x1ec;
			this.label337.BackColor = Color.White;
			this.label337.Location = new Point(94, 212);
			this.label337.Name = "label337";
			this.label337.Size = new System.Drawing.Size(2, 2);
			this.label337.TabIndex = 0x1eb;
			this.label338.BackColor = Color.White;
			this.label338.Location = new Point(94, 203);
			this.label338.Name = "label338";
			this.label338.Size = new System.Drawing.Size(2, 2);
			this.label338.TabIndex = 0x1ea;
			this.label339.BackColor = Color.White;
			this.label339.Location = new Point(94, 194);
			this.label339.Name = "label339";
			this.label339.Size = new System.Drawing.Size(2, 2);
			this.label339.TabIndex = 0x1e9;
			this.label340.BackColor = Color.White;
			this.label340.Location = new Point(94, 221);
			this.label340.Name = "label340";
			this.label340.Size = new System.Drawing.Size(2, 2);
			this.label340.TabIndex = 0x1e8;
			this.label341.BackColor = Color.White;
			this.label341.Location = new Point(94, 185);
			this.label341.Name = "label341";
			this.label341.Size = new System.Drawing.Size(2, 2);
			this.label341.TabIndex = 0x1e7;
			this.timer8.Interval = 0x2bc;
			this.timer8.Tick += new EventHandler(this.timer8_Tick);
			this.panel1.Controls.Add(this.label254);
			this.panel1.Controls.Add(this.label255);
			this.panel1.Controls.Add(this.label253);
			this.panel1.Controls.Add(this.label142);
			this.panel1.Controls.Add(this.pictureBox5);
			this.panel1.Controls.Add(this.pictureBox4);
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = DockStyle.Fill;
			this.panel1.Location = new Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(0x172, 0x1ae);
			this.panel1.TabIndex = 0x1f6;
			this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
			this.pictureBox5.Image = Resources.bg_name;
			this.pictureBox5.Location = new Point(12, 226);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(0x15c, 171);
			this.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 7;
			this.pictureBox5.TabStop = false;
			this.pictureBox5.Click += new EventHandler(this.pictureBox5_Click);
			this.pictureBox4.Image = Resources.exit;
			this.pictureBox4.Location = new Point(163, 158);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(50, 50);
			this.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 2;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new EventHandler(this.pictureBox4_Click);
			this.pictureBox3.Image = Resources.pacman_bg;
			this.pictureBox3.Location = new Point(12, 18);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(0x15c, 101);
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
			this.button1.Image = Resources.playgame;
			this.button1.Location = new Point(123, 124);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(136, 36);
			this.button1.TabIndex = 0;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Visible = false;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.button1.MouseEnter += new EventHandler(this.button1_MouseEnter);
			this.button1.MouseLeave += new EventHandler(this.button1_MouseLeave);
			this.pacman.BackgroundImageLayout = ImageLayout.None;
			this.pacman.Cursor = Cursors.Default;
			this.pacman.Image = Resources.pacdx;
			this.pacman.Location = new Point(24, 0x16c);
			this.pacman.Name = "pacman";
			this.pacman.Size = new System.Drawing.Size(22, 22);
			this.pacman.TabIndex = 0x1f7;
			this.pacman.TabStop = false;
			this.powermod.Interval = 0x2710;
			this.powermod.Tick += new EventHandler(this.powermod_Tick);
			this.timer7.Interval = 0x9c4;
			this.timer7.Tick += new EventHandler(this.timer7_Tick);
			this.timer9.Enabled = true;
			this.timer9.Interval = 200;
			this.timer9.Tick += new EventHandler(this.timer9_Tick);
			this.ghostmangiato.Interval = 0x1f4;
			this.ghostmangiato.Tick += new EventHandler(this.ghostmangiato_Tick);
			this.label124.BackColor = Color.Black;
			this.label124.Font = new System.Drawing.Font("Segoe UI Black", 10f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label124.ForeColor = Color.White;
			this.label124.Image = Resources.gameover;
			this.label124.Location = new Point(123, 222);
			this.label124.Name = "label124";
			this.label124.Size = new System.Drawing.Size(125, 19);
			this.label124.TabIndex = 0x1f8;
			this.label124.Text = "          ";
			this.label124.TextAlign = ContentAlignment.MiddleRight;
			this.label124.Visible = false;
			this.label141.BackColor = Color.Black;
			this.label141.Font = new System.Drawing.Font("Segoe UI Black", 10f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label141.ForeColor = Color.White;
			this.label141.Image = Resources.gamewin1;
			this.label141.Location = new Point(125, 222);
			this.label141.Name = "label141";
			this.label141.Size = new System.Drawing.Size(125, 19);
			this.label141.TabIndex = 0x1f9;
			this.label141.Text = "          ";
			this.label141.TextAlign = ContentAlignment.MiddleRight;
			this.label141.Visible = false;
			this.powermod1.Interval = 0x1b58;
			this.powermod1.Tick += new EventHandler(this.powermod1_Tick);
			this.attendo.Interval = 0x190;
			this.attendo.Tick += new EventHandler(this.attendo_Tick);
			this.label254.AutoSize = true;
			this.label254.Font = new System.Drawing.Font("News706 BT", 12.25f, FontStyle.Bold);
			this.label254.ForeColor = Color.White;
			this.label254.Location = new Point(128, 0x162);
			this.label254.Name = "label254";
			this.label254.Size = new System.Drawing.Size(122, 20);
			this.label254.TabIndex = 11;
			this.label254.Text = "(15050623024)";
			this.label254.Click += new EventHandler(this.label254_Click_1);
			this.label255.AutoSize = true;
			this.label255.Font = new System.Drawing.Font("News706 BT", 13.25f, FontStyle.Bold);
			this.label255.ForeColor = Color.White;
			this.label255.Location = new Point(97, 0x14b);
			this.label255.Name = "label255";
			this.label255.Size = new System.Drawing.Size(197, 21);
			this.label255.TabIndex = 10;
			this.label255.Text = "Fahmi Rizky Maulidy";
			this.label253.AutoSize = true;
			this.label253.Font = new System.Drawing.Font("News706 BT", 12.25f, FontStyle.Bold);
			this.label253.ForeColor = Color.White;
			this.label253.Location = new Point(126, 0x115);
			this.label253.Name = "label253";
			this.label253.Size = new System.Drawing.Size(122, 20);
			this.label253.TabIndex = 9;
			this.label253.Text = "(15050623021)";
			this.label142.AutoSize = true;
			this.label142.BackColor = Color.Transparent;
			this.label142.Font = new System.Drawing.Font("News706 BT", 12.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label142.ForeColor = SystemColors.Window;
			this.label142.Location = new Point(53, 0xff);
			this.label142.Name = "label142";
			this.label142.Size = new System.Drawing.Size(0x10a, 20);
			this.label142.TabIndex = 8;
			this.label142.Text = "Muhammad Akbar Priambodo ";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.Black;
			this.BackgroundImage = Resources.percorso;
			this.BackgroundImageLayout = ImageLayout.None;
			base.ClientSize = new System.Drawing.Size(0x172, 0x1ae);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.ghost3);
			base.Controls.Add(this.ghost4);
			base.Controls.Add(this.ghost2);
			base.Controls.Add(this.ghost1);
			base.Controls.Add(this.label141);
			base.Controls.Add(this.label124);
			base.Controls.Add(this.pacman);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label326);
			base.Controls.Add(this.label328);
			base.Controls.Add(this.label329);
			base.Controls.Add(this.label330);
			base.Controls.Add(this.label331);
			base.Controls.Add(this.label332);
			base.Controls.Add(this.label333);
			base.Controls.Add(this.label334);
			base.Controls.Add(this.label335);
			base.Controls.Add(this.label336);
			base.Controls.Add(this.label337);
			base.Controls.Add(this.label338);
			base.Controls.Add(this.label339);
			base.Controls.Add(this.label340);
			base.Controls.Add(this.label341);
			base.Controls.Add(this.label324);
			base.Controls.Add(this.label325);
			base.Controls.Add(this.label327);
			base.Controls.Add(this.label317);
			base.Controls.Add(this.label318);
			base.Controls.Add(this.label319);
			base.Controls.Add(this.label320);
			base.Controls.Add(this.label321);
			base.Controls.Add(this.label322);
			base.Controls.Add(this.label323);
			base.Controls.Add(this.label311);
			base.Controls.Add(this.label312);
			base.Controls.Add(this.label313);
			base.Controls.Add(this.label314);
			base.Controls.Add(this.label315);
			base.Controls.Add(this.label316);
			base.Controls.Add(this.label291);
			base.Controls.Add(this.label292);
			base.Controls.Add(this.label303);
			base.Controls.Add(this.label304);
			base.Controls.Add(this.label305);
			base.Controls.Add(this.label306);
			base.Controls.Add(this.label307);
			base.Controls.Add(this.label308);
			base.Controls.Add(this.label309);
			base.Controls.Add(this.label310);
			base.Controls.Add(this.label293);
			base.Controls.Add(this.label294);
			base.Controls.Add(this.label295);
			base.Controls.Add(this.label296);
			base.Controls.Add(this.label297);
			base.Controls.Add(this.label298);
			base.Controls.Add(this.label299);
			base.Controls.Add(this.label300);
			base.Controls.Add(this.label301);
			base.Controls.Add(this.label302);
			base.Controls.Add(this.label266);
			base.Controls.Add(this.label267);
			base.Controls.Add(this.label268);
			base.Controls.Add(this.label269);
			base.Controls.Add(this.label270);
			base.Controls.Add(this.label271);
			base.Controls.Add(this.label275);
			base.Controls.Add(this.label276);
			base.Controls.Add(this.label277);
			base.Controls.Add(this.label278);
			base.Controls.Add(this.label279);
			base.Controls.Add(this.label285);
			base.Controls.Add(this.label286);
			base.Controls.Add(this.label287);
			base.Controls.Add(this.label288);
			base.Controls.Add(this.label289);
			base.Controls.Add(this.label290);
			base.Controls.Add(this.label272);
			base.Controls.Add(this.label273);
			base.Controls.Add(this.label274);
			base.Controls.Add(this.label280);
			base.Controls.Add(this.label281);
			base.Controls.Add(this.label282);
			base.Controls.Add(this.label283);
			base.Controls.Add(this.label284);
			base.Controls.Add(this.label247);
			base.Controls.Add(this.label248);
			base.Controls.Add(this.label249);
			base.Controls.Add(this.label250);
			base.Controls.Add(this.label251);
			base.Controls.Add(this.label252);
			base.Controls.Add(this.label256);
			base.Controls.Add(this.label257);
			base.Controls.Add(this.label258);
			base.Controls.Add(this.label259);
			base.Controls.Add(this.label260);
			base.Controls.Add(this.label261);
			base.Controls.Add(this.label262);
			base.Controls.Add(this.label263);
			base.Controls.Add(this.label264);
			base.Controls.Add(this.label265);
			base.Controls.Add(this.label243);
			base.Controls.Add(this.label244);
			base.Controls.Add(this.label245);
			base.Controls.Add(this.label246);
			base.Controls.Add(this.label235);
			base.Controls.Add(this.label236);
			base.Controls.Add(this.label237);
			base.Controls.Add(this.label238);
			base.Controls.Add(this.label239);
			base.Controls.Add(this.label240);
			base.Controls.Add(this.label241);
			base.Controls.Add(this.label242);
			base.Controls.Add(this.label229);
			base.Controls.Add(this.label230);
			base.Controls.Add(this.label231);
			base.Controls.Add(this.label232);
			base.Controls.Add(this.label233);
			base.Controls.Add(this.label234);
			base.Controls.Add(this.label223);
			base.Controls.Add(this.label224);
			base.Controls.Add(this.label225);
			base.Controls.Add(this.label226);
			base.Controls.Add(this.label227);
			base.Controls.Add(this.label228);
			base.Controls.Add(this.label197);
			base.Controls.Add(this.label215);
			base.Controls.Add(this.label216);
			base.Controls.Add(this.label217);
			base.Controls.Add(this.label218);
			base.Controls.Add(this.label219);
			base.Controls.Add(this.label220);
			base.Controls.Add(this.label221);
			base.Controls.Add(this.label222);
			base.Controls.Add(this.label198);
			base.Controls.Add(this.label200);
			base.Controls.Add(this.label201);
			base.Controls.Add(this.label202);
			base.Controls.Add(this.label203);
			base.Controls.Add(this.label204);
			base.Controls.Add(this.label205);
			base.Controls.Add(this.label206);
			base.Controls.Add(this.label207);
			base.Controls.Add(this.label208);
			base.Controls.Add(this.label209);
			base.Controls.Add(this.label210);
			base.Controls.Add(this.label211);
			base.Controls.Add(this.label212);
			base.Controls.Add(this.label213);
			base.Controls.Add(this.label214);
			base.Controls.Add(this.label192);
			base.Controls.Add(this.label193);
			base.Controls.Add(this.label194);
			base.Controls.Add(this.label195);
			base.Controls.Add(this.label196);
			base.Controls.Add(this.label199);
			base.Controls.Add(this.label183);
			base.Controls.Add(this.label184);
			base.Controls.Add(this.label185);
			base.Controls.Add(this.label186);
			base.Controls.Add(this.label187);
			base.Controls.Add(this.label188);
			base.Controls.Add(this.label189);
			base.Controls.Add(this.label190);
			base.Controls.Add(this.label191);
			base.Controls.Add(this.label174);
			base.Controls.Add(this.label175);
			base.Controls.Add(this.label176);
			base.Controls.Add(this.label177);
			base.Controls.Add(this.label178);
			base.Controls.Add(this.label179);
			base.Controls.Add(this.label180);
			base.Controls.Add(this.label181);
			base.Controls.Add(this.label182);
			base.Controls.Add(this.label170);
			base.Controls.Add(this.label171);
			base.Controls.Add(this.label172);
			base.Controls.Add(this.label173);
			base.Controls.Add(this.label169);
			base.Controls.Add(this.label166);
			base.Controls.Add(this.label167);
			base.Controls.Add(this.label168);
			base.Controls.Add(this.label163);
			base.Controls.Add(this.label164);
			base.Controls.Add(this.label165);
			base.Controls.Add(this.label119);
			base.Controls.Add(this.label120);
			base.Controls.Add(this.label121);
			base.Controls.Add(this.label122);
			base.Controls.Add(this.label123);
			base.Controls.Add(this.label125);
			base.Controls.Add(this.label126);
			base.Controls.Add(this.label127);
			base.Controls.Add(this.label128);
			base.Controls.Add(this.label129);
			base.Controls.Add(this.label130);
			base.Controls.Add(this.label131);
			base.Controls.Add(this.label132);
			base.Controls.Add(this.label133);
			base.Controls.Add(this.label134);
			base.Controls.Add(this.label135);
			base.Controls.Add(this.label136);
			base.Controls.Add(this.label137);
			base.Controls.Add(this.label138);
			base.Controls.Add(this.label139);
			base.Controls.Add(this.label140);
			base.Controls.Add(this.label143);
			base.Controls.Add(this.label144);
			base.Controls.Add(this.label145);
			base.Controls.Add(this.label146);
			base.Controls.Add(this.label147);
			base.Controls.Add(this.label148);
			base.Controls.Add(this.label149);
			base.Controls.Add(this.label150);
			base.Controls.Add(this.label151);
			base.Controls.Add(this.label152);
			base.Controls.Add(this.label153);
			base.Controls.Add(this.label154);
			base.Controls.Add(this.label155);
			base.Controls.Add(this.label156);
			base.Controls.Add(this.label157);
			base.Controls.Add(this.label158);
			base.Controls.Add(this.label159);
			base.Controls.Add(this.label160);
			base.Controls.Add(this.label161);
			base.Controls.Add(this.label162);
			base.Controls.Add(this.label105);
			base.Controls.Add(this.label106);
			base.Controls.Add(this.label107);
			base.Controls.Add(this.label108);
			base.Controls.Add(this.label109);
			base.Controls.Add(this.label110);
			base.Controls.Add(this.label111);
			base.Controls.Add(this.label112);
			base.Controls.Add(this.label113);
			base.Controls.Add(this.label114);
			base.Controls.Add(this.label115);
			base.Controls.Add(this.label116);
			base.Controls.Add(this.label117);
			base.Controls.Add(this.label118);
			base.Controls.Add(this.label103);
			base.Controls.Add(this.label104);
			base.Controls.Add(this.label97);
			base.Controls.Add(this.label99);
			base.Controls.Add(this.label100);
			base.Controls.Add(this.label101);
			base.Controls.Add(this.label102);
			base.Controls.Add(this.label93);
			base.Controls.Add(this.label95);
			base.Controls.Add(this.label96);
			base.Controls.Add(this.label98);
			base.Controls.Add(this.label90);
			base.Controls.Add(this.label91);
			base.Controls.Add(this.label92);
			base.Controls.Add(this.label94);
			base.Controls.Add(this.label86);
			base.Controls.Add(this.label87);
			base.Controls.Add(this.label88);
			base.Controls.Add(this.label89);
			base.Controls.Add(this.label75);
			base.Controls.Add(this.label84);
			base.Controls.Add(this.label85);
			base.Controls.Add(this.label80);
			base.Controls.Add(this.label81);
			base.Controls.Add(this.label82);
			base.Controls.Add(this.label83);
			base.Controls.Add(this.label76);
			base.Controls.Add(this.label77);
			base.Controls.Add(this.label78);
			base.Controls.Add(this.label79);
			base.Controls.Add(this.label71);
			base.Controls.Add(this.label72);
			base.Controls.Add(this.label73);
			base.Controls.Add(this.label74);
			base.Controls.Add(this.label70);
			base.Controls.Add(this.label67);
			base.Controls.Add(this.label68);
			base.Controls.Add(this.label69);
			base.Controls.Add(this.label66);
			base.Controls.Add(this.label64);
			base.Controls.Add(this.label65);
			base.Controls.Add(this.label61);
			base.Controls.Add(this.label62);
			base.Controls.Add(this.label63);
			base.Controls.Add(this.label58);
			base.Controls.Add(this.label59);
			base.Controls.Add(this.label60);
			base.Controls.Add(this.label42);
			base.Controls.Add(this.label48);
			base.Controls.Add(this.label51);
			base.Controls.Add(this.label52);
			base.Controls.Add(this.label53);
			base.Controls.Add(this.label54);
			base.Controls.Add(this.label55);
			base.Controls.Add(this.label56);
			base.Controls.Add(this.label57);
			base.Controls.Add(this.label33);
			base.Controls.Add(this.label34);
			base.Controls.Add(this.label35);
			base.Controls.Add(this.label36);
			base.Controls.Add(this.label37);
			base.Controls.Add(this.label38);
			base.Controls.Add(this.label39);
			base.Controls.Add(this.label40);
			base.Controls.Add(this.label41);
			base.Controls.Add(this.label50);
			base.Controls.Add(this.label49);
			base.Controls.Add(this.label45);
			base.Controls.Add(this.label46);
			base.Controls.Add(this.label47);
			base.Controls.Add(this.label44);
			base.Controls.Add(this.label43);
			base.Controls.Add(this.label32);
			base.Controls.Add(this.label18);
			base.Controls.Add(this.label19);
			base.Controls.Add(this.label20);
			base.Controls.Add(this.label21);
			base.Controls.Add(this.label22);
			base.Controls.Add(this.label23);
			base.Controls.Add(this.label24);
			base.Controls.Add(this.label25);
			base.Controls.Add(this.label26);
			base.Controls.Add(this.label27);
			base.Controls.Add(this.label28);
			base.Controls.Add(this.label29);
			base.Controls.Add(this.label30);
			base.Controls.Add(this.label31);
			base.Controls.Add(this.label12);
			base.Controls.Add(this.label13);
			base.Controls.Add(this.label14);
			base.Controls.Add(this.label15);
			base.Controls.Add(this.label16);
			base.Controls.Add(this.label17);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.label11);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.score);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			this.Cursor = Cursors.Default;
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.ForeColor = Color.Black;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.KeyPreview = true;
			base.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(0x182, 0x1d5);
			base.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(0x182, 0x1d5);
			base.Name = "Form1";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Pac-Man";
			base.TransparencyKey = Color.Fuchsia;
			base.KeyDown += new KeyEventHandler(this.Form1_KeyDown);
			((ISupportInitialize)this.pictureBox2).EndInit();
			((ISupportInitialize)this.pictureBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((ISupportInitialize)this.pictureBox5).EndInit();
			((ISupportInitialize)this.pictureBox4).EndInit();
			((ISupportInitialize)this.pictureBox3).EndInit();
			((ISupportInitialize)this.pacman).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void label142_Click(object sender, EventArgs e)
		{
		}

		private void label254_Click(object sender, EventArgs e)
		{
		}

		private void label254_Click_1(object sender, EventArgs e)
		{
		}

		private void label255_Click(object sender, EventArgs e)
		{
		}

		private void leftright(int i, int y, int n, int m)
		{
			bool flag;
			bool flag1;
			bool flag2;
			bool flag3;
			bool flag4;
			if (this.ghost1turn)
			{
				if ((!this.Supermod1 ? false : !this.ghost1puomangiare))
				{
					if (this.ghost1.Left >= 180 || this.ghost1.Top != 150)
					{
						flag4 = (this.ghost1.Left <= 170 ? false : this.ghost1.Top == 150);
					}
					else
					{
						flag4 = true;
					}
					if (!flag4)
					{
						if (this.ghost1.Top < 150)
						{
							if ((n != 1 ? false : m == 1))
							{
								n = 0;
							}
						}
						if (this.ghost1.Top > 150)
						{
							if ((n != 1 ? false : m == 1))
							{
								m = 0;
							}
						}
						if (this.ghost1.Left < 176)
						{
							if ((i != 1 ? false : y == 1))
							{
								i = 0;
							}
						}
						if (this.ghost1.Left > 176)
						{
							if ((i != 1 ? false : y == 1))
							{
								y = 0;
							}
						}
					}
					else
					{
						this.ghost1velocity = 2;
						this.Supermod1 = false;
						this.v1 = false;
						this.ghost1puomangiare = true;
						this.g1mangiato = false;
					}
				}
				this.topghost1 = 0;
				this.leftghost1 = 0;
				while (!this.dir1)
				{
					this.random1 = this.rand.Next(1, 5);
					if ((this.random1 != 1 || this.dir1 ? false : this.random1 != this.prec1) && i == 1)
					{
						this.leftghost1 = -this.ghost1velocity;
						this.dir1 = true;
						if ((this.Supermod1 ? false : this.ghost1puomangiare))
						{
							this.ghost1.Image = Resources.rsx;
						}
						else if ((!this.tresec ? false : !this.g1mangiato))
						{
							this.ghost1.Image = Resources.tempo;
						}
						else
						{
							if (!this.tresec)
							{
								this.ghost1.Image = Resources.crazy;
							}
							if (this.g1mangiato)
							{
								this.ghost1.Image = Resources.msx;
							}
						}
					}
					if ((this.random1 != 2 || this.dir1 ? false : this.random1 != this.prec1) && y == 1)
					{
						this.leftghost1 = this.ghost1velocity;
						this.dir1 = true;
						if ((this.Supermod1 ? false : this.ghost1puomangiare))
						{
							this.ghost1.Image = Resources.rdx;
						}
						else if ((!this.tresec ? false : !this.g1mangiato))
						{
							this.ghost1.Image = Resources.tempo;
						}
						else
						{
							if (!this.tresec)
							{
								this.ghost1.Image = Resources.crazy;
							}
							if (this.g1mangiato)
							{
								this.ghost1.Image = Resources.mdx;
							}
						}
					}
					if ((this.random1 != 3 || this.dir1 ? false : this.random1 != this.prec1) && m == 1)
					{
						this.topghost1 = this.ghost1velocity;
						this.dir1 = true;
						if ((this.Supermod1 ? false : this.ghost1puomangiare))
						{
							this.ghost1.Image = Resources.rdown;
						}
						else if ((!this.tresec ? false : !this.g1mangiato))
						{
							this.ghost1.Image = Resources.tempo;
						}
						else
						{
							if (!this.tresec)
							{
								this.ghost1.Image = Resources.crazy;
							}
							if (this.g1mangiato)
							{
								this.ghost1.Image = Resources.mdown;
							}
						}
					}
					if ((this.random1 != 4 || this.dir1 ? false : this.random1 != this.prec1) && n == 1)
					{
						this.topghost1 = -this.ghost1velocity;
						this.dir1 = true;
						if ((this.Supermod1 ? false : this.ghost1puomangiare))
						{
							this.ghost1.Image = Resources.rup;
						}
						else if ((!this.tresec ? false : !this.g1mangiato))
						{
							this.ghost1.Image = Resources.tempo;
						}
						else
						{
							if (!this.tresec)
							{
								this.ghost1.Image = Resources.crazy;
							}
							if (this.g1mangiato)
							{
								this.ghost1.Image = Resources.mup1;
							}
						}
					}
				}
				if (this.random1 == 1)
				{
					this.prec1 = 2;
				}
				if (this.random1 == 2)
				{
					this.prec1 = 1;
				}
				if (this.random1 == 3)
				{
					this.prec1 = 4;
				}
				if (this.random1 == 4)
				{
					this.prec1 = 3;
				}
				this.dir1 = false;
			}
			if (this.ghost2turn)
			{
				if ((!this.Supermod2 ? false : !this.ghost2puomangiare))
				{
					if (this.ghost2.Left >= 180 || this.ghost2.Top != 150)
					{
						flag3 = (this.ghost2.Left <= 170 ? false : this.ghost2.Top == 150);
					}
					else
					{
						flag3 = true;
					}
					if (!flag3)
					{
						if (this.ghost2.Top < 150)
						{
							if ((n != 1 ? false : m == 1))
							{
								n = 0;
							}
						}
						if (this.ghost2.Top > 150)
						{
							if ((n != 1 ? false : m == 1))
							{
								m = 0;
							}
						}
						if (this.ghost2.Left < 176)
						{
							if ((i != 1 ? false : y == 1))
							{
								i = 0;
							}
						}
						if (this.ghost2.Left > 176)
						{
							if ((i != 1 ? false : y == 1))
							{
								y = 0;
							}
						}
					}
					else
					{
						this.ghost2velocity = 2;
						this.Supermod2 = false;
						this.v2 = false;
						this.ghost2puomangiare = true;
						this.g2mangiato = false;
					}
				}
				this.topghost2 = 0;
				this.leftghost2 = 0;
				while (!this.dir2)
				{
					this.random2 = this.rand.Next(1, 5);
					if ((this.random2 != 1 || this.dir2 ? false : this.random2 != this.prec2) && i == 1)
					{
						this.leftghost2 = -this.ghost2velocity;
						this.dir2 = true;
						if ((this.Supermod2 ? false : this.ghost2puomangiare))
						{
							this.ghost2.Image = Resources.asx;
						}
						else if ((!this.tresec ? false : !this.g2mangiato))
						{
							this.ghost2.Image = Resources.tempo;
						}
						else
						{
							if (!this.tresec)
							{
								this.ghost2.Image = Resources.crazy;
							}
							if (this.g2mangiato)
							{
								this.ghost2.Image = Resources.msx;
							}
						}
					}
					if ((this.random2 != 2 || this.dir2 ? false : this.random2 != this.prec2) && y == 1)
					{
						this.leftghost2 = this.ghost2velocity;
						this.dir2 = true;
						if ((this.Supermod2 ? false : this.ghost2puomangiare))
						{
							this.ghost2.Image = Resources.adx;
						}
						else if ((!this.tresec ? false : !this.g2mangiato))
						{
							this.ghost2.Image = Resources.tempo;
						}
						else
						{
							if (!this.tresec)
							{
								this.ghost2.Image = Resources.crazy;
							}
							if (this.g2mangiato)
							{
								this.ghost2.Image = Resources.mdx;
							}
						}
					}
					if ((this.random2 != 3 || this.dir2 ? false : this.random2 != this.prec2) && m == 1)
					{
						this.topghost2 = this.ghost2velocity;
						this.dir2 = true;
						if ((this.Supermod2 ? false : this.ghost2puomangiare))
						{
							this.ghost2.Image = Resources.adown;
						}
						else if ((!this.tresec ? false : !this.g2mangiato))
						{
							this.ghost2.Image = Resources.tempo;
						}
						else
						{
							if (!this.tresec)
							{
								this.ghost2.Image = Resources.crazy;
							}
							if (this.g2mangiato)
							{
								this.ghost2.Image = Resources.mdown;
							}
						}
					}
					if ((this.random2 != 4 || this.dir2 ? false : this.random2 != this.prec2) && n == 1)
					{
						this.topghost2 = -this.ghost2velocity;
						this.dir2 = true;
						if ((this.Supermod2 ? false : this.ghost2puomangiare))
						{
							this.ghost2.Image = Resources.aup;
						}
						else if ((!this.tresec ? false : !this.g2mangiato))
						{
							this.ghost2.Image = Resources.tempo;
						}
						else
						{
							if (!this.tresec)
							{
								this.ghost2.Image = Resources.crazy;
							}
							if (this.g2mangiato)
							{
								this.ghost2.Image = Resources.mup1;
							}
						}
					}
				}
				if (this.random2 == 1)
				{
					this.prec2 = 2;
				}
				if (this.random2 == 2)
				{
					this.prec2 = 1;
				}
				if (this.random2 == 3)
				{
					this.prec2 = 4;
				}
				if (this.random2 == 4)
				{
					this.prec2 = 3;
				}
				this.dir2 = false;
			}
			if (this.ghost3turn)
			{
				if ((!this.Supermod3 ? false : !this.ghost3puomangiare))
				{
					if (this.ghost3.Left >= 180 || this.ghost3.Top != 150)
					{
						flag2 = (this.ghost3.Left <= 170 ? false : this.ghost3.Top == 150);
					}
					else
					{
						flag2 = true;
					}
					if (!flag2)
					{
						if (this.ghost3.Top > 150)
						{
							if ((n != 1 ? false : m == 1))
							{
								m = 0;
							}
						}
						if (this.ghost3.Top < 150)
						{
							if ((n != 1 ? false : m == 1))
							{
								n = 0;
							}
						}
						if (this.ghost3.Left < 176)
						{
							if ((i != 1 ? false : y == 1))
							{
								i = 0;
							}
						}
						if (this.ghost3.Left > 176)
						{
							if ((i != 1 ? false : y == 1))
							{
								y = 0;
							}
						}
					}
					else
					{
						this.ghost3velocity = 2;
						this.Supermod3 = false;
						this.v3 = false;
						this.ghost3puomangiare = true;
						this.g3mangiato = false;
					}
				}
				this.topghost3 = 0;
				this.leftghost3 = 0;
				while (!this.dir3)
				{
					this.random3 = this.rand.Next(1, 5);
					if ((this.random3 != 1 || this.dir3 ? false : this.random3 != this.prec3) && i == 1)
					{
						this.leftghost3 = -this.ghost3velocity;
						this.dir3 = true;
						if ((this.Supermod3 ? false : this.ghost3puomangiare))
						{
							this.ghost3.Image = Resources.vsx;
						}
						else if ((!this.tresec ? false : !this.g3mangiato))
						{
							this.ghost3.Image = Resources.tempo;
						}
						else
						{
							if (!this.tresec)
							{
								this.ghost3.Image = Resources.crazy;
							}
							if (this.g3mangiato)
							{
								this.ghost3.Image = Resources.msx;
							}
						}
					}
					if ((this.random3 != 2 || this.dir3 ? false : this.random3 != this.prec3) && y == 1)
					{
						this.leftghost3 = this.ghost3velocity;
						this.dir3 = true;
						if ((this.Supermod3 ? false : this.ghost3puomangiare))
						{
							this.ghost3.Image = Resources.vdx;
						}
						else if ((!this.tresec ? false : !this.g3mangiato))
						{
							this.ghost3.Image = Resources.tempo;
						}
						else
						{
							if (!this.tresec)
							{
								this.ghost3.Image = Resources.crazy;
							}
							if (this.g3mangiato)
							{
								this.ghost3.Image = Resources.mdx;
							}
						}
					}
					if ((this.random3 != 3 || this.dir3 ? false : this.random3 != this.prec3) && m == 1)
					{
						this.topghost3 = this.ghost3velocity;
						this.dir3 = true;
						if ((this.Supermod3 ? false : this.ghost3puomangiare))
						{
							this.ghost3.Image = Resources.vdown;
						}
						else if ((!this.tresec ? false : !this.g3mangiato))
						{
							this.ghost3.Image = Resources.tempo;
						}
						else
						{
							if (!this.tresec)
							{
								this.ghost3.Image = Resources.crazy;
							}
							if (this.g3mangiato)
							{
								this.ghost3.Image = Resources.mdown;
							}
						}
					}
					if ((this.random3 != 4 || this.dir3 ? false : this.random3 != this.prec3) && n == 1)
					{
						this.topghost3 = -this.ghost3velocity;
						this.dir3 = true;
						if ((this.Supermod3 ? false : this.ghost3puomangiare))
						{
							this.ghost3.Image = Resources.vup;
						}
						else if ((!this.tresec ? false : !this.g3mangiato))
						{
							this.ghost3.Image = Resources.tempo;
						}
						else
						{
							if (!this.tresec)
							{
								this.ghost3.Image = Resources.crazy;
							}
							if (this.g3mangiato)
							{
								this.ghost3.Image = Resources.mup1;
							}
						}
					}
				}
				if (this.random3 == 1)
				{
					this.prec3 = 2;
				}
				if (this.random3 == 2)
				{
					this.prec3 = 1;
				}
				if (this.random3 == 3)
				{
					this.prec3 = 4;
				}
				if (this.random3 == 4)
				{
					this.prec3 = 3;
				}
				this.dir3 = false;
			}
			if (this.ghost4turn)
			{
				if ((!this.Supermod4 ? false : !this.ghost4puomangiare))
				{
					if (this.ghost4.Left >= 180 || this.ghost4.Top != 150)
					{
						flag1 = (this.ghost4.Left <= 170 ? false : this.ghost4.Top == 150);
					}
					else
					{
						flag1 = true;
					}
					if (!flag1)
					{
						if (this.ghost4.Top > 150)
						{
							if ((n != 1 ? false : m == 1))
							{
								m = 0;
							}
						}
						if (this.ghost4.Top < 150)
						{
							if ((n != 1 ? false : m == 1))
							{
								n = 0;
							}
						}
						if (this.ghost4.Left < 176)
						{
							if ((i != 1 ? false : y == 1))
							{
								i = 0;
							}
						}
						if (this.ghost4.Left > 176)
						{
							if ((i != 1 ? false : y == 1))
							{
								y = 0;
							}
						}
					}
					else
					{
						this.ghost4velocity = 2;
						this.Supermod4 = false;
						this.v4 = false;
						this.ghost4puomangiare = true;
						this.g4mangiato = false;
					}
				}
				this.topghost4 = 0;
				this.leftghost4 = 0;
				while (!this.dir4)
				{
					this.random4 = this.rand.Next(1, 5);
					if ((this.random4 != 1 || this.dir4 ? false : this.random4 != this.prec4) && i == 1)
					{
						this.leftghost4 = -this.ghost4velocity;
						this.dir4 = true;
						if ((this.Supermod4 ? false : this.ghost4puomangiare))
						{
							this.ghost4.Image = Resources.gsx;
						}
						else if ((!this.tresec ? false : !this.g4mangiato))
						{
							this.ghost4.Image = Resources.tempo;
						}
						else
						{
							if (!this.tresec)
							{
								this.ghost4.Image = Resources.crazy;
							}
							if (this.g4mangiato)
							{
								this.ghost4.Image = Resources.msx;
							}
						}
					}
					if ((this.random4 != 2 || this.dir4 ? false : this.random4 != this.prec4) && y == 1)
					{
						this.leftghost4 = this.ghost4velocity;
						this.dir4 = true;
						if ((this.Supermod4 ? false : this.ghost4puomangiare))
						{
							this.ghost4.Image = Resources.gdx;
						}
						else if ((!this.tresec ? false : !this.g4mangiato))
						{
							this.ghost4.Image = Resources.tempo;
						}
						else
						{
							if (!this.tresec)
							{
								this.ghost4.Image = Resources.crazy;
							}
							if (this.g4mangiato)
							{
								this.ghost4.Image = Resources.mdx;
							}
						}
					}
					if ((this.random4 != 3 || this.dir4 ? false : this.random4 != this.prec4) && m == 1)
					{
						this.topghost4 = this.ghost4velocity;
						this.dir4 = true;
						if ((this.Supermod4 ? false : this.ghost4puomangiare))
						{
							this.ghost4.Image = Resources.gdown;
						}
						else if ((!this.tresec ? false : !this.g4mangiato))
						{
							this.ghost4.Image = Resources.tempo;
						}
						else
						{
							if (!this.tresec)
							{
								this.ghost4.Image = Resources.crazy;
							}
							if (this.g4mangiato)
							{
								this.ghost4.Image = Resources.mdown;
							}
						}
					}
					if ((this.random4 != 4 || this.dir4 ? false : this.random4 != this.prec4) && n == 1)
					{
						this.topghost4 = -this.ghost4velocity;
						this.dir4 = true;
						if ((this.Supermod4 ? false : this.ghost4puomangiare))
						{
							this.ghost4.Image = Resources.gup;
						}
						else if ((!this.tresec ? false : !this.g4mangiato))
						{
							this.ghost4.Image = Resources.tempo;
						}
						else
						{
							if (!this.tresec)
							{
								this.ghost4.Image = Resources.crazy;
							}
							if (this.g4mangiato)
							{
								this.ghost4.Image = Resources.mup1;
							}
						}
					}
				}
				if (this.random4 == 1)
				{
					this.prec4 = 2;
				}
				if (this.random4 == 2)
				{
					this.prec4 = 1;
				}
				if (this.random4 == 3)
				{
					this.prec4 = 4;
				}
				if (this.random4 == 4)
				{
					this.prec4 = 3;
				}
				this.dir4 = false;
			}
			if (this.pacturn)
			{
				this.top = 0;
				this.left = 0;
				if ((this.temp != 1 || i != 1) && (this.temp != 2 || y != 1) && (this.temp != 3 || n != 1))
				{
					flag = (this.temp != 4 ? false : m == 1);
				}
				else
				{
					flag = true;
				}
				if (flag)
				{
					this.next = this.temp;
				}
				if ((this.next != 1 ? false : i == 1))
				{
					this.left = -2;
					this.pacman.Image = Resources.pacsx;
					this.direzione = this.next;
				}
				if ((this.next != 2 ? false : y == 1))
				{
					this.left = 2;
					this.pacman.Image = Resources.pacdx;
					this.direzione = this.next;
				}
				if ((this.next != 3 ? false : n == 1))
				{
					this.top = -2;
					this.pacman.Image = Resources.pacup;
					this.direzione = this.next;
				}
				if ((this.next != 4 ? false : m == 1))
				{
					this.top = 2;
					this.pacman.Image = Resources.pacdown;
					this.direzione = this.next;
				}
				if ((this.top != 0 ? false : this.left == 0))
				{
					this.temp = this.next;
					this.next = this.direzione;
					if (this.next == 1)
					{
						this.pacman.Image = Resources._1sx;
					}
					if (this.next == 2)
					{
						this.pacman.Image = Resources._1dx;
					}
					if (this.next == 3)
					{
						this.pacman.Image = Resources._1up;
					}
					if (this.next == 4)
					{
						this.pacman.Image = Resources._1down;
					}
				}
			}
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
			if (this.vita == 1)
			{
				this.pictureBox1.Visible = false;
				this.pictureBox2.Visible = false;
			}
		}

		private void mangiato()
		{
			this.pacman.Image = Resources.pacmorto;
			if (this.vita - 1 > 0)
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
			else
			{
				this.label124.Visible = true;
				this.finepartita();
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
		}

		private void points()
		{
			bool flag;
			for (int i = 0; i < 0x14c; i++)
			{
				if (!((Label)this.oggetti[i]).Visible)
				{
					flag = false;
				}
				else
				{
					Rectangle bounds = this.pacman.Bounds;
					flag = bounds.IntersectsWith(((Label)this.oggetti[i]).Bounds);
				}
				if (flag)
				{
					this.point++;
					((Label)this.oggetti[i]).Visible = false;
				}
			}
			this.score.Text = this.point.ToString();
			if (this.point >= 0x14c)
			{
				this.finepartita();
				this.label141.Visible = true;
			}
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
			if ((this.prec1 != 1 ? false : !this.g1mangiato))
			{
				if (this.ghost1.Left % 2 == 0)
				{
					this.leftghost1 = this.ghost1velocity;
				}
				this.ghost1.Image = Resources.rdx;
			}
			if ((this.prec1 != 2 ? false : !this.g1mangiato))
			{
				if (this.ghost1.Left % 2 == 0)
				{
					this.leftghost1 = -this.ghost1velocity;
				}
				this.ghost1.Image = Resources.rsx;
			}
			if ((this.prec1 != 3 ? false : !this.g1mangiato))
			{
				if (this.ghost1.Top % 2 == 0)
				{
					this.topghost1 = -this.ghost1velocity;
				}
				this.ghost1.Image = Resources.rup;
			}
			if ((this.prec1 != 4 ? false : !this.g1mangiato))
			{
				if (this.ghost1.Top % 2 == 0)
				{
					this.topghost1 = this.ghost1velocity;
				}
				this.ghost1.Image = Resources.rdown;
			}
			if ((this.prec2 != 1 ? false : !this.g2mangiato))
			{
				if (this.ghost2.Left % 2 == 0)
				{
					this.leftghost2 = this.ghost2velocity;
				}
				this.ghost2.Image = Resources.adx;
			}
			if ((this.prec2 != 2 ? false : !this.g2mangiato))
			{
				if (this.ghost2.Left % 2 == 0)
				{
					this.leftghost2 = -this.ghost2velocity;
				}
				this.ghost2.Image = Resources.asx;
			}
			if ((this.prec2 != 3 ? false : !this.g2mangiato))
			{
				if (this.ghost2.Top % 2 == 0)
				{
					this.topghost2 = -this.ghost2velocity;
				}
				this.ghost2.Image = Resources.aup;
			}
			if ((this.prec2 != 4 ? false : !this.g2mangiato))
			{
				if (this.ghost2.Top % 2 == 0)
				{
					this.topghost2 = this.ghost2velocity;
				}
				this.ghost2.Image = Resources.adown;
			}
			if ((this.prec3 != 1 ? false : !this.g3mangiato))
			{
				if (this.ghost3.Left % 2 == 0)
				{
					this.leftghost3 = this.ghost3velocity;
				}
				this.ghost3.Image = Resources.vdx;
			}
			if ((this.prec3 != 2 ? false : !this.g3mangiato))
			{
				if (this.ghost3.Left % 2 == 0)
				{
					this.leftghost3 = -this.ghost3velocity;
				}
				this.ghost3.Image = Resources.vsx;
			}
			if ((this.prec3 != 3 ? false : !this.g3mangiato))
			{
				if (this.ghost3.Top % 2 == 0)
				{
					this.topghost3 = -this.ghost3velocity;
				}
				this.ghost3.Image = Resources.vup;
			}
			if ((this.prec3 != 4 ? false : !this.g3mangiato))
			{
				if (this.ghost3.Top % 2 == 0)
				{
					this.topghost3 = this.ghost3velocity;
				}
				this.ghost3.Image = Resources.vdown;
			}
			if ((this.prec4 != 1 ? false : !this.g4mangiato))
			{
				if (this.ghost4.Left % 2 == 0)
				{
					this.leftghost4 = this.ghost4velocity;
				}
				this.ghost4.Image = Resources.gdx;
			}
			if ((this.prec4 != 2 ? false : !this.g4mangiato))
			{
				if (this.ghost4.Left % 2 == 0)
				{
					this.leftghost4 = -this.ghost4velocity;
				}
				this.ghost4.Image = Resources.gsx;
			}
			if ((this.prec4 != 3 ? false : !this.g4mangiato))
			{
				if (this.ghost4.Top % 2 == 0)
				{
					this.topghost4 = -this.ghost4velocity;
				}
				this.ghost4.Image = Resources.gup;
			}
			if ((this.prec4 != 4 ? false : !this.g4mangiato))
			{
				if (this.ghost4.Top % 2 == 0)
				{
					this.topghost4 = this.ghost4velocity;
				}
				this.ghost1.Image = Resources.gdown;
			}
		}

		private void powermod1_Tick(object sender, EventArgs e)
		{
			this.tresec = true;
			this.powermod1.Enabled = false;
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
			this.pacman.Top = 0x16c;
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
			this.pacman.Image = Resources._1dx;
			this.ghost1.Image = Resources.rup;
			this.ghost2.Image = Resources.aup;
			this.ghost3.Image = Resources.vup;
			this.ghost4.Image = Resources.gup;
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
			for (int i = 0; i < 0x14c; i++)
			{
				((Label)this.oggetti[i]).Visible = true;
			}
		}

		private void supermod()
		{
			if ((!this.pacman.Bounds.IntersectsWith(this.label173.Bounds) ? false : this.label173.Visible))
			{
				this.supermod2();
			}
			if ((!this.pacman.Bounds.IntersectsWith(this.label307.Bounds) ? false : this.label307.Visible))
			{
				this.supermod2();
			}
			if ((!this.pacman.Bounds.IntersectsWith(this.label220.Bounds) ? false : this.label220.Visible))
			{
				this.supermod2();
			}
			if ((!this.pacman.Bounds.IntersectsWith(this.label71.Bounds) ? false : this.label71.Visible))
			{
				this.supermod2();
			}
		}

		private void supermod2()
		{
			if (!this.g1mangiato)
			{
				this.v1 = false;
				this.ghost1velocity = 2;
				this.Supermod1 = true;
				this.ghost1.Image = Resources.crazy;
				this.ghost1puomangiare = true;
			}
			if (!this.g2mangiato)
			{
				this.v2 = false;
				this.ghost2velocity = 2;
				this.Supermod2 = true;
				this.ghost2.Image = Resources.crazy;
				this.ghost2puomangiare = true;
			}
			if (!this.g3mangiato)
			{
				this.v3 = false;
				this.ghost3velocity = 2;
				this.Supermod3 = true;
				this.ghost3.Image = Resources.crazy;
				this.ghost3puomangiare = true;
			}
			if (!this.g4mangiato)
			{
				this.v4 = false;
				this.ghost4velocity = 2;
				this.Supermod4 = true;
				this.ghost4.Image = Resources.crazy;
				this.ghost4puomangiare = true;
			}
			this.powermod.Enabled = false;
			this.powermod1.Enabled = false;
			this.powermod1.Enabled = true;
			this.tresec = false;
			this.powermod.Enabled = true;
			this.Supermod = true;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (this.pacman.Enabled)
			{
				this.direction();
				this.freedirection();
			}
			if ((this.ghost1.Enabled || this.ghost2.Enabled || this.ghost3.Enabled ? true : this.ghost4.Enabled))
			{
				this.ghost();
			}
			if (this.c)
			{
				this.control();
			}
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
			{
				this.startdirection = 2;
			}
			if (this.ghost2.Top == 192)
			{
				this.startdirection = 1;
			}
			if (this.startdirection == 1)
			{
				Label top = this.ghost2;
				top.Top = top.Top - 1;
				Label label = this.ghost4;
				label.Top = label.Top - 1;
			}
			if (this.startdirection == 2)
			{
				Label top1 = this.ghost2;
				top1.Top = top1.Top + 1;
				Label label1 = this.ghost4;
				label1.Top = label1.Top + 1;
			}
		}

		private void timer4_Tick(object sender, EventArgs e)
		{
			this.tic4++;
			if ((this.ghost3.Top <= 150 ? false : this.tic4 > 100))
			{
				this.prec1 = 3;
				Label top = this.ghost3;
				top.Top = top.Top - 1;
			}
			if (this.ghost3.Top == 150)
			{
				this.timer4.Enabled = false;
			}
		}

		private void timer5_Tick(object sender, EventArgs e)
		{
			this.tic5++;
			if ((this.ghost2.Left <= 153 || this.ghost2.Left >= 176 ? false : this.tic5 > 0x12c))
			{
				Label left = this.ghost2;
				left.Left = left.Left + 1;
			}
			if ((this.ghost2.Top <= 150 ? false : this.ghost2.Left == 176))
			{
				Label top = this.ghost2;
				top.Top = top.Top - 1;
			}
			if (this.ghost2.Top == 150)
			{
				this.timer6.Enabled = true;
				this.timer5.Enabled = false;
			}
		}

		private void timer6_Tick(object sender, EventArgs e)
		{
			this.tic6++;
			if ((this.ghost4.Left <= 176 || this.ghost4.Left >= 200 ? false : this.tic6 > 100))
			{
				Label left = this.ghost4;
				left.Left = left.Left - 1;
			}
			if ((this.ghost4.Top <= 150 ? false : this.ghost4.Left == 176))
			{
				Label top = this.ghost4;
				top.Top = top.Top - 1;
			}
			if (this.ghost4.Top == 150)
			{
				this.timer6.Enabled = false;
			}
		}

		private void timer7_Tick(object sender, EventArgs e)
		{
			this.timer7.Enabled = false;
			this.panel1.Visible = true;
			this.attendo.Enabled = true;
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
			this.vita--;
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
			this.pacman.Top = 0x16c;
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
			this.pacman.Image = Resources._1dx;
			this.ghost1.Image = Resources.rup;
			this.ghost2.Image = Resources.aup;
			this.ghost3.Image = Resources.vup;
			this.ghost4.Image = Resources.gup;
			this.ghost1.Visible = true;
			this.ghost2.Visible = true;
			this.ghost3.Visible = true;
			this.ghost4.Visible = true;
			this.pacman.SetBounds(this.pacman.Left, this.pacman.Top, 22, 22);
			this.pacman.Visible = true;
			this.timer2.Enabled = true;
			this.timer3.Enabled = true;
			this.timer8.Interval = 0x76c;
		}

		private void timer9_Tick(object sender, EventArgs e)
		{
			this.pictureBox3.Visible = true;
			this.button1.Visible = true;
			this.timer9.Enabled = false;
		}

		private void transport(int i, int n)
		{
			if (this.pacturn)
			{
				if (i == 0)
				{
					this.pacman.Left = -26;
				}
				if (n == 0)
				{
					this.pacman.Left = 0x176;
				}
			}
			if (this.ghost1turn)
			{
				if (i == 0)
				{
					this.ghost1.Left = -26;
				}
				if (n == 0)
				{
					this.ghost1.Left = 0x176;
				}
			}
			if (this.ghost2turn)
			{
				if (i == 0)
				{
					this.ghost2.Left = -26;
				}
				if (n == 0)
				{
					this.ghost2.Left = 0x176;
				}
			}
			if (this.ghost3turn)
			{
				if (i == 0)
				{
					this.ghost3.Left = -26;
				}
				if (n == 0)
				{
					this.ghost3.Left = 0x176;
				}
			}
			if (this.ghost4turn)
			{
				if (i == 0)
				{
					this.ghost4.Left = -26;
				}
				if (n == 0)
				{
					this.ghost4.Left = 0x176;
				}
			}
		}
	}
}