mkdir bin
cp ../../../Bin/Desktop/UrhoDotNet.dll bin
cp ../../../Bin/Desktop/libmono-urho.dylib bin
cp ../../../Urho3D/CoreData.pak bin
mcs /target:exe /out:bin/FeatureSamples.exe /reference:bin/UrhoDotNet.dll /platform:x64  *.cs ../Core/*.cs ../Core/*/*.cs  