
copy .\BpImplement\bin\Debug\UFIDA.U9.Cust.HeXingProjectSV.Deploy.dll  C:\yonyou\U9V50\Portal\ApplicationLib
copy .\BpImplement\bin\Debug\UFIDA.U9.Cust.HeXingProjectSV.Deploy.pdb  C:\yonyou\U9V50\Portal\ApplicationLib
copy .\BpAgent\bin\Debug\UFIDA.U9.Cust.HeXingProjectSV.Agent.dll  C:\yonyou\U9V50\Portal\ApplicationLib
copy .\BpAgent\bin\Debug\UFIDA.U9.Cust.HeXingProjectSV.Agent.pdb  C:\yonyou\U9V50\Portal\ApplicationLib

copy .\BpImplement\bin\Debug\UFIDA.U9.Cust.HeXingProjectSV.Deploy.dll  C:\yonyou\U9V50\Portal\ApplicationServer\Libs
copy .\BpImplement\bin\Debug\UFIDA.U9.Cust.HeXingProjectSV.Deploy.pdb  C:\yonyou\U9V50\Portal\ApplicationServer\Libs
copy .\BpAgent\bin\Debug\UFIDA.U9.Cust.HeXingProjectSV.Agent.dll  C:\yonyou\U9V50\Portal\ApplicationServer\Libs
copy .\BpAgent\bin\Debug\UFIDA.U9.Cust.HeXingProjectSV.Agent.pdb  C:\yonyou\U9V50\Portal\ApplicationServer\Libs
copy .\BpImplement\bin\Debug\UFIDA.U9.Cust.HeXingProjectSV.dll  C:\yonyou\U9V50\Portal\ApplicationServer\Libs
copy .\BpImplement\bin\Debug\UFIDA.U9.Cust.HeXingProjectSV.pdb  C:\yonyou\U9V50\Portal\ApplicationServer\Libs
copy .\BpImplement\bin\Debug\UFIDA.U9.Cust.HeXingProjectSV.ubfsvc  C:\yonyou\U9V50\Portal\ApplicationServer\Libs


copy .\BpImplement\UFIDA.U9.Cust.HeXingProjectSV.HeXingCreateSAPU9GLVoucherSV.ICreateSAPU9GLVoucherSV.svc  C:\yonyou\U9V50\Portal\Services

echo 请手工将该bat文件打开，将下面这段内容与C:\yonyou\U9V50\Portal\RestServices\web.config进行合并。
	<service name="{type.FullName}Stub"  behaviorConfiguration="U9SrvTypeBehaviors">
		<endpoint address="" behaviorConfiguration="U9RestSrvBehaviors" binding="basicHttpBinding" contract="{type.Namespace.FullName}.ICreateSAPU9GLVoucherSV" /> 
	</service>


pause