using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace izotov12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[,] ratesOfTransitions = new double[3, 3] { 
                                                          {-0.4, 0.3, 0.1 },
                                                          {0.4, -0.8, 0.4 },
                                                          {0.1, 0.4, -0.5 }
                                                        };
        double[] duration = new double[3] {0, 0, 0};
        double[,] initialProbabilities = new double[3, 3];
        double[] calcFrequencies = new double[3] {0, 0, 0};
        string[] weatherConditions = new string[3] { "Clear", "Cloudy", "Overcast" };

        int N;
        int count = 0;

        int HoursInADay = 24;
        int day = 0;
        int hour = 0;
        double fullTime = 0;
        int curConditionLifeTime = 0;
        int dtInHours;

        int curCondition = 0;

        int clickOnPause = 0;

        private void btStart_Click(object sender, EventArgs e)
        {
            if (clickOnPause == 0)
            {
                N = (int)NumOfIterations.Value;

                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                    {
                        if (i == j)
                            initialProbabilities[i, j] = 0;
                        else
                            initialProbabilities[i, j] = ratesOfTransitions[i, j] / -ratesOfTransitions[i, i];

                    }

                GetNextCondition();
            }

            timer1.Start();
        }

        private void btPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            clickOnPause = 1;

            for (int i = 0; i < 3; i++)
                calcFrequencies[i] = Math.Round(fullTime / duration[i], 3);

            lbClearDur.Text = duration[0].ToString();
            lbCloudyDur.Text = duration[1].ToString();
            lbOvercastDur.Text = duration[2].ToString();
            lbClearFreq.Text = calcFrequencies[0].ToString();
            lbCloudyFreq.Text = calcFrequencies[1].ToString();
            lbOvercastFreq.Text = calcFrequencies[2].ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(count >= N)
            {
                timer1.Stop();

                for (int i = 0; i < 3; i++)
                    calcFrequencies[i] = fullTime / duration[i];

                lbClearDur.Text = duration[0].ToString();
                lbCloudyDur.Text = duration[1].ToString();
                lbOvercastDur.Text = duration[2].ToString();
                lbClearFreq.Text = Math.Round(calcFrequencies[0], 3).ToString();
                lbCloudyFreq.Text = Math.Round(calcFrequencies[1], 3).ToString();
                lbOvercastFreq.Text = Math.Round(calcFrequencies[2], 3).ToString();
            }

            hour += 1;
            if(hour == 24)
            {
                day += 1;
                hour = 0;
                lbDay.Text = day.ToString();
            }
            lbHour.Text = hour.ToString();

            curConditionLifeTime++;
            if(curConditionLifeTime >= dtInHours)
            {
                lbWeather.Text = weatherConditions[curCondition];
                GetNextCondition();
                curConditionLifeTime = 0;

            }
        }

        private void GetNextCondition()
        {
            Random random = new Random();
            double a = random.NextDouble();

            double dt = Math.Log(a) / ratesOfTransitions[curCondition, curCondition];
            fullTime += Math.Round(dt, 3);
            duration[curCondition] += Math.Round(dt, 3);
            dtInHours = (int)(dt * HoursInADay);

            int k = 0;
            do
            {
                a -= initialProbabilities[curCondition, k];
                k++;
            }
            while (a > 0);

            curCondition = k - 1;

            count++;
            lbCurIter.Text = count.ToString();
        }
    }
}
