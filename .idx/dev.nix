{ pkgs, ... }: {
  packages = [
    pkgs.go
    pkgs.gcc
    pkgs.dotnet-sdk_8
  ];
}
