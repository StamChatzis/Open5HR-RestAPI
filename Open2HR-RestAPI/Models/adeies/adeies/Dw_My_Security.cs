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
    [DataWindow("dw_my_security", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"ots_adeies_employee\" )  TABLE(NAME=\"ots_adeies_user\" ) @(_COLUMNS_PLACEHOLDER_) JOIN (LEFT=\"ots_adeies_user.employee_id\"    OP =\"=\"RIGHT=\"ots_adeies_employee.id\" )WHERE(    EXP1 =\"ots_adeies_user.id\"   OP =\"=\"    EXP2 =\":an_id\" ) ) ARG(NAME = \"an_id\" TYPE = number)")]
    #endregion
    [DwParameter("an_id", typeof(double?))]
    public class Dw_My_Security
    {
        [StringLength(20)]
        [DwColumn("ots_adeies_user", "role")]
        public string Ots_Adeies_User_Role { get; set; }

        [DwColumn("ots_adeies_employee", "isSupervisor")]
        public int? Ots_Adeies_Employee_Issupervisor { get; set; }

    }

}



