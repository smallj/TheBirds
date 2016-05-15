using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TheBirds
{
    public partial class MainWindow
    {
        private void moveButton_Click(object sender, RoutedEventArgs e)
        {
            Penguin penguin = new Penguin();
            Hawk hawk = new Hawk();
            Robin robin = new Robin();
            Crow crow = new Crow();

            //Start world
            World.tempurature = 20;
            World.windSpeed = 12;

            temperatureValue.Content = World.tempurature.ToString();
            windValue.Content = World.windSpeed.ToString();

            penguin.hop();
            penguin.fly();

            hawk.hop();
            hawk.fly();

            robin.hop();
            robin.fly();

            crow.hop();
            crow.fly();

            //Storm
            World.tempurature = -10;
            World.windSpeed = 30;

            temperatureValue.Content = World.tempurature.ToString();
            windValue.Content = World.windSpeed.ToString();

            penguin.hop();

            hawk.hop();
            hawk.fly();

            robin.hop();
            robin.fly();

            crow.hop();
            crow.fly();

            //Print distances
            result.Items.Add(String.Format("The penguin moved {0} ft.", penguin.getDistanceTravled));
            result.Items.Add(String.Format("The hawk moved {0} ft.", hawk.getDistanceTravled));
            result.Items.Add(String.Format("The robin moved {0} ft.", robin.getDistanceTravled));
            result.Items.Add(String.Format("The crow moved {0} ft.", crow.getDistanceTravled));
        }
    }
}
