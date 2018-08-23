# HoloExcept
[![AppVeyor](https://ci.appveyor.com/api/projects/status/hbc05ykq6jspwx8b?svg=true)](https://ci.appveyor.com/project/Orwel/holoexcept)
[![Codecov](https://codecov.io/gh/Orwel/HoloExcept/branch/master/graph/badge.svg)](https://codecov.io/gh/Orwel/HoloExcept)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

A console program to retrieve file's elements not present in other file.

## Example

source.txt :

    aaa
    bbb
    ccc
    ddd
    eee

except.txt :

    aaa
    ccc
    ooo
    zzz

Run :

    dotnet Holo.Except.dll source.txt except.txt > result.txt

result.txt :

    bbb
    ddd
    eee

## Contributing to this project

Anyone and everyone is welcome to contribute. Please take a moment to
review the [guidelines for contributing](CONTRIBUTING.md).

* [Bug reports](CONTRIBUTING.md#bugs)
* [Feature requests](CONTRIBUTING.md#features)
* [Pull requests](CONTRIBUTING.md#pull-requests)
