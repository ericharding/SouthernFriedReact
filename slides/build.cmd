@echo off
set SLIDES=%~dp0\src
cd FSReveal
rmdir /s /q slides
mklink /d slides %SLIDES%
build.cmd

