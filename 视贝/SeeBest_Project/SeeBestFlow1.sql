--�ű�Ԥ�ƣ�
--ɾ������ά���ӱ�
DELETE FROM [Approval_DimensionFeature] WHERE [ID] in (90000011)
--ɾ������ά��
DELETE FROM [Approval_Dimension] WHERE [ID] in (90000011)
DELETE FROM [Approval_Dimension_Trl] WHERE [ID] in (90000011)
--ɾ����������
DELETE FROM [Approval_DocumentType] WHERE [ID] =9000001
DELETE FROM [Approval_DocumentType_Trl] WHERE [ID] =9000001
----- ��ɫ���� �������� �����㷢���˵���ID +110  
----- ��ɫ���ֻ��ɶ�Ӧ��ʵ�壬 ע�⣬����������ռ�ĵط����� �������Ҫ���Ȼ��̵ĸĳ�����

----��ɫ���� ���� �����ʵ���Ӧ��From ID
--- ��ɫ���㷢��֮�󣬶�Ӧ������ �ĳ��㵱ǰʵ������ƾ���
 
INSERT [Approval_DocumentType]
( [ID] , [SysVersion] , [EntityType] , [HROrgExpr] , [PositionExpr] , [Code] , [Uri] , [DisplayNameExpr] )
VALUES (9000001, 0 , 'UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE.SpecialApplyBE' , 'SpecialApplyBE.Org' , 'GetEmployeeByCreateBy(SpecialApplyBE.CreatedBy)'  , 'SpecialApplyBE' , '50e4e7ec-2c5f-4059-af07-d546f82715e5' , 'SpecialApplyBE.DocNo' )
INSERT [Approval_DocumentType_Trl] ([ID] , [Name] , SysMLFlag) VALUES (9000001, 'ר�����뵥' , 'zh-CN')
 
 
 
 
--- ��ɫ�� �ĳɷ����˵���ID +10  �������Լ����
---- ��ɫ������ �������͵�ʵ�� �����ĸ��ǵ�ǰʵ�塣���������ֶΡ�Code
---��ɫ���ɵ������͵�FromID
 
INSERT INTO Approval_Dimension
( ID,CreatedOn,CreatedBy,DimensionType,Reference,Code,EntityType )
VALUES(90000011,'',Host_Name(),1,'dc378576-49be-43be-b4e5-577f0a1528ea','AD90000011','UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocType' )
INSERT INTO Approval_Dimension_Trl ( ID,SysMLFlag,Name ) VALUES(90000011,'zh-CN','ר�����뵥��������' )
 
 
--ע����SQL��������ά�Ⱥ���������
INSERT [Approval_DimensionFeature] ( [ID] , [SysVersion] , [ApprovalColumn] , [Dimension] , [DocumentType]) VALUES (90000011, 0 , 'SpecialApplyBE.SpecialApplyDocType.Code' , 90000011, 9000001)



