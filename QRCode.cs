private void DrawQRCode()
	{
		try
		{
			int ActualRows = 0;
			int ActualCols = 0;
			int ActualWidth = 0;
			int ActualHeight = 0;
			Point p = new Point(0, 0);
			MW6QRCodeASPNet.QRCode qRCode = new MW6QRCodeASPNet.QRCode();
			qRCode.BackColor = Color.FromName("White");
			qRCode.BarColor = Color.FromName("Black");
			qRCode.Data = _qr;
			qRCode.Level = enumLevel.lvL;
			qRCode.Mask = enumMask.mkAuto;
			qRCode.Orientation = enumOrientation.or0;
			qRCode.Version = enumVersion.vrAuto;
			qRCode.ModuleSize = 0.07f;
			qRCode.GetActualRC(ref ActualRows, ref ActualCols);
			qRCode.GetActualSize(ref ActualWidth, ref ActualHeight);
			qRCode.SetSize(ActualWidth, ActualHeight);
			Bitmap bitmap = new Bitmap(ActualWidth, ActualHeight);
			Graphics graphics = Graphics.FromImage(bitmap);
			qRCode.Render(graphics, p);
			graphics.Flush();
			_qrCodeBMP = bitmap;
		}
		catch
		{
		}
	}