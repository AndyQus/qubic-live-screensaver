using Microsoft.Web.WebView2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace qubic_live_screensaver
{
    public class WebForm : Form
    {
        private WebView2 webView;
        private Button closeButton;

        public WebForm()
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            BackColor = Color.Black;

            webView = new WebView2
            {
                Dock = DockStyle.Fill
            };

            Controls.Add(webView);

            // Close Button
            closeButton = new Button
            {
                Text = "Close",
                BackColor = Color.Red,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(100, 40),
                Location = new Point(ClientSize.Width - 110, 10) // Position oben rechts
            };
            closeButton.Click += (sender, e) => Application.Exit();
            Controls.Add(closeButton);

            // Button in den Vordergrund bringen
            closeButton.BringToFront();

            Load += WebForm_Load;
            KeyDown += (_, __) => Application.Exit();
            MouseMove += (_, __) => Application.Exit();
            Resize += WebForm_Resize; // Für dynamische Positionierung des Buttons
        }

        private async void WebForm_Load(object? sender, EventArgs e)
        {
            await webView.EnsureCoreWebView2Async();
            webView.Source = new Uri("https://live.qubic.org");

            // Button nach dem Laden der Webseite in den Vordergrund bringen
            closeButton.BringToFront();
        }

        private void WebForm_Resize(object? sender, EventArgs e)
        {
            // Button-Position anpassen, wenn die Fenstergröße geändert wird
            closeButton.Location = new Point(ClientSize.Width - 110, 10);
            closeButton.BringToFront(); // Sicherstellen, dass der Button sichtbar bleibt
        }
    }
}