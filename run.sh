#!/bin/bash

WORK_DIR=$( cd -- "$( dirname -- "${BASH_SOURCE[0]}" )" &> /dev/null && pwd )

alacritty --working-directory "$WORK_DIR" --command dotnet run --project Server &
alacritty --working-directory "$WORK_DIR" --command dotnet run --project Client &

