﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace OTALogService
{
    [RunInstaller(true)]
    public partial class OTALogServiceInstaller : System.Configuration.Install.Installer
    {
        public OTALogServiceInstaller()
        {
            InitializeComponent();
        }
    }
}
