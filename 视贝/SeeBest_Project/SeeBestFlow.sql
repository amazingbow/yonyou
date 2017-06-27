--脚本预制：
--删除审批维度子表
DELETE FROM [Approval_DimensionFeature] WHERE [ID] in (90000011)
--删除审批维度
DELETE FROM [Approval_Dimension] WHERE [ID] in (90000011)
DELETE FROM [Approval_Dimension_Trl] WHERE [ID] in (90000011)
--删除审批对象
DELETE FROM [Approval_DocumentType] WHERE [ID] =9000001
DELETE FROM [Approval_DocumentType_Trl] WHERE [ID] =9000001
----- 红色部分 。换成你 上面你发布菜单的ID +110  
----- 黄色部分换成对应的实体， 注意，这个加命名空间的地方，是 到这里，不要多加然后短的改成类名

----蓝色部分 换成 你这个实体对应的From ID
--- 紫色是你发布之后，对应的名称 改成你当前实体的名称就行
 
INSERT [Approval_DocumentType]
( [ID] , [SysVersion] , [EntityType] , [HROrgExpr] , [PositionExpr] , [Code] , [Uri] , [DisplayNameExpr] )
VALUES (9000001, 0 , 'UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE' , 'SpecialApplyBE.Org' , 'GetEmployeeByCreateBy(SpecialApplyBE.CreatedBy)'  , 'SpecialApplyBE' , '50e4e7ec-2c5f-4059-af07-d546f82715e5' , 'SpecialApplyBE.DocNo' )
INSERT [Approval_DocumentType_Trl] ([ID] , [Name] , SysMLFlag) VALUES (9000001, '专柜申请单' , 'zh-CN')
 
 
 
 
--- 红色部 改成发布菜单的ID +10  看例子自己理解
---- 黄色部分是 单据类型的实体 下面哪个是当前实体。单据类型字段。Code
---蓝色换成单据类型的FromID
 
INSERT INTO Approval_Dimension
( ID,CreatedOn,CreatedBy,DimensionType,Reference,Code,EntityType )
VALUES(90000011,'',Host_Name(),1,'dc378576-49be-43be-b4e5-577f0a1528ea','AD90000011','UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocType' )
INSERT INTO Approval_Dimension_Trl ( ID,SysMLFlag,Name ) VALUES(90000011,'zh-CN','专柜申请单单据类型' )
 
 
--注：该SQL关联审批维度和审批对象
INSERT [Approval_DimensionFeature] ( [ID] , [SysVersion] , [ApprovalColumn] , [Dimension] , [DocumentType]) VALUES (90000011, 0 , 'SpecialApplyBE.SpecialApplyDocType.Code' , 90000011, 9000001)



