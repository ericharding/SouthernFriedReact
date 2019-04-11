@echo off
set HERE=%~dp0
cd FSReveal
rmdir /s /q slides
rmdir /s /q output
mklink /d slides %HERE%\src
mkdir %HERE%\output
mklink /d output %HERE%\output
build.cmd

