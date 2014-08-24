/*
 * Created by SharpDevelop.
 * User: kasem
 * Date: 20/8/2557
 * Time: 18:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Li_keSing.Net
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.Timer = new System.Windows.Forms.Timer(this.components);
			this.LyricTimer = new System.Windows.Forms.Timer(this.components);
			this.pCommand = new System.Windows.Forms.Panel();
			this.tPosition = new System.Windows.Forms.TrackBar();
			this.btnMin = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.in1 = new System.Windows.Forms.Label();
			this.tVolumn = new System.Windows.Forms.TrackBar();
			this.t16 = new System.Windows.Forms.TrackBar();
			this.t15 = new System.Windows.Forms.TrackBar();
			this.t14 = new System.Windows.Forms.TrackBar();
			this.t13 = new System.Windows.Forms.TrackBar();
			this.t12 = new System.Windows.Forms.TrackBar();
			this.t11 = new System.Windows.Forms.TrackBar();
			this.t10 = new System.Windows.Forms.TrackBar();
			this.t9 = new System.Windows.Forms.TrackBar();
			this.t8 = new System.Windows.Forms.TrackBar();
			this.t7 = new System.Windows.Forms.TrackBar();
			this.t6 = new System.Windows.Forms.TrackBar();
			this.t5 = new System.Windows.Forms.TrackBar();
			this.t4 = new System.Windows.Forms.TrackBar();
			this.t3 = new System.Windows.Forms.TrackBar();
			this.t2 = new System.Windows.Forms.TrackBar();
			this.t1 = new System.Windows.Forms.TrackBar();
			this.btnExit = new System.Windows.Forms.Button();
			this.pStatus = new System.Windows.Forms.Panel();
			this.lTempo = new System.Windows.Forms.Label();
			this.lBeat = new System.Windows.Forms.Label();
			this.lTotal = new System.Windows.Forms.Label();
			this.lClock = new System.Windows.Forms.Label();
			this.TrackTimer = new System.Windows.Forms.Timer(this.components);
			this.pSoundfont = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.cbSoundfont = new System.Windows.Forms.ComboBox();
			this.openFile = new System.Windows.Forms.OpenFileDialog();
			this.grid = new System.Windows.Forms.DataGrid();
			this.pCommand.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tPosition)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tVolumn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.t16)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.t15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.t14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.t13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.t12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.t11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.t10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.t9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.t8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.t7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.t6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.t5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.t4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.t3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.t2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.t1)).BeginInit();
			this.pStatus.SuspendLayout();
			this.pSoundfont.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			this.SuspendLayout();
			// 
			// Timer
			// 
			this.Timer.Enabled = true;
			this.Timer.Interval = 1000;
			this.Timer.Tick += new System.EventHandler(this.TimerTick);
			// 
			// LyricTimer
			// 
			this.LyricTimer.Interval = 10;
			this.LyricTimer.Tick += new System.EventHandler(this.LyricTimerTick);
			// 
			// pCommand
			// 
			this.pCommand.BackColor = System.Drawing.SystemColors.ControlLight;
			this.pCommand.Controls.Add(this.tPosition);
			this.pCommand.Controls.Add(this.btnMin);
			this.pCommand.Controls.Add(this.label13);
			this.pCommand.Controls.Add(this.label14);
			this.pCommand.Controls.Add(this.label15);
			this.pCommand.Controls.Add(this.label16);
			this.pCommand.Controls.Add(this.label17);
			this.pCommand.Controls.Add(this.label18);
			this.pCommand.Controls.Add(this.label8);
			this.pCommand.Controls.Add(this.label9);
			this.pCommand.Controls.Add(this.label10);
			this.pCommand.Controls.Add(this.label11);
			this.pCommand.Controls.Add(this.label12);
			this.pCommand.Controls.Add(this.label7);
			this.pCommand.Controls.Add(this.label6);
			this.pCommand.Controls.Add(this.label5);
			this.pCommand.Controls.Add(this.label4);
			this.pCommand.Controls.Add(this.in1);
			this.pCommand.Controls.Add(this.tVolumn);
			this.pCommand.Controls.Add(this.t16);
			this.pCommand.Controls.Add(this.t15);
			this.pCommand.Controls.Add(this.t14);
			this.pCommand.Controls.Add(this.t13);
			this.pCommand.Controls.Add(this.t12);
			this.pCommand.Controls.Add(this.t11);
			this.pCommand.Controls.Add(this.t10);
			this.pCommand.Controls.Add(this.t9);
			this.pCommand.Controls.Add(this.t8);
			this.pCommand.Controls.Add(this.t7);
			this.pCommand.Controls.Add(this.t6);
			this.pCommand.Controls.Add(this.t5);
			this.pCommand.Controls.Add(this.t4);
			this.pCommand.Controls.Add(this.t3);
			this.pCommand.Controls.Add(this.t2);
			this.pCommand.Controls.Add(this.t1);
			this.pCommand.Controls.Add(this.btnExit);
			this.pCommand.Location = new System.Drawing.Point(12, 13);
			this.pCommand.Name = "pCommand";
			this.pCommand.Size = new System.Drawing.Size(724, 251);
			this.pCommand.TabIndex = 4;
			this.pCommand.Visible = false;
			// 
			// tPosition
			// 
			this.tPosition.BackColor = System.Drawing.Color.LightGray;
			this.tPosition.Location = new System.Drawing.Point(9, 195);
			this.tPosition.Maximum = 1000000;
			this.tPosition.Name = "tPosition";
			this.tPosition.Size = new System.Drawing.Size(621, 45);
			this.tPosition.TabIndex = 1;
			this.tPosition.TickFrequency = 0;
			this.tPosition.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.tPosition.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TPositionMouseDown);
			this.tPosition.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TPositionMouseUp);
			// 
			// btnMin
			// 
			this.btnMin.BackColor = System.Drawing.Color.LightGray;
			this.btnMin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.btnMin.ForeColor = System.Drawing.Color.White;
			this.btnMin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnMin.Location = new System.Drawing.Point(699, 0);
			this.btnMin.Name = "btnMin";
			this.btnMin.Size = new System.Drawing.Size(25, 23);
			this.btnMin.TabIndex = 35;
			this.btnMin.Text = "..";
			this.btnMin.UseVisualStyleBackColor = false;
			this.btnMin.Click += new System.EventHandler(this.BtnMinClick);
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label13.Location = new System.Drawing.Point(595, 4);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(33, 23);
			this.label13.TabIndex = 34;
			this.label13.Text = "00";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label14.Location = new System.Drawing.Point(557, 4);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(33, 23);
			this.label14.TabIndex = 33;
			this.label14.Text = "00";
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label15.Location = new System.Drawing.Point(521, 4);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(33, 23);
			this.label15.TabIndex = 32;
			this.label15.Text = "00";
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label16.Location = new System.Drawing.Point(482, 4);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(33, 23);
			this.label16.TabIndex = 31;
			this.label16.Text = "00";
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label17.Location = new System.Drawing.Point(443, 4);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(33, 23);
			this.label17.TabIndex = 30;
			this.label17.Text = "00";
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label18.Location = new System.Drawing.Point(404, 4);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(33, 23);
			this.label18.TabIndex = 29;
			this.label18.Text = "00";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label8.Location = new System.Drawing.Point(363, 4);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(33, 23);
			this.label8.TabIndex = 28;
			this.label8.Text = "00";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label9.Location = new System.Drawing.Point(325, 4);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(33, 23);
			this.label9.TabIndex = 27;
			this.label9.Text = "00";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label10.Location = new System.Drawing.Point(289, 4);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(33, 23);
			this.label10.TabIndex = 26;
			this.label10.Text = "00";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label11.Location = new System.Drawing.Point(250, 4);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(33, 23);
			this.label11.TabIndex = 25;
			this.label11.Text = "00";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label12.Location = new System.Drawing.Point(211, 4);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(33, 23);
			this.label12.TabIndex = 24;
			this.label12.Text = "00";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label7.Location = new System.Drawing.Point(172, 4);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(33, 23);
			this.label7.TabIndex = 23;
			this.label7.Text = "00";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label6.Location = new System.Drawing.Point(134, 4);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(33, 23);
			this.label6.TabIndex = 22;
			this.label6.Text = "00";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label5.Location = new System.Drawing.Point(98, 4);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(33, 23);
			this.label5.TabIndex = 21;
			this.label5.Text = "00";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label4.Location = new System.Drawing.Point(59, 4);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 23);
			this.label4.TabIndex = 20;
			this.label4.Text = "00";
			// 
			// in1
			// 
			this.in1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.in1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.in1.Location = new System.Drawing.Point(20, 4);
			this.in1.Name = "in1";
			this.in1.Size = new System.Drawing.Size(33, 23);
			this.in1.TabIndex = 19;
			this.in1.Text = "00";
			// 
			// tVolumn
			// 
			this.tVolumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.tVolumn.Location = new System.Drawing.Point(657, 24);
			this.tVolumn.Maximum = 100;
			this.tVolumn.Name = "tVolumn";
			this.tVolumn.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.tVolumn.Size = new System.Drawing.Size(45, 165);
			this.tVolumn.TabIndex = 18;
			this.tVolumn.TickFrequency = 5;
			this.tVolumn.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.tVolumn.Value = 50;
			this.tVolumn.Scroll += new System.EventHandler(this.TVolumnScroll);
			// 
			// t16
			// 
			this.t16.Location = new System.Drawing.Point(585, 18);
			this.t16.Maximum = 127;
			this.t16.Name = "t16";
			this.t16.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.t16.Size = new System.Drawing.Size(45, 159);
			this.t16.TabIndex = 17;
			this.t16.Tag = "15";
			this.t16.TickFrequency = 5;
			this.t16.TickStyle = System.Windows.Forms.TickStyle.Both;
			// 
			// t15
			// 
			this.t15.Location = new System.Drawing.Point(546, 18);
			this.t15.Maximum = 127;
			this.t15.Name = "t15";
			this.t15.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.t15.Size = new System.Drawing.Size(45, 159);
			this.t15.TabIndex = 16;
			this.t15.Tag = "14";
			this.t15.TickFrequency = 5;
			this.t15.TickStyle = System.Windows.Forms.TickStyle.Both;
			// 
			// t14
			// 
			this.t14.Location = new System.Drawing.Point(507, 18);
			this.t14.Maximum = 127;
			this.t14.Name = "t14";
			this.t14.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.t14.Size = new System.Drawing.Size(45, 159);
			this.t14.TabIndex = 15;
			this.t14.Tag = "13";
			this.t14.TickFrequency = 5;
			this.t14.TickStyle = System.Windows.Forms.TickStyle.Both;
			// 
			// t13
			// 
			this.t13.Location = new System.Drawing.Point(469, 18);
			this.t13.Maximum = 127;
			this.t13.Name = "t13";
			this.t13.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.t13.Size = new System.Drawing.Size(45, 159);
			this.t13.TabIndex = 14;
			this.t13.Tag = "12";
			this.t13.TickFrequency = 5;
			this.t13.TickStyle = System.Windows.Forms.TickStyle.Both;
			// 
			// t12
			// 
			this.t12.Location = new System.Drawing.Point(431, 18);
			this.t12.Maximum = 127;
			this.t12.Name = "t12";
			this.t12.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.t12.Size = new System.Drawing.Size(45, 159);
			this.t12.TabIndex = 13;
			this.t12.Tag = "11";
			this.t12.TickFrequency = 5;
			this.t12.TickStyle = System.Windows.Forms.TickStyle.Both;
			// 
			// t11
			// 
			this.t11.Location = new System.Drawing.Point(392, 18);
			this.t11.Maximum = 127;
			this.t11.Name = "t11";
			this.t11.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.t11.Size = new System.Drawing.Size(45, 159);
			this.t11.TabIndex = 12;
			this.t11.Tag = "10";
			this.t11.TickFrequency = 5;
			this.t11.TickStyle = System.Windows.Forms.TickStyle.Both;
			// 
			// t10
			// 
			this.t10.Location = new System.Drawing.Point(353, 18);
			this.t10.Maximum = 127;
			this.t10.Name = "t10";
			this.t10.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.t10.Size = new System.Drawing.Size(45, 159);
			this.t10.TabIndex = 11;
			this.t10.Tag = "9";
			this.t10.TickFrequency = 5;
			this.t10.TickStyle = System.Windows.Forms.TickStyle.Both;
			// 
			// t9
			// 
			this.t9.Location = new System.Drawing.Point(315, 18);
			this.t9.Maximum = 127;
			this.t9.Name = "t9";
			this.t9.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.t9.Size = new System.Drawing.Size(45, 159);
			this.t9.TabIndex = 10;
			this.t9.Tag = "8";
			this.t9.TickFrequency = 5;
			this.t9.TickStyle = System.Windows.Forms.TickStyle.Both;
			// 
			// t8
			// 
			this.t8.Location = new System.Drawing.Point(276, 18);
			this.t8.Maximum = 127;
			this.t8.Name = "t8";
			this.t8.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.t8.Size = new System.Drawing.Size(45, 159);
			this.t8.TabIndex = 9;
			this.t8.Tag = "7";
			this.t8.TickFrequency = 5;
			this.t8.TickStyle = System.Windows.Forms.TickStyle.Both;
			// 
			// t7
			// 
			this.t7.Location = new System.Drawing.Point(238, 18);
			this.t7.Maximum = 127;
			this.t7.Name = "t7";
			this.t7.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.t7.Size = new System.Drawing.Size(45, 159);
			this.t7.TabIndex = 8;
			this.t7.Tag = "6";
			this.t7.TickFrequency = 5;
			this.t7.TickStyle = System.Windows.Forms.TickStyle.Both;
			// 
			// t6
			// 
			this.t6.Location = new System.Drawing.Point(200, 18);
			this.t6.Maximum = 127;
			this.t6.Name = "t6";
			this.t6.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.t6.Size = new System.Drawing.Size(45, 159);
			this.t6.TabIndex = 7;
			this.t6.Tag = "5";
			this.t6.TickFrequency = 5;
			this.t6.TickStyle = System.Windows.Forms.TickStyle.Both;
			// 
			// t5
			// 
			this.t5.Location = new System.Drawing.Point(162, 18);
			this.t5.Maximum = 127;
			this.t5.Name = "t5";
			this.t5.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.t5.Size = new System.Drawing.Size(45, 159);
			this.t5.TabIndex = 6;
			this.t5.Tag = "4";
			this.t5.TickFrequency = 5;
			this.t5.TickStyle = System.Windows.Forms.TickStyle.Both;
			// 
			// t4
			// 
			this.t4.Location = new System.Drawing.Point(124, 18);
			this.t4.Maximum = 127;
			this.t4.Name = "t4";
			this.t4.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.t4.Size = new System.Drawing.Size(45, 159);
			this.t4.TabIndex = 5;
			this.t4.Tag = "3";
			this.t4.TickFrequency = 5;
			this.t4.TickStyle = System.Windows.Forms.TickStyle.Both;
			// 
			// t3
			// 
			this.t3.Location = new System.Drawing.Point(86, 18);
			this.t3.Maximum = 127;
			this.t3.Name = "t3";
			this.t3.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.t3.Size = new System.Drawing.Size(45, 159);
			this.t3.TabIndex = 4;
			this.t3.Tag = "2";
			this.t3.TickFrequency = 5;
			this.t3.TickStyle = System.Windows.Forms.TickStyle.Both;
			// 
			// t2
			// 
			this.t2.Location = new System.Drawing.Point(48, 18);
			this.t2.Maximum = 127;
			this.t2.Name = "t2";
			this.t2.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.t2.Size = new System.Drawing.Size(45, 159);
			this.t2.TabIndex = 3;
			this.t2.Tag = "1";
			this.t2.TickFrequency = 5;
			this.t2.TickStyle = System.Windows.Forms.TickStyle.Both;
			// 
			// t1
			// 
			this.t1.Location = new System.Drawing.Point(9, 18);
			this.t1.Maximum = 127;
			this.t1.Name = "t1";
			this.t1.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.t1.Size = new System.Drawing.Size(45, 159);
			this.t1.TabIndex = 2;
			this.t1.Tag = "0";
			this.t1.TickFrequency = 5;
			this.t1.TickStyle = System.Windows.Forms.TickStyle.Both;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(642, 203);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(79, 31);
			this.btnExit.TabIndex = 0;
			this.btnExit.Text = "Close";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.BtnExitClick);
			// 
			// pStatus
			// 
			this.pStatus.BackColor = System.Drawing.Color.LightSkyBlue;
			this.pStatus.Controls.Add(this.lTempo);
			this.pStatus.Controls.Add(this.lBeat);
			this.pStatus.Controls.Add(this.lTotal);
			this.pStatus.Location = new System.Drawing.Point(1128, 10);
			this.pStatus.Name = "pStatus";
			this.pStatus.Size = new System.Drawing.Size(102, 93);
			this.pStatus.TabIndex = 6;
			// 
			// lTempo
			// 
			this.lTempo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lTempo.ForeColor = System.Drawing.Color.Lime;
			this.lTempo.Location = new System.Drawing.Point(32, 25);
			this.lTempo.Name = "lTempo";
			this.lTempo.Size = new System.Drawing.Size(39, 23);
			this.lTempo.TabIndex = 5;
			this.lTempo.Text = "0";
			this.lTempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lBeat
			// 
			this.lBeat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lBeat.ForeColor = System.Drawing.Color.Red;
			this.lBeat.Location = new System.Drawing.Point(3, 50);
			this.lBeat.Name = "lBeat";
			this.lBeat.Size = new System.Drawing.Size(57, 23);
			this.lBeat.TabIndex = 2;
			this.lBeat.Text = "0:0";
			this.lBeat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lTotal
			// 
			this.lTotal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lTotal.ForeColor = System.Drawing.Color.Yellow;
			this.lTotal.Location = new System.Drawing.Point(60, 50);
			this.lTotal.Name = "lTotal";
			this.lTotal.Size = new System.Drawing.Size(39, 23);
			this.lTotal.TabIndex = 4;
			this.lTotal.Text = "0";
			this.lTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lClock
			// 
			this.lClock.BackColor = System.Drawing.Color.Transparent;
			this.lClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lClock.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lClock.ForeColor = System.Drawing.Color.Yellow;
			this.lClock.Location = new System.Drawing.Point(1033, 13);
			this.lClock.Name = "lClock";
			this.lClock.Size = new System.Drawing.Size(89, 23);
			this.lClock.TabIndex = 7;
			// 
			// TrackTimer
			// 
			this.TrackTimer.Interval = 300;
			this.TrackTimer.Tick += new System.EventHandler(this.TrackTimerTick);
			// 
			// pSoundfont
			// 
			this.pSoundfont.BackColor = System.Drawing.Color.Gainsboro;
			this.pSoundfont.Controls.Add(this.button2);
			this.pSoundfont.Controls.Add(this.button1);
			this.pSoundfont.Controls.Add(this.label1);
			this.pSoundfont.Controls.Add(this.cbSoundfont);
			this.pSoundfont.Location = new System.Drawing.Point(12, 261);
			this.pSoundfont.Name = "pSoundfont";
			this.pSoundfont.Size = new System.Drawing.Size(428, 216);
			this.pSoundfont.TabIndex = 8;
			this.pSoundfont.Visible = false;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(124, 87);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(3, 87);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(3, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "Soundfont";
			// 
			// cbSoundfont
			// 
			this.cbSoundfont.DisplayMember = "1";
			this.cbSoundfont.FormattingEnabled = true;
			this.cbSoundfont.Items.AddRange(new object[] {
									"F:\\Karaoke\\Li-keSing2.601.sf2"});
			this.cbSoundfont.Location = new System.Drawing.Point(3, 27);
			this.cbSoundfont.Name = "cbSoundfont";
			this.cbSoundfont.Size = new System.Drawing.Size(181, 21);
			this.cbSoundfont.TabIndex = 0;
			this.cbSoundfont.SelectedIndexChanged += new System.EventHandler(this.CbSoundfontSelectedIndexChanged);
			// 
			// openFile
			// 
			this.openFile.InitialDirectory = "D:\\ncn\\song";
			// 
			// grid
			// 
			this.grid.DataMember = "";
			this.grid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.grid.Location = new System.Drawing.Point(375, 279);
			this.grid.Name = "grid";
			this.grid.Size = new System.Drawing.Size(667, 265);
			this.grid.TabIndex = 9;
			this.grid.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(1242, 668);
			this.Controls.Add(this.grid);
			this.Controls.Add(this.pSoundfont);
			this.Controls.Add(this.lClock);
			this.Controls.Add(this.pStatus);
			this.Controls.Add(this.pCommand);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Name = "MainForm";
			this.Text = "Li-keSing.Net";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.Shown += new System.EventHandler(this.MainFormShown);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyUp);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainFormMouseMove);
			this.pCommand.ResumeLayout(false);
			this.pCommand.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tPosition)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tVolumn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.t16)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.t15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.t14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.t13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.t12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.t11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.t10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.t9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.t8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.t7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.t6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.t5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.t4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.t3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.t2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.t1)).EndInit();
			this.pStatus.ResumeLayout(false);
			this.pSoundfont.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGrid grid;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label lTempo;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.OpenFileDialog openFile;
		private System.Windows.Forms.ComboBox cbSoundfont;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel pSoundfont;
		private System.Windows.Forms.Button btnMin;
		private System.Windows.Forms.Timer TrackTimer;
		private System.Windows.Forms.TrackBar tVolumn;
		private System.Windows.Forms.Label in1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TrackBar tPosition;
		private System.Windows.Forms.TrackBar t1;
		private System.Windows.Forms.TrackBar t2;
		private System.Windows.Forms.TrackBar t3;
		private System.Windows.Forms.TrackBar t4;
		private System.Windows.Forms.TrackBar t5;
		private System.Windows.Forms.TrackBar t6;
		private System.Windows.Forms.TrackBar t7;
		private System.Windows.Forms.TrackBar t8;
		private System.Windows.Forms.TrackBar t9;
		private System.Windows.Forms.TrackBar t10;
		private System.Windows.Forms.TrackBar t11;
		private System.Windows.Forms.TrackBar t12;
		private System.Windows.Forms.TrackBar t13;
		private System.Windows.Forms.TrackBar t14;
		private System.Windows.Forms.TrackBar t15;
		private System.Windows.Forms.TrackBar t16;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Panel pCommand;
		private System.Windows.Forms.Panel pStatus;
		private System.Windows.Forms.Label lClock;
		private System.Windows.Forms.Label lTotal;
		private System.Windows.Forms.Label lBeat;
		private System.Windows.Forms.Timer LyricTimer;
		private System.Windows.Forms.Timer Timer;
		
	}
}
