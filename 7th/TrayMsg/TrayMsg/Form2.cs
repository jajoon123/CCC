using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace TrayMsg
{
    public partial class Form2 : Form
    {
        public Form2()
        {

            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 20; // 스크린의 가로위치 //좌표값으로 지정해줘야함 위치를 어케잡아야하냐  디자인 속성에서 오른아래에 배치한다고 만듬
            int y = Screen.PrimaryScreen.WorkingArea.Height - this.Height; // 스크린의 세로위치

            DesktopLocation = new Point(x, y); //폼의 위치 설정 //x,y위치잡았으니 데스크탑의 위치 잡아준다 
            this.Size = new Size(170, 0); //폼의 크기 설정 //초기값 왜? 숨겨져있다 너비 170만 있고 높이는 아직 지정안한상태로 

            InitializeComponent();
        }

        private static System.Timers.Timer TimerEvent; //Timer 개체 생성  

        public string MsgText //이 속성에 대한 정의를 내려야한다 //대문자(M) 시작 set을 통해 값을 파라미터로 읽어와 lblResult에 할당,텍스트를 가져와 그대로 여기에 표시해준다 . 
        {
            set
            { 
                this.lblResult.Text = value;
            }
        }

        private delegate void OnDelegateHeight(int Flag); //델리게이트 선언

        private OnDelegateHeight OnHeight = null; //델리게이트 개체 생성

        private void lblResult_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            TimerEvent.Stop();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            OnHeight = new OnDelegateHeight(MsgView);

            this.Size = new System.Drawing.Size(170, 0);
            this.Location = new System.Drawing.Point(
                Screen.PrimaryScreen.WorkingArea.Width - this.Width - 20,
                Screen.PrimaryScreen.WorkingArea.Height - this.Height
            );

            TimerEvent = new System.Timers.Timer(2);
            TimerEvent.Elapsed += new ElapsedEventHandler(OnPopUp);
            TimerEvent.Start();
        }

        private void MsgView(int Flag) //왜 이렇게 되는지 이해하기
        {
            if (Flag == 0)
            {
                Height++;
                Top--;
            }
            else if (Flag == 1)
            {
                Height--;
                Top++;
            }
            else if (Flag == 2)
            {
                this.Close();
            }
        }

        private void OnPopUp(object sender, ElapsedEventArgs e)
        {
            if (Height < 120)
            {
                Invoke(OnHeight, 0);
            }
            else
            {
                TimerEvent.Stop();
                TimerEvent.Elapsed -= new ElapsedEventHandler(OnPopUp);
                TimerEvent.Elapsed += new ElapsedEventHandler(OnPopOut);
                TimerEvent.Interval = 3000;
                TimerEvent.Start();
            }
            Application.DoEvents();
        }

        private void OnPopOut(object sender, ElapsedEventArgs e)
        {
            while (Height > 2)
            {
                Invoke(OnHeight, 1);
            }
            TimerEvent.Stop();
            Application.DoEvents();
            Invoke(OnHeight, 2);
        }

    }
}
