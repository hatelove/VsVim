﻿#light

namespace Vim.Modes.Normal
open Vim
open Microsoft.VisualStudio.Text
open Microsoft.VisualStudio.Text.Editor
open System.Windows.Input
open System.Windows.Media

type internal NormalMode =
    interface INormalMode
    new: (IVimBuffer* IOperations * IIncrementalSearch) -> NormalMode
    member IncrementalSearch : IIncrementalSearch

