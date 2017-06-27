
copy .\BpImplement\bin\Debug\UFIDA.U9.Cust.XMJL.SV.Deploy.dll  D:\yonyou\U9V50\Portal\ApplicationLib
copy .\BpImplement\bin\Debug\UFIDA.U9.Cust.XMJL.SV.Deploy.pdb  D:\yonyou\U9V50\Portal\ApplicationLib
copy .\BpAgent\bin\Debug\UFIDA.U9.Cust.XMJL.SV.Agent.dll  D:\yonyou\U9V50\Portal\ApplicationLib
copy .\BpAgent\bin\Debug\UFIDA.U9.Cust.XMJL.SV.Agent.pdb  D:\yonyou\U9V50\Portal\ApplicationLib

copy .\BpImplement\bin\Debug\UFIDA.U9.Cust.XMJL.SV.Deploy.dll  D:\yonyou\U9V50\Portal\ApplicationServer\Libs
copy .\BpImplement\bin\Debug\UFIDA.U9.Cust.XMJL.SV.Deploy.pdb  D:\yonyou\U9V50\Portal\ApplicationServer\Libs
copy .\BpAgent\bin\Debug\UFIDA.U9.Cust.XMJL.SV.Agent.dll  D:\yonyou\U9V50\Portal\ApplicationServer\Libs
copy .\BpAgent\bin\Debug\UFIDA.U9.Cust.XMJL.SV.Agent.pdb  D:\yonyou\U9V50\Portal\ApplicationServer\Libs
copy .\BpImplement\bin\Debug\UFIDA.U9.Cust.XMJL.SV.dll  D:\yonyou\U9V50\Portal\ApplicationServer\Libs
copy .\BpImplement\bin\Debug\UFIDA.U9.Cust.XMJL.SV.pdb  D:\yonyou\U9V50\Portal\ApplicationServer\Libs
copy .\BpImplement\bin\Debug\UFIDA.U9.Cust.XMJL.SV.ubfsvc  D:\yonyou\U9V50\Portal\ApplicationServer\Libs


copy .\BpImplement\UFIDA.U9.Cust.XMJL.SupplierSV.IQueryAllVerifiedSupply.svc  D:\yonyou\U9V50\Portal\Services
copy .\BpImplement\UFIDA.U9.Cust.XMJL.ItemSV.IQueryAllEffectiveItem.svc  D:\yonyou\U9V50\Portal\Services
copy .\BpImplement\UFIDA.U9.Cust.XMJL.ItemSV.IQueryAllItemPrice.svc  D:\yonyou\U9V50\Portal\Services
copy .\BpImplement\UFIDA.U9.Cust.XMJL.ItemSV.IGetItemPrice.svc  D:\yonyou\U9V50\Portal\Services
copy .\BpImplement\UFIDA.U9.Cust.XMJL.ItemSV.IQueryAllItemStore.svc  D:\yonyou\U9V50\Portal\Services
copy .\BpImplement\UFIDA.U9.Cust.XMJL.ItemSV.IGetItemStore.svc  D:\yonyou\U9V50\Portal\Services
copy .\BpImplement\UFIDA.U9.Cust.XMJL.CustomerSV.IQueryBalance.svc  D:\yonyou\U9V50\Portal\Services
copy .\BpImplement\UFIDA.U9.Cust.XMJL.BOMSV.IGetBom.svc  D:\yonyou\U9V50\Portal\Services
copy .\BpImplement\UFIDA.U9.Cust.XMJL.BOMSV.IImportXMJLBom.svc  D:\yonyou\U9V50\Portal\Services
copy .\BpImplement\UFIDA.U9.Cust.XMJL.BOMSV.IService.svc  D:\yonyou\U9V50\Portal\Services
copy .\BpImplement\UFIDA.U9.Cust.XMJL.ReceivementSV.IGetSRMRcv.svc  D:\yonyou\U9V50\Portal\Services
copy .\BpImplement\UFIDA.U9.Cust.XMJL.ReceivementSV.IApproveRcvSV.svc  D:\yonyou\U9V50\Portal\Services
copy .\BpImplement\UFIDA.U9.Cust.XMJL.BillBalanceSV.IGetBillBalance.svc  D:\yonyou\U9V50\Portal\Services
copy .\BpImplement\UFIDA.U9.Cust.XMJL.ARBillSV.IApproveARBillSV.svc  D:\yonyou\U9V50\Portal\Services
copy .\BpImplement\UFIDA.U9.Cust.XMJL.RecBillSV.IApproveRecBillSV.svc  D:\yonyou\U9V50\Portal\Services
copy .\BpImplement\UFIDA.U9.Cust.XMJL.VoucherSV.IApproveVoucherSV.svc  D:\yonyou\U9V50\Portal\Services
copy .\BpImplement\UFIDA.U9.Cust.XMJL.APBillSV.ISumAccrueDocToAPBillSV.svc  D:\yonyou\U9V50\Portal\Services
copy .\BpImplement\UFIDA.U9.Cust.XMJL.APBillSV.IRcvPushAPComfirmSV.svc  D:\yonyou\U9V50\Portal\Services

echo 请手工将该bat文件打开，将下面这段内容与D:\yonyou\U9V50\Portal\RestServices\web.config进行合并。
	<service name="{type.FullName}Stub"  behaviorConfiguration="U9SrvTypeBehaviors">
		<endpoint address="" behaviorConfiguration="U9RestSrvBehaviors" binding="basicHttpBinding" contract="{type.Namespace.FullName}.IQueryAllVerifiedSupply" /> 
	</service>
	<service name="{type.FullName}Stub"  behaviorConfiguration="U9SrvTypeBehaviors">
		<endpoint address="" behaviorConfiguration="U9RestSrvBehaviors" binding="basicHttpBinding" contract="{type.Namespace.FullName}.IQueryAllEffectiveItem" /> 
	</service>
	<service name="{type.FullName}Stub"  behaviorConfiguration="U9SrvTypeBehaviors">
		<endpoint address="" behaviorConfiguration="U9RestSrvBehaviors" binding="basicHttpBinding" contract="{type.Namespace.FullName}.IQueryAllItemPrice" /> 
	</service>
	<service name="{type.FullName}Stub"  behaviorConfiguration="U9SrvTypeBehaviors">
		<endpoint address="" behaviorConfiguration="U9RestSrvBehaviors" binding="basicHttpBinding" contract="{type.Namespace.FullName}.IGetItemPrice" /> 
	</service>
	<service name="{type.FullName}Stub"  behaviorConfiguration="U9SrvTypeBehaviors">
		<endpoint address="" behaviorConfiguration="U9RestSrvBehaviors" binding="basicHttpBinding" contract="{type.Namespace.FullName}.IQueryAllItemStore" /> 
	</service>
	<service name="{type.FullName}Stub"  behaviorConfiguration="U9SrvTypeBehaviors">
		<endpoint address="" behaviorConfiguration="U9RestSrvBehaviors" binding="basicHttpBinding" contract="{type.Namespace.FullName}.IGetItemStore" /> 
	</service>
	<service name="{type.FullName}Stub"  behaviorConfiguration="U9SrvTypeBehaviors">
		<endpoint address="" behaviorConfiguration="U9RestSrvBehaviors" binding="basicHttpBinding" contract="{type.Namespace.FullName}.IQueryBalance" /> 
	</service>
	<service name="{type.FullName}Stub"  behaviorConfiguration="U9SrvTypeBehaviors">
		<endpoint address="" behaviorConfiguration="U9RestSrvBehaviors" binding="basicHttpBinding" contract="{type.Namespace.FullName}.IGetBom" /> 
	</service>
	<service name="{type.FullName}Stub"  behaviorConfiguration="U9SrvTypeBehaviors">
		<endpoint address="" behaviorConfiguration="U9RestSrvBehaviors" binding="basicHttpBinding" contract="{type.Namespace.FullName}.IImportXMJLBom" /> 
	</service>
	<service name="{type.FullName}Stub"  behaviorConfiguration="U9SrvTypeBehaviors">
		<endpoint address="" behaviorConfiguration="U9RestSrvBehaviors" binding="basicHttpBinding" contract="{type.Namespace.FullName}.IService" /> 
	</service>
	<service name="{type.FullName}Stub"  behaviorConfiguration="U9SrvTypeBehaviors">
		<endpoint address="" behaviorConfiguration="U9RestSrvBehaviors" binding="basicHttpBinding" contract="{type.Namespace.FullName}.IGetSRMRcv" /> 
	</service>
	<service name="{type.FullName}Stub"  behaviorConfiguration="U9SrvTypeBehaviors">
		<endpoint address="" behaviorConfiguration="U9RestSrvBehaviors" binding="basicHttpBinding" contract="{type.Namespace.FullName}.IApproveRcvSV" /> 
	</service>
	<service name="{type.FullName}Stub"  behaviorConfiguration="U9SrvTypeBehaviors">
		<endpoint address="" behaviorConfiguration="U9RestSrvBehaviors" binding="basicHttpBinding" contract="{type.Namespace.FullName}.IGetBillBalance" /> 
	</service>
	<service name="{type.FullName}Stub"  behaviorConfiguration="U9SrvTypeBehaviors">
		<endpoint address="" behaviorConfiguration="U9RestSrvBehaviors" binding="basicHttpBinding" contract="{type.Namespace.FullName}.IApproveARBillSV" /> 
	</service>
	<service name="{type.FullName}Stub"  behaviorConfiguration="U9SrvTypeBehaviors">
		<endpoint address="" behaviorConfiguration="U9RestSrvBehaviors" binding="basicHttpBinding" contract="{type.Namespace.FullName}.IApproveRecBillSV" /> 
	</service>
	<service name="{type.FullName}Stub"  behaviorConfiguration="U9SrvTypeBehaviors">
		<endpoint address="" behaviorConfiguration="U9RestSrvBehaviors" binding="basicHttpBinding" contract="{type.Namespace.FullName}.IApproveVoucherSV" /> 
	</service>
	<service name="{type.FullName}Stub"  behaviorConfiguration="U9SrvTypeBehaviors">
		<endpoint address="" behaviorConfiguration="U9RestSrvBehaviors" binding="basicHttpBinding" contract="{type.Namespace.FullName}.ISumAccrueDocToAPBillSV" /> 
	</service>
	<service name="{type.FullName}Stub"  behaviorConfiguration="U9SrvTypeBehaviors">
		<endpoint address="" behaviorConfiguration="U9RestSrvBehaviors" binding="basicHttpBinding" contract="{type.Namespace.FullName}.IRcvPushAPComfirmSV" /> 
	</service>


pause