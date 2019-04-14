syntax on
set fenc=utf-8
set encoding=utf-8
set t_Co=256
set background=dark
set number


set hlsearch  		"highligh zoekwoordjes
set ignorecase		"ignore hoofd-kleine letters bij zoeken
set relativenumber	"relatieve nummers (is makkelijker met commando's)

set nocompatible
filetype off
set rtp+=~/.vim/bundle/Vundle.vim
call vundle#begin()
Plugin 'VundleVim/Vundle.vim'

" Add plugins here

Plugin 'morhetz/gruvbox'
Plugin 'Valloric/YouCompleteMe'
Plugin 'vim-airline/vim-airline'
Plugin 'scrooloose/nerdtree'
Plugin 'ctrlp.vim'

call vundle#end()
filetype plugin indent on

" dit moet onderin, anders herkent die hem niet
colorscheme gruvbox

set showcmd

" Blijkbaar nodig voor mooiere statusbar (met arrows ipv blocks)

if !exists('g:airline_symbols')
  let g:airline_symbols = {}
endif

" unicode symbols
let g:airline_left_sep = '»'
let g:airline_left_sep = '▶'
let g:airline_right_sep = '«'
let g:airline_right_sep = '◀'
let g:airline_symbols.linenr = '␊'
let g:airline_symbols.linenr = '␤'
let g:airline_symbols.linenr = '¶'
let g:airline_symbols.branch = '⎇'
let g:airline_symbols.paste = 'ρ'
let g:airline_symbols.paste = 'Þ'
let g:airline_symbols.paste = '∥'
let g:airline_symbols.whitespace = 'Ξ'
" buffers altijd laten zien (ook bij 1 tab)
let g:airline#extensions#tabline#enabled = 1

" maps gemaakt door Joost
"   <silent> zorgt ervoor dat er niks ge-echood wordt in de commandline
"   de eerste 'n' va nnoremap betekent 'normal mode' (map versus nmap)
"   'nore' = non recursive en dat betekent dat de mapping eenmaal geldt en niet doorwerkt op een andere variabele/mapping
nnoremap <silent> <F5> :!python3 %<CR>
nnoremap <silent> <C-j> 10j
nnoremap <silent> <C-k> 10k



