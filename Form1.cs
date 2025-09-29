using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using NAudio.Wave;

namespace Piano;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        this.KeyPreview = true;
        this.KeyDown += Form1_KeyDown;
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.A)
        {
            e.Handled = true;
            button1.PerformClick();
        }
        if (e.KeyCode == Keys.S)
        {
            e.Handled = true;
            button2.PerformClick();
        }
        if (e.KeyCode == Keys.D)
        {
            e.Handled = true;
            button3.PerformClick();
        }
        if (e.KeyCode == Keys.F)
        {
            e.Handled = true;
            button4.PerformClick();
        }
        if (e.KeyCode == Keys.G)
        {
            e.Handled = true;
            button5.PerformClick();
        }
        if (e.KeyCode == Keys.H)
        {
            e.Handled = true;
            button6.PerformClick();
        }
        if (e.KeyCode == Keys.J)
        {
            e.Handled = true;
            button7.PerformClick();
        }
        if (e.KeyCode == Keys.W)
        {
            e.Handled = true;
            button8.PerformClick();
        }
        if (e.KeyCode == Keys.R)
        {
            e.Handled = true;
            button9.PerformClick();
        }
        if (e.KeyCode == Keys.T)
        {
            e.Handled = true;
            button10.PerformClick();
        }
        if (e.KeyCode == Keys.Y)
        {
            e.Handled = true;
            button11.PerformClick();
        }
        if (e.KeyCode == Keys.U)
        {
            e.Handled = true;
            button12.PerformClick();
        }


    }
    private async void button1_Click(object sender, EventArgs e)
    {
        using (var audioFile = new AudioFileReader(@"C:\Users\azamjon\Desktop\Apps\Piano\resources\do.mp3"))
        using (var outputDevice = new NAudio.Wave.WaveOutEvent())
        {
            outputDevice.Init(audioFile);
            outputDevice.Play();
            // Ожидание, пока звук проиграется
            while (outputDevice.PlaybackState == NAudio.Wave.PlaybackState.Playing)
            {
                await Task.Delay(1); // Пауза для предотвращения блокировки UI
            }
        }
    }

    private async void button2_Click(object sender, EventArgs e)
    {
        using (var audioFile = new AudioFileReader(@"C:\Users\azamjon\Desktop\Apps\Piano\resources\re.mp3"))
        using (var outputDevice = new NAudio.Wave.WaveOutEvent())
        {
            outputDevice.Init(audioFile);
            outputDevice.Play();
            // Ожидание, пока звук проиграется
            while (outputDevice.PlaybackState == NAudio.Wave.PlaybackState.Playing)
            {
                await Task.Delay(1); // Пауза для предотвращения блокировки UI
            }
        }
        

    }

    private async void button3_Click(object sender, EventArgs e)
    {
        using (var audioFile = new AudioFileReader(@"C:\Users\azamjon\Desktop\Apps\Piano\resources\mi.mp3"))
        using (var outputDevice = new NAudio.Wave.WaveOutEvent())
        {
            outputDevice.Init(audioFile);
            outputDevice.Play();
            // Ожидание, пока звук проиграется
            while (outputDevice.PlaybackState == NAudio.Wave.PlaybackState.Playing)
            {
                await Task.Delay(1); // Пауза для предотвращения блокировки UI
            }
        }
    }

    private async void button4_Click(object sender, EventArgs e)
    {
        using (var audioFile = new AudioFileReader(@"C:\Users\azamjon\Desktop\Apps\Piano\resources\fa.mp3"))
        using (var outputDevice = new NAudio.Wave.WaveOutEvent())
        {
            outputDevice.Init(audioFile);
            outputDevice.Play();
            // Ожидание, пока звук проиграется
            while (outputDevice.PlaybackState == NAudio.Wave.PlaybackState.Playing)
            {
                await Task.Delay(1); // Пауза для предотвращения блокировки UI
            }
        }

    }

    private async void button5_Click(object sender, EventArgs e)
    {
        using (var audioFile = new AudioFileReader(@"C:\Users\azamjon\Desktop\Apps\Piano\resources\sol.mp3"))
        using (var outputDevice = new NAudio.Wave.WaveOutEvent())
        {
            outputDevice.Init(audioFile);
            outputDevice.Play();
            // Ожидание, пока звук проиграется
            while (outputDevice.PlaybackState == NAudio.Wave.PlaybackState.Playing)
            {
                await Task.Delay(1); // Пауза для предотвращения блокировки UI
            }
        }
    }

    private async void button6_Click(object sender, EventArgs e)
    {
        using (var audioFile = new AudioFileReader(@"C:\Users\azamjon\Desktop\Apps\Piano\resources\lja.mp3"))
        using (var outputDevice = new NAudio.Wave.WaveOutEvent())
        {
            outputDevice.Init(audioFile);
            outputDevice.Play();
            // Ожидание, пока звук проиграется
            while (outputDevice.PlaybackState == NAudio.Wave.PlaybackState.Playing)
            {
                await Task.Delay(1); // Пауза для предотвращения блокировки UI
            }
        }
    }

    private async void button7_Click(object sender, EventArgs e)
    {
        using (var audioFile = new AudioFileReader(@"C:\Users\azamjon\Desktop\Apps\Piano\resources\si.mp3"))
        using (var outputDevice = new NAudio.Wave.WaveOutEvent())
        {
            outputDevice.Init(audioFile);
            outputDevice.Play();
            // Ожидание, пока звук проиграется
            while (outputDevice.PlaybackState == NAudio.Wave.PlaybackState.Playing)
            {
                await Task.Delay(1); // Пауза для предотвращения блокировки UI
            }
        }

    }

    private async void button8_Click(object sender, EventArgs e)
    {
        using (var audioFile = new AudioFileReader(@"C:\Users\azamjon\Desktop\Apps\Piano\resources\doA.mp3"))
        using (var outputDevice = new NAudio.Wave.WaveOutEvent())
        {
            outputDevice.Init(audioFile);
            outputDevice.Play();
            // Ожидание, пока звук проиграется
            while (outputDevice.PlaybackState == NAudio.Wave.PlaybackState.Playing)
            {
                await Task.Delay(1); // Пауза для предотвращения блокировки UI
            }
        }

    }

    private async void button9_Click(object sender, EventArgs e)
    {
        using (var audioFile = new AudioFileReader(@"C:\Users\azamjon\Desktop\Apps\Piano\resources\reA.mp3"))
        using (var outputDevice = new NAudio.Wave.WaveOutEvent())
        {
            outputDevice.Init(audioFile);
            outputDevice.Play();
            // Ожидание, пока звук проиграется
            while (outputDevice.PlaybackState == NAudio.Wave.PlaybackState.Playing)
            {
                await Task.Delay(1); // Пауза для предотвращения блокировки UI
            }
        }

    }

    private async void button10_Click(object sender, EventArgs e)
    {
        using (var audioFile = new AudioFileReader(@"C:\Users\azamjon\Desktop\Apps\Piano\resources\miA.mp3"))
        using (var outputDevice = new NAudio.Wave.WaveOutEvent())
        {
            outputDevice.Init(audioFile);
            outputDevice.Play();
            // Ожидание, пока звук проиграется
            while (outputDevice.PlaybackState == NAudio.Wave.PlaybackState.Playing)
            {
                await Task.Delay(1); // Пауза для предотвращения блокировки UI
            }
        }

    }

    private async void button11_Click(object sender, EventArgs e)
    {
        using (var audioFile = new AudioFileReader(@"C:\Users\azamjon\Desktop\Apps\Piano\resources\faA.mp3"))
        using (var outputDevice = new NAudio.Wave.WaveOutEvent())
        {
            outputDevice.Init(audioFile);
            outputDevice.Play();
            // Ожидание, пока звук проиграется
            while (outputDevice.PlaybackState == NAudio.Wave.PlaybackState.Playing)
            {
                await Task.Delay(1); // Пауза для предотвращения блокировки UI
            }
        }

    }

    private async void button12_Click(object sender, EventArgs e)
    {
        using (var audioFile = new AudioFileReader(@"C:\Users\azamjon\Desktop\Apps\Piano\resources\solA.mp3"))
        using (var outputDevice = new NAudio.Wave.WaveOutEvent())
        {
            outputDevice.Init(audioFile);
            outputDevice.Play();
            // Ожидание, пока звук проиграется
            while (outputDevice.PlaybackState == NAudio.Wave.PlaybackState.Playing)
            {
                await Task.Delay(1); // Пауза для предотвращения блокировки UI
            }
        }

    }

    private async void button13_Click(object sender, EventArgs e)
    {
        using (var audioFile = new AudioFileReader(@"C:\Users\azamjon\Desktop\Apps\Piano\resources\do-re-mi-fa-sol-lja-si.mp3"))
        using (var outputDevice = new NAudio.Wave.WaveOutEvent())
        {
            outputDevice.Init(audioFile);
            outputDevice.Play();
            // Ожидание, пока звук проиграется
            while (outputDevice.PlaybackState == NAudio.Wave.PlaybackState.Playing)
            {
                await Task.Delay(1); // Пауза для предотвращения блокировки UI
            }
        }

    }
}
