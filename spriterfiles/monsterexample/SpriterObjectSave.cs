﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.17929.
// 


/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class key {
    
    private keyBone_ref[] bone_refField;
    
    private keyObject_ref[] object_refField;
    
    private keyObject[] objectField;
    
    private keyBone[] boneField;
    
    private int idField;
	
    private int timeField;
       
    private int spinField;
        /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("bone_ref", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public keyBone_ref[] bone_ref {
        get {
            return this.bone_refField;
        }
        set {
            this.bone_refField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("object_ref", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public keyObject_ref[] object_ref {
        get {
            return this.object_refField;
        }
        set {
            this.object_refField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("object", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public keyObject[] @object {
        get {
            return this.objectField;
        }
        set {
            this.objectField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("bone", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public keyBone[] bone {
        get {
            return this.boneField;
        }
        set {
            this.boneField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int time {
        get {
            return this.timeField;
        }
        set {
            this.timeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int spin {
        get {
            return this.spinField;
        }
        set {
            this.spinField = value;
        }
    }    
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class keyBone_ref {
    
    private int idField;
        
    private int timelineField;
    
    private int keyField;
    
    private int parentField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int timeline {
        get {
            return this.timelineField;
        }
        set {
            this.timelineField = value;
        }
    }
        
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int key {
        get {
            return this.keyField;
        }
        set {
            this.keyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int parent {
        get {
            return this.parentField;
        }
        set {
            this.parentField = value;
        }
    }
}

[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class keyObject_ref {
    
    private int idField;
        
    private int parentField;
    
    private int timelineField;
    
    private int keyField;
    
    private int z_indexField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int parent {
        get {
            return this.parentField;
        }
        set {
            this.parentField = value;
        }
    }
    
	/// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int timeline {
        get {
            return this.timelineField;
        }
        set {
            this.timelineField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int key {
        get {
            return this.keyField;
        }
        set {
            this.keyField = value;
        }
    }
    
	/// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int z_index {
        get {
            return this.z_indexField;
        }
        set {
            this.z_indexField = value;
        }
    }
}

[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class keyObject {
    
    private int folderField;
    
    private int fileField;
    
    private float xField;
    
    private float yField;
    
    private float angleField;
    
    private float scale_xField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int folder {
        get {
            return this.folderField;
        }
        set {
            this.folderField = value;
        }
    }
        
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int file {
        get {
            return this.fileField;
        }
        set {
            this.fileField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public float x {
        get {
            return this.xField;
        }
        set {
            this.xField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public float y {
        get {
            return this.yField;
        }
        set {
            this.yField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public float angle {
        get {
            return this.angleField;
        }
        set {
            this.angleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public float scale_x {
        get {
            return this.scale_xField;
        }
        set {
            this.scale_xField = value;
        }
    }
    
}

[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class keyBone {
    
    private float xField;
    
    private float yField;
    
    private float angleField;
    
    private float scale_xField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public float x {
        get {
            return this.xField;
        }
        set {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public float y {
        get {
            return this.yField;
        }
        set {
            this.yField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public float angle {
        get {
            return this.angleField;
        }
        set {
            this.angleField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public float scale_x {
        get {
            return this.scale_xField;
        }
        set {
            this.scale_xField = value;
        }
    }
}

[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class spriter_data {
    
    private spriter_dataFolder[] folderField;
    
    private spriter_dataEntity[] entityField;
    
    private string scml_versionField;
    
    private string generatorField;
    
    private string generator_versionField;
    
    private bool pixel_art_modeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("folder", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public spriter_dataFolder[] folder {
        get {
            return this.folderField;
        }
        set {
            this.folderField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("entity", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public spriter_dataEntity[] entity {
        get {
            return this.entityField;
        }
        set {
            this.entityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string scml_version {
        get {
            return this.scml_versionField;
        }
        set {
            this.scml_versionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string generator {
        get {
            return this.generatorField;
        }
        set {
            this.generatorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string generator_version {
        get {
            return this.generator_versionField;
        }
        set {
            this.generator_versionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool pixel_art_mode {
        get {
            return this.pixel_art_modeField;
        }
        set {
            this.pixel_art_modeField = value;
        }
    }
}

[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class spriter_dataFolder {
    
    private spriter_dataFolderFile[] fileField;
    
    private int idField;
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("file", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public spriter_dataFolderFile[] file {
        get {
            return this.fileField;
        }
        set {
            this.fileField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
}

[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class spriter_dataFolderFile {
    
    private int idField;
    
    private string nameField;
    
    private int widthField;
    
    private int heightField;
    
    private float pivot_xField;
    
    private float pivot_yField;
    
    private int atlas_xField;
    
    private int atlas_yField;
    
    private int offset_xField;
    
    private int offset_yField;
    
    private int original_widthField;
    
    private int original_heightField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int width {
        get {
            return this.widthField;
        }
        set {
            this.widthField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int height {
        get {
            return this.heightField;
        }
        set {
            this.heightField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public float pivot_x {
        get {
            return this.pivot_xField;
        }
        set {
            this.pivot_xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public float pivot_y {
        get {
            return this.pivot_yField;
        }
        set {
            this.pivot_yField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int atlas_x {
        get {
            return this.atlas_xField;
        }
        set {
            this.atlas_xField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int atlas_y {
        get {
            return this.atlas_yField;
        }
        set {
            this.atlas_yField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int offset_x {
        get {
            return this.offset_xField;
        }
        set {
            this.offset_xField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int offset_y {
        get {
            return this.offset_yField;
        }
        set {
            this.offset_yField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int original_width {
        get {
            return this.original_widthField;
        }
        set {
            this.original_widthField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int original_height {
        get {
            return this.original_heightField;
        }
        set {
            this.original_heightField = value;
        }
    }
}

[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class spriter_dataEntity {
    
    private spriter_dataEntityAnimation[] animationField;
    
    private int idField;
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("animation", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public spriter_dataEntityAnimation[] animation {
        get {
            return this.animationField;
        }
        set {
            this.animationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
}

[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class spriter_dataEntityAnimation {
    
    private key[][] mainlineField;
    
    private spriter_dataEntityAnimationTimeline[] timelineField;
    
    private int idField;
    
    private string nameField;
    
    private int lengthField;
    
    private bool loopingField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("key", typeof(key), IsNullable=false)]
    public key[][] mainline {
        get {
            return this.mainlineField;
        }
        set {
            this.mainlineField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("timeline", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public spriter_dataEntityAnimationTimeline[] timeline {
        get {
            return this.timelineField;
        }
        set {
            this.timelineField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int length {
        get {
            return this.lengthField;
        }
        set {
            this.lengthField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool looping {
        get {
            return this.loopingField;
        }
        set {
            this.loopingField = value;
        }
    }
}

[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class spriter_dataEntityAnimationTimeline {
    
    private key[] keyField;
    
    private int idField;
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("key")]
    public key[] key {
        get {
            return this.keyField;
        }
        set {
            this.keyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
}

[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class NewDataSet {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("key", typeof(key))]
    [System.Xml.Serialization.XmlElementAttribute("spriter_data", typeof(spriter_data))]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}
