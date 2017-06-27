
copy .\BpImplement\bin\Debug\UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.Deploy.dll  D:\yonyou\U9V50\Portal\ApplicationLib
copy .\BpImplement\bin\Debug\UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.Deploy.pdb  D:\yonyou\U9V50\Portal\ApplicationLib
copy .\BpAgent\bin\Debug\UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.Agent.dll  D:\yonyou\U9V50\Portal\ApplicationLib
copy .\BpAgent\bin\Debug\UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.Agent.pdb  D:\yonyou\U9V50\Portal\ApplicationLib

copy .\BpImplement\bin\Debug\UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.Deploy.dll  D:\yonyou\U9V50\Portal\ApplicationServer\Libs
copy .\BpImplement\bin\Debug\UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.Deploy.pdb  D:\yonyou\U9V50\Portal\ApplicationServer\Libs
copy .\BpAgent\bin\Debug\UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.Agent.dll  D:\yonyou\U9V50\Portal\ApplicationServer\Libs
copy .\BpAgent\bin\Debug\UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.Agent.pdb  D:\yonyou\U9V50\Portal\ApplicationServer\Libs
copy .\BpImplement\bin\Debug\UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.dll  D:\yonyou\U9V50\Portal\ApplicationServer\Libs
copy .\BpImplement\bin\Debug\UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.pdb  D:\yonyou\U9V50\Portal\ApplicationServer\Libs
copy .\BpImplement\bin\Debug\UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.ubfsvc  D:\yonyou\U9V50\Portal\ApplicationServer\Libs


copy .\BpImplement\UFIDA.U9.Cust.XMJL.XMJLApBillSV.ubfserproj.IBatchRcvToAPBillSV.svc  D:\yonyou\U9V50\Portal\Services

echo 请手工将该bat文件打开，将下面这段内容与D:\yonyou\U9V50\Portal\RestServices\web.config进行合并。
	<service name="{type.FullName}Stub"  behaviorConfiguration="U9SrvTypeBehaviors">
		<endpoint address="" behaviorConfiguration="U9RestSrvBehaviors" binding="basicHttpBinding" contract="{type.Namespace.FullName}.IBatchRcvToAPBillSV" /> 
	</service>

