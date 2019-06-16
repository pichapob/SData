Public Class frmAccount8
    Public sqlf As New SQLManager
    Private Sub frmAccount8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql = "select v.village_id,(v.village_moo+0) as village_moo_int,v.village_name,t.full_name from village v left outer join thaiaddress t on t.addressid = v.address_id order by v.address_id,village_moo_int"
        Dim village As DataTable = sqlf.QueryAsDatatable(sql)
        ac8_village_table.DataSource = village
        GetDataVillage(ac8_village_table.Item(0, 0).Value)
    End Sub

    Private Sub ac8_village_table_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ac8_village_table.CellClick
        GetDataVillage(ac8_village_table.Item(0, e.RowIndex).Value)
    End Sub

    Public Sub GetDataVillage(ByVal village_id As String)
        Dim sql = "select i.village_survey_item_id, i.village_survey_item_name,d.survey_value,i.unit_name  from village_survey_item  i  left outer join village_survey_detail d on d.village_survey_item_id = i.village_survey_item_id  and d.village_id = " & village_id & " where i.item_group = 1  order by i.village_survey_item_id "
        Dim survey As DataTable = sqlf.QueryAsDatatable(sql)
        village_survey_tb.DataSource = survey
        sql = "select i.village_survey_item_id, i.village_survey_item_name,d.survey_value,i.unit_name  from village_survey_item  i  left outer join village_survey_detail d on d.village_survey_item_id = i.village_survey_item_id  and d.village_id = " & village_id & " where i.item_group = 2  order by i.village_survey_item_id "
        Dim survey2 As DataTable = sqlf.QueryAsDatatable(sql)
        village_survey2_tb.DataSource = survey2

        sql = "select v1.village_school_id,v1.school_name ,t1.school_type_name,count(d.village_student_id) as student_count  from village_school v1  left outer join village_school_type t1 on t1.school_type_id = v1.school_type_id  left outer join village_student d on d.village_school_id = v1.village_school_id  where v1.village_id = " & village_id & " group by v1.village_school_id,v1.school_name ,t1.school_type_name  order by v1.school_type_id"
        Dim village_school As DataTable = sqlf.QueryAsDatatable(sql)
        Dim index As New DataColumn("index", GetType(String))
        village_school.Columns.Add(index)
        For i = 0 To village_school.Rows.Count - 1
            village_school.Rows(i).Item("index") = i + 1
        Next
        village_school_tb.DataSource = village_school

        sql = "select t.village_temple_id,t.temple_name, y.village_temple_type_name,count(p.village_priest_id) as priest_count  from village_temple    t  left outer join village_temple_type y on y.village_temple_type_id = t.village_temple_type_id  left outer join village_priest p on p.village_temple_id = t.village_temple_id  where t.village_id = " & village_id & " group by  t.village_temple_id,t.temple_name, y.village_temple_type_name"
        Dim village_temple As DataTable = sqlf.QueryAsDatatable(sql)
        Dim temple_index As New DataColumn("temple_index", GetType(String))
        village_temple.Columns.Add(temple_index)
        For i = 0 To village_temple.Rows.Count - 1
            village_temple.Rows(i).Item("temple_index") = i + 1
        Next
        village_temple_tb.DataSource = village_temple

        sql = "select v.village_store_id,vt.village_store_type_name,v.village_store_name,v.sell_cigar,v.sell_alcohol,v.village_store_address,v.village_store_phone  from village_store    v  left outer join village_store_type vt on vt.village_store_type_id = v.village_store_type_id  where v.village_id = " & village_id
        Dim village_store As DataTable = sqlf.QueryAsDatatable(sql)
        Dim village_store_index As New DataColumn("village_store_index", GetType(String))
        village_store.Columns.Add(village_store_index)
        For i = 0 To village_store.Rows.Count - 1
            village_store.Rows(i).Item("village_store_index") = i + 1
        Next
        village_store_tb.DataSource = village_store

        sql = "select v.village_organization_id,v.village_organization_name,count(m.person_id) as person_count  from village_organization  v  left outer join village_organization_member m on m.village_organization_id = v.village_organization_id  where v.village_id = " & village_id & " group by v.village_organization_id,v.village_organization_name"
        Dim village_organization As DataTable = sqlf.QueryAsDatatable(sql)
        Dim village_organization_index As New DataColumn("village_organization_index", GetType(String))
        village_organization.Columns.Add(village_organization_index)
        For i = 0 To village_organization.Rows.Count - 1
            village_organization.Rows(i).Item("village_organization_index") = i + 1
        Next
        village_organization_tb.DataSource = village_organization

        sql = "select v.village_club_id,v.village_club_name, count(m.person_id) as village_club_count  from village_club   v   left outer join village_club_member m on m.village_club_id = v.village_club_id  where v.village_id =" & village_id & " group by v.village_club_id,v.village_club_name"
        Dim village_club As DataTable = sqlf.QueryAsDatatable(sql)
        Dim village_club_index As New DataColumn("village_club_index", GetType(String))
        village_club.Columns.Add(village_club_index)
        For i = 0 To village_club.Rows.Count - 1
            village_club.Rows(i).Item("village_club_index") = i + 1
        Next
        village_club_tb.DataSource = village_club

        sql = "select v1.village_water_id,v1.village_water_name ,v2.village_water_type_name,IFNULL(v1.village_water_status,'N') AS village_water_status  from village_water v1  left outer join village_water_type v2 on v2.village_water_type_id = v1.village_water_type_id  where v1.village_id = " & village_id
        Dim village_water As DataTable = sqlf.QueryAsDatatable(sql)
        Dim village_water_index As New DataColumn("village_water_index", GetType(String))
        village_water.Columns.Add(village_water_index)
        For i = 0 To village_water.Rows.Count - 1
            village_water.Rows(i).Item("village_water_index") = i + 1
        Next
        village_water_tb.DataSource = village_water

        sql = "select v1.village_basis_health_center_id,v1.village_basis_health_center_name,concat(p.pname,p.fname,' ',p.lname) as village_basis_health_center_older_name,IFNULL(v1.has_medical_funds,'N') AS has_medical_funds  from village_basis_health_center v1  left outer join person p on p.person_id = v1.person_id  where v1.village_id = " & village_id
        Dim village_basis_health_center As DataTable = sqlf.QueryAsDatatable(sql)
        Dim village_basis_health_center_index As New DataColumn("village_basis_health_center_index", GetType(String))
        village_basis_health_center.Columns.Add(village_basis_health_center_index)
        For i = 0 To village_basis_health_center.Rows.Count - 1
            village_basis_health_center.Rows(i).Item("village_basis_health_center_index") = i + 1
        Next
        village_basis_health_center_tb.DataSource = village_basis_health_center

        sql = "select v1.village_basis_doctor_id,concat(p1.pname,p1.fname,' ',p1.lname) as village_basis_doctor_name,v2.village_basis_doctor_tye_name  from village_basis_doctor v1  left outer join person p1 on p1.person_id = v1.person_id LEFT JOIN village_basis_doctor_type v2 ON v1.village_basis_doctor_type_id = v2.village_basis_doctor_type_id  where v1.village_id = " & village_id
        Dim village_basis_doctor As DataTable = sqlf.QueryAsDatatable(sql)
        Dim village_basis_doctor_index As New DataColumn("village_basis_doctor_index", GetType(String))
        village_basis_doctor.Columns.Add(village_basis_doctor_index)
        For i = 0 To village_basis_doctor.Rows.Count - 1
            village_basis_doctor.Rows(i).Item("village_basis_doctor_index") = i + 1
        Next
        village_basis_doctor_tb.DataSource = village_basis_doctor

        sql = "select v.village_news_tower_id,v.village_news_tower_name,IFNULL(v.usable,'N') usable from village_news_tower v where village_id = " & village_id
        Dim village_news_tower As DataTable = sqlf.QueryAsDatatable(sql)
        Dim village_news_tower_index As New DataColumn("village_news_tower_index", GetType(String))
        village_news_tower.Columns.Add(village_news_tower_index)
        For i = 0 To village_news_tower.Rows.Count - 1
            village_news_tower.Rows(i).Item("village_news_tower_index") = i + 1
        Next
        village_news_tower_tb.DataSource = village_news_tower

        sql = "select v.village_radio_tower_id,v.village_radio_tower_name,v.village_radio_tower_person_name,v.village_radio_tower_address1,v.village_radio_tower_address2 from village_radio_tower v  where village_id = " & village_id
        Dim village_radio_tower As DataTable = sqlf.QueryAsDatatable(sql)
        Dim village_radio_tower_index As New DataColumn("village_radio_tower_index", GetType(String))
        village_radio_tower.Columns.Add(village_radio_tower_index)
        For i = 0 To village_radio_tower.Rows.Count - 1
            village_radio_tower.Rows(i).Item("village_radio_tower_index") = i + 1
        Next
        village_radio_tower_tb.DataSource = village_radio_tower

        sql = "select v1.village_drug_store_id,v1.village_drug_store_name  ,v2.village_drug_store_type_name,v1.village_drug_store_owner_name,v1.village_drug_store_register_date  from village_drug_store v1  left outer join village_drug_store_type v2 on v2.village_drug_store_type_id = v1.village_drug_store_type_id  where v1.village_id = " & village_id
        Dim village_drug_store As DataTable = sqlf.QueryAsDatatable(sql)
        Dim village_drug_store_index As New DataColumn("village_drug_store_index", GetType(String))
        village_drug_store.Columns.Add(village_drug_store_index)
        For i = 0 To village_drug_store.Rows.Count - 1
            village_drug_store.Rows(i).Item("village_drug_store_index") = i + 1
        Next
        village_drug_store_tb.DataSource = village_drug_store

        sql = "select v1.village_healthcare_center_id,v1.village_healthcare_center_name,v2.village_healthcare_center_type_name,v1.village_healthcare_center_owner_name,v1.village_healthcare_center_open_date   from village_healthcare_center v1  left outer join  village_healthcare_center_type v2 on v2.village_healthcare_center_type_id = v1.village_healthcare_center_type_id  where v1.village_id = " & village_id
        Dim village_healthcare_center As DataTable = sqlf.QueryAsDatatable(sql)
        Dim village_healthcare_center_index As New DataColumn("village_healthcare_center_index", GetType(String))
        village_healthcare_center.Columns.Add(village_healthcare_center_index)
        For i = 0 To village_healthcare_center.Rows.Count - 1
            village_healthcare_center.Rows(i).Item("village_healthcare_center_index") = i + 1
        Next
        village_healthcare_center_tb.DataSource = village_healthcare_center

        sql = "select v1.village_factory_id,v1.village_factory_name,v2.village_factory_type_name,v1.village_factory_owner_name,v1.village_factory_open_date  from village_factory v1  left outer join village_factory_type v2 on v2.village_factory_type_id = v1.village_factory_type_id  where  v1.village_id = " & village_id
        Dim village_factory As DataTable = sqlf.QueryAsDatatable(sql)
        Dim village_factory_index As New DataColumn("village_factory_index", GetType(String))
        village_factory.Columns.Add(village_factory_index)
        For i = 0 To village_factory.Rows.Count - 1
            village_factory.Rows(i).Item("village_factory_index") = i + 1
        Next
        village_factory_tb.DataSource = village_factory

    End Sub

    Private Sub save_servey1b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_servey1b.Click
        Dim sql As String = ""
        Dim village_id As String = ac8_village_table.Item("village_id", ac8_village_table.CurrentRow.Index).Value.ToString
        For i As Integer = 0 To village_survey_tb.Rows.Count - 1
            sql = "UPDATE village_survey_detail vsd SET vsd.survey_value = " & village_survey_tb.Item("survey_value", i).Value.ToString & " WHERE vsd.village_survey_item_id = " & village_survey_tb.Item("village_survey_item_id", i).Value.ToString & " AND vsd.village_id =" & village_id
            sqlf.Excute(sql)
        Next
        MessageBox.Show("บันทึกข้อมูลเรียบร้อย")
    End Sub

    Private Sub save_servey2b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_servey2b.Click
        Dim sql As String = ""
        Dim village_id As String = ac8_village_table.Item("village_id", ac8_village_table.CurrentRow.Index).Value.ToString
        For i As Integer = 0 To village_survey2_tb.Rows.Count - 1
            sql = "UPDATE village_survey_detail vsd SET vsd.survey_value = " & village_survey2_tb.Item("survey2_value", i).Value.ToString & " WHERE vsd.village_survey_item_id = " & village_survey2_tb.Item("village_survey2_item_id", i).Value.ToString & " AND vsd.village_id =" & village_id
            sqlf.Excute(sql)
        Next
        MessageBox.Show("บันทึกข้อมูลเรียบร้อย")
    End Sub

End Class