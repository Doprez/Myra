/* Generated by MyraPad at 1/6/2021 1:18:58 PM */
using Myra;
using Myra.Graphics2D;
using Myra.Graphics2D.TextureAtlases;
using Myra.Graphics2D.UI;
using Myra.Graphics2D.Brushes;

#if MONOGAME || FNA
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#elif STRIDE
using Stride.Core.Mathematics;
#else
using System.Drawing;
using System.Numerics;
using Color = FontStashSharp.FSColor;
#endif

namespace Myra.Samples.AllWidgets
{
	partial class AllWidgets: VerticalStackPanel
	{
		private void BuildUI()
		{
			_menuItemOpenFile = new MenuItem();
			_menuItemOpenFile.Text = "&Open";
			_menuItemOpenFile.ShortcutText = "Ctrl+O";
			_menuItemOpenFile.Id = "_menuItemOpenFile";

			_menuItemSaveFile = new MenuItem();
			_menuItemSaveFile.Text = "&Save";
			_menuItemSaveFile.ShortcutText = "Ctrl+S";
			_menuItemSaveFile.Id = "_menuItemSaveFile";

			_menuItemChooseFolder = new MenuItem();
			_menuItemChooseFolder.Text = "Choose Fol&der";
			_menuItemChooseFolder.ShortcutText = "Ctrl+D";
			_menuItemChooseFolder.Id = "_menuItemChooseFolder";

			_menuItemChooseColor = new MenuItem();
			_menuItemChooseColor.Text = "Choose Co&lor";
			_menuItemChooseColor.ShortcutText = "Ctrl+L";
			_menuItemChooseColor.Id = "_menuItemChooseColor";

			var menuSeparator1 = new MenuSeparator();

			_menuItemQuit = new MenuItem();
			_menuItemQuit.Text = "&Quit";
			_menuItemQuit.ShortcutText = "Ctrl+Q";
			_menuItemQuit.Id = "_menuItemQuit";

			_menuFile = new MenuItem();
			_menuFile.Text = "&File";
			_menuFile.Id = "_menuFile";
			_menuFile.Items.Add(_menuItemOpenFile);
			_menuFile.Items.Add(_menuItemSaveFile);
			_menuFile.Items.Add(_menuItemChooseFolder);
			_menuFile.Items.Add(_menuItemChooseColor);
			_menuFile.Items.Add(menuSeparator1);
			_menuFile.Items.Add(_menuItemQuit);

			_menuItemCopy = new MenuItem();
			_menuItemCopy.Text = "&Copy";
			_menuItemCopy.ShortcutText = "Ctrl+Insert, Ctrl+C";
			_menuItemCopy.Id = "_menuItemCopy";

			_menuItemPaste = new MenuItem();
			_menuItemPaste.Text = "&Paste";
			_menuItemPaste.ShortcutText = "Shift+Insert, Ctrl+V";
			_menuItemPaste.Id = "_menuItemPaste";

			var menuSeparator2 = new MenuSeparator();

			_menuItemUndo = new MenuItem();
			_menuItemUndo.Text = "&Undo";
			_menuItemUndo.ShortcutText = "Ctrl+Z";
			_menuItemUndo.Id = "_menuItemUndo";

			_menuItemRedo = new MenuItem();
			_menuItemRedo.Text = "&Redo";
			_menuItemRedo.ShortcutText = "Ctrl+Y";
			_menuItemRedo.Id = "_menuItemRedo";

			_menuEdit = new MenuItem();
			_menuEdit.Text = "&Edit";
			_menuEdit.Id = "_menuEdit";
			_menuEdit.Items.Add(_menuItemCopy);
			_menuEdit.Items.Add(_menuItemPaste);
			_menuEdit.Items.Add(menuSeparator2);
			_menuEdit.Items.Add(_menuItemUndo);
			_menuEdit.Items.Add(_menuItemRedo);

			_menuItemAbout = new MenuItem();
			_menuItemAbout.Text = "&About";
			_menuItemAbout.Id = "_menuItemAbout";

			_menuHelp = new MenuItem();
			_menuHelp.Text = "&Help";
			_menuHelp.Id = "_menuHelp";
			_menuHelp.Items.Add(_menuItemAbout);

			_mainMenu = new HorizontalMenu();
			_mainMenu.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			_mainMenu.Id = "_mainMenu";
			_mainMenu.Items.Add(_menuFile);
			_mainMenu.Items.Add(_menuEdit);
			_mainMenu.Items.Add(_menuHelp);

			var label1 = new Label();
			label1.Text = "Button:";

			_buttonSaveFile = new ImageTextButton();
			_buttonSaveFile.Text = "Save File";
			_buttonSaveFile.Padding = new Thickness(8, 0);
			_buttonSaveFile.GridColumn = 1;
			_buttonSaveFile.Id = "_buttonSaveFile";

			_textSaveFile = new TextBox();
			_textSaveFile.GridColumn = 2;
			_textSaveFile.Id = "_textSaveFile";

			var label2 = new Label();
			label2.Text = "Another Button:";
			label2.GridRow = 1;

			_buttonOpenFile = new ImageTextButton();
			_buttonOpenFile.Text = "Open File";
			_buttonOpenFile.Padding = new Thickness(8, 0);
			_buttonOpenFile.GridColumn = 1;
			_buttonOpenFile.GridRow = 1;
			_buttonOpenFile.Id = "_buttonOpenFile";

			_textOpenFile = new TextBox();
			_textOpenFile.GridColumn = 2;
			_textOpenFile.GridRow = 1;
			_textOpenFile.Id = "_textOpenFile";

			var label3 = new Label();
			label3.Text = "Blue Button:";
			label3.GridRow = 2;

			_buttonChooseFolder = new ImageTextButton("blue");
			_buttonChooseFolder.Text = "Choose Folder";
			_buttonChooseFolder.Padding = new Thickness(8, 0);
			_buttonChooseFolder.GridColumn = 1;
			_buttonChooseFolder.GridRow = 2;
			_buttonChooseFolder.Id = "_buttonChooseFolder";

			_textChooseFolder = new TextBox();
			_textChooseFolder.GridColumn = 2;
			_textChooseFolder.GridRow = 2;
			_textChooseFolder.Id = "_textChooseFolder";

			_textButtonLabel = new Label();
			_textButtonLabel.Text = "Text Button:";
			_textButtonLabel.GridRow = 3;
			_textButtonLabel.Id = "_textButtonLabel";

			_buttonChooseColor = new TextButton();
			_buttonChooseColor.Text = "Choose Color";
			_buttonChooseColor.Padding = new Thickness(8, 0);
			_buttonChooseColor.GridColumn = 1;
			_buttonChooseColor.GridRow = 3;
			_buttonChooseColor.Id = "_buttonChooseColor";

			var label4 = new Label();
			label4.Text = "Image Button:";
			label4.GridRow = 4;

			_imageButton = new ImageButton();
			_imageButton.Padding = new Thickness(8, 0);
			_imageButton.GridColumn = 1;
			_imageButton.GridRow = 4;
			_imageButton.Id = "_imageButton";

			var checkBox1 = new CheckBox();
			checkBox1.Text = "This is checkbox";
			checkBox1.ImageWidth = 10;
			checkBox1.ImageHeight = 10;
			checkBox1.GridRow = 5;
			checkBox1.GridColumnSpan = 2;

			var label5 = new Label();
			label5.Text = "Horizontal Slider:";
			label5.GridRow = 6;

			var horizontalSlider1 = new HorizontalSlider();
			horizontalSlider1.GridColumn = 1;
			horizontalSlider1.GridRow = 6;
			horizontalSlider1.GridColumnSpan = 2;

			var label6 = new Label();
			label6.Text = "Combo Box:";
			label6.GridRow = 7;

			var listItem1 = new ListItem();
			listItem1.Text = "Red";
			listItem1.Color = Color.Red;

			var listItem2 = new ListItem();
			listItem2.Text = "Green";
			listItem2.Color = Color.Lime;

			var listItem3 = new ListItem();
			listItem3.Text = "Blue";
			listItem3.Color = new Color(0, 128, 255, 255);

			var comboBox1 = new ComboBox();
			comboBox1.Width = 200;
			comboBox1.GridColumn = 1;
			comboBox1.GridRow = 7;
			comboBox1.GridColumnSpan = 2;
			comboBox1.Items.Add(listItem1);
			comboBox1.Items.Add(listItem2);
			comboBox1.Items.Add(listItem3);

			var label7 = new Label();
			label7.Text = "Text Field:";
			label7.GridRow = 8;

			var textBox1 = new TextBox();
			textBox1.GridColumn = 1;
			textBox1.GridRow = 8;
			textBox1.GridColumnSpan = 2;

			var label8 = new Label();
			label8.Text = "Spin Button:";
			label8.GridRow = 9;

			var spinButton1 = new SpinButton();
			spinButton1.Value = 1;
			spinButton1.Width = 100;
			spinButton1.GridColumn = 1;
			spinButton1.GridRow = 9;

			var label9 = new Label();
			label9.Text = "List Box:";
			label9.GridRow = 10;

			var listItem4 = new ListItem();
			listItem4.Text = "Red";
			listItem4.Color = Color.Red;

			var listItem5 = new ListItem();
			listItem5.Text = "Green";
			listItem5.Color = Color.Lime;

			var listItem6 = new ListItem();
			listItem6.Text = "Blue";
			listItem6.Color = Color.Blue;

			var listBox1 = new ListBox();
			listBox1.Width = 200;
			listBox1.GridColumn = 1;
			listBox1.GridRow = 10;
			listBox1.GridColumnSpan = 2;
			listBox1.Items.Add(listItem4);
			listBox1.Items.Add(listItem5);
			listBox1.Items.Add(listItem6);

			var label10 = new Label();
			label10.Text = "Vertical Menu:";
			label10.GridRow = 11;

			var menuItem1 = new MenuItem();
			menuItem1.Text = "Start New Game";

			var menuItem2 = new MenuItem();
			menuItem2.Text = "Options";

			var menuItem3 = new MenuItem();
			menuItem3.Text = "Quit";

			var verticalMenu1 = new VerticalMenu();
			verticalMenu1.GridColumn = 1;
			verticalMenu1.GridRow = 11;
			verticalMenu1.Items.Add(menuItem1);
			verticalMenu1.Items.Add(menuItem2);
			verticalMenu1.Items.Add(menuItem3);

			var label11 = new Label();
			label11.Text = "Tree";
			label11.GridRow = 12;

			_gridRight = new Grid();
			_gridRight.ColumnSpacing = 8;
			_gridRight.RowSpacing = 8;
			_gridRight.DefaultRowProportion = new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			};
			_gridRight.ColumnsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			_gridRight.ColumnsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			_gridRight.ColumnsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			_gridRight.Id = "_gridRight";
			_gridRight.Widgets.Add(label1);
			_gridRight.Widgets.Add(_buttonSaveFile);
			_gridRight.Widgets.Add(_textSaveFile);
			_gridRight.Widgets.Add(label2);
			_gridRight.Widgets.Add(_buttonOpenFile);
			_gridRight.Widgets.Add(_textOpenFile);
			_gridRight.Widgets.Add(label3);
			_gridRight.Widgets.Add(_buttonChooseFolder);
			_gridRight.Widgets.Add(_textChooseFolder);
			_gridRight.Widgets.Add(_textButtonLabel);
			_gridRight.Widgets.Add(_buttonChooseColor);
			_gridRight.Widgets.Add(label4);
			_gridRight.Widgets.Add(_imageButton);
			_gridRight.Widgets.Add(checkBox1);
			_gridRight.Widgets.Add(label5);
			_gridRight.Widgets.Add(horizontalSlider1);
			_gridRight.Widgets.Add(label6);
			_gridRight.Widgets.Add(comboBox1);
			_gridRight.Widgets.Add(label7);
			_gridRight.Widgets.Add(textBox1);
			_gridRight.Widgets.Add(label8);
			_gridRight.Widgets.Add(spinButton1);
			_gridRight.Widgets.Add(label9);
			_gridRight.Widgets.Add(listBox1);
			_gridRight.Widgets.Add(label10);
			_gridRight.Widgets.Add(verticalMenu1);
			_gridRight.Widgets.Add(label11);

			var scrollViewer1 = new ScrollViewer();
			scrollViewer1.Content = _gridRight;

			var label12 = new Label();
			label12.Text = "Vertical Slider:";

			var verticalSlider1 = new VerticalSlider();
			verticalSlider1.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Center;
			verticalSlider1.GridRow = 1;

			var grid1 = new Grid();
			grid1.RowSpacing = 8;
			grid1.ColumnsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			grid1.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			grid1.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			grid1.Widgets.Add(label12);
			grid1.Widgets.Add(verticalSlider1);

			var label13 = new Label();
			label13.Text = "Progress Bars:";

			_horizontalProgressBar = new HorizontalProgressBar();
			_horizontalProgressBar.GridRow = 1;
			_horizontalProgressBar.Id = "_horizontalProgressBar";

			_verticalProgressBar = new VerticalProgressBar();
			_verticalProgressBar.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Center;
			_verticalProgressBar.GridRow = 2;
			_verticalProgressBar.Id = "_verticalProgressBar";

			var grid2 = new Grid();
			grid2.RowSpacing = 8;
			grid2.ColumnsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			grid2.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			grid2.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			grid2.RowsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			grid2.Widgets.Add(label13);
			grid2.Widgets.Add(_horizontalProgressBar);
			grid2.Widgets.Add(_verticalProgressBar);

			var verticalSplitPane1 = new VerticalSplitPane();
			verticalSplitPane1.Widgets.Add(grid1);
			verticalSplitPane1.Widgets.Add(grid2);

			var horizontalSplitPane1 = new HorizontalSplitPane();
			horizontalSplitPane1.Widgets.Add(scrollViewer1);
			horizontalSplitPane1.Widgets.Add(verticalSplitPane1);

			
			Spacing = 8;
			Proportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			Proportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			Widgets.Add(_mainMenu);
			Widgets.Add(horizontalSplitPane1);
		}

		
		public MenuItem _menuItemOpenFile;
		public MenuItem _menuItemSaveFile;
		public MenuItem _menuItemChooseFolder;
		public MenuItem _menuItemChooseColor;
		public MenuItem _menuItemQuit;
		public MenuItem _menuFile;
		public MenuItem _menuItemCopy;
		public MenuItem _menuItemPaste;
		public MenuItem _menuItemUndo;
		public MenuItem _menuItemRedo;
		public MenuItem _menuEdit;
		public MenuItem _menuItemAbout;
		public MenuItem _menuHelp;
		public HorizontalMenu _mainMenu;
		public ImageTextButton _buttonSaveFile;
		public TextBox _textSaveFile;
		public ImageTextButton _buttonOpenFile;
		public TextBox _textOpenFile;
		public ImageTextButton _buttonChooseFolder;
		public TextBox _textChooseFolder;
		public Label _textButtonLabel;
		public TextButton _buttonChooseColor;
		public ImageButton _imageButton;
		public Grid _gridRight;
		public HorizontalProgressBar _horizontalProgressBar;
		public VerticalProgressBar _verticalProgressBar;
	}
}
