using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinionMaster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static bool botIsRunning;


        public void startNewThread()
        {
            // Run the botmethods in a different thread, then the UI won't freeze.
            // this starts the above method
            Thread botMethod = new Thread(mainTrainerMethod);
            botMethod.Start();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            botIsRunning = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            botIsRunning = true;
            startNewThread();
        }

        IntPtr baseAddressNvwgf2 = IntPtr.Zero;
        IntPtr baseAddressMono = IntPtr.Zero;
        public void mainTrainerMethod() // Focus world of warcraft windows
        {
            // nvwgf2umx.dll+19BE230
            var dummyprocess = Process.GetProcesses();
            var prc = Process.GetProcessesByName("MinionMasters");
            if (prc.Length > 0)
            {
                Process mainProcess = prc[0];
                foreach (ProcessModule module in mainProcess.Modules)
                {
                    if (module.ModuleName.Contains("nvwgf2umx"))
                    {
                        baseAddressNvwgf2 = module.BaseAddress;
                    }
                    if (module.ModuleName.Contains("mono"))
                    {
                        baseAddressMono = module.BaseAddress;
                    }
                }


                VAMemory vMemory = new VAMemory("MinionMasters");

                while (botIsRunning)
                {
                    IntPtr handle = new IntPtr(Convert.ToInt64(txtEnemyHealthAddr.Text, 16));
                    int enemyXp = vMemory.ReadInt32(handle);
                    Invoke(new Action(() =>
                    {
                        lblHealth.Text = enemyXp.ToString();

                    }));
                    if (enemyXp > 50)
                        vMemory.WriteInt32(handle, enemyXp - 50);
                    ////nvwgf2umx.dll+19BE230
                    //int totalXpAddress = vMemory.ReadInt32((IntPtr)baseAddressNvwgf2 + 0x19BE230);

                    ////nvwgf2umx.dll + 19BE240
                    //int totalXpAddress2 = vMemory.ReadInt32((IntPtr)baseAddressNvwgf2 + 0x19BE240);

                    //long xpP1 = vMemory.ReadLong((IntPtr)baseAddressMono + 0x2691D0);
                    //long xpP2 = vMemory.ReadLong((IntPtr)xpP1 + 0x0);
                    //long xpP3 = vMemory.ReadLong((IntPtr)xpP2 + 0x70);
                    //long xpP4 = vMemory.ReadLong((IntPtr)xpP3 + 0x88);
                    //long xpP5 = vMemory.ReadLong((IntPtr)xpP4 + 0x160);
                    //long xpP6 = vMemory.ReadLong((IntPtr)xpP5 + 0xd8);
                    //long xpP7 = vMemory.ReadLong((IntPtr)xpP6 + 0x0);
                    //long xpActual = vMemory.ReadInt32((IntPtr)xpP7 + 0x198);


                    //Invoke(new Action(() =>
                    //{
                    //    lblActualXp.Text = xpActual.ToString();
                    //    lblTotalXp.Text = totalXpAddress.ToString();
                    //}));

                    //if (chkLevelUpEachMatch.Checked)
                    //{
                    //    vMemory.WriteInt32((IntPtr)xpP7 + 0x198, totalXpAddress - 1);
                    //}

                    Thread.Sleep(3000);
                }



                //while (botIsRunning)
                //{
                //    //nvwgf2umx.dll+19BE230
                //    int totalXpAddress = vMemory.ReadInt32((IntPtr)baseAddressNvwgf2 + 0x19BE230);

                //    //nvwgf2umx.dll + 19BE240
                //    int totalXpAddress2 = vMemory.ReadInt32((IntPtr)baseAddressNvwgf2 + 0x19BE240);

                //    long xpP1 = vMemory.ReadLong((IntPtr)baseAddressMono + 0x2691D0); 
                //    long xpP2 = vMemory.ReadLong((IntPtr)xpP1 + 0x0);
                //    long xpP3 = vMemory.ReadLong((IntPtr)xpP2 + 0x70);
                //    long xpP4 = vMemory.ReadLong((IntPtr)xpP3 + 0x88);
                //    long xpP5 = vMemory.ReadLong((IntPtr)xpP4 + 0x160);
                //    long xpP6 = vMemory.ReadLong((IntPtr)xpP5 + 0xd8);
                //    long xpP7 = vMemory.ReadLong((IntPtr)xpP6 + 0x0);
                //    long xpActual = vMemory.ReadInt32((IntPtr)xpP7 + 0x198);


                //    Invoke(new Action(() =>
                //    {
                //        lblActualXp.Text  = xpActual.ToString();
                //        lblTotalXp.Text  = totalXpAddress.ToString();
                //    }));

                //    if(chkLevelUpEachMatch.Checked)
                //    {
                //        vMemory.WriteInt32((IntPtr)xpP7 + 0x198, totalXpAddress - 1);
                //    }

                //    Thread.Sleep(2000);
                //}

            }
            else
                MessageBox.Show("LC2 window not found");

        }

        private float SetHealth(VAMemory vMemory, int healthFinalAddress, float healthOriginal)
        {
            float health = vMemory.ReadFloat((IntPtr)healthFinalAddress + 0x18); // 808 // 288
            Invoke(new Action(() =>
            {
                lblHealth.Text = health.ToString();
            }));
            if (chkHealth.Checked)
            {
                if (health > healthOriginal)
                {
                    healthOriginal = health;
                }

                vMemory.WriteFloat((IntPtr)healthFinalAddress + 0x18, healthOriginal); // 808 // 288
            }
            else
            {
                healthOriginal = health;
            }

            return healthOriginal;
        }

        private int SetAmmo(VAMemory vMemory, int ammoP2, int ammoOriginal)
        {
            int ammo = vMemory.ReadInt32((IntPtr)ammoP2 + 0x8); // 808 // 288
            Invoke(new Action(() =>
            {
                lblActualXp.Text = ammo.ToString();
            }));
            if (chkLevelUpEachMatch.Checked)
            {
                if (ammo > ammoOriginal)
                {
                    ammoOriginal = ammo;
                }

                vMemory.WriteInt32((IntPtr)ammoP2 + 0x8, ammoOriginal); // 808 // 288
            }
            else
            {
                ammoOriginal = ammo;
            }

            return ammoOriginal;
        }

     
    }
}
