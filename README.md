# CoreTweetTest  

Download: https://github.com/CoreTweet/CoreTweet/releases  

-----Windows-----  
C:\Windows\Microsoft.NET\Framework\v4.0.30319\mcs.exe -reference:CoreTweet.dll,Newtonsoft.Json.dll -out:main.exe main.cs  
main.exe oauth  
-----ubuntu-----  
sudo apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF  
echo "deb http://download.mono-project.com/repo/ubuntu stable-xenial main" | sudo tee /etc/apt/sources.list.d/mono-official-stable.list  
sudo apt-get update  
sudo apt-get install mono-devel  
  
mcs -reference:CoreTweet.dll,Newtonsoft.Json.dll -out:main.exe main.cs  
mono main.exe oauth  
