#!/bin/bash

if ! type reportgenerator &> /dev/null;
then
    dotnet tool install -g dotnet-reportgenerator-globaltool  
fi

if ! type dotnet-coverage &> /dev/null;
then
    dotnet tool install --global dotnet-coverage
fi

if ! type dotnet-ef &> /dev/null;
then
    dotnet tool install --global dotnet-ef
fi

if ! type dotnet sonarscanner &> /dev/null;
then
    dotnet tool install --global dotnet-sonarscanner
fi