﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dnn.vNext.Data
{
    public class Package
    {
        [Key]
/*PK*/  public int PackageId { get; set; }
        public int? PortalId { get; set; }
        public string Name { get; set; }
        public string FriendlyName { get; set; }
        public string Description { get; set; }
        
        // AH - Since this FK doesn't follow convention of having an Id
        // at the end we need to specify the ForeignKey Navigation property
        // the parameter here *has* to match the property name below
        [ForeignKey("PackageTypeNavigation")]
/*FK*/  public string PackageType { get; set; }

        public string Version { get; set; }
        public string License { get; set; }
        public string Manifest { get; set; }
        public string Owner { get; set; }
        public string Organization { get; set; }
        public string Url { get; set; }
        public string Email { get; set; }
        public string ReleaseNotes { get; set; }
        public bool IsSystemPackage { get; set; }
        public int? CreatedByUserId { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public string FolderName { get; set; }
        public string IconFile { get; set; }

                
        public virtual Package_Type PackageTypeNavigation { get; set; }
        public virtual ICollection<Assembly> Assemblies { get; set; }
        public virtual ICollection<SkinPackage> SkinPackage { get; set; }
        public virtual ICollection<JavascriptLibrary> JavascriptLibrary { get; set; }
        public virtual ICollection<LanguagePack> LanguagePack { get; set; }
        public virtual ICollection<SkinControl> SkinControl { get; set; }
        public virtual ICollection<DesktopModule> DesktopModule { get; set; }
        public virtual ICollection<PackageDependency> PackageDependency { get; set; }
        public virtual ICollection<Authentication> Authentications { get; set; }        
    }
}
