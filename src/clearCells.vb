Sub ClearCellWarning()
' Clear all used cells
    Dim events As Range
    Dim frowIdx As Integer
    frowIdx = 2
    Dim CellName As String

    CellName = Range(Cells(2, RefNumcolidx), Cells(RefRowidx, RefNumcolidx)).Address
  
    For Each events In AuditPropertiesSheet.Range(CellName)

       If events.Errors.Item(xlNumberAsText).Value = True Then
          events.Errors.Item(xlNumberAsText).Ignore = True
       End If
       frowIdx = frowIdx + 1
       
    Next events

    SettingsSheet.Range(cn.outDataLoadedFinishedDate) = DateTime.Now
    SettingsSheet.Range(cn.outLoadingState) = "Audit Log Complete"

End Sub
