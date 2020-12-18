mkdir bin
cp ../../../Bin/Desktop/UrhoDotNet.dll bin
cp ../../../Bin/Desktop/libmono-urho.dylib bin
cp ../../../Urho3D/CoreData.pak bin
csc /target:exe /out:bin/SamplyGame.exe /reference:bin/UrhoDotNet.dll /platform:x64  *.cs ../Core/*.cs ../Core/Aircrafts/*.cs ../Core/Aircrafts//Enemies/*.cs ../Core/Helpers/*.cs ../Core/Weapons/*.cs 