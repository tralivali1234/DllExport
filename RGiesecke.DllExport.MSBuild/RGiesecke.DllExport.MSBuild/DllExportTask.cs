﻿// [Decompiled] Assembly: RGiesecke.DllExport.MSBuild, Version=1.2.1.28778, Culture=neutral, PublicKeyToken=ad5f9f4a55b5020b
// Author of original assembly (MIT-License): Robert Giesecke
// Use Readme & LICENSE files for details.

using System;
using System.Resources;
using System.Security.Permissions;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace RGiesecke.DllExport.MSBuild
{
    [PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
    public class DllExportTask: Task, IDllExportTask, IInputValues
    {
        private readonly ExportTaskImplementation<DllExportTask> _ExportTaskImplementation;

        public bool? SkipOnAnyCpu
        {
            get {
                return this._ExportTaskImplementation.SkipOnAnyCpu;
            }

            set {
                this._ExportTaskImplementation.SkipOnAnyCpu = value;
            }
        }

        public string TargetFrameworkVersion
        {
            get {
                return this._ExportTaskImplementation.TargetFrameworkVersion;
            }

            set {
                this._ExportTaskImplementation.TargetFrameworkVersion = value;
            }
        }

        public string Platform
        {
            get {
                return this._ExportTaskImplementation.Platform;
            }

            set {
                this._ExportTaskImplementation.Platform = value;
            }
        }

        public string PlatformTarget
        {
            get {
                return this._ExportTaskImplementation.PlatformTarget;
            }

            set {
                this._ExportTaskImplementation.PlatformTarget = value;
            }
        }

        public string CpuType
        {
            get {
                return this._ExportTaskImplementation.CpuType;
            }

            set {
                this._ExportTaskImplementation.CpuType = value;
            }
        }

        public string ProjectDirectory
        {
            get {
                return this._ExportTaskImplementation.ProjectDirectory;
            }

            set {
                this._ExportTaskImplementation.ProjectDirectory = value;
            }
        }

        public string AssemblyKeyContainerName
        {
            get {
                return this._ExportTaskImplementation.AssemblyKeyContainerName;
            }

            set {
                this._ExportTaskImplementation.AssemblyKeyContainerName = value;
            }
        }

        public int Timeout
        {
            get {
                return this._ExportTaskImplementation.Timeout;
            }

            set {
                this._ExportTaskImplementation.Timeout = value;
            }
        }

        public CpuPlatform Cpu
        {
            get {
                return this._ExportTaskImplementation.Cpu;
            }

            set {
                this._ExportTaskImplementation.Cpu = value;
            }
        }

        public bool EmitDebugSymbols
        {
            get {
                return this._ExportTaskImplementation.EmitDebugSymbols;
            }

            set {
                this._ExportTaskImplementation.EmitDebugSymbols = value;
            }
        }

        public string FileName
        {
            get {
                return this._ExportTaskImplementation.FileName;
            }

            set {
                this._ExportTaskImplementation.FileName = value;
            }
        }

        [Required]
        public string FrameworkPath
        {
            get {
                return this._ExportTaskImplementation.FrameworkPath;
            }

            set {
                this._ExportTaskImplementation.FrameworkPath = value;
            }
        }

        public string LibToolPath
        {
            get {
                return this._ExportTaskImplementation.LibToolPath;
            }

            set {
                this._ExportTaskImplementation.LibToolPath = value;
            }
        }

        public string LibToolDllPath
        {
            get {
                return this._ExportTaskImplementation.LibToolDllPath;
            }

            set {
                this._ExportTaskImplementation.LibToolDllPath = value;
            }
        }

        [Required]
        public string InputFileName
        {
            get {
                return this._ExportTaskImplementation.InputFileName;
            }

            set {
                this._ExportTaskImplementation.InputFileName = value;
            }
        }

        public string KeyContainer
        {
            get {
                return this._ExportTaskImplementation.KeyContainer;
            }

            set {
                this._ExportTaskImplementation.KeyContainer = value;
            }
        }

        public string KeyFile
        {
            get {
                return this._ExportTaskImplementation.KeyFile;
            }

            set {
                this._ExportTaskImplementation.KeyFile = value;
            }
        }

        public string OutputFileName
        {
            get {
                return this._ExportTaskImplementation.OutputFileName;
            }

            set {
                this._ExportTaskImplementation.OutputFileName = value;
            }
        }

        public string RootDirectory
        {
            get {
                return this._ExportTaskImplementation.RootDirectory;
            }

            set {
                this._ExportTaskImplementation.RootDirectory = value;
            }
        }

        [Required]
        public string SdkPath
        {
            get {
                return this._ExportTaskImplementation.SdkPath;
            }

            set {
                this._ExportTaskImplementation.SdkPath = value;
            }
        }

        public string DllExportAttributeFullName
        {
            get {
                return this._ExportTaskImplementation.DllExportAttributeFullName;
            }

            set {
                this._ExportTaskImplementation.DllExportAttributeFullName = value;
            }
        }

        public string DllExportAttributeAssemblyName
        {
            get {
                return this._ExportTaskImplementation.DllExportAttributeAssemblyName;
            }

            set {
                this._ExportTaskImplementation.DllExportAttributeAssemblyName = value;
            }
        }

        static DllExportTask()
        {
            AssemblyLoadingRedirection.EnsureSetup();
        }

        public DllExportTask()
        {
            this._ExportTaskImplementation = new ExportTaskImplementation<DllExportTask>(this);
        }

        public DllExportTask(ResourceManager taskResources)
        : base(taskResources)
        {
            this._ExportTaskImplementation = new ExportTaskImplementation<DllExportTask>(this);
        }

        public DllExportTask(ResourceManager taskResources, string helpKeywordPrefix)
        : base(taskResources, helpKeywordPrefix)
        {
            this._ExportTaskImplementation = new ExportTaskImplementation<DllExportTask>(this);
        }

        [CLSCompliant(false)]
        public AssemblyBinaryProperties InferAssemblyBinaryProperties()
        {
            return this._ExportTaskImplementation.InferAssemblyBinaryProperties();
        }

        public void InferOutputFile()
        {
            this._ExportTaskImplementation.InferOutputFile();
        }

        public override bool Execute()
        {
            return this._ExportTaskImplementation.Execute();
        }
    }
}
