/*
 * Created by SharpDevelop.
 * User: kasem
 * Date: 20/8/2557
 * Time: 18:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;

using Un4seen.Bass;
using Un4seen.Bass.Misc;
using Un4seen.Bass.AddOn.Midi;

namespace Li_keSing.Net
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private string _folder="";
		private string _sffolder="";
		
		private int _stream;
		private float _ppqn=0f;
		private float _beat=0f;
		private int _totalDelta = 0;
		private int _tempo=0;
		private long _cPosition=0;
		private int _SFont=0;
		private string _songcode;
		private int _songrow;
		private int _delayhide=0;
		private string _searchsong="";
		private bool _command;
		private string _DBFileName=""; 
		private SQLiteConnection _conn;
		
		private DataSet _gds;
		const int hidetext = 5;
		
		private SYNCPROC myTempo,myTick;
		
		private static int a = 1;
		private static int b = 7;
		private static string c = "kjdzrekjmdo@hjüö.ahyxcn$0q15765";
		private static char[] d = new char[]
		{
			'a',
			'1',
			'q',
			'a',
			'x',
			'l',
			'-',
			'7',
			'u',
			'd',
			'3',
			'b',
			'2',
			'9',
			'n',
			'g',
			'f',
			'v',
			't',
			'j',
			'k',
			'5',
			'@',
			'e',
			'o',
			'p',
			'6',
			'/',
			's',
			'i',
			'8',
			'h',
			'w',
			'4',
			'y',
			'_',
			'0',
			'r',
			'$',
			'z'
		};
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void TimerTick(object sender, EventArgs e)
		{
			lClock.Text = DateTime.Now.ToString("HH:mm:ss");
			_delayhide++;			
			if (_delayhide == hidetext) {
				ClearScreen();
				_delayhide = 0;
				_searchsong = "";
			}
			Application.DoEvents();			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
//			EventManager.RegisterClassHandler(typeof(Window),Keyboard.KeyUpEvent,new KeyEventHandler(keyUp), true);
			this.MouseWheel += Form_MouseWheel;
			pStatus.Left = this.Width - pStatus.Width- 10;
			pSoundfont.Left = this.Width - pSoundfont.Width- 10;
			pSoundfont.Top = 10;
			lClock.Left = pStatus.Left - lClock.Size.Width-10;			
			_totalDelta = tVolumn.Value;
			
			_folder = "D:\\NCN\\Song\\";
			_sffolder = "D:\\SoundFont";
			_DBFileName ="D:\\Li-ke Sing\\Li-ke Sing\\Songlist.db";
				
			OpenDB(_DBFileName);
			initComponent();
			initBass();
		}
		
		void BtnExitClick(object sender, EventArgs e)
		{
			this.Close();
		}		
		
			
		void TVolumnScroll(object sender, EventArgs e)
		{
			SetVolumn();
		}
		
		void TrackTimerTick(object sender, EventArgs e)
		{
			long cPosition = Bass.BASS_ChannelGetPosition(_stream,BASSMode.BASS_POS_MIDI_TICK);
			tPosition.Value = (int)cPosition;
			Application.DoEvents();
//            float Beat = cPosition / _ppqn;
//            lBeat.Text = ((int)(Beat / 4)).ToString() + ":" + ((int)(Beat % 4) + 1).ToString();
		}
		
		
		public static bool ExitProgram(){
			DialogResult result = MessageBox.Show("ต้องการออกจากโปรแกรม ใช่หรือไม่", "ยืนยัน",	MessageBoxButtons.OKCancel);
        	if (result == DialogResult.OK)
            	return true;
        	else
            	return false;							
		}
				
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			if (ExitProgram() == true)
				this.Dispose(true);
			else
				e.Cancel = true;
		}
		
		void BtnMinClick(object sender, EventArgs e)
		{
			ActiveForm.WindowState = FormWindowState.Minimized;
		}
		
		void MainFormShown(object sender, EventArgs e)
		{

//			LoadSoundfont("F:\\Karaoke\\Li-keSing2.601.sf2");
			SetVolumn();
//			PlayMIDI("F:\\Karaoke\\NCN\\Song\\6\\61158.MID");
		}
		
		void TPositionMouseUp(object sender, MouseEventArgs e)
		{
				Bass.BASS_ChannelSetPosition(_stream,tPosition.Value,BASSMode.BASS_POS_MIDI_TICK);
//				_cPosition = Bass.BASS_ChannelGetPosition(_stream,BASSMode.BASS_POS_MIDI_TICK);
//				Bass.BASS_ChannelSetSync(_stream, BASSSync.BASS_SYNC_MIDI_TICK|BASSSync.BASS_SYNC_MIXTIME|BASSSync.BASS_SYNC_ONETIME, (long)tPosition.Value, myTick, IntPtr.Zero);

				TrackTimer.Enabled = true;
//				SetVolumn();
		}
		
		void TPositionMouseDown(object sender, MouseEventArgs e)
		{
//				Bass.BASS_SetVolume(0);	
			TrackTimer.Enabled = false;
		}
		

		void LyricTimerTick(object sender, EventArgs e)
		{
			lTempo.Text = _tempo.ToString();
			_cPosition = Bass.BASS_ChannelGetPosition(_stream,BASSMode.BASS_POS_MIDI_TICK);
			if (_cPosition / _ppqn != _beat) {
            	_beat = _cPosition / _ppqn;			
				lBeat.Text = ((int)(_beat / 4)).ToString() + ":" + ((int)(_beat % 4) + 1).ToString();	
			}
		}
		
		void CbSoundfontSelectedIndexChanged(object sender, EventArgs e)
		{
			_SFont = 0;
			LoadSoundfont(cbSoundfont.SelectedItem.ToString());
			BassMidi.BASS_MIDI_StreamLoadSamples(_stream);
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			openFile.ShowDialog();
			if (Bass.BASS_ChannelIsActive(_stream) == BASSActive.BASS_ACTIVE_PLAYING) {
				long cPosition = Bass.BASS_ChannelGetPosition(_stream,BASSMode.BASS_POS_MIDI_TICK);
				while ((cPosition / _ppqn) %4 != 1) {
					cPosition = Bass.BASS_ChannelGetPosition(_stream,BASSMode.BASS_POS_MIDI_TICK);
					Application.DoEvents();
				}
			} 
			Bass.BASS_ChannelSlideAttribute(_stream, BASSAttribute.BASS_ATTRIB_VOL, -1, 100);
			StopTimer();
			PlayMIDI(openFile.FileName);
			Bass.BASS_ChannelSlideAttribute(_stream, BASSAttribute.BASS_ATTRIB_VOL, 1, 100);
		}
		
		
		void Button2Click(object sender, EventArgs e)
		{
            string text = "Hello World!";
            Graphics g = this.CreateGraphics();
			g.SmoothingMode = SmoothingMode.HighQuality;
			g.CompositingQuality = CompositingQuality.HighQuality;
        	g.InterpolationMode = InterpolationMode.HighQualityBicubic;
        	
            var path = new GraphicsPath();

            path.AddString(text, new FontFamily("EucrosiaUPC"), (int)FontStyle.Bold, 90, new Point(10, 10), StringFormat.GenericDefault);
            g.FillPath(new SolidBrush(Color.White), path);

            Region r = new Region(path);
            RectangleF rect = r.GetBounds(g);
            RectangleF intersectRect = new RectangleF(rect.X, rect.Y, rect.Width * 75 / 100, rect.Height);
            r.Intersect(intersectRect);
            g.FillRegion(Brushes.Red, r);

            g.DrawPath(new Pen(Color.Black), path);			
		}
		
		//
		//
		//
		#region Subroutine
		//
		//
		//
			
		private void OpenDB(string DBFileName)
		{
			  _conn = new SQLiteConnection("Data Source=" + DBFileName + ";Version=3;");
			  _conn.Open();
		}

		private void CloseDB()
		{
			   _conn.Close();
		}
		
		private DataSet SearchDB(string keyword)
		{
//			const string filename = FileName;
			if (keyword.Length > 0)
			{
	            string sql = "select * from song";
	            sql += " where code like '" + keyword.Trim() +"%'";
	            sql += " or Name like '" + keyword.Trim() +"%'";
	            sql += " or Artist like '" + keyword.Trim() +"%'";
	            sql += " order by name,lyric,artist,code";

//	            string sql = "select * from song";
//	            sql += " where Name like '" + keyword.Trim() +"%'";
//	            sql += " or Artist like '" + keyword.Trim() +"%'";
//	            sql += " or Lyric like '" + keyword.Trim() +"%'";
//	            sql += " order by name,lyric,artist,code";				
	
				using (DataSet ds = new DataSet()) 
				{
				      using(SQLiteDataAdapter da = new SQLiteDataAdapter(sql, _conn))
				      {
						    da.Fill(ds);
						    if (ds.Tables[0].Rows.Count == 0) {
						    	
					            sql = "select * from song";
					            sql += " where lyric like'%" + keyword.Trim() +"%'";
					            sql += " order by lyric,name,artist,code";
						    	using(SQLiteDataAdapter daa = new SQLiteDataAdapter(sql,_conn))
						    	{
						    		daa.Fill(ds);
						    	}
						    }
		                  grid.DataSource = ds.Tables[0].DefaultView;
							_songrow = 0;
							return ds;
				      }
				}
			}
			return null;

		}
		
		private void DoSearchSong(DataSet ds)
		{
				ClearScreen();
				PrintText(_searchsong,10,10,36,3);	
				ShowSearchResult(ds.Tables[0],_songrow);
		}	
		
		private void ShowSearchResult(DataTable dt, int row)
		{
			string text="";
			if (dt.Rows.Count > 0 && row < dt.Rows.Count) {
				text = row.ToString() +":"+dt.Rows.Count.ToString() + "/" +dt.Rows[row]["Code"].ToString() + " : " + dt.Rows[row]["Name"].ToString() + " -> " + dt.Rows[row]["Artist"].ToString();
				_songcode = dt.Rows[row]["Code"].ToString().Trim();
				PrintText(text,10,45,32,3);
			}
		}
		
		private void PrintText(string text,int x,int y,int fontSize,int o)
		{
//			Graphics g = ScreenBG.CreateGraphics();
//			g.SmoothingMode = SmoothingMode.HighQuality;
//			g.CompositingQuality = CompositingQuality.HighQuality;
//        	g.InterpolationMode = InterpolationMode.HighQualityBicubic;
////        	var path = new GraphicsPath();
//			Font = new System.Drawing.Font("EucrosiaUPC", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((System.Byte)(0)));
//
//            
////		    using (Font myFont = new Font("EucrosiaUPC", 24))
////		    {
//		        //g.DrawString(text, myFont, Brushes.White, new Point(x, y));
//		        g.DrawString(text,Font,new SolidBrush( Color.FromArgb(128, Color.Black)), 10, 10, StringFormat.GenericTypographic );
//		        g.DrawString(text,Font,Brushes.White,10,10,StringFormat.GenericTypographic);
////		        path.AddString(text, new FontFamily("EucrosiaUPC"), (int)FontStyle.Bold, 90, new Point(10, 10), StringFormat.GenericTypographic);
////        	g.FillPath(new SolidBrush(Color.White), path);
////            g.DrawPath(new Pen(Color.Black), path);           
////		    }

//				float fontSize = 32;
				
				//some test image for this demo
				Graphics g = this.CreateGraphics();
				
				//this will center align our text at the bottom of the image
				StringFormat sf = new StringFormat();
				sf.Alignment = StringAlignment.Near;
				sf.LineAlignment = StringAlignment.Near;
				
				//define a font to use.
				Font f = new Font("EucrosiaUPC", fontSize, FontStyle.Bold, GraphicsUnit.Pixel);
				
				//pen for outline - set width parameter
				Pen p = new Pen(ColorTranslator.FromHtml("#FFFFFF"), o);
				p.LineJoin = LineJoin.Round; //prevent "spikes" at the path
				
				//this makes the gradient repeat for each text line
				Rectangle fr = new Rectangle(0, 0, this.Width, f.Height);
				LinearGradientBrush b = new LinearGradientBrush(fr,  
				                                                ColorTranslator.FromHtml("#FF6493"),
				                                                ColorTranslator.FromHtml("#D00F14"),
				                                                90);
				
				//this will be the rectangle used to draw and auto-wrap the text.
				//basically = image size
				Rectangle r = new Rectangle(x, y, this.Width, this.Height);
				
				GraphicsPath gp = new GraphicsPath();
				
				//look mom! no pre-wrapping!
				gp.AddString(text, 
				             f.FontFamily, (int)f.Style, fontSize, r, sf);
				
				//these affect lines such as those in paths. Textrenderhint doesn't affect
				//text in a path as it is converted to ..well, a path.    
				g.SmoothingMode = SmoothingMode.AntiAlias;
				g.PixelOffsetMode = PixelOffsetMode.HighQuality;
				
				//TODO: shadow -> g.translate, fillpath once, remove translate
				g.DrawPath(p, gp);
				g.FillPath(b, gp);
				
				//cleanup
				gp.Dispose();
				b.Dispose();
				b.Dispose();
				f.Dispose();
				sf.Dispose();
				g.Dispose();
		}
		
		void Form_MouseWheel(object sender, MouseEventArgs e)
		{
			if (_totalDelta >= 0 && _totalDelta <= 100) {
		    	_totalDelta = _totalDelta + e.Delta/120;
		    	if (_totalDelta < 0)
		    		_totalDelta = 0;
		    	if (_totalDelta > 100)
		    		_totalDelta = 100;
			}
		   	tVolumn.Value = _totalDelta;
		    SetVolumn();
		}
		
		private static int Finda(char A_0)
		{
			int result = 42;
			d[27] = c[2 + b + a * 2];
			char[] array = d;
			array[0] = c[4 * b - 3];
			array[38] = c[1 + 2 * b + a];
			array[2] = c[21];
			for (int i = 0; i < array.Length; i++)
			{
				if (A_0 == array[i])
				{
					result = i;
				}
			}
			return result;
		}
				
		private static string RegID(string A_0, char A_1)
		{
			string text = "2X";
			d[22] = A_1;
			if (A_0.Length > 5 && A_0.IndexOf('.', A_0.IndexOf('@')) > 0)
			{
				char[] array = A_0.ToLower().ToCharArray();
				int num = A_0.IndexOf("@");
				text += Finda(array[0]).ToString();
				text += Finda(array[1]).ToString();
				text += Finda(array[num - 1]).ToString();
				text += A_0.Length.ToString();
				text += Finda(array[num + 1]).ToString();
				text += Finda(array[num + 2]).ToString();
				text += Finda(array[A_0.Length - 1]).ToString();
			}
			return text;
		}
		
		private void initBass(){
			string myEmail = "freeware@forevery.one";
			string myReg = RegID(myEmail,'m');
			BassNet.Registration (myEmail, myReg);
			if (Bass.BASS_Init (-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero)) {
//				MessageBox.Show ("Bass initialized");				
			} else
				MessageBox.Show ("Bass initialized Error!!!");
		}
		
		private void LoadSoundfont(string FileName){
			// first initialize the fonts 
			if (_SFont == 0) {
				int font1 = BassMidi.BASS_MIDI_FontInit(FileName);
				if (font1 != _SFont) {
					BassMidi.BASS_MIDI_FontFree(_SFont);
					BASS_MIDI_FONT[] newfonts = new BASS_MIDI_FONT[1];
					newfonts[0] = new BASS_MIDI_FONT(font1, -1, 0);
					// now set them
					BassMidi.BASS_MIDI_StreamSetFonts(_stream, newfonts, 1);
					_SFont = font1;
				}
			}
		}
	
		private void SetReverb(){
				Bass.BASS_ChannelFlags(_stream, 0, BASSFlag.BASS_MIDI_NOFX);
				for(int i=0;i<16;i++) {
					if (i==9) {
						BassMidi.BASS_MIDI_StreamEvent(_stream,i,BASSMIDIEvent.MIDI_EVENT_DRUM_REVERB,30);
						BassMidi.BASS_MIDI_StreamEvent(_stream,i,BASSMIDIEvent.MIDI_EVENT_DRUM_LEVEL,100);
					} else {
						if (i==1){
							BassMidi.BASS_MIDI_StreamEvent(_stream,i,BASSMIDIEvent.MIDI_EVENT_REVERB,30);
							BassMidi.BASS_MIDI_StreamEvent(_stream,i,BASSMIDIEvent.MIDI_EVENT_REVERB_LEVEL,100);
						} else {
							BassMidi.BASS_MIDI_StreamEvent(_stream,i,BASSMIDIEvent.MIDI_EVENT_REVERB,100);
							BassMidi.BASS_MIDI_StreamEvent(_stream,i,BASSMIDIEvent.MIDI_EVENT_REVERB_LEVEL,60);						
						}
					}
					
				}
		}

		private void SetVolumn(){
			Bass.BASS_SetVolume((float)tVolumn.Value/1000);
		}
		
		private void SetSync(){
			myTempo = new SYNCPROC(TempoSyncProc);
			myTick = new SYNCPROC(TickSyncProc);
//			Bass.BASS_ChannelSetSync(_stream, BASSSync.BASS_SYNC_MIDI_TICK|BASSSync.BASS_SYNC_MIXTIME|BASSSync.BASS_SYNC_ONETIME, (long)_ppqn, myTick, IntPtr.Zero);
				Bass.BASS_ChannelSetSync(_stream, BASSSync.BASS_SYNC_MIDI_EVENT|BASSSync.BASS_SYNC_MIXTIME,(long)BASSMIDIEvent.MIDI_EVENT_TEMPO, myTempo, IntPtr.Zero);
//				Bass.BASS_ChannelSetSync(_stream, BASSSync.BASS_SYNC_MIDI_EVENT|BASSSync.BASS_SYNC_MIXTIME,(long)BASSMIDIEvent.MIDI_EVENT_NOTE, NoteSyncProc, (IntPtr)0);
//				Bass.BASS_ChannelSetSync(_stream, BASSSync.BASS_SYNC_MIDI_EVENT|BASSSync.BASS_SYNC_MIXTIME,(long)BASSMIDIEvent.MIDI_EVENT_NOTE, NoteSyncProc, (IntPtr)0);

		}	
		
		private void GetTempo(int handle)
		{

				int TTempo = BassMidi.BASS_MIDI_StreamGetEvent(handle, 0, BASSMIDIEvent.MIDI_EVENT_TEMPO);
				if (TTempo > 0) 
    			_tempo = (60000000 / TTempo);
//    			lTempo.Text = _tempo.ToString();

		}
		
		private void PlayMIDI(string FileName){
//				LoadSoundfont(cbSoundfont.SelectedItem.ToString());
				_stream = BassMidi.BASS_MIDI_StreamCreateFile(FileName,0,0, BASSFlag.BASS_MIDI_DECAYEND | BASSFlag.BASS_MIDI_DECAYSEEK | BASSFlag.BASS_MIDI_NOFX,1);
				if (_stream == 0) {
//					MessageBox.Show ("MIDI File Error!!");
					return;
				}
//				LoadSoundfont(cbSoundfont.SelectedItem.ToString());
				BassMidi.BASS_MIDI_StreamLoadSamples(_stream);
				
				long len = Bass.BASS_ChannelGetLength(_stream,BASSMode.BASS_POS_MIDI_TICK);
				
				Bass.BASS_ChannelGetAttribute(_stream, BASSAttribute.BASS_ATTRIB_MIDI_PPQN,ref _ppqn);

				tPosition.Maximum = (int)len;
				lTotal.Text = ((int)(len/_ppqn)/4).ToString();

				SetSync();

				Bass.BASS_ChannelPlay (_stream, false);	
//				SetReverb();
				StartTimer();
//				GetTempo(_stream);

		}
		
		private void StartTimer(){
			LyricTimer.Enabled = true;
			TrackTimer.Enabled = true;		
		}
		
		private void StopTimer(){
			LyricTimer.Enabled = false;
			TrackTimer.Enabled = false;		
		}
		
//		void PlaySong(){
//				_stream = Bass.BASS_StreamCreateFile ("d:\\เสรีย์ รุ่งสว่าง - แม่ไม้เพลงดัง - 05. คนกล่อมโลก.mp3", 0, 0, BASSFlag.BASS_DEFAULT);
//				if (_stream == 0) {
//					MessageBox.Show ("_stream error: ");
//					this.Close();
//				}
//				long len = Bass.BASS_ChannelGetLength(_stream);
//
//				tPosition.Maximum = (int)Bass.BASS_ChannelBytes2Seconds(_stream, len);
//				Bass.BASS_ChannelPlay (_stream, false);			
//		}
		
		private void initComponent(){
			string[] filePaths = Directory.GetFiles(_sffolder, "*.sf2");
			cbSoundfont.Items.Clear();
			foreach (string file in filePaths)
			{
			    cbSoundfont.Items.Add(file);
			}
			
			cbSoundfont.SelectedIndex = 0;
		}
		
		private void ClearScreen()
		{
//			this.Invalidate();
			this.Refresh();
		}
		#endregion
		
		#region Sync
		// the sync callback
		private void TickSyncProc(int handle, int channel, int data, IntPtr user)
		{
			_cPosition = Bass.BASS_ChannelGetPosition(_stream,BASSMode.BASS_POS_MIDI_TICK);
            _beat = _cPosition / _ppqn;
			Bass.BASS_ChannelSetSync(channel, BASSSync.BASS_SYNC_MIDI_TICK|BASSSync.BASS_SYNC_MIXTIME|BASSSync.BASS_SYNC_ONETIME, (long)_cPosition+(long)_ppqn, myTick, IntPtr.Zero);
		}

		private void NoteSyncProc(int handle, int channel, int data, IntPtr user)
		{
			int ch = channel / 65536;
			BassMidi.BASS_MIDI_StreamEvent(handle, ch, BASSMIDIEvent.MIDI_EVENT_MIXLEVEL, 0);
		}	

		private void TempoSyncProc(int handle, int channel, int data, IntPtr user)
		{
			GetTempo(_stream);
		}	
		
		private void VolumnSyncProc(int handle, int channel, int data, IntPtr user)
		{

		}
		#endregion
		
		void MainFormKeyPress(object sender, KeyPressEventArgs e)
		{
//			DataSet ds;
			switch ((int)e.KeyChar) {
					case 8: _searchsong = _searchsong.Substring(0,_searchsong.Length-1);
							break;
					case 27: ClearScreen(); _searchsong = "";
						break;
			}
		
			if (_searchsong.Length < 50 && (int)e.KeyChar > 32)
				_searchsong += e.KeyChar;
			e.Handled = true;			
		}
	
		
		void MainFormKeyUp(object sender, KeyEventArgs e)
		{
				switch((int)e.KeyCode) {
					case 13: //if (Bass.BASS_ChannelIsActive(_stream) == BASSActive.BASS_ACTIVE_PLAYING) {
	//										long cPosition = Bass.BASS_ChannelGetPosition(_stream,BASSMode.BASS_POS_MIDI_TICK);
	//										while ((cPosition / _ppqn) %4 != 1) {
	//											cPosition = Bass.BASS_ChannelGetPosition(_stream,BASSMode.BASS_POS_MIDI_TICK);
	//											Application.DoEvents();
	//										}
							Bass.BASS_ChannelSlideAttribute(_stream, BASSAttribute.BASS_ATTRIB_VOL, -1, 1000);
							StopTimer();
	//						} 
							PlayMIDI(_folder+_songcode.Substring(0,1)+"\\"+_songcode+".mid");
							Bass.BASS_ChannelSlideAttribute(_stream, BASSAttribute.BASS_ATTRIB_VOL, 1, 100); 
						break;
						case 39: if (_searchsong.Length > 0) {
									_songrow++;
									if (_songrow > _gds.Tables[0].Rows.Count) _songrow = _gds.Tables[0].Rows.Count-1;
								}
							break;
						case 37: if (_searchsong.Length > 0) {
								_songrow--;
								if(_songrow < 0) _songrow = 0; 
								}
							break;
				}
					
				
			if (_searchsong.Length > 0 && ((int)e.KeyCode != 39 && (int)e.KeyCode != 37))
					_gds = SearchDB(_searchsong);
				DoSearchSong(_gds);
				_delayhide = 0;						
				e.Handled = true;
		}
		
		void MainFormMouseMove(object sender, MouseEventArgs e)
		{
			if (e.X <= pCommand.Width+10 && e.Y <= pCommand.Height+10) {
				pCommand.Visible = true;
				_command = true;
			} else {
				pCommand.Visible = false;	
				if (_command == true) {
					_command = false;
					if (_searchsong.Length >0)
						PrintText(_searchsong,10,10,32,3);	
				}
			}
			if (e.X >=this.Width-pSoundfont.Width-10 && e.Y <= pSoundfont.Height+10)
				pSoundfont.Visible = true;
			else
				pSoundfont.Visible = false;				
		}
		

		
		void MainFormFormClosed(object sender, FormClosedEventArgs e)
		{
			CloseDB();
		}
	}
}
