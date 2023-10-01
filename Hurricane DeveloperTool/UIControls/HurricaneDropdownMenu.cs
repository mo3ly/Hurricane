﻿using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Hurricane_DeveloperTool.HurricaneControls
{
    public class HurricaneDropdownMenu : ContextMenuStrip
    {
        private bool isMainMenu;
        private int menuItemHeight = 20;
        private Color menuItemTextColor = Color.Empty;//No color, The default color is set in the MenuRenderer class
        private Color primaryColor = Color.Empty;//No color, The default color is set in the MenuRenderer class

        private Bitmap menuItemHeaderSize;

        //Constructor
        public HurricaneDropdownMenu(IContainer container)
            : base(container)
        {

        }

        public HurricaneDropdownMenu()
        {

        }

        //Properties
        //Optionally, hide the properties in the toolbox to avoid the problem of displaying and/or 
        //saving control property changes in the designer at design time in Visual Studio.
        //If the problem I mention does not occur you can expose the properties and manipulate them from the toolbox.
        [Browsable(false)]
        public bool IsMainMenu
        {
            get { return isMainMenu; }
            set { isMainMenu = value; }
        }

        [Browsable(false)]
        public int MenuItemHeight
        {
            get { return menuItemHeight; }
            set { menuItemHeight = value; }
        }

        [Browsable(false)]
        public Color MenuItemTextColor
        {
            get { return menuItemTextColor; }
            set { menuItemTextColor = value; }
        }

        [Browsable(false)]
        public Color PrimaryColor
        {
            get { return primaryColor; }
            set { primaryColor = value; }
        }


        private void LoadMenuItemHeight()
        {
            if (isMainMenu)
                menuItemHeaderSize = new Bitmap(25, menuItemHeight);
            else menuItemHeaderSize = new Bitmap(20, menuItemHeight);

            foreach (ToolStripMenuItem menuItemL1 in Items)
            {
                menuItemL1.ImageScaling = ToolStripItemImageScaling.None;
                if (menuItemL1.Image == null) menuItemL1.Image = menuItemHeaderSize;

                foreach (ToolStripMenuItem menuItemL2 in menuItemL1.DropDownItems)
                {
                    menuItemL2.ImageScaling = ToolStripItemImageScaling.None;
                    if (menuItemL2.Image == null) menuItemL2.Image = menuItemHeaderSize;

                    foreach (ToolStripMenuItem menuItemL3 in menuItemL2.DropDownItems)
                    {
                        menuItemL3.ImageScaling = ToolStripItemImageScaling.None;
                        if (menuItemL3.Image == null) menuItemL3.Image = menuItemHeaderSize;

                        foreach (ToolStripMenuItem menuItemL4 in menuItemL3.DropDownItems)
                        {
                            menuItemL4.ImageScaling = ToolStripItemImageScaling.None;
                            if (menuItemL4.Image == null) menuItemL4.Image = menuItemHeaderSize;
                            ///Level 5++
                        }
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (DesignMode == false)
            {
                Renderer = new HurricaneMenuRenderer(isMainMenu, primaryColor, menuItemTextColor);
                LoadMenuItemHeight();
            }
        }
    }
}
