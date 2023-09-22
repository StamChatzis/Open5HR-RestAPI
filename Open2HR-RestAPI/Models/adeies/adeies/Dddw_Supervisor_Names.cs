using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using SnapObjects.Data;
using DWNet.Data;
using Newtonsoft.Json;
using System.Collections;

namespace Open2HRRestAPI.Models 
{
    [DataWindow("dddw_supervisor_names", DwStyle.Default)]
    [Table("ots_adeies_employee")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"ots_adeies_employee\" ) @(_COLUMNS_PLACEHOLDER_) WHERE(    EXP1 =\"\\\"ots_adeies_employee\\\".\\\"isSupervisor\\\"\"   OP =\"=\"    EXP2 =\"1\" ) )")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    [DwTemplate(DataFormat.Xml, "custom_xml", "adeies\\adeies\\dddw_supervisor_names.tpl.custom_xml.xml")]
    public class Dddw_Supervisor_Names
    {
        [Key]
        [DwColumn("ots_adeies_employee", "id")]
        public decimal Id { get; set; }

        [DwColumn("ots_adeies_employee", "first_name")]
        public string First_Name { get; set; }

        [DwColumn("ots_adeies_employee", "last_name")]
        public string Last_Name { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("first_name + \\\" \\\" + last_name")]
        public object Compute_1 { get; set; }

    }

}



