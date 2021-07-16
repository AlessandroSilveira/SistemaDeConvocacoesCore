•
ñC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\Interfaces\Services\IAdminAppService.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

Interfaces+ 5
.5 6
Services6 >
{		 
public

 

	interface

 
IAdminAppService

 %
:

& '
IDisposable

( 3
{ 
Task 
< 
Admin2ViewModel 
> 
AddAsync &
(& '
Admin2ViewModel' 6
obj7 :
): ;
;; <
Task 
< 
Admin2ViewModel 
> 
GetByIdAsync *
(* +
Guid+ /
id0 2
)2 3
;3 4
Task 
< 
IEnumerable 
< 
Admin2ViewModel (
>( )
>) *
GetAllAsync+ 6
(6 7
)7 8
;8 9
Task 
< 
Admin2ViewModel 
> 
UpdateAsync )
() *
Admin2ViewModel* 9
obj: =
)= >
;> ?
Task 
RemoveAsync 
( 
Guid 
id  
)  !
;! "
Task 
< 
IEnumerable 
< 
Admin2ViewModel (
>( )
>) *
SearchAsync+ 6
(6 7

Expression7 A
<A B
FuncB F
<F G
AdminG L
,L M
boolN R
>R S
>S T
	predicateU ^
)^ _
;_ `
Task 
< 
Admin2ViewModel 
> 
GetOneAsync )
() *

Expression* 4
<4 5
Func5 9
<9 :
Admin: ?
,? @
boolA E
>E F
>F G
	predicateH Q
)Q R
;R S
} 
} ≠	
ïC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\Interfaces\Services\IAppServiceBase.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

Interfaces+ 5
.5 6
Services6 >
{ 
public 

	interface 
IAppServiceBase $
<$ %
TEntity% ,
>, -
where. 3
TEntity4 ;
:< =
class> C
{ 
void 
Add 
( 
TEntity 
obj 
) 
; 
TEntity		 
GetById		 
(		 
int		 
id		 
)		 
;		  
IEnumerable 
< 
TEntity 
> 
GetAll #
(# $
)$ %
;% &
void 
Update 
( 
TEntity 
obj 
)  
;  !
void 
Remove 
( 
TEntity 
obj 
)  
;  !
} 
} ù
ñC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\Interfaces\Services\ICargoAppService.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

Interfaces+ 5
.5 6
Services6 >
{		 
public

 

	interface

 
ICargoAppService

 %
:

& '
IDisposable

( 3
{ 
Task 
< 
CargoViewModel 
> 
AddAsync %
(% &
CargoViewModel& 4
obj5 8
)8 9
;9 :
Task 
< 
CargoViewModel 
> 
GetByIdAsync )
() *
Guid* .
id/ 1
)1 2
;2 3
Task 
< 
IEnumerable 
< 
CargoViewModel '
>' (
>( )
GetAllAsync* 5
(5 6
)6 7
;7 8
Task 
< 
CargoViewModel 
> 
UpdateAsync (
(( )
CargoViewModel) 7
obj8 ;
); <
;< =
Task 
RemoveAsync 
( 
Guid 
id  
)  !
;! "
Task 
< 
IEnumerable 
< 
CargoViewModel '
>' (
>( )
SearchAsync* 5
(5 6

Expression6 @
<@ A
FuncA E
<E F
CargoF K
,K L
boolM Q
>Q R
>R S
	predicateT ]
)] ^
;^ _
Task 
< 
CargoViewModel 
> 
GetOneAsync (
(( )

Expression) 3
<3 4
Func4 8
<8 9
Cargo9 >
,> ?
bool@ D
>D E
>E F
	predicateG P
)P Q
;Q R
} 
} µ
òC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\Interfaces\Services\IClienteAppService.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

Interfaces+ 5
.5 6
Services6 >
{		 
public

 

	interface

 
IClienteAppService

 '
:

( )
IDisposable

* 5
{ 
Task 
< 
ClienteViewModel 
> 
AddAsync '
(' (
ClienteViewModel( 8
obj9 <
)< =
;= >
Task 
< 
ClienteViewModel 
> 
GetByIdAsync +
(+ ,
Guid, 0
id1 3
)3 4
;4 5
Task 
< 
IEnumerable 
< 
ClienteViewModel )
>) *
>* +
GetAllAsync, 7
(7 8
)8 9
;9 :
Task 
< 
ClienteViewModel 
> 
UpdateAsync *
(* +
ClienteViewModel+ ;
obj< ?
)? @
;@ A
Task 
RemoveAsync 
( 
Guid 
id  
)  !
;! "
Task 
< 
IEnumerable 
< 
ClienteViewModel )
>) *
>* +
SearchAsync, 7
(7 8

Expression8 B
<B C
FuncC G
<G H
ClienteH O
,O P
boolQ U
>U V
>V W
	predicateX a
)a b
;b c
Task 
< 
ClienteViewModel 
> 
GetOneAsync *
(* +

Expression+ 5
<5 6
Func6 :
<: ;
Cliente; B
,B C
boolD H
>H I
>I J
	predicateK T
)T U
;U V
} 
} ÷
õC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\Interfaces\Services\IConvocacaoAppService.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

Interfaces+ 5
.5 6
Services6 >
{		 
public

 

	interface

 !
IConvocacaoAppService

 *
:

+ ,
IDisposable

- 8
{ 
Task 
< 
ConvocacaoViewModel  
>  !
AddAsync" *
(* +
ConvocacaoViewModel+ >
obj? B
)B C
;C D
Task 
< 
ConvocacaoViewModel  
>  !
GetByIdAsync" .
(. /
Guid/ 3
id4 6
)6 7
;7 8
Task 
< 
IEnumerable 
< 
ConvocacaoViewModel ,
>, -
>- .
GetAllAsync/ :
(: ;
); <
;< =
Task 
< 
ConvocacaoViewModel  
>  !
UpdateAsync" -
(- .
ConvocacaoViewModel. A
objB E
)E F
;F G
Task 
RemoveAsync 
( 
Guid 
id  
)  !
;! "
Task 
< 
IEnumerable 
< 
ConvocacaoViewModel ,
>, -
>- .
SearchAsync/ :
(: ;

Expression; E
<E F
FuncF J
<J K

ConvocacaoK U
,U V
boolW [
>[ \
>\ ]
	predicate^ g
)g h
;h i
Task 
< 
string 
> "
GerarSenhaUsuarioAsync +
(+ ,
), -
;- .
List 
< 
ConvocadoViewModel 
>  "
MontaListaDeConvocados! 7
(7 8
IEnumerable8 C
<C D
ConvocacaoViewModelD W
>W X
dadosConfirmadosY i
,i j
IEnumerable 
< 
ConvocadoViewModel *
>* +

convocados, 6
)6 7
;7 8
Task 
< 
ConvocacaoViewModel  
>  !
GetOneAsync" -
(- .

Expression. 8
<8 9
Func9 =
<= >

Convocacao> H
,H I
boolJ N
>N O
>O P
	predicateQ Z
)Z [
;[ \
void 
DetachLocal 
( 
Func 
< 

Convocacao (
,( )
bool* .
>. /
func0 4
)4 5
;5 6
} 
}   Ö
öC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\Interfaces\Services\IConvocadoAppService.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

Interfaces+ 5
.5 6
Services6 >
{		 
public

 

	interface

  
IConvocadoAppService

 )
:

* +
IDisposable

, 7
{ 
Task 
< 
ConvocadoViewModel 
>  
AddAsync! )
() *
ConvocadoViewModel* <
obj= @
)@ A
;A B
Task 
< 
ConvocadoViewModel 
>  
GetByIdAsync! -
(- .
Guid. 2
id3 5
)5 6
;6 7
Task 
< 
IEnumerable 
< 
ConvocadoViewModel +
>+ ,
>, -
GetAllAsync. 9
(9 :
): ;
;; <
Task 
< 
ConvocadoViewModel 
>  
UpdateAsync! ,
(, -
ConvocadoViewModel- ?
obj@ C
)C D
;D E
Task 
RemoveAsync 
( 
Guid 
id  
)  !
;! "
Task 
< 
IEnumerable 
< 
ConvocadoViewModel +
>+ ,
>, -
SearchAsync. 9
(9 :

Expression: D
<D E
FuncE I
<I J
	ConvocadoJ S
,S T
boolU Y
>Y Z
>Z [
	predicate\ e
)e f
;f g
Task 
< 
bool 
> !
VerificaSeHaSobrenome (
(( )
string) /
nome0 4
)4 5
;5 6
Task 
< 
ConvocadoViewModel 
>  
GetOneAsync! ,
(, -

Expression- 7
<7 8
Func8 <
<< =
	Convocado= F
,F G
boolH L
>L M
>M N
	predicateO X
)X Y
;Y Z
} 
} Í
†C:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\Interfaces\Services\IDadosConvocacaoAppService.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

Interfaces+ 5
.5 6
Services6 >
{		 
public

 

	interface

 &
IDadosConvocacaoAppService

 /
:

0 1
IDisposable

2 =
{ 
Task 
< $
DadosConvocadosViewModel %
>% &
AddAsync' /
(/ 0$
DadosConvocadosViewModel0 H
objI L
)L M
;M N
Task 
< $
DadosConvocadosViewModel %
>% &
GetByIdAsync' 3
(3 4
Guid4 8
id9 ;
); <
;< =
Task 
< 
IEnumerable 
< $
DadosConvocadosViewModel 1
>1 2
>2 3
GetAllAsync4 ?
(? @
)@ A
;A B
Task 
< $
DadosConvocadosViewModel %
>% &
UpdateAsync' 2
(2 3$
DadosConvocadosViewModel3 K
objL O
)O P
;P Q
Task 
RemoveAsync 
( 
Guid 
id  
)  !
;! "
Task 
< 
IEnumerable 
< $
DadosConvocadosViewModel 1
>1 2
>2 3
SearchAsync4 ?
(? @

Expression@ J
<J K
FuncK O
<O P
	ConvocadoP Y
,Y Z
bool[ _
>_ `
>` a
	predicateb k
)k l
;l m
Task 
< $
DadosConvocadosViewModel %
>% &
GetOneAsync' 2
(2 3

Expression3 =
<= >
Func> B
<B C
	ConvocadoC L
,L M
boolN R
>R S
>S T
	predicateU ^
)^ _
;_ `
Task 
SalvarCargosAsync 
( 
Guid #
id$ &
,& '
List( ,
<, -
Cargo- 2
>2 3

listaCargo4 >
)> ?
;? @
Task !
SalvarCandidatosAsync "
(" #
Guid# '
id( *
,* +
List, 0
<0 1
	Convocado1 :
>: ;
listaConvocados< K
)L M
;M N
} 
} ù
ùC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\Interfaces\Services\IDocumentacaoAppService.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

Interfaces+ 5
.5 6
Services6 >
{		 
public

 

	interface

 #
IDocumentacaoAppService

 ,
:

- .
IDisposable

/ :
{ 
Task 
< !
DocumentacaoViewModel "
>" #
AddAsync$ ,
(, -!
DocumentacaoViewModel- B
objC F
)F G
;G H
Task 
< !
DocumentacaoViewModel "
>" #
GetByIdAsync$ 0
(0 1
Guid1 5
id6 8
)8 9
;9 :
Task 
< 
IEnumerable 
< !
DocumentacaoViewModel .
>. /
>/ 0
GetAllAsync1 <
(< =
)= >
;> ?
Task 
< !
DocumentacaoViewModel "
>" #
UpdateAsync$ /
(/ 0!
DocumentacaoViewModel0 E
objF I
)I J
;J K
Task 
RemoveAsync 
( 
Guid 
id  
)  !
;! "
Task 
< 
IEnumerable 
< !
DocumentacaoViewModel .
>. /
>/ 0
SearchAsync1 <
(< =

Expression= G
<G H
FuncH L
<L M
	DocumentoM V
,V W
boolX \
>\ ]
>] ^
	predicate_ h
)h i
;i j
} 
} ©
£C:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\Interfaces\Services\IDocumentoCandidatoAppService.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

Interfaces+ 5
.5 6
Services6 >
{		 
public

 

	interface

 )
IDocumentoCandidatoAppService

 2
:

3 4
IDisposable

5 @
{ 
Task 
< '
DocumentoCandidatoViewModel (
>( )
AddAsync* 2
(2 3'
DocumentoCandidatoViewModel3 N
objO R
)R S
;S T
Task 
< '
DocumentoCandidatoViewModel (
>( )
GetByIdAsync* 6
(6 7
Guid7 ;
id< >
)> ?
;? @
Task 
< 
IEnumerable 
< '
DocumentoCandidatoViewModel 4
>4 5
>5 6
GetAllAsync7 B
(B C
)C D
;D E
Task 
< '
DocumentoCandidatoViewModel (
>( )
UpdateAsync* 5
(5 6'
DocumentoCandidatoViewModel6 Q
objR U
)U V
;V W
Task 
RemoveAsync 
( 
Guid 
id  
)  !
;! "
Task 
< 
IEnumerable 
< '
DocumentoCandidatoViewModel 4
>4 5
>5 6
SearchAsync7 B
(B C

ExpressionC M
<M N
FuncN R
<R S
DocumentoCandidatoS e
,e f
boolg k
>k l
>l m
	predicaten w
)w x
;x y
Task 
< '
DocumentoCandidatoViewModel (
>( )
GetOneAsync* 5
(5 6

Expression6 @
<@ A
FuncA E
<E F
DocumentoCandidatoF X
,X Y
boolZ ^
>^ _
>_ `
	predicatea j
)j k
;k l
Task 
< 
List 
< $
ListaDocumentosViewModel *
>* +
>+ ,/
#MontarListaDeDocumentosDoCandidatos- P
(P Q
IEnumerableQ \
<\ ]'
DocumentoCandidatoViewModel] x
>x y

documentos	z Ñ
,
Ñ Ö
IEnumerable
Ü ë
<
ë í 
ConvocadoViewModel
í §
>
§ •
dadosCandidatos
¶ µ
)
µ ∂
;
∂ ∑
} 
} ’
ñC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\Interfaces\Services\IEmailAppService.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

Interfaces+ 5
.5 6
Services6 >
{ 
public 

	interface 
IEmailAppService %
{ 
void 
EnviarEmail 
( 
ConvocadoViewModel +

convocacao, 6
)6 7
;7 8
} 
}		 ©
óC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\Interfaces\Services\IPessoaAppService.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

Interfaces+ 5
.5 6
Services6 >
{		 
public

 

	interface

 
IPessoaAppService

 &
:

' (
IDisposable

) 4
{ 
Task 
< 
PessoaViewModel 
> 
AddAsync &
(& '
PessoaViewModel' 6
obj7 :
): ;
;; <
Task 
< 
PessoaViewModel 
> 
GetByIdAsync *
(* +
Guid+ /
id0 2
)2 3
;3 4
Task 
< 
IEnumerable 
< 
PessoaViewModel (
>( )
>) *
GetAllAsync+ 6
(6 7
)7 8
;8 9
Task 
< 
PessoaViewModel 
> 
UpdateAsync )
() *
PessoaViewModel* 9
obj: =
)= >
;> ?
Task 
RemoveAsync 
( 
Guid 
id  
)  !
;! "
Task 
< 
IEnumerable 
< 
PessoaViewModel (
>( )
>) *
SearchAsync+ 6
(6 7

Expression7 A
<A B
FuncB F
<F G
PessoaG M
,M N
boolO S
>S T
>T U
	predicateV _
)_ `
;` a
Task 
< 
PessoaViewModel 
> 
GetOneAsync )
() *

Expression* 4
<4 5
Func5 9
<9 :
Pessoa: @
,@ A
boolB F
>F G
>G H
	predicateI R
)R S
;S T
} 
} â
üC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\Interfaces\Services\IPrimeiroAcessoAppService.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

Interfaces+ 5
.5 6
Services6 >
{		 
public

 

	interface

 %
IPrimeiroAcessoAppService

 .
:

/ 0
IDisposable

1 <
{ 
Task 
< #
PrimeiroAcessoViewModel $
>$ %
AddAsync& .
(. /#
PrimeiroAcessoViewModel/ F
objG J
)J K
;K L
Task 
< #
PrimeiroAcessoViewModel $
>$ %
GetByIdAsync& 2
(2 3
Guid3 7
id8 :
): ;
;; <
Task 
< 
IEnumerable 
< #
PrimeiroAcessoViewModel 0
>0 1
>1 2
GetAllAsync3 >
(> ?
)? @
;@ A
Task 
< #
PrimeiroAcessoViewModel $
>$ %
UpdateAsync& 1
(1 2#
PrimeiroAcessoViewModel2 I
objJ M
)M N
;N O
Task 
RemoveAsync 
( 
Guid 
id  
)  !
;! "
Task 
< 
IEnumerable 
< #
PrimeiroAcessoViewModel 0
>0 1
>1 2
SearchAsync3 >
(> ?

Expression? I
<I J
FuncJ N
<N O
PrimeiroAcessoO ]
,] ^
bool_ c
>c d
>d e
	predicatef o
)o p
;p q
Task 
< #
PrimeiroAcessoViewModel $
>$ %
GetOneAsync& 1
(1 2

Expression2 <
<< =
Func= A
<A B
PrimeiroAcessoB P
,P Q
boolR V
>V W
>W X
	predicateY b
)b c
;c d
} 
} ¡
ôC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\Interfaces\Services\IProcessoAppService.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

Interfaces+ 5
.5 6
Services6 >
{		 
public

 

	interface

 
IProcessoAppService

 (
:

) *
IDisposable

+ 6
{ 
Task 
< 
ProcessoViewModel 
> 
AddAsync  (
(( )
ProcessoViewModel) :
obj; >
)> ?
;? @
Task 
< 
ProcessoViewModel 
> 
GetByIdAsync  ,
(, -
Guid- 1
id2 4
)4 5
;5 6
Task 
< 
IEnumerable 
< 
ProcessoViewModel *
>* +
>+ ,
GetAllAsync- 8
(8 9
)9 :
;: ;
Task 
< 
ProcessoViewModel 
> 
UpdateAsync  +
(+ ,
ProcessoViewModel, =
obj> A
)A B
;B C
Task 
RemoveAsync 
( 
Guid 
id  
)  !
;! "
Task 
< 
IEnumerable 
< 
ProcessoViewModel *
>* +
>+ ,
SearchAsync- 8
(8 9

Expression9 C
<C D
FuncD H
<H I
ProcessoI Q
,Q R
boolS W
>W X
>X Y
	predicateZ c
)c d
;d e
Task 
< 
ProcessoViewModel 
> 
GetOneAsync  +
(+ ,

Expression, 6
<6 7
Func7 ;
<; <
Processo< D
,D E
boolF J
>J K
>K L
	predicateM V
)V W
;W X
} 
} ¡
ôC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\Interfaces\Services\ITelefoneAppService.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

Interfaces+ 5
.5 6
Services6 >
{		 
public

 

	interface

 
ITelefoneAppService

 (
:

) *
IDisposable

+ 6
{ 
Task 
< 
TelefoneViewModel 
> 
AddAsync  (
(( )
TelefoneViewModel) :
obj; >
)> ?
;? @
Task 
< 
TelefoneViewModel 
> 
GetByIdAsync  ,
(, -
Guid- 1
id2 4
)4 5
;5 6
Task 
< 
IEnumerable 
< 
TelefoneViewModel *
>* +
>+ ,
GetAllAsync- 8
(8 9
)9 :
;: ;
Task 
< 
TelefoneViewModel 
> 
UpdateAsync  +
(+ ,
TelefoneViewModel, =
obj> A
)A B
;B C
Task 
RemoveAsync 
( 
Guid 
id  
)  !
;! "
Task 
< 
IEnumerable 
< 
TelefoneViewModel *
>* +
>+ ,
SearchAsync- 8
(8 9

Expression9 C
<C D
FuncD H
<H I
TelefoneI Q
,Q R
boolS W
>W X
>X Y
	predicateZ c
)c d
;d e
Task 
< 
TelefoneViewModel 
> 
GetOneAsync  +
(+ ,

Expression, 6
<6 7
Func7 ;
<; <
Telefone< D
,D E
boolF J
>J K
>K L
	predicateM V
)V W
;W X
} 
} ˝
ûC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\Interfaces\Services\ITipoDocumentoAppService.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

Interfaces+ 5
.5 6
Services6 >
{		 
public

 

	interface

 $
ITipoDocumentoAppService

 -
:

. /
IDisposable

0 ;
{ 
Task 
< "
TipoDocumentoViewModel #
># $
AddAsync% -
(- ."
TipoDocumentoViewModel. D
objE H
)H I
;I J
Task 
< "
TipoDocumentoViewModel #
># $
GetByIdAsync% 1
(1 2
Guid2 6
id7 9
)9 :
;: ;
Task 
< 
IEnumerable 
< "
TipoDocumentoViewModel /
>/ 0
>0 1
GetAllAsync2 =
(= >
)> ?
;? @
Task 
< "
TipoDocumentoViewModel #
># $
UpdateAsync% 0
(0 1"
TipoDocumentoViewModel1 G
objH K
)K L
;L M
Task 
RemoveAsync 
( 
Guid 
id  
)  !
;! "
Task 
< 
IEnumerable 
< "
TipoDocumentoViewModel /
>/ 0
>0 1
SearchAsync2 =
(= >

Expression> H
<H I
FuncI M
<M N
TipoDocumentoN [
,[ \
bool] a
>a b
>b c
	predicated m
)m n
;n o
Task 
< "
TipoDocumentoViewModel #
># $
GetOneAsync% 0
(0 1

Expression1 ;
<; <
Func< @
<@ A
TipoDocumentoA N
,N O
boolP T
>T U
>U V
	predicateW `
)` a
;a b
} 
} µ
òC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\Interfaces\Services\IUsuarioAppService.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

Interfaces+ 5
.5 6
Services6 >
{		 
public

 

	interface

 
IUsuarioAppService

 '
:

( )
IDisposable

* 5
{ 
Task 
< 
UsuarioViewModel 
> 
AddAsync '
(' (
UsuarioViewModel( 8
obj9 <
)< =
;= >
Task 
< 
UsuarioViewModel 
> 
GetByIdAsync +
(+ ,
Guid, 0
id1 3
)3 4
;4 5
Task 
< 
IEnumerable 
< 
UsuarioViewModel )
>) *
>* +
GetAllAsync, 7
(7 8
)8 9
;9 :
Task 
< 
UsuarioViewModel 
> 
UpdateAsync *
(* +
UsuarioViewModel+ ;
obj< ?
)? @
;@ A
Task 
RemoveAsync 
( 
Guid 
id  
)  !
;! "
Task 
< 
IEnumerable 
< 
UsuarioViewModel )
>) *
>* +
SearchAsync, 7
(7 8

Expression8 B
<B C
FuncC G
<G H
UsuarioH O
,O P
boolQ U
>U V
>V W
	predicateX a
)a b
;b c
Task 
< 
UsuarioViewModel 
> 
GetOneAsync *
(* +

Expression+ 5
<5 6
Func6 :
<: ;
Usuario; B
,B C
boolD H
>H I
>I J
	predicateK T
)T U
;U V
} 
} £-
äC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\Services\AdminAppService.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +
Services+ 3
{ 
public 

class 
AdminAppService  
:! "
IAdminAppService# 3
{ 
private 
readonly 
IAdminService &
_adminService' 4
;4 5
private 
readonly 
IMapper  
_mapper! (
;( )
public 
AdminAppService 
( 
IAdminService ,
adminService- 9
,9 :
IMapper; B
mapperC I
)I J
{ 	
_adminService 
= 
adminService (
;( )
_mapper 
= 
mapper 
; 
} 	
public 
void 
Dispose 
( 
) 
{ 	
_adminService 
. 
Dispose !
(! "
)" #
;# $
} 	
public 
async 
Task 
< 
Admin2ViewModel )
>) *
AddAsync+ 3
(3 4
Admin2ViewModel4 C
objD G
)G H
{ 	
var 
admin 
= 
_mapper 
.  
Map  #
<# $
Admin2ViewModel$ 3
,3 4
Admin5 :
>: ;
(; <
obj< ?
)? @
;@ A
await   
_adminService   
.    
AddAsync    (
(  ( )
admin  ) .
)  . /
;  / 0
return!! 
obj!! 
;!! 
}"" 	
public$$ 
async$$ 
Task$$ 
<$$ 
Admin2ViewModel$$ )
>$$) *
GetByIdAsync$$+ 7
($$7 8
Guid$$8 <
id$$= ?
)$$? @
{%% 	
return&& 
_mapper&& 
.&& 
Map&& 
<&& 
Admin&& $
,&&$ %
Admin2ViewModel&&& 5
>&&5 6
(&&6 7
await&&7 <
_adminService&&= J
.&&J K
GetByIdAsync&&K W
(&&W X
id&&X Z
)&&Z [
)&&[ \
;&&\ ]
}'' 	
public)) 
async)) 
Task)) 
<)) 
IEnumerable)) %
<))% &
Admin2ViewModel))& 5
>))5 6
>))6 7
GetAllAsync))8 C
())C D
)))D E
{** 	
return++ 
_mapper++ 
.++ 
Map++ 
<++ 
IEnumerable++ *
<++* +
Admin+++ 0
>++0 1
,++1 2
IEnumerable++3 >
<++> ?
Admin2ViewModel++? N
>++N O
>++O P
(++P Q
await++Q V
_adminService++W d
.++d e
GetAllAsync++e p
(++p q
)++q r
)++r s
;++s t
},, 	
public.. 
async.. 
Task.. 
<.. 
Admin2ViewModel.. )
>..) *
UpdateAsync..+ 6
(..6 7
Admin2ViewModel..7 F
obj..G J
)..J K
{// 	
await00 
_adminService00 
.00  
UpdateAsync00  +
(00+ ,
_mapper00, 3
.003 4
Map004 7
<007 8
Admin2ViewModel008 G
,00G H
Admin00I N
>00N O
(00O P
obj00P S
)00S T
)00T U
;00U V
return11 
obj11 
;11 
}22 	
public44 
async44 
Task44 
RemoveAsync44 %
(44% &
Guid44& *
id44+ -
)44- .
{55 	
await66 
_adminService66 
.66  
RemoveAsync66  +
(66+ ,
id66, .
)66. /
;66/ 0
}77 	
public99 
async99 
Task99 
<99 
IEnumerable99 %
<99% &
Admin2ViewModel99& 5
>995 6
>996 7
SearchAsync998 C
(99C D

Expression99D N
<99N O
Func99O S
<99S T
Admin99T Y
,99Y Z
bool99[ _
>99_ `
>99` a
	predicate99b k
)99k l
{:: 	
return;; 
_mapper;; 
.;; 
Map;; 
<;; 
IEnumerable;; *
<;;* +
Admin;;+ 0
>;;0 1
,;;1 2
IEnumerable;;3 >
<;;> ?
Admin2ViewModel;;? N
>;;N O
>;;O P
(;;P Q
await;;Q V
_adminService;;W d
.;;d e
SearchAsync;;e p
(;;p q
	predicate;;q z
);;z {
);;{ |
;;;| }
}<< 	
public>> 
async>> 
Task>> 
<>> 
Admin2ViewModel>> )
>>>) *
GetOneAsync>>+ 6
(>>6 7

Expression>>7 A
<>>A B
Func>>B F
<>>F G
Admin>>G L
,>>L M
bool>>N R
>>>R S
>>>S T
	predicate>>U ^
)>>^ _
{?? 	
return@@ 
_mapper@@ 
.@@ 
Map@@ 
<@@ 
Admin@@ $
,@@$ %
Admin2ViewModel@@& 5
>@@5 6
(@@6 7
await@@7 <
_adminService@@= J
.@@J K
GetOneAsync@@K V
(@@V W
	predicate@@W `
)@@` a
)@@a b
;@@b c
}AA 	
}BB 
}CC ï-
äC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\Services\CargoAppService.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +
Services+ 3
{ 
public 

class 
CargoAppService  
:! "
ICargoAppService# 3
{ 
private 
readonly 
ICargoService &
_cargoService' 4
;4 5
private 
readonly 
IMapper  
_mapper! (
;( )
public 
CargoAppService 
( 
ICargoService ,
cargoService- 9
,9 :
IMapper; B
mapperC I
)I J
{ 	
_cargoService 
= 
cargoService (
;( )
_mapper 
= 
mapper 
; 
} 	
public 
void 
Dispose 
( 
) 
{ 	
_cargoService 
. 
Dispose !
(! "
)" #
;# $
} 	
public 
async 
Task 
< 
CargoViewModel (
>( )
AddAsync* 2
(2 3
CargoViewModel3 A
objB E
)E F
{ 	
var 
cargo 
= 
_mapper 
.  
Map  #
<# $
CargoViewModel$ 2
,2 3
Cargo4 9
>9 :
(: ;
obj; >
)> ?
;? @
await   
_cargoService   
.    
AddAsync    (
(  ( )
cargo  ) .
)  . /
;  / 0
return!! 
obj!! 
;!! 
}"" 	
public$$ 
async$$ 
Task$$ 
<$$ 
CargoViewModel$$ (
>$$( )
GetByIdAsync$$* 6
($$6 7
Guid$$7 ;
id$$< >
)$$> ?
{%% 	
return&& 
_mapper&& 
.&& 
Map&& 
<&& 
Cargo&& $
,&&$ %
CargoViewModel&&& 4
>&&4 5
(&&5 6
await&&6 ;
_cargoService&&< I
.&&I J
GetByIdAsync&&J V
(&&V W
id&&W Y
)&&Y Z
)&&Z [
;&&[ \
}'' 	
public)) 
async)) 
Task)) 
<)) 
IEnumerable)) %
<))% &
CargoViewModel))& 4
>))4 5
>))5 6
GetAllAsync))7 B
())B C
)))C D
{** 	
return++ 
_mapper++ 
.++ 
Map++ 
<++ 
IEnumerable++ *
<++* +
Cargo+++ 0
>++0 1
,++1 2
IEnumerable++3 >
<++> ?
CargoViewModel++? M
>++M N
>++N O
(++O P
await++P U
_cargoService++V c
.++c d
GetAllAsync++d o
(++o p
)++p q
)++q r
;++r s
},, 	
public.. 
async.. 
Task.. 
<.. 
CargoViewModel.. (
>..( )
UpdateAsync..* 5
(..5 6
CargoViewModel..6 D
obj..E H
)..H I
{// 	
await00 
_cargoService00 
.00  
UpdateAsync00  +
(00+ ,
_mapper00, 3
.003 4
Map004 7
<007 8
CargoViewModel008 F
,00F G
Cargo00H M
>00M N
(00N O
obj00O R
)00R S
)00S T
;00T U
return22 
obj22 
;22 
}33 	
public55 
async55 
Task55 
RemoveAsync55 %
(55% &
Guid55& *
id55+ -
)55- .
{66 	
await77 
_cargoService77 
.77  
RemoveAsync77  +
(77+ ,
id77, .
)77. /
;77/ 0
}88 	
public:: 
async:: 
Task:: 
<:: 
IEnumerable:: %
<::% &
CargoViewModel::& 4
>::4 5
>::5 6
SearchAsync::7 B
(::B C

Expression::C M
<::M N
Func::N R
<::R S
Cargo::S X
,::X Y
bool::Z ^
>::^ _
>::_ `
	predicate::a j
)::j k
{;; 	
return<< 
_mapper<< 
.<< 
Map<< 
<<< 
IEnumerable<< *
<<<* +
Cargo<<+ 0
><<0 1
,<<1 2
IEnumerable<<3 >
<<<> ?
CargoViewModel<<? M
><<M N
><<N O
(<<O P
await<<P U
_cargoService<<V c
.<<c d
SearchAsync<<d o
(<<o p
	predicate<<p y
)<<y z
)<<z {
;<<{ |
}== 	
public?? 
async?? 
Task?? 
<?? 
CargoViewModel?? (
>??( )
GetOneAsync??* 5
(??5 6

Expression??6 @
<??@ A
Func??A E
<??E F
Cargo??F K
,??K L
bool??M Q
>??Q R
>??R S
	predicate??T ]
)??] ^
{@@ 	
returnAA 
_mapperAA 
.AA 
MapAA 
<AA 
CargoAA $
,AA$ %
CargoViewModelAA& 4
>AA4 5
(AA5 6
awaitAA6 ;
_cargoServiceAA< I
.AAI J
GetOneAsyncAAJ U
(AAU V
	predicateAAV _
)AA_ `
)AA` a
;AAa b
}BB 	
}CC 
}DD Ó-
åC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\Services\ClienteAppService.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +
Services+ 3
{ 
public 

class 
ClienteAppService "
:# $
IClienteAppService% 7
{ 
private 
readonly 
IClienteService (
_clienteService) 8
;8 9
private 
readonly 
IMapper  
_mapper! (
;( )
public 
ClienteAppService  
(  !
IClienteService! 0
clienteService1 ?
,? @
IMapperA H
mapperI O
)O P
{ 	
_clienteService 
= 
clienteService ,
;, -
_mapper 
= 
mapper 
; 
} 	
public 
void 
Dispose 
( 
) 
{ 	
_clienteService 
. 
Dispose "
(" #
)# $
;$ %
} 	
public 
async 
Task 
< 
ClienteViewModel *
>* +
AddAsync, 4
(4 5
ClienteViewModel5 E
objF I
)I J
{ 	
var 
cliente 
= 
_mapper !
.! "
Map" %
<% &
ClienteViewModel& 6
,6 7
Cliente8 ?
>? @
(@ A
objA D
)D E
;E F
await   
_clienteService   !
.  ! "
AddAsync  " *
(  * +
cliente  + 2
)  2 3
;  3 4
return"" 
obj"" 
;"" 
}## 	
public%% 
async%% 
Task%% 
<%% 
ClienteViewModel%% *
>%%* +
GetByIdAsync%%, 8
(%%8 9
Guid%%9 =
id%%> @
)%%@ A
{&& 	
return'' 
_mapper'' 
.'' 
Map'' 
<'' 
Cliente'' &
,''& '
ClienteViewModel''( 8
>''8 9
(''9 :
await'': ?
_clienteService''@ O
.''O P
GetByIdAsync''P \
(''\ ]
id''] _
)''_ `
)''` a
;''a b
}(( 	
public** 
async** 
Task** 
<** 
IEnumerable** %
<**% &
ClienteViewModel**& 6
>**6 7
>**7 8
GetAllAsync**9 D
(**D E
)**E F
{++ 	
return,, 
_mapper,, 
.,, 
Map,, 
<,, 
IEnumerable,, *
<,,* +
Cliente,,+ 2
>,,2 3
,,,3 4
IEnumerable,,5 @
<,,@ A
ClienteViewModel,,A Q
>,,Q R
>,,R S
(,,S T
await,,T Y
_clienteService,,Z i
.,,i j
GetAllAsync,,j u
(,,u v
),,v w
),,w x
;,,x y
}-- 	
public// 
async// 
Task// 
<// 
ClienteViewModel// *
>//* +
UpdateAsync//, 7
(//7 8
ClienteViewModel//8 H
obj//I L
)//L M
{00 	
await11 
_clienteService11 !
.11! "
UpdateAsync11" -
(11- .
_mapper11. 5
.115 6
Map116 9
<119 :
ClienteViewModel11: J
,11J K
Cliente11L S
>11S T
(11T U
obj11U X
)11X Y
)11Y Z
;11Z [
return22 
obj22 
;22 
}33 	
public55 
async55 
Task55 
RemoveAsync55 %
(55% &
Guid55& *
id55+ -
)55- .
{66 	
await77 
_clienteService77 !
.77! "
RemoveAsync77" -
(77- .
id77. 0
)770 1
;771 2
}88 	
public:: 
async:: 
Task:: 
<:: 
IEnumerable:: %
<::% &
ClienteViewModel::& 6
>::6 7
>::7 8
SearchAsync::9 D
(::D E

Expression::E O
<::O P
Func::P T
<::T U
Cliente::U \
,::\ ]
bool::^ b
>::b c
>::c d
	predicate::e n
)::n o
{;; 	
return<< 
_mapper<< 
.<< 
Map<< 
<<< 
IEnumerable<< *
<<<* +
Cliente<<+ 2
><<2 3
,<<3 4
IEnumerable<<5 @
<<<@ A
ClienteViewModel<<A Q
><<Q R
><<R S
(<<S T
await<<T Y
_clienteService<<Z i
.<<i j
SearchAsync<<j u
(<<u v
	predicate<<v 
)	<< Ä
)
<<Ä Å
;
<<Å Ç
}== 	
public?? 
async?? 
Task?? 
<?? 
ClienteViewModel?? *
>??* +
GetOneAsync??, 7
(??7 8

Expression??8 B
<??B C
Func??C G
<??G H
Cliente??H O
,??O P
bool??Q U
>??U V
>??V W
	predicate??X a
)??a b
{@@ 	
returnAA 
_mapperAA 
.AA 
MapAA 
<AA 
ClienteAA &
,AA& '
ClienteViewModelAA( 8
>AA8 9
(AA9 :
awaitAA: ?
_clienteServiceAA@ O
.AAO P
GetOneAsyncAAP [
(AA[ \
	predicateAA\ e
)AAe f
)AAf g
;AAg h
}BB 	
}CC 
}DD ç_
èC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\Services\ConvocacaoAppService.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +
Services+ 3
{ 
public 

class  
ConvocacaoAppService %
:& '!
IConvocacaoAppService( =
{ 
private 
readonly 
IConvocacaoService +
_convocacaoService, >
;> ?
private 
readonly 
IListaOpcoes %!
_opcoesComparecimento& ;
;; <
private 
readonly "
IPrimeiroAcessoService /"
_primeiroAcessoService0 F
;F G
private 
readonly 
IMapper  
_mapper! (
;( )
public  
ConvocacaoAppService #
(# $
IConvocacaoService 
convocacaoService 0
,0 1
IListaOpcoes  
opcoesComparecimento -
,- ."
IPrimeiroAcessoService "!
primeiroAcessoService# 8
,8 9
IMapper: A
mapperB H
)H I
{ 	
_convocacaoService 
=  
convocacaoService! 2
;2 3!
_opcoesComparecimento !
=" # 
opcoesComparecimento$ 8
;8 9"
_primeiroAcessoService "
=# $!
primeiroAcessoService% :
;: ;
_mapper 
= 
mapper 
; 
} 	
public!! 
void!! 
Dispose!! 
(!! 
)!! 
{"" 	
_convocacaoService## 
.## 
Dispose## &
(##& '
)##' (
;##( )
}$$ 	
public&& 
async&& 
Task&& 
<&& 
ConvocacaoViewModel&& -
>&&- .
AddAsync&&/ 7
(&&7 8
ConvocacaoViewModel&&8 K
obj&&L O
)&&O P
{'' 	
var(( 

convocacao(( 
=(( 
_mapper(( $
.(($ %
Map((% (
<((( )
ConvocacaoViewModel(() <
,((< =

Convocacao((> H
>((H I
(((I J
obj((J M
)((M N
;((N O
await)) 
_convocacaoService)) $
.))$ %
AddAsync))% -
())- .

convocacao)). 8
)))8 9
;))9 :
return** 
obj** 
;** 
}++ 	
public-- 
async-- 
Task-- 
<-- 
ConvocacaoViewModel-- -
>--- .
GetByIdAsync--/ ;
(--; <
Guid--< @
id--A C
)--C D
{.. 	
return// 
_mapper// 
.// 
Map// 
<// 

Convocacao// )
,//) *
ConvocacaoViewModel//+ >
>//> ?
(//? @
await//@ E
_convocacaoService//F X
.//X Y
GetByIdAsync//Y e
(//e f
id//f h
)//h i
)//i j
;//j k
}00 	
public22 
async22 
Task22 
<22 
IEnumerable22 %
<22% &
ConvocacaoViewModel22& 9
>229 :
>22: ;
GetAllAsync22< G
(22G H
)22H I
{33 	
return44 
_mapper44 
.44 
Map44 
<44 
IEnumerable44 *
<44* +

Convocacao44+ 5
>445 6
,446 7
IEnumerable448 C
<44C D
ConvocacaoViewModel44D W
>44W X
>44X Y
(44Y Z
await44Z _
_convocacaoService44` r
.44r s
GetAllAsync44s ~
(44~ 
)	44 Ä
)
44Ä Å
;
44Å Ç
}55 	
public77 
async77 
Task77 
<77 
ConvocacaoViewModel77 -
>77- .
UpdateAsync77/ :
(77: ;
ConvocacaoViewModel77; N
obj77O R
)77R S
{88 	
await99 
_convocacaoService99 $
.99$ %
UpdateAsync99% 0
(990 1
_mapper991 8
.998 9
Map999 <
<99< =
ConvocacaoViewModel99= P
,99P Q

Convocacao99R \
>99\ ]
(99] ^
obj99^ a
)99a b
)99b c
;99c d
return:: 
obj:: 
;:: 
};; 	
public== 
async== 
Task== 
RemoveAsync== %
(==% &
Guid==& *
id==+ -
)==- .
{>> 	
await?? 
_convocacaoService?? $
.??$ %
RemoveAsync??% 0
(??0 1
id??1 3
)??3 4
;??4 5
}@@ 	
publicBB 
asyncBB 
TaskBB 
<BB 
IEnumerableBB %
<BB% &
ConvocacaoViewModelBB& 9
>BB9 :
>BB: ;
SearchAsyncBB< G
(BBG H

ExpressionBBH R
<BBR S
FuncBBS W
<BBW X

ConvocacaoBBX b
,BBb c
boolBBd h
>BBh i
>BBi j
	predicateBBk t
)BBt u
{CC 	
returnDD 
_mapperDD 
.DD 
MapDD 
<DD 
IEnumerableDD *
<DD* +

ConvocacaoDD+ 5
>DD5 6
,DD6 7
IEnumerableDD8 C
<DDC D
ConvocacaoViewModelDDD W
>DDW X
>DDX Y
(DDY Z
awaitEE 
_convocacaoServiceEE '
.EE' (
SearchAsyncEE( 3
(EE3 4
	predicateEE4 =
)EE= >
)EE> ?
;EE? @
}FF 	
publicHH 
asyncHH 
TaskHH 
<HH 
stringHH  
>HH  !"
GerarSenhaUsuarioAsyncHH" 8
(HH8 9
)HH9 :
{II 	
returnJJ 
awaitJJ 
_convocacaoServiceJJ +
.JJ+ ,!
GeneratePasswordAsyncJJ, A
(JJA B
)JJB C
;JJC D
}KK 	
publicMM 
ListMM 
<MM 
ConvocadoViewModelMM &
>MM& '"
MontaListaDeConvocadosMM( >
(MM> ?
IEnumerableMM? J
<MMJ K
ConvocacaoViewModelMMK ^
>MM^ _
dadosConfirmadosMM` p
,MMp q
IEnumerableNN 
<NN 
ConvocadoViewModelNN *
>NN* +

convocadosNN, 6
)NN6 7
{OO 	
varPP 
resultPP 
=PP 
dadosConfirmadosPP )
.PP) *
	GroupJoinPP* 3
(PP3 4

convocadosPP4 >
,PP> ?
confPP@ D
=>PPE G
confPPH L
.PPL M
ConvocadoIdPPM X
,PPX Y
convPPZ ^
=>PP_ a
convPPb f
.PPf g
ConvocadoIdPPg r
,PPr s
(QQ 
confQQ 
,QQ 
convQQ 
)QQ 
=>QQ 
newQQ  #
{RR 
confSS 
.SS 

DesistenteSS #
,SS# $
confTT 
.TT !
DataEntregaDocumentosTT .
,TT. /
confUU 
.UU 
ConvocacaoIdUU %
,UU% &
confVV 
.VV 
StatusConvocacaoVV )
,VV) *
confWW 
.WW 
StatusContratacaoWW *
,WW* +
confXX 
.XX 
EntrouNoSistemaXX (
,XX( )

convocadosYY 
=YY  
convYY! %
}ZZ 
)ZZ 
;ZZ 
var\\ 
listaDeconvocados\\ !
=\\" #
new\\$ '
List\\( ,
<\\, -
ConvocadoViewModel\\- ?
>\\? @
(\\@ A
)\\A B
;\\B C
foreach^^ 
(^^ 
var^^ 
itens^^ 
in^^ !
result^^" (
)^^( )
{__ 
var`` 
itemDesistente`` "
=``# $
itens``% *
.``* +

Desistente``+ 5
;``5 6
varaa %
itemDataEntregaDocumentosaa -
=aa. /
itensaa0 5
.aa5 6!
DataEntregaDocumentosaa6 K
;aaK L
varbb 
convocacaoIdbb  
=bb! "
itensbb# (
.bb( )
ConvocacaoIdbb) 5
;bb5 6
varcc 
statusConvocacaocc $
=cc% &
itenscc' ,
.cc, -
StatusConvocacaocc- =
;cc= >
listaDeconvocadosee !
.ee! "
AddRangeee" *
(ee* +
itensee+ 0
.ee0 1

convocadosee1 ;
.ee; <
Selectee< B
(eeB C
listaeeC H
=>eeI K
neweeL O
ConvocadoViewModeleeP b
{ff 
ConvocacaoIdgg  
=gg! "
convocacaoIdgg# /
,gg/ 0
ConvocadoIdhh 
=hh  !
listahh" '
.hh' (
ConvocadoIdhh( 3
,hh3 4
Nomeii 
=ii 
listaii  
.ii  !
Nomeii! %
,ii% &
Posicaojj 
=jj 
listajj #
.jj# $
Posicaojj$ +
,jj+ ,
	Inscricaokk 
=kk 
listakk  %
.kk% &
	Inscricaokk& /
,kk/ 0

Desistentell 
=ll  
itemDesistentell! /
,ll/ 0
EntrouNoSistemamm #
=mm$ %"
_primeiroAcessoServicemm& <
.mm< =
SearchAsyncmm= H
(mmH I
ammI J
=>mmK M
ammN O
.mmO P
EmailmmP U
.mmU V
EqualsmmV \
(mm\ ]
listamm] b
.mmb c
Emailmmc h
)mmh i
)mmi j
.mmj k
Resultmmk q
==mmr t
nullmmu y
?nn 
$strnn  
:oo 
$stroo 
,oo  !
DataEntregaDocumentospp )
=pp* +%
itemDataEntregaDocumentospp, E
,ppE F
InstituicaoEnsinoqq %
=qq& '
listaqq( -
.qq- .
InstituicaoEnsinoqq. ?
,qq? @
StatusConvocacaorr $
=rr% &
stringrr' -
.rr- .
IsNullOrEmptyrr. ;
(rr; <
statusConvocacaorr< L
)rrL M
?ss 
$strss 
:tt !
_opcoesComparecimentott /
.tt/ 0
EnumDescriptiontt0 ?
(tt? @
(uu 
StatusConvocacaouu -
)uu- .
Enumuu. 2
.uu2 3
Parseuu3 8
(uu8 9
typeofuu9 ?
(uu? @
StatusConvocacaouu@ P
)uuP Q
,uuQ R
statusConvocacaouuS c
)uuc d
)uud e
}vv 
)vv 
)vv 
;vv 
}ww 
returnyy 
listaDeconvocadosyy $
;yy$ %
}zz 	
public|| 
async|| 
Task|| 
<|| 
ConvocacaoViewModel|| -
>||- .
GetOneAsync||/ :
(||: ;

Expression||; E
<||E F
Func||F J
<||J K

Convocacao||K U
,||U V
bool||W [
>||[ \
>||\ ]
	predicate||^ g
)||g h
{}} 	
return~~ 
_mapper~~ 
.~~ 
Map~~ 
<~~ 

Convocacao~~ )
,~~) *
ConvocacaoViewModel~~+ >
>~~> ?
(~~? @
await~~@ E
_convocacaoService~~F X
.~~X Y
GetOneAsync~~Y d
(~~d e
	predicate~~e n
)~~n o
)~~o p
;~~p q
} 	
public
ÅÅ 
void
ÅÅ 
DetachLocal
ÅÅ 
(
ÅÅ  
Func
ÅÅ  $
<
ÅÅ$ %

Convocacao
ÅÅ% /
,
ÅÅ/ 0
bool
ÅÅ1 5
>
ÅÅ5 6
func
ÅÅ7 ;
)
ÅÅ; <
{
ÇÇ 	 
_convocacaoService
ÉÉ 
.
ÉÉ  
DetachLocal
ÉÉ  +
(
ÉÉ+ ,
func
ÉÉ, 0
)
ÉÉ0 1
;
ÉÉ1 2
}
ÑÑ 	
}
ÖÖ 
}ÜÜ ‚1
éC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\Services\ConvocadoAppService.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +
Services+ 3
{ 
public 

class 
ConvocadoAppService $
:% & 
IConvocadoAppService' ;
{ 
private 
readonly 
IConvocadoService *
_convocadoService+ <
;< =
private 
readonly 
IMapper  
_mapper! (
;( )
public 
ConvocadoAppService "
(" #
IConvocadoService# 4
convocadoService5 E
,E F
IMapperG N
mapperO U
)U V
{ 	
_convocadoService 
= 
convocadoService  0
;0 1
_mapper 
= 
mapper 
; 
} 	
public 
void 
Dispose 
( 
) 
{ 	
_convocadoService 
. 
Dispose %
(% &
)& '
;' (
} 	
public 
async 
Task 
< 
ConvocadoViewModel ,
>, -
AddAsync. 6
(6 7
ConvocadoViewModel7 I
objJ M
)M N
{ 	
var 
	convocado 
= 
_mapper #
.# $
Map$ '
<' (
ConvocadoViewModel( :
,: ;
	Convocado< E
>E F
(F G
objG J
)J K
;K L
await   
_convocadoService   #
.  # $
AddAsync  $ ,
(  , -
	convocado  - 6
)  6 7
;  7 8
return!! 
obj!! 
;!! 
}"" 	
public$$ 
async$$ 
Task$$ 
<$$ 
ConvocadoViewModel$$ ,
>$$, -
GetByIdAsync$$. :
($$: ;
Guid$$; ?
id$$@ B
)$$B C
{%% 	
return&& 
_mapper&& 
.&& 
Map&& 
<&& 
	Convocado&& (
,&&( )
ConvocadoViewModel&&* <
>&&< =
(&&= >
await&&> C
_convocadoService&&D U
.&&U V
GetByIdAsync&&V b
(&&b c
id&&c e
)&&e f
)&&f g
;&&g h
}'' 	
public)) 
async)) 
Task)) 
<)) 
IEnumerable)) %
<))% &
ConvocadoViewModel))& 8
>))8 9
>))9 :
GetAllAsync)); F
())F G
)))G H
{** 	
return++ 
_mapper++ 
.++ 
Map++ 
<++ 
IEnumerable++ *
<++* +
	Convocado+++ 4
>++4 5
,++5 6
IEnumerable++7 B
<++B C
ConvocadoViewModel++C U
>++U V
>++V W
(++W X
await++X ]
_convocadoService++^ o
.++o p
GetAllAsync++p {
(++{ |
)++| }
)++} ~
;++~ 
},, 	
public.. 
async.. 
Task.. 
<.. 
ConvocadoViewModel.. ,
>.., -
UpdateAsync... 9
(..9 :
ConvocadoViewModel..: L
obj..M P
)..P Q
{// 	
await00 
_convocadoService00 "
.00" #
UpdateAsync00# .
(00. /
_mapper00/ 6
.006 7
Map007 :
<00: ;
ConvocadoViewModel00; M
,00M N
	Convocado00O X
>00X Y
(00Y Z
obj00Z ]
)00] ^
)00^ _
;00_ `
return11 
obj11 
;11 
}22 	
public44 
async44 
Task44 
RemoveAsync44 %
(44% &
Guid44& *
id44+ -
)44- .
{55 	
await66 
_convocadoService66 #
.66# $
RemoveAsync66$ /
(66/ 0
id660 2
)662 3
;663 4
}77 	
public99 
async99 
Task99 
<99 
IEnumerable99 %
<99% &
ConvocadoViewModel99& 8
>998 9
>999 :
SearchAsync99; F
(99F G

Expression99G Q
<99Q R
Func99R V
<99V W
	Convocado99W `
,99` a
bool99b f
>99f g
>99g h
	predicate99i r
)99r s
{:: 	
return;; 
_mapper;; 
.;; 
Map;; 
<;; 
IEnumerable;; *
<;;* +
	Convocado;;+ 4
>;;4 5
,;;5 6
IEnumerable;;7 B
<;;B C
ConvocadoViewModel;;C U
>;;U V
>;;V W
(;;W X
await<< 
_convocadoService<< '
.<<' (
SearchAsync<<( 3
(<<3 4
	predicate<<4 =
)<<= >
)<<> ?
;<<? @
}== 	
public?? 
async?? 
Task?? 
<?? 
bool?? 
>?? !
VerificaSeHaSobrenome??  5
(??5 6
string??6 <
nome??= A
)??A B
{@@ 	
returnAA 
awaitAA 
_convocadoServiceAA *
.AA* +!
VerificaSeHaSobrenomeAA+ @
(AA@ A
nomeAAA E
)AAE F
;AAF G
}BB 	
publicDD 
asyncDD 
TaskDD 
<DD 
ConvocadoViewModelDD ,
>DD, -
GetOneAsyncDD. 9
(DD9 :

ExpressionDD: D
<DDD E
FuncDDE I
<DDI J
	ConvocadoDDJ S
,DDS T
boolDDU Y
>DDY Z
>DDZ [
	predicateDD\ e
)DDe f
{EE 	
returnFF 
_mapperFF 
.FF 
MapFF 
<FF 
	ConvocadoFF (
,FF( )
ConvocadoViewModelFF* <
>FF< =
(FF= >
awaitFF> C
_convocadoServiceFFD U
.FFU V
GetOneAsyncFFV a
(FFa b
	predicateFFb k
)FFk l
)FFl m
;FFm n
}GG 	
}HH 
}II Á7
îC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\Services\DadosConvocacaoAppService.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +
Services+ 3
{ 
public 

class %
DadosConvocacaoAppService *
:+ ,&
IDadosConvocacaoAppService- G
{ 
private 
readonly #
IDadosConvocadosService 0#
_dadosConvocadosService1 H
;H I
private 
readonly 
IMapper  
_mapper! (
;( )
public %
DadosConvocacaoAppService (
(( )#
IDadosConvocadosService) @"
dadosConvocadosServiceA W
,W X
IMapperY `
mappera g
)g h
{ 	#
_dadosConvocadosService #
=$ %"
dadosConvocadosService& <
;< =
_mapper 
= 
mapper 
; 
} 	
public 
void 
Dispose 
( 
) 
{ 	#
_dadosConvocadosService #
.# $
Dispose$ +
(+ ,
), -
;- .
} 	
public 
async 
Task 
< $
DadosConvocadosViewModel 2
>2 3
AddAsync4 <
(< =$
DadosConvocadosViewModel= U
objV Y
)Y Z
{ 	
var 
	convocado 
= 
_mapper #
.# $
Map$ '
<' ($
DadosConvocadosViewModel( @
,@ A
	ConvocadoB K
>K L
(L M
objM P
)P Q
;Q R
await   #
_dadosConvocadosService   )
.  ) *
AddAsync  * 2
(  2 3
	convocado  3 <
)  < =
;  = >
return!! 
obj!! 
;!! 
}"" 	
public$$ 
async$$ 
Task$$ 
<$$ $
DadosConvocadosViewModel$$ 2
>$$2 3
GetByIdAsync$$4 @
($$@ A
Guid$$A E
id$$F H
)$$H I
{%% 	
return&& 
_mapper&& 
.&& 
Map&& 
<&& 
	Convocado&& (
,&&( )$
DadosConvocadosViewModel&&* B
>&&B C
(&&C D
await&&D I#
_dadosConvocadosService&&J a
.&&a b
GetByIdAsync&&b n
(&&n o
id&&o q
)&&q r
)&&r s
;&&s t
}'' 	
public)) 
async)) 
Task)) 
<)) 
IEnumerable)) %
<))% &$
DadosConvocadosViewModel))& >
>))> ?
>))? @
GetAllAsync))A L
())L M
)))M N
{** 	
return++ 
_mapper++ 
.++ 
Map++ 
<++ 
IEnumerable++ *
<++* +
	Convocado+++ 4
>++4 5
,++5 6
IEnumerable++7 B
<++B C$
DadosConvocadosViewModel++C [
>++[ \
>++\ ]
(++] ^
await++^ c#
_dadosConvocadosService++d {
.,, 
GetAllAsync,, 
(,, 
),, 
),, 
;,,  
}-- 	
public// 
async// 
Task// 
<// $
DadosConvocadosViewModel// 2
>//2 3
UpdateAsync//4 ?
(//? @$
DadosConvocadosViewModel//@ X
obj//Y \
)//\ ]
{00 	
await11 #
_dadosConvocadosService11 )
.11) *
UpdateAsync11* 5
(115 6
_mapper116 =
.11= >
Map11> A
<11A B$
DadosConvocadosViewModel11B Z
,11Z [
	Convocado11\ e
>11e f
(11f g
obj11g j
)11j k
)11k l
;11l m
return22 
obj22 
;22 
}33 	
public55 
async55 
Task55 
RemoveAsync55 %
(55% &
Guid55& *
id55+ -
)55- .
{66 	
await77 #
_dadosConvocadosService77 )
.77) *
RemoveAsync77* 5
(775 6
id776 8
)778 9
;779 :
}88 	
public:: 
async:: 
Task:: 
<:: 
IEnumerable:: %
<::% &$
DadosConvocadosViewModel::& >
>::> ?
>::? @
SearchAsync::A L
(::L M

Expression::M W
<::W X
Func::X \
<::\ ]
	Convocado::] f
,::f g
bool::h l
>::l m
>::m n
	predicate::o x
)::x y
{;; 	
return<< 
_mapper<< 
.<< 
Map<< 
<<< 
IEnumerable<< *
<<<* +
	Convocado<<+ 4
><<4 5
,<<5 6
IEnumerable<<7 B
<<<B C$
DadosConvocadosViewModel<<C [
><<[ \
><<\ ]
(<<] ^
await== #
_dadosConvocadosService== ,
.==, -
SearchAsync==- 8
(==8 9
	predicate==9 B
)==B C
)==C D
;==D E
}>> 	
publicBB 
asyncBB 
TaskBB 
<BB $
DadosConvocadosViewModelBB 2
>BB2 3
GetOneAsyncBB4 ?
(BB? @

ExpressionBB@ J
<BBJ K
FuncBBK O
<BBO P
	ConvocadoBBP Y
,BBY Z
boolBB[ _
>BB_ `
>BB` a
	predicateBBb k
)BBk l
{CC 	
returnDD 
_mapperDD 
.DD 
MapDD 
<DD 
	ConvocadoDD (
,DD( )$
DadosConvocadosViewModelDD* B
>DDB C
(DDC D
awaitDDD I#
_dadosConvocadosServiceDDJ a
.DDa b
GetOneAsyncDDb m
(DDm n
	predicateDDn w
)DDw x
)DDx y
;DDy z
}EE 	
publicGG 
asyncGG 
TaskGG 
SalvarCargosAsyncGG +
(GG+ ,
GuidGG, 0
idGG1 3
,GG3 4
ListGG5 9
<GG9 :
CargoGG: ?
>GG? @

listaCargoGGA K
)GGL M
{HH 	
awaitII #
_dadosConvocadosServiceII )
.II) *
SalvarCargosAsyncII* ;
(II; <
idII< >
,II> ?

listaCargoII@ J
)IIJ K
;IIK L
}JJ 	
publicLL 
asyncLL 
TaskLL !
SalvarCandidatosAsyncLL /
(LL/ 0
GuidLL0 4
idLL5 7
,LL7 8
ListLL9 =
<LL= >
	ConvocadoLL> G
>LLG H
listaConvocadosLLI X
)LLX Y
{MM 	
awaitNN #
_dadosConvocadosServiceNN )
.NN) *!
SalvarCandidatosAsyncNN* ?
(NN? @
idNN@ B
,NNB C
listaConvocadosNND S
)NNS T
;NNT U
}OO 	
}PP 
}QQ ù/
ëC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\Services\DocumentacaoAppService.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +
Services+ 3
{ 
public 

class "
DocumentacaoAppService '
:( )#
IDocumentacaoAppService* A
{ 
private 
readonly  
IDocumentacaoService - 
_documentacaoService. B
;B C
private 
readonly 
IMapper  
_mapper! (
;( )
public "
DocumentacaoAppService %
(% & 
IDocumentacaoService& :
documentacaoService; N
,N O
IMapperP W
mapperX ^
)^ _
{ 	 
_documentacaoService  
=! "
documentacaoService# 6
;6 7
_mapper 
= 
mapper 
; 
} 	
public 
void 
Dispose 
( 
) 
{ 	 
_documentacaoService  
.  !
Dispose! (
(( )
)) *
;* +
} 	
public 
async 
Task 
< !
DocumentacaoViewModel /
>/ 0
AddAsync1 9
(9 :!
DocumentacaoViewModel: O
objP S
)S T
{ 	
var 
	documento 
= 
_mapper #
.# $
Map$ '
<' (!
DocumentacaoViewModel( =
,= >
	Documento? H
>H I
(I J
objJ M
)M N
;N O
await    
_documentacaoService   &
.  & '
AddAsync  ' /
(  / 0
	documento  0 9
)  9 :
;  : ;
return!! 
obj!! 
;!! 
}"" 	
public$$ 
async$$ 
Task$$ 
<$$ !
DocumentacaoViewModel$$ /
>$$/ 0
GetByIdAsync$$1 =
($$= >
Guid$$> B
id$$C E
)$$E F
{%% 	
return&& 
_mapper&& 
.&& 
Map&& 
<&& 
	Documento&& (
,&&( )!
DocumentacaoViewModel&&* ?
>&&? @
(&&@ A
await&&A F 
_documentacaoService&&G [
.&&[ \
GetByIdAsync&&\ h
(&&h i
id&&i k
)&&k l
)&&l m
;&&m n
}'' 	
public)) 
async)) 
Task)) 
<)) 
IEnumerable)) %
<))% &!
DocumentacaoViewModel))& ;
>)); <
>))< =
GetAllAsync))> I
())I J
)))J K
{** 	
return++ 
_mapper++ 
.++ 
Map++ 
<++ 
IEnumerable++ *
<++* +
	Documento+++ 4
>++4 5
,++5 6
IEnumerable++7 B
<++B C!
DocumentacaoViewModel++C X
>++X Y
>++Y Z
(++Z [
await,,  
_documentacaoService,, *
.,,* +
GetAllAsync,,+ 6
(,,6 7
),,7 8
),,8 9
;,,9 :
}-- 	
public// 
async// 
Task// 
<// !
DocumentacaoViewModel// /
>/// 0
UpdateAsync//1 <
(//< =!
DocumentacaoViewModel//= R
obj//S V
)//V W
{00 	
await11  
_documentacaoService11 &
.11& '
UpdateAsync11' 2
(112 3
_mapper113 :
.11: ;
Map11; >
<11> ?!
DocumentacaoViewModel11? T
,11T U
	Documento11V _
>11_ `
(11` a
obj11a d
)11d e
)11e f
;11f g
return22 
obj22 
;22 
}33 	
public55 
async55 
Task55 
RemoveAsync55 %
(55% &
Guid55& *
id55+ -
)55- .
{66 	
await77  
_documentacaoService77 %
.77% &
RemoveAsync77& 1
(771 2
id772 4
)774 5
;775 6
}88 	
public:: 
async:: 
Task:: 
<:: 
IEnumerable:: %
<::% &!
DocumentacaoViewModel::& ;
>::; <
>::< =
SearchAsync::> I
(::I J

Expression::J T
<::T U
Func::U Y
<::Y Z
	Documento::Z c
,::c d
bool::e i
>::i j
>::j k
	predicate::l u
)::u v
{;; 	
return<< 
_mapper<< 
.<< 
Map<< 
<<< 
IEnumerable<< *
<<<* +
	Documento<<+ 4
><<4 5
,<<5 6
IEnumerable<<7 B
<<<B C!
DocumentacaoViewModel<<C X
><<X Y
><<Y Z
(<<Z [
await==  
_documentacaoService== *
.==* +
SearchAsync==+ 6
(==6 7
	predicate==7 @
)==@ A
)==A B
;==B C
}>> 	
public@@ 
async@@ 
Task@@ 
<@@ !
DocumentacaoViewModel@@ /
>@@/ 0
GetOneAsync@@1 <
(@@< =

Expression@@= G
<@@G H
Func@@H L
<@@L M
	Documento@@M V
,@@V W
bool@@X \
>@@\ ]
>@@] ^
	predicate@@_ h
)@@h i
{AA 	
returnBB 
_mapperBB 
.BB 
MapBB 
<BB 
	DocumentoBB (
,BB( )!
DocumentacaoViewModelBB* ?
>BB? @
(BB@ A
awaitBBA F 
_documentacaoServiceBBG [
.BB[ \
GetOneAsyncBB\ g
(BBg h
	predicateBBh q
)BBq r
)BBr s
;BBs t
}CC 	
}DD 
}EE ¬N
óC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\Services\DocumentoCandidatoAppService.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +
Services+ 3
{ 
public 

class (
DocumentoCandidatoAppService -
:. /)
IDocumentoCandidatoAppService0 M
{ 
private 
readonly &
IDocumentoCandidatoService 3&
_documentoCandidatoService4 N
;N O
private 
readonly 
IMapper  
_mapper! (
;( )
public 
string 
	Inscricao 
{  !
get" %
;% &
private' .
set/ 2
;2 3
}4 5
public (
DocumentoCandidatoAppService +
(+ ,&
IDocumentoCandidatoService &%
documentoCandidatoService' @
,@ A
IMapper 
mapper 
) 
{ 	&
_documentoCandidatoService &
=' (%
documentoCandidatoService) B
;B C
_mapper 
= 
mapper 
; 
} 	
public 
void 
Dispose 
( 
) 
{ 	&
_documentoCandidatoService   &
.  & '
Dispose  ' .
(  . /
)  / 0
;  0 1
}!! 	
public## 
async## 
Task## 
<## '
DocumentoCandidatoViewModel## 5
>##5 6
AddAsync##7 ?
(##? @'
DocumentoCandidatoViewModel##@ [
obj##\ _
)##_ `
{$$ 	
var%% 
dados%% 
=%% 
_mapper%% 
.%%  
Map%%  #
<%%# $'
DocumentoCandidatoViewModel%%$ ?
,%%? @
DocumentoCandidato%%A S
>%%S T
(%%T U
obj%%U X
)%%X Y
;%%Y Z
await&& &
_documentoCandidatoService&& ,
.&&, -
AddAsync&&- 5
(&&5 6
dados&&6 ;
)&&; <
;&&< =
return'' 
obj'' 
;'' 
}(( 	
public** 
async** 
Task** 
<** '
DocumentoCandidatoViewModel** 5
>**5 6
GetByIdAsync**7 C
(**C D
Guid**D H
id**I K
)**K L
{++ 	
return,, 
_mapper,, 
.,, 
Map,, 
<,, 
DocumentoCandidato,, 1
,,,1 2'
DocumentoCandidatoViewModel,,3 N
>,,N O
(,,O P
await,,P U&
_documentoCandidatoService,,V p
.,,p q
GetByIdAsync,,q }
(,,} ~
id	,,~ Ä
)
,,Ä Å
)
,,Å Ç
;
,,Ç É
}-- 	
public// 
async// 
Task// 
<// 
IEnumerable// %
<//% &'
DocumentoCandidatoViewModel//& A
>//A B
>//B C
GetAllAsync//D O
(//O P
)//P Q
{00 	
return11 
_mapper11 
.11 
Map11 
<11 
IEnumerable11 *
<11* +
DocumentoCandidato11+ =
>11= >
,11> ?
IEnumerable11@ K
<11K L'
DocumentoCandidatoViewModel11L g
>11g h
>11h i
(11i j
await11j o'
_documentoCandidatoService	11p ä
.
11ä ã
GetAllAsync
11ã ñ
(
11ñ ó
)
11ó ò
)
11ò ô
;
11ô ö
}22 	
public44 
async44 
Task44 
<44 '
DocumentoCandidatoViewModel44 5
>445 6
UpdateAsync447 B
(44B C'
DocumentoCandidatoViewModel44C ^
obj44_ b
)44b c
{55 	
await66 &
_documentoCandidatoService66 ,
.66, -
UpdateAsync66- 8
(668 9
_mapper669 @
.66@ A
Map66A D
<66D E'
DocumentoCandidatoViewModel66E `
,66` a
DocumentoCandidato66b t
>66t u
(66u v
obj66v y
)66y z
)66z {
;66{ |
return77 
obj77 
;77 
}88 	
public:: 
async:: 
Task:: 
RemoveAsync:: %
(::% &
Guid::& *
id::+ -
)::- .
{;; 	
await<< &
_documentoCandidatoService<< ,
.<<, -
RemoveAsync<<- 8
(<<8 9
id<<9 ;
)<<; <
;<<< =
}== 	
public?? 
async?? 
Task?? 
<?? 
IEnumerable?? %
<??% &'
DocumentoCandidatoViewModel??& A
>??A B
>??B C
SearchAsync??D O
(??O P

Expression??P Z
<??Z [
Func??[ _
<??_ `
DocumentoCandidato??` r
,??r s
bool??t x
>??x y
>??y z
	predicate	??{ Ñ
)
??Ñ Ö
{@@ 	
returnAA 
_mapperAA 
.AA 
MapAA 
<AA 
IEnumerableAA *
<AA* +
DocumentoCandidatoAA+ =
>AA= >
,AA> ?
IEnumerableAA@ K
<AAK L'
DocumentoCandidatoViewModelAAL g
>AAg h
>AAh i
(AAi j
awaitBB &
_documentoCandidatoServiceBB 0
.BB0 1
SearchAsyncBB1 <
(BB< =
	predicateBB= F
)BBF G
)BBG H
;BBH I
}CC 	
publicEE 
asyncEE 
TaskEE 
<EE '
DocumentoCandidatoViewModelEE 5
>EE5 6
GetOneAsyncEE7 B
(EEB C

ExpressionEEC M
<EEM N
FuncEEN R
<EER S
DocumentoCandidatoEES e
,EEe f
boolEEg k
>EEk l
>EEl m
	predicateEEn w
)EEw x
{FF 	
returnGG 
_mapperGG 
.GG 
MapGG 
<GG 
DocumentoCandidatoGG 1
,GG1 2'
DocumentoCandidatoViewModelGG3 N
>GGN O
(GGO P
awaitHH &
_documentoCandidatoServiceHH /
.HH/ 0
GetOneAsyncHH0 ;
(HH; <
	predicateHH< E
)HHE F
)HHF G
;HHG H
}II 	
publicKK 
asyncKK 
TaskKK 
<KK 
ListKK 
<KK $
ListaDocumentosViewModelKK 7
>KK7 8
>KK8 9/
#MontarListaDeDocumentosDoCandidatosKK: ]
(KK] ^
IEnumerableKK^ i
<KKi j(
DocumentoCandidatoViewModel	KKj Ö
>
KKÖ Ü

documentos
KKá ë
,
KKë í
IEnumerableLL 
<LL 
ConvocadoViewModelLL *
>LL* +
dadosCandidatosLL, ;
)LL; <
{MM 	
varNN 
resultNN 
=NN 

documentosNN #
.NN# $
	GroupJoinNN$ -
(NN- .
dadosCandidatosNN. =
,NN= >
docsNN? C
=>NND F
docsNNG K
.NNK L
ConvocadoIdNNL W
,NNW X
candNNY ]
=>NN^ `
candNNa e
.NNe f
ConvocadoIdNNf q
,NNq r
(OO 
docsOO 
,OO 
candOO 
)OO 
=>OO 
newOO  #
{PP 
docsQQ 
.QQ 
AtivoQQ 
,QQ 
docsRR 
.RR 
ConvocadoIdRR $
,RR$ %
docsSS 
.SS 
DataInclusaoSS %
,SS% &
docsTT 
.TT 
	DocumentoTT "
,TT" #
docsUU 
.UU  
DocumentoCandidatoIdUU -
,UU- .
docsVV 
.VV 
PathVV 
,VV 
docsWW 
.WW 

ProcessoIdWW #
,WW# $
docsXX 
.XX 
TipoDocumentoXX &
,XX& '
dadosCandidatosYY #
=YY$ %
candYY& *
}ZZ 
)ZZ 
;ZZ 
var\\ '
listaDeDocumentosCandidatos\\ +
=\\, -
new\\. 1
List\\2 6
<\\6 7$
ListaDocumentosViewModel\\7 O
>\\O P
(\\P Q
)\\Q R
;\\R S
foreach^^ 
(^^ 
var^^ 
itens^^ 
in^^ !
result^^" (
)^^( )
{__ '
listaDeDocumentosCandidatos`` +
.``+ ,
AddRange``, 4
(``4 5
itens``5 :
.``: ;
dadosCandidatos``; J
.``J K
Select``K Q
(``Q R
lista``R W
=>``X Z
new``[ ^$
ListaDocumentosViewModel``_ w
{aa 
ConvocacaoIdbb  
=bb! "
itensbb# (
.bb( )
ConvocadoIdbb) 4
,bb4 5
	Inscricaocc 
=cc 
listacc  %
.cc% &
	Inscricaocc& /
,cc/ 0
Nomedd 
=dd 
listadd  
.dd  !
Nomedd! %
,dd% &
Cursoee 
=ee 
listaee !
.ee! "
Cargoee" '
,ee' (
Pathff 
=ff 
itensff  
.ff  !
Pathff! %
,ff% &
TipoDocumentogg !
=gg" #
itensgg$ )
.gg) *
TipoDocumentogg* 7
,gg7 8
DataPostagemhh  
=hh! "
itenshh# (
.hh( )
DataInclusaohh) 5
,hh5 6 
DocumentoCandidatoIdii (
=ii) *
itensii+ 0
.ii0 1 
DocumentoCandidatoIdii1 E
}jj 
)jj 
)jj 
;jj 
}kk 
returnmm 
awaitmm 
Taskmm 
.mm 

FromResultmm (
(mm( )'
listaDeDocumentosCandidatosmm) D
)mmD E
;mmE F
}nn 	
}oo 
}pp „
äC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\Services\EmailAppService.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +
Services+ 3
{ 
public 

class 
EmailAppService  
:! "
IEmailAppService# 3
{ 
public		 
void		 
EnviarEmail		 
(		  
ConvocadoViewModel		  2

convocacao		3 =
)		= >
{

 	
throw 
new #
NotImplementedException -
(- .
). /
;/ 0
} 	
} 
} ∑1
ãC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\Services\PessoaAppService.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +
Services+ 3
{ 
public 

class 
PessoaAppService !
:" #
IPessoaAppService$ 5
{ 
private 
readonly 
IPessoaService '
_pessoaService( 6
;6 7
private 
readonly 
IMapper  
_mapper! (
;( )
public 
PessoaAppService 
(  
IPessoaService  .
pessoaService/ <
,< =
IMapper> E
mapperF L
)L M
{ 	
_pessoaService 
= 
pessoaService *
;* +
_mapper 
= 
mapper 
; 
} 	
public 
void 
Dispose 
( 
) 
{ 	
_pessoaService 
. 
Dispose "
(" #
)# $
;$ %
} 	
public 
async 
Task 
< 
PessoaViewModel )
>) *
AddAsync+ 3
(3 4
PessoaViewModel4 C
objD G
)G H
{ 	
var 
pessoa 
= 
_mapper  
.  !
Map! $
<$ %
PessoaViewModel% 4
,4 5
Pessoa6 <
>< =
(= >
obj> A
)A B
;B C
await!! 
_pessoaService!!  
.!!  !
AddAsync!!! )
(!!) *
pessoa!!* 0
)!!0 1
;!!1 2
return## 
obj## 
;## 
}$$ 	
public&& 
async&& 
Task&& 
<&& 
PessoaViewModel&& )
>&&) *
GetByIdAsync&&+ 7
(&&7 8
Guid&&8 <
id&&= ?
)&&? @
{'' 	
return(( 
_mapper(( 
.(( 
Map(( 
<(( 
Pessoa(( %
,((% &
PessoaViewModel((' 6
>((6 7
(((7 8
await((8 =
_pessoaService((> L
.((L M
GetByIdAsync((M Y
(((Y Z
id((Z \
)((\ ]
)((] ^
;((^ _
})) 	
public++ 
async++ 
Task++ 
<++ 
IEnumerable++ %
<++% &
PessoaViewModel++& 5
>++5 6
>++6 7
GetAllAsync++8 C
(++C D
)++D E
{,, 	
return-- 
_mapper-- 
.-- 
Map-- 
<-- 
IEnumerable-- *
<--* +
Pessoa--+ 1
>--1 2
,--2 3
IEnumerable--4 ?
<--? @
PessoaViewModel--@ O
>--O P
>--P Q
(--Q R
await--R W
_pessoaService--X f
.--f g
GetAllAsync--g r
(--r s
)--s t
)--t u
;--u v
}.. 	
public00 
async00 
Task00 
<00 
PessoaViewModel00 )
>00) *
UpdateAsync00+ 6
(006 7
PessoaViewModel007 F
obj00G J
)00J K
{11 	
await22 
_pessoaService22  
.22  !
UpdateAsync22! ,
(22, -
_mapper22- 4
.224 5
Map225 8
<228 9
PessoaViewModel229 H
,22H I
Pessoa22J P
>22P Q
(22Q R
obj22R U
)22U V
)22V W
;22W X
return44 
obj44 
;44 
}55 	
public77 
async77 
Task77 
RemoveAsync77 %
(77% &
Guid77& *
id77+ -
)77- .
{88 	
await99 
_pessoaService99  
.99  !
RemoveAsync99! ,
(99, -
id99- /
)99/ 0
;990 1
}:: 	
public<< 
async<< 
Task<< 
<<< 
IEnumerable<< %
<<<% &
PessoaViewModel<<& 5
><<5 6
><<6 7
SearchAsync<<8 C
(<<C D

Expression<<D N
<<<N O
Func<<O S
<<<S T
Pessoa<<T Z
,<<Z [
bool<<\ `
><<` a
><<a b
	predicate<<c l
)<<l m
{== 	
return>> 
_mapper>> 
.>> 
Map>> 
<>> 
IEnumerable>> *
<>>* +
Pessoa>>+ 1
>>>1 2
,>>2 3
IEnumerable>>4 ?
<>>? @
PessoaViewModel>>@ O
>>>O P
>>>P Q
(>>Q R
await>>R W
_pessoaService>>X f
.>>f g
SearchAsync>>g r
(>>r s
	predicate>>s |
)>>| }
)>>} ~
;>>~ 
}?? 	
publicAA 
asyncAA 
TaskAA 
<AA 
PessoaViewModelAA )
>AA) *
GetOneAsyncAA+ 6
(AA6 7

ExpressionAA7 A
<AAA B
FuncAAB F
<AAF G
PessoaAAG M
,AAM N
boolAAO S
>AAS T
>AAT U
	predicateAAV _
)AA_ `
{BB 	
returnCC 
_mapperCC 
.CC 
MapCC 
<CC 
PessoaCC %
,CC% &
PessoaViewModelCC' 6
>CC6 7
(CC7 8
awaitCC8 =
_pessoaServiceCC> L
.CCL M
GetOneAsyncCCM X
(CCX Y
	predicateCCY b
)CCb c
)CCc d
;CCd e
}DD 	
TaskFF 
<FF 
PessoaViewModelFF 
>FF 
IPessoaAppServiceFF /
.FF/ 0
GetOneAsyncFF0 ;
(FF; <

ExpressionFF< F
<FFF G
FuncFFG K
<FFK L
PessoaFFL R
,FFR S
boolFFT X
>FFX Y
>FFY Z
	predicateFF[ d
)FFd e
{GG 	
throwHH 
newHH #
NotImplementedExceptionHH -
(HH- .
)HH. /
;HH/ 0
}II 	
}JJ 
}KK è0
ìC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\Services\PrimeiroAcessoAppService.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +
Services+ 3
{ 
public 

class $
PrimeiroAcessoAppService )
:* +%
IPrimeiroAcessoAppService, E
{ 
private 
readonly "
IPrimeiroAcessoService /"
_primeiroAcessoService0 F
;F G
private 
readonly 
IMapper  
_mapper! (
;( )
public $
PrimeiroAcessoAppService '
(' ("
IPrimeiroAcessoService( >!
primeiroAcessoService? T
,T U
IMapperV ]
mapper^ d
)d e
{ 	"
_primeiroAcessoService "
=# $!
primeiroAcessoService% :
;: ;
_mapper 
= 
mapper 
; 
} 	
public 
void 
Dispose 
( 
) 
{ 	"
_primeiroAcessoService "
." #
Dispose# *
(* +
)+ ,
;, -
} 	
public 
async 
Task 
< #
PrimeiroAcessoViewModel 1
>1 2
AddAsync3 ;
(; <#
PrimeiroAcessoViewModel< S
objT W
)W X
{ 	
var   
primeiroAcesso   
=    
_mapper  ! (
.  ( )
Map  ) ,
<  , -#
PrimeiroAcessoViewModel  - D
,  D E
PrimeiroAcesso  F T
>  T U
(  U V
obj  V Y
)  Y Z
;  Z [
await!! "
_primeiroAcessoService!! (
.!!( )
AddAsync!!) 1
(!!1 2
primeiroAcesso!!2 @
)!!@ A
;!!A B
return"" 
obj"" 
;"" 
}## 	
public%% 
async%% 
Task%% 
<%% #
PrimeiroAcessoViewModel%% 1
>%%1 2
GetByIdAsync%%3 ?
(%%? @
Guid%%@ D
id%%E G
)%%G H
{&& 	
return'' 
_mapper'' 
.'' 
Map'' 
<'' 
PrimeiroAcesso'' -
,''- .#
PrimeiroAcessoViewModel''/ F
>''F G
(''G H
await''H M"
_primeiroAcessoService''N d
.''d e
GetByIdAsync''e q
(''q r
id''r t
)''t u
)''u v
;''v w
}(( 	
public** 
async** 
Task** 
<** 
IEnumerable** %
<**% &#
PrimeiroAcessoViewModel**& =
>**= >
>**> ?
GetAllAsync**@ K
(**K L
)**L M
{++ 	
return,, 
_mapper,, 
.,, 
Map,, 
<,, 
IEnumerable,, *
<,,* +
PrimeiroAcesso,,+ 9
>,,9 :
,,,: ;
IEnumerable,,< G
<,,G H#
PrimeiroAcessoViewModel,,H _
>,,_ `
>,,` a
(,,a b
await,,b g"
_primeiroAcessoService,,h ~
.-- 
GetAllAsync-- 
(-- 
)-- 
)-- 
;--  
}.. 	
public00 
async00 
Task00 
<00 #
PrimeiroAcessoViewModel00 1
>001 2
UpdateAsync003 >
(00> ?#
PrimeiroAcessoViewModel00? V
obj00W Z
)00Z [
{11 	
await22 "
_primeiroAcessoService22 (
.22( )
UpdateAsync22) 4
(224 5
_mapper225 <
.22< =
Map22= @
<22@ A#
PrimeiroAcessoViewModel22A X
,22X Y
PrimeiroAcesso22Z h
>22h i
(22i j
obj22j m
)22m n
)22n o
;22o p
return33 
obj33 
;33 
}44 	
public66 
async66 
Task66 
RemoveAsync66 %
(66% &
Guid66& *
id66+ -
)66- .
{77 	
await88 "
_primeiroAcessoService88 (
.88( )
RemoveAsync88) 4
(884 5
id885 7
)887 8
;888 9
}99 	
public;; 
async;; 
Task;; 
<;; 
IEnumerable;; %
<;;% &#
PrimeiroAcessoViewModel;;& =
>;;= >
>;;> ?
SearchAsync;;@ K
(;;K L

Expression;;L V
<;;V W
Func;;W [
<;;[ \
PrimeiroAcesso;;\ j
,;;j k
bool;;l p
>;;p q
>;;q r
	predicate;;s |
);;| }
{<< 	
return== 
_mapper== 
.== 
Map== 
<== 
IEnumerable== *
<==* +
PrimeiroAcesso==+ 9
>==9 :
,==: ;
IEnumerable==< G
<==G H#
PrimeiroAcessoViewModel==H _
>==_ `
>==` a
(==a b
await>> "
_primeiroAcessoService>> ,
.>>, -
SearchAsync>>- 8
(>>8 9
	predicate>>9 B
)>>B C
)>>C D
;>>D E
}?? 	
publicAA 
asyncAA 
TaskAA 
<AA #
PrimeiroAcessoViewModelAA 1
>AA1 2
GetOneAsyncAA3 >
(AA> ?

ExpressionAA? I
<AAI J
FuncAAJ N
<AAN O
PrimeiroAcessoAAO ]
,AA] ^
boolAA_ c
>AAc d
>AAd e
	predicateAAf o
)AAo p
{BB 	
returnCC 
_mapperCC 
.CC 
MapCC 
<CC 
PrimeiroAcessoCC -
,CC- .#
PrimeiroAcessoViewModelCC/ F
>CCF G
(CCG H
awaitCCH M"
_primeiroAcessoServiceCCN d
.CCd e
GetOneAsyncCCe p
(CCp q
	predicateCCq z
)CCz {
)CC{ |
;CC| }
}DD 	
}EE 
}FF ç.
çC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\Services\ProcessoAppService.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +
Services+ 3
{ 
public 

class 
ProcessoAppService #
:$ %
IProcessoAppService& 9
{ 
private 
readonly 
IProcessoService )
_processoService* :
;: ;
private 
readonly 
IMapper  
_mapper! (
;( )
public 
ProcessoAppService !
(! "
IProcessoService" 2
processoService3 B
,B C
IMapperD K
mapperL R
)R S
{ 	
_processoService 
= 
processoService .
;. /
_mapper 
= 
mapper 
; 
} 	
public 
void 
Dispose 
( 
) 
{ 	
_processoService 
. 
Dispose $
($ %
)% &
;& '
} 	
public 
async 
Task 
< 
ProcessoViewModel +
>+ ,
AddAsync- 5
(5 6
ProcessoViewModel6 G
objH K
)K L
{ 	
var 
admin 
= 
_mapper 
.  
Map  #
<# $
ProcessoViewModel$ 5
,5 6
Processo7 ?
>? @
(@ A
objA D
)D E
;E F
await   
_processoService   "
.  " #
AddAsync  # +
(  + ,
admin  , 1
)  1 2
;  2 3
return!! 
obj!! 
;!! 
}"" 	
public$$ 
async$$ 
Task$$ 
<$$ 
ProcessoViewModel$$ +
>$$+ ,
GetByIdAsync$$- 9
($$9 :
Guid$$: >
id$$? A
)$$A B
{%% 	
return&& 
_mapper&& 
.&& 
Map&& 
<&& 
Processo&& '
,&&' (
ProcessoViewModel&&) :
>&&: ;
(&&; <
await&&< A
_processoService&&B R
.&&R S
GetByIdAsync&&S _
(&&_ `
id&&` b
)&&b c
)&&c d
;&&d e
}'' 	
public)) 
async)) 
Task)) 
<)) 
IEnumerable)) %
<))% &
ProcessoViewModel))& 7
>))7 8
>))8 9
GetAllAsync)): E
())E F
)))F G
{** 	
return++ 
_mapper++ 
.++ 
Map++ 
<++ 
IEnumerable++ *
<++* +
Processo+++ 3
>++3 4
,++4 5
IEnumerable++6 A
<++A B
ProcessoViewModel++B S
>++S T
>++T U
(++U V
await++V [
_processoService++\ l
.++l m
GetAllAsync++m x
(++x y
)++y z
)++z {
;++{ |
},, 	
public.. 
async.. 
Task.. 
<.. 
ProcessoViewModel.. +
>..+ ,
UpdateAsync..- 8
(..8 9
ProcessoViewModel..9 J
obj..K N
)..N O
{// 	
await00 
_processoService00 "
.00" #
UpdateAsync00# .
(00. /
_mapper00/ 6
.006 7
Map007 :
<00: ;
ProcessoViewModel00; L
,00L M
Processo00N V
>00V W
(00W X
obj00X [
)00[ \
)00\ ]
;00] ^
return11 
obj11 
;11 
}22 	
public44 
async44 
Task44 
RemoveAsync44 %
(44% &
Guid44& *
id44+ -
)44- .
{55 	
await66 
_processoService66 "
.66" #
RemoveAsync66# .
(66. /
id66/ 1
)661 2
;662 3
}77 	
public99 
async99 
Task99 
<99 
IEnumerable99 %
<99% &
ProcessoViewModel99& 7
>997 8
>998 9
SearchAsync99: E
(99E F

Expression99F P
<99P Q
Func99Q U
<99U V
Processo99V ^
,99^ _
bool99` d
>99d e
>99e f
	predicate99g p
)99p q
{:: 	
return;; 
_mapper;; 
.;; 
Map;; 
<;; 
IEnumerable;; *
<;;* +
Processo;;+ 3
>;;3 4
,;;4 5
IEnumerable;;6 A
<;;A B
ProcessoViewModel;;B S
>;;S T
>;;T U
(;;U V
await<< 
_processoService<< &
.<<& '
SearchAsync<<' 2
(<<2 3
	predicate<<3 <
)<<< =
)<<= >
;<<> ?
}== 	
public?? 
async?? 
Task?? 
<?? 
ProcessoViewModel?? +
>??+ ,
GetOneAsync??- 8
(??8 9

Expression??9 C
<??C D
Func??D H
<??H I
Processo??I Q
,??Q R
bool??S W
>??W X
>??X Y
	predicate??Z c
)??c d
{@@ 	
returnAA 
_mapperAA 
.AA 
MapAA 
<AA 
ProcessoAA '
,AA' (
ProcessoViewModelAA) :
>AA: ;
(AA; <
awaitAA< A
_processoServiceAAB R
.AAR S
GetOneAsyncAAS ^
(AA^ _
	predicateAA_ h
)AAh i
)AAi j
;AAj k
}BB 	
}CC 
}DD ì.
çC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\Services\TelefoneAppService.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +
Services+ 3
{ 
public 

class 
TelefoneAppService #
:$ %
ITelefoneAppService& 9
{ 
private 
readonly 
ITelefoneService )
_telefoneService* :
;: ;
private 
readonly 
IMapper  
_mapper! (
;( )
public 
TelefoneAppService !
(! "
ITelefoneService" 2
telefoneService3 B
,B C
IMapperD K
mapperL R
)R S
{ 	
_telefoneService 
= 
telefoneService .
;. /
_mapper 
= 
mapper 
; 
} 	
public 
void 
Dispose 
( 
) 
{ 	
_telefoneService 
. 
Dispose $
($ %
)% &
;& '
} 	
public 
async 
Task 
< 
TelefoneViewModel +
>+ ,
AddAsync- 5
(5 6
TelefoneViewModel6 G
objH K
)K L
{ 	
var 
telefone 
= 
_mapper "
." #
Map# &
<& '
TelefoneViewModel' 8
,8 9
Telefone: B
>B C
(C D
objD G
)G H
;H I
await   
_telefoneService   "
.  " #
AddAsync  # +
(  + ,
telefone  , 4
)  4 5
;  5 6
return!! 
obj!! 
;!! 
}"" 	
public$$ 
async$$ 
Task$$ 
<$$ 
TelefoneViewModel$$ +
>$$+ ,
GetByIdAsync$$- 9
($$9 :
Guid$$: >
id$$? A
)$$A B
{%% 	
return&& 
_mapper&& 
.&& 
Map&& 
<&& 
Telefone&& '
,&&' (
TelefoneViewModel&&) :
>&&: ;
(&&; <
await&&< A
_telefoneService&&B R
.&&R S
GetByIdAsync&&S _
(&&_ `
id&&` b
)&&b c
)&&c d
;&&d e
}'' 	
public)) 
async)) 
Task)) 
<)) 
IEnumerable)) %
<))% &
TelefoneViewModel))& 7
>))7 8
>))8 9
GetAllAsync)): E
())E F
)))F G
{** 	
return++ 
_mapper++ 
.++ 
Map++ 
<++ 
IEnumerable++ *
<++* +
Telefone+++ 3
>++3 4
,++4 5
IEnumerable++6 A
<++A B
TelefoneViewModel++B S
>++S T
>++T U
(++U V
await++V [
_telefoneService++\ l
.++l m
GetAllAsync++m x
(++x y
)++y z
)++z {
;++{ |
},, 	
public.. 
async.. 
Task.. 
<.. 
TelefoneViewModel.. +
>..+ ,
UpdateAsync..- 8
(..8 9
TelefoneViewModel..9 J
obj..K N
)..N O
{// 	
await00 
_telefoneService00 "
.00" #
UpdateAsync00# .
(00. /
_mapper00/ 6
.006 7
Map007 :
<00: ;
TelefoneViewModel00; L
,00L M
Telefone00N V
>00V W
(00W X
obj00X [
)00[ \
)00\ ]
;00] ^
return11 
obj11 
;11 
}22 	
public44 
async44 
Task44 
RemoveAsync44 %
(44% &
Guid44& *
id44+ -
)44- .
{55 	
await66 
_telefoneService66 "
.66" #
RemoveAsync66# .
(66. /
id66/ 1
)661 2
;662 3
}77 	
public99 
async99 
Task99 
<99 
IEnumerable99 %
<99% &
TelefoneViewModel99& 7
>997 8
>998 9
SearchAsync99: E
(99E F

Expression99F P
<99P Q
Func99Q U
<99U V
Telefone99V ^
,99^ _
bool99` d
>99d e
>99e f
	predicate99g p
)99p q
{:: 	
return;; 
_mapper;; 
.;; 
Map;; 
<;; 
IEnumerable;; *
<;;* +
Telefone;;+ 3
>;;3 4
,;;4 5
IEnumerable;;6 A
<;;A B
TelefoneViewModel;;B S
>;;S T
>;;T U
(;;U V
await<< 
_telefoneService<< &
.<<& '
SearchAsync<<' 2
(<<2 3
	predicate<<3 <
)<<< =
)<<= >
;<<> ?
}== 	
public?? 
async?? 
Task?? 
<?? 
TelefoneViewModel?? +
>??+ ,
GetOneAsync??- 8
(??8 9

Expression??9 C
<??C D
Func??D H
<??H I
Telefone??I Q
,??Q R
bool??S W
>??W X
>??X Y
	predicate??Z c
)??c d
{@@ 	
returnAA 
_mapperAA 
.AA 
MapAA 
<AA 
TelefoneAA '
,AA' (
TelefoneViewModelAA) :
>AA: ;
(AA; <
awaitAA< A
_telefoneServiceAAB R
.AAR S
GetOneAsyncAAS ^
(AA^ _
	predicateAA_ h
)AAh i
)AAi j
;AAj k
}BB 	
}CC 
}DD ﬁ/
íC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\Services\TipoDocumentoAppService.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +
Services+ 3
{ 
public 

class #
TipoDocumentoAppService (
:) *$
ITipoDocumentoAppService+ C
{ 
private 
readonly !
ITipoDocumentoService .!
_tipoDocumentoService/ D
;D E
private 
readonly 
IMapper  
_mapper! (
;( )
public #
TipoDocumentoAppService &
(& '!
ITipoDocumentoService' < 
tipoDocumentoService= Q
,Q R
IMapperS Z
mapper[ a
)a b
{ 	!
_tipoDocumentoService !
=" # 
tipoDocumentoService$ 8
;8 9
_mapper 
= 
mapper 
; 
} 	
public 
void 
Dispose 
( 
) 
{ 	!
_tipoDocumentoService !
.! "
Dispose" )
() *
)* +
;+ ,
} 	
public 
async 
Task 
< "
TipoDocumentoViewModel 0
>0 1
AddAsync2 :
(: ;"
TipoDocumentoViewModel; Q
objR U
)U V
{ 	
var 
dados 
= 
_mapper 
.  
Map  #
<# $"
TipoDocumentoViewModel$ :
,: ;
TipoDocumento< I
>I J
(J K
objK N
)N O
;O P
await!! !
_tipoDocumentoService!! '
.!!' (
AddAsync!!( 0
(!!0 1
dados!!1 6
)!!6 7
;!!7 8
return## 
obj## 
;## 
}$$ 	
public&& 
async&& 
Task&& 
<&& "
TipoDocumentoViewModel&& 0
>&&0 1
GetByIdAsync&&2 >
(&&> ?
Guid&&? C
id&&D F
)&&F G
{'' 	
return(( 
_mapper(( 
.(( 
Map(( 
<(( 
TipoDocumento(( ,
,((, -"
TipoDocumentoViewModel((. D
>((D E
(((E F
await((F K!
_tipoDocumentoService((L a
.((a b
GetByIdAsync((b n
(((n o
id((o q
)((q r
)((r s
;((s t
})) 	
public++ 
async++ 
Task++ 
<++ 
IEnumerable++ %
<++% &"
TipoDocumentoViewModel++& <
>++< =
>++= >
GetAllAsync++? J
(++J K
)++K L
{,, 	
return-- 
_mapper-- 
.-- 
Map-- 
<-- 
IEnumerable-- *
<--* +
TipoDocumento--+ 8
>--8 9
,--9 :
IEnumerable--; F
<--F G"
TipoDocumentoViewModel--G ]
>--] ^
>--^ _
(--_ `
await--` e!
_tipoDocumentoService--f {
.--{ |
GetAllAsync	--| á
(
--á à
)
--à â
)
--â ä
;
--ä ã
}.. 	
public00 
async00 
Task00 
<00 "
TipoDocumentoViewModel00 0
>000 1
UpdateAsync002 =
(00= >"
TipoDocumentoViewModel00> T
obj00U X
)00X Y
{11 	
await33 !
_tipoDocumentoService33 &
.33& '
UpdateAsync33' 2
(332 3
_mapper333 :
.33: ;
Map33; >
<33> ?"
TipoDocumentoViewModel33? U
,33U V
TipoDocumento33W d
>33d e
(33e f
obj33f i
)33i j
)33j k
;33k l
return55 
obj55 
;55 
}66 	
public88 
async88 
Task88 
RemoveAsync88 %
(88% &
Guid88& *
id88+ -
)88- .
{99 	
await::
 !
_tipoDocumentoService:: %
.::% &
RemoveAsync::& 1
(::1 2
id::2 4
)::4 5
;::5 6
};; 	
public== 
async== 
Task== 
<== 
IEnumerable== %
<==% &"
TipoDocumentoViewModel==& <
>==< =
>=== >
SearchAsync==? J
(==J K

Expression==K U
<==U V
Func==V Z
<==Z [
TipoDocumento==[ h
,==h i
bool==j n
>==n o
>==o p
	predicate==q z
)==z {
{>> 	
return?? 
_mapper?? 
.?? 
Map?? 
<?? 
IEnumerable?? *
<??* +
TipoDocumento??+ 8
>??8 9
,??9 :
IEnumerable??; F
<??F G"
TipoDocumentoViewModel??G ]
>??] ^
>??^ _
(??_ `
await@@ !
_tipoDocumentoService@@ +
.@@+ ,
SearchAsync@@, 7
(@@7 8
	predicate@@8 A
)@@A B
)@@B C
;@@C D
}AA 	
publicCC 
asyncCC 
TaskCC 
<CC "
TipoDocumentoViewModelCC 0
>CC0 1
GetOneAsyncCC2 =
(CC= >

ExpressionCC> H
<CCH I
FuncCCI M
<CCM N
TipoDocumentoCCN [
,CC[ \
boolCC] a
>CCa b
>CCb c
	predicateCCd m
)CCm n
{DD 	
returnEE 
_mapperEE 
.EE 
MapEE 
<EE 
TipoDocumentoEE ,
,EE, -"
TipoDocumentoViewModelEE. D
>EED E
(EEE F
awaitFF !
_tipoDocumentoServiceFF +
.FF+ ,
GetOneAsyncFF, 7
(FF7 8
	predicateFF8 A
)FFA B
)FFB C
;FFC D
}GG 	
}HH 
}II -
åC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\Services\UsuarioAppService.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +
Services+ 3
{ 
public 

class 
UsuarioAppService "
:# $
IUsuarioAppService% 7
{ 
private 
readonly 
IUsuarioService (
_usuarioService) 8
;8 9
private 
readonly 
IMapper  
_mapper! (
;( )
public 
UsuarioAppService  
(  !
IUsuarioService! 0
usuarioService1 ?
,? @
IMapperA H
mapperI O
)O P
{ 	
_usuarioService 
= 
usuarioService ,
;, -
_mapper 
= 
mapper 
; 
} 	
public 
void 
Dispose 
( 
) 
{ 	
_usuarioService 
. 
Dispose #
(# $
)$ %
;% &
} 	
public 
async 
Task 
< 
UsuarioViewModel *
>* +
AddAsync, 4
(4 5
UsuarioViewModel5 E
objF I
)I J
{ 	
var 
telefone 
= 
_mapper "
." #
Map# &
<& '
UsuarioViewModel' 7
,7 8
Usuario9 @
>@ A
(A B
objB E
)E F
;F G
await   
_usuarioService   !
.  ! "
AddAsync  " *
(  * +
telefone  + 3
)  3 4
;  4 5
return!! 
obj!! 
;!! 
}"" 	
public$$ 
async$$ 
Task$$ 
<$$ 
UsuarioViewModel$$ *
>$$* +
GetByIdAsync$$, 8
($$8 9
Guid$$9 =
id$$> @
)$$@ A
{%% 	
return&& 
_mapper&& 
.&& 
Map&& 
<&& 
Usuario&& &
,&&& '
UsuarioViewModel&&( 8
>&&8 9
(&&9 :
await&&: ?
_usuarioService&&@ O
.&&O P
GetByIdAsync&&P \
(&&\ ]
id&&] _
)&&_ `
)&&` a
;&&a b
}'' 	
public)) 
async)) 
Task)) 
<)) 
IEnumerable)) %
<))% &
UsuarioViewModel))& 6
>))6 7
>))7 8
GetAllAsync))9 D
())D E
)))E F
{** 	
return++ 
_mapper++ 
.++ 
Map++ 
<++ 
IEnumerable++ *
<++* +
Usuario+++ 2
>++2 3
,++3 4
IEnumerable++5 @
<++@ A
UsuarioViewModel++A Q
>++Q R
>++R S
(++S T
await++T Y
_usuarioService++Z i
.++i j
GetAllAsync++j u
(++u v
)++v w
)++w x
;++x y
},, 	
public.. 
async.. 
Task.. 
<.. 
UsuarioViewModel.. *
>..* +
UpdateAsync.., 7
(..7 8
UsuarioViewModel..8 H
obj..I L
)..L M
{// 	
await00 
_usuarioService00 !
.00! "
UpdateAsync00" -
(00- .
_mapper00. 5
.005 6
Map006 9
<009 :
UsuarioViewModel00: J
,00J K
Usuario00L S
>00S T
(00T U
obj00U X
)00X Y
)00Y Z
;00Z [
return22 
obj22 
;22 
}33 	
public55 
async55 
Task55 
RemoveAsync55 %
(55% &
Guid55& *
id55+ -
)55- .
{66 	
await77 
_usuarioService77 !
.77! "
RemoveAsync77" -
(77- .
id77. 0
)770 1
;771 2
}88 	
public:: 
async:: 
Task:: 
<:: 
IEnumerable:: %
<::% &
UsuarioViewModel::& 6
>::6 7
>::7 8
SearchAsync::9 D
(::D E

Expression::E O
<::O P
Func::P T
<::T U
Usuario::U \
,::\ ]
bool::^ b
>::b c
>::c d
	predicate::e n
)::n o
{;; 	
return<< 
_mapper<< 
.<< 
Map<< 
<<< 
IEnumerable<< *
<<<* +
Usuario<<+ 2
><<2 3
,<<3 4
IEnumerable<<5 @
<<<@ A
UsuarioViewModel<<A Q
><<Q R
><<R S
(<<S T
await<<T Y
_usuarioService<<Z i
.<<i j
SearchAsync<<j u
(<<u v
	predicate<<v 
)	<< Ä
)
<<Ä Å
;
<<Å Ç
}== 	
public?? 
async?? 
Task?? 
<?? 
UsuarioViewModel?? *
>??* +
GetOneAsync??, 7
(??7 8

Expression??8 B
<??B C
Func??C G
<??G H
Usuario??H O
,??O P
bool??Q U
>??U V
>??V W
	predicate??X a
)??a b
{@@ 	
returnAA 
_mapperAA 
.AA 
MapAA 
<AA 
UsuarioAA &
,AA& '
UsuarioViewModelAA( 8
>AA8 9
(AA9 :
awaitAA: ?
_usuarioServiceAA@ O
.AAO P
GetOneAsyncAAP [
(AA[ \
	predicateAA\ e
)AAe f
)AAf g
;AAg h
}BB 	
}CC 
}DD §
îC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\AddPhoneNumberViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class #
AddPhoneNumberViewModel (
{ 
[ 	
Required	 
] 
[ 	
Phone	 
] 
[		 	
Display			 
(		 
Name		 
=		 
$str		 &
)		& '
]		' (
public

 
string

 
Number

 
{

 
get

 "
;

" #
set

$ '
;

' (
}

) *
} 
} ¨#
åC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\Admin2ViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class 
Admin2ViewModel  
{ 
[ 	
Key	 
] 
public 
Guid 
AdminId !
{" #
get$ '
;' (
set) ,
;, -
}. /
[

 	
Required

	 
]

 
[ 	
Display	 
( 
Name 
= 
$str *
)* +
]+ ,
[ 	
	MaxLength	 
( 
$num 
, 
ErrorMessage $
=% &
$str' R
)R S
]S T
public 
string 
Nome 
{ 
get  
;  !
set" %
;% &
}' (
[ 	
Required	 
] 
[ 	
Display	 
( 
Name 
= 
$str .
). /
]/ 0
[ 	
	MaxLength	 
( 
$num 
, 
ErrorMessage $
=% &
$str' T
)T U
]U V
public 
string 
Email 
{ 
get !
;! "
set# &
;& '
}( )
[ 	
Required	 
] 
[ 	
Display	 
( 
Name 
= 
$str 1
)1 2
]2 3
[ 	
	MaxLength	 
( 
$num 
, 
ErrorMessage #
=$ %
$str& S
)S T
]T U
public 
string 
Empresa 
{ 
get  #
;# $
set% (
;( )
}* +
[ 	
Required	 
] 
[ 	
Display	 
( 
Name 
= 
$str 1
)1 2
]2 3
[ 	
	MaxLength	 
( 
$num 
, 
ErrorMessage #
=$ %
$str& P
)P Q
]Q R
public 
string 
Cnpj 
{ 
get  
;  !
set" %
;% &
}' (
[ 	
Required	 
] 
[ 	
Display	 
( 
Name 
= 
$str .
). /
]/ 0
[   	
	MaxLength  	 
(   
$num   
,   
ErrorMessage   #
=  $ %
$str  & T
)  T U
]  U V
public!! 
string!! 
Telefone!! 
{!!  
get!!! $
;!!$ %
set!!& )
;!!) *
}!!+ ,
[## 	
Required##	 
]## 
[$$ 	
Display$$	 
($$ 
Name$$ 
=$$ 
$str$$ 3
)$$3 4
]$$4 5
[%% 	
	MaxLength%%	 
(%% 
$num%% 
,%% 
ErrorMessage%% $
=%%% &
$str%%' T
)%%T U
]%%U V
public&& 
string&& 
Imagem&& 
{&& 
get&& "
;&&" #
set&&$ '
;&&' (
}&&) *
[(( 	
Required((	 
](( 
[(( 
Display(( 
((( 
Name((  
=((! "
$str((# +
)((+ ,
]((, -
public((. 4
bool((5 9
Ativo((: ?
{((@ A
get((B E
;((E F
set((G J
;((J K
}((L M
[** 	
Required**	 
]** 
[++ 	
Display++	 
(++ 
Name++ 
=++ 
$str++ -
)++- .
]++. /
[,, 	
	MaxLength,,	 
(,, 
$num,, 
,,, 
ErrorMessage,, $
=,,% &
$str,,' R
),,R S
],,S T
public-- 
string-- 
Senha-- 
{-- 
get-- !
;--! "
set--# &
;--& '
}--( )
}.. 
}// ™#
ãC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\AdminViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class 
AdminViewModel 
{ 
[		 	
Key			 
]		 
public		 
Guid		 
AdminId		 !
{		" #
get		$ '
;		' (
set		) ,
;		, -
}		. /
[ 	
Required	 
] 
[ 	
Display	 
( 
Name 
= 
$str *
)* +
]+ ,
[ 	
	MaxLength	 
( 
$num 
, 
ErrorMessage $
=% &
$str' R
)R S
]S T
public 
string 
Nome 
{ 
get  
;  !
set" %
;% &
}' (
[ 	
Required	 
] 
[ 	
Display	 
( 
Name 
= 
$str .
). /
]/ 0
[ 	
	MaxLength	 
( 
$num 
, 
ErrorMessage $
=% &
$str' T
)T U
]U V
public 
string 
Email 
{ 
get !
;! "
set# &
;& '
}( )
[ 	
Required	 
] 
[ 	
Display	 
( 
Name 
= 
$str 1
)1 2
]2 3
[ 	
	MaxLength	 
( 
$num 
, 
ErrorMessage #
=$ %
$str& S
)S T
]T U
public 
string 
Empresa 
{ 
get  #
;# $
set% (
;( )
}* +
[ 	
Required	 
] 
[ 	
Display	 
( 
Name 
= 
$str 1
)1 2
]2 3
[ 	
	MaxLength	 
( 
$num 
, 
ErrorMessage #
=$ %
$str& P
)P Q
]Q R
public 
string 
Cnpj 
{ 
get  
;  !
set" %
;% &
}' (
[ 	
Required	 
] 
[   	
Display  	 
(   
Name   
=   
$str   .
)  . /
]  / 0
[!! 	
	MaxLength!!	 
(!! 
$num!! 
,!! 
ErrorMessage!! #
=!!$ %
$str!!& T
)!!T U
]!!U V
public"" 
string"" 
Telefone"" 
{""  
get""! $
;""$ %
set""& )
;"") *
}""+ ,
[$$ 	
Required$$	 
]$$ 
[%% 	
Display%%	 
(%% 
Name%% 
=%% 
$str%% 3
)%%3 4
]%%4 5
[&& 	
	MaxLength&&	 
(&& 
$num&& 
,&& 
ErrorMessage&& $
=&&% &
$str&&' T
)&&T U
]&&U V
public'' 
string'' 
Imagem'' 
{'' 
get'' "
;''" #
set''$ '
;''' (
}'') *
[)) 	
Required))	 
])) 
[)) 
Display)) 
()) 
Name))  
=))! "
$str))# +
)))+ ,
])), -
public)). 4
bool))5 9
Ativo)): ?
{))@ A
get))B E
;))E F
set))G J
;))J K
}))L M
[++ 	
Required++	 
]++ 
[,, 	
Display,,	 
(,, 
Name,, 
=,, 
$str,, -
),,- .
],,. /
[-- 	
	MaxLength--	 
(-- 
$num-- 
,-- 
ErrorMessage-- $
=--% &
$str--' R
)--R S
]--S T
public.. 
string.. 
Senha.. 
{.. 
get.. !
;..! "
set..# &
;..& '
}..( )
}00 
}11 Ö
ãC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\CargoViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class 
CargoViewModel 
{ 
[ 	
Key	 
] 
public 
Guid 
CargoId !
{" #
get$ '
;' (
set) ,
;, -
}. /
public

 
Guid

 

ProcessoId

 
{

  
get

! $
;

$ %
set

& )
;

) *
}

+ ,
[ 	
Required	 
( 
AllowEmptyStrings #
=$ %
false& +
,+ ,
ErrorMessage- 9
=: ;
$str< T
)T U
]U V
[ 	
Display	 
( 
Name 
= 
$str 
) 
]  
[ 	
	MaxLength	 
( 
$num 
) 
] 
public 
string 
Nome 
{ 
get  
;  !
set" %
;% &
}' (
[ 	
Required	 
( 
AllowEmptyStrings #
=$ %
false& +
,+ ,
ErrorMessage- 9
=: ;
$str< _
)_ `
]` a
[ 	
Display	 
( 
Name 
= 
$str )
)) *
]* +
[ 	
	MaxLength	 
( 
$num 
) 
] 
public 
string 
CodigoCargo !
{" #
get$ '
;' (
set) ,
;, -
}. /
[ 	
Required	 
] 
[ 	
Display	 
( 
Name 
= 
$str 
)  
]  !
public 
bool 
Ativo 
{ 
get 
;  
set! $
;$ %
}& '
} 
} «
îC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\ChangePasswordViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class #
ChangePasswordViewModel (
{ 
[ 	
Required	 
] 
[ 	
DataType	 
( 
DataType 
. 
Password #
)# $
]$ %
[		 	
Display			 
(		 
Name		 
=		 
$str		 *
)		* +
]		+ ,
public

 
string

 
OldPassword

 !
{

" #
get

$ '
;

' (
set

) ,
;

, -
}

. /
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
, 
ErrorMessage '
=( )
$str* Y
,Y Z
MinimumLength[ h
=i j
$numk l
)l m
]m n
[ 	
DataType	 
( 
DataType 
. 
Password #
)# $
]$ %
[ 	
Display	 
( 
Name 
= 
$str &
)& '
]' (
public 
string 
NewPassword !
{" #
get$ '
;' (
set) ,
;, -
}. /
[ 	
DataType	 
( 
DataType 
. 
Password #
)# $
]$ %
[ 	
Display	 
( 
Name 
= 
$str .
). /
]/ 0
[ 	
Compare	 
( 
$str 
, 
ErrorMessage  ,
=- .
$str/ i
)i j
]j k
public 
string 
ConfirmPassword %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
} 
} ˘#
çC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\ClienteViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class 
ClienteViewModel !
{ 
public 
ClienteViewModel 
(  
)  !
{		 	
	ClienteId

 
=

 
Guid

 
.

 
NewGuid

 $
(

$ %
)

% &
;

& '
} 	
[ 	
Key	 
] 
public 
Guid 
	ClienteId 
{ 
get  #
;# $
set% (
;( )
}* +
[ 	
Required	 
( 
AllowEmptyStrings #
=$ %
false& +
)+ ,
], -
[ 	
Display	 
( 
Name 
= 
$str )
)) *
]* +
public 
string 
Nome 
{ 
get  
;  !
set" %
;% &
}' (
[ 	
Required	 
( 
AllowEmptyStrings #
=$ %
false& +
)+ ,
], -
[ 	
Display	 
( 
Name 
= 
$str )
)) *
]* +
public 
string 
Cnpj 
{ 
get  
;  !
set" %
;% &
}' (
[ 	
Required	 
( 
AllowEmptyStrings #
=$ %
false& +
)+ ,
], -
[ 	
EmailAddress	 
] 
[ 	
Display	 
( 
Name 
= 
$str +
)+ ,
], -
public 
string 
Email 
{ 
get !
;! "
set# &
;& '
}( )
[ 	
Required	 
( 
AllowEmptyStrings #
=$ %
false& +
)+ ,
], -
[ 	
Display	 
( 
Name 
= 
$str -
)- .
]. /
public 
string 
Telefone 
{  
get! $
;$ %
set& )
;) *
}+ ,
[!! 	
Required!!	 
]!! 
["" 	
StringLength""	 
("" 
$num"" 
,"" 
ErrorMessage"" &
=""' (
$str"") X
,""X Y
MinimumLength""Z g
=""h i
$num""j k
)""k l
]""l m
[## 	
DataType##	 
(## 
DataType## 
.## 
Password## #
)### $
]##$ %
[$$ 	
Display$$	 
($$ 
Name$$ 
=$$ 
$str$$ 
)$$  
]$$  !
public%% 
string%% 
Password%% 
{%%  
get%%! $
;%%$ %
set%%& )
;%%) *
}%%+ ,
['' 	
DataType''	 
('' 
DataType'' 
.'' 
Password'' #
)''# $
]''$ %
[(( 	
Display((	 
((( 
Name(( 
=(( 
$str(( )
)(() *
]((* +
[)) 	
Compare))	 
()) 
$str)) 
,)) 
ErrorMessage)) )
=))* +
$str)), [
)))[ \
]))\ ]
public** 
string** 
ConfirmPassword** %
{**& '
get**( +
;**+ ,
set**- 0
;**0 1
}**2 3
[,, 	
Required,,	 
],, 
[-- 	
Display--	 
(-- 
Name-- 
=-- 
$str-- 
)--  
]--  !
public.. 
bool.. 
Ativo.. 
{.. 
get.. 
;..  
set..! $
;..$ %
}..& '
[11 	
Display11	 
(11 
Name11 
=11 
$str11 -
)11- .
]11. /
public22 
string22 
Imagem22 
{22 
get22 "
;22" #
set22$ '
;22' (
}22) *
}33 
}44 °
òC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\ConfigureTwoFactorViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class '
ConfigureTwoFactorViewModel ,
{ 
public 
string 
SelectedProvider &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
public 
ICollection 
< 
string !
>! "
	Providers# ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
}		 
}

 ≥
êC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\ConvocacaoViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class 
ConvocacaoViewModel $
{ 
[ 	
Key	 
] 
public		 
Guid		 
ConvocacaoId		  
{		! "
get		# &
;		& '
set		( +
;		+ ,
}		- .
public 
Guid 

ProcessoId 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
Guid 
ConvocadoId 
{  !
get" %
;% &
set' *
;* +
}, -
public 
DateTime !
DataEntregaDocumentos -
{. /
get0 3
;3 4
set5 8
;8 9
}: ;
public 
TimeSpan #
HorarioEntregaDocumento /
{0 1
get2 5
;5 6
set7 :
;: ;
}< =
public 
string $
EnderecoEntregaDocumento .
{/ 0
get1 4
;4 5
set6 9
;9 :
}; <
public 
bool 
EnviouEmail 
{  !
get" %
;% &
set' *
;* +
}, -
public 
string 

Desistente  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
bool 
Ativo 
{ 
get 
;  
set! $
;$ %
}& '
public 
string "
CandidatosSelecionados ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
public 
string  
TextoParaDesistentes *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
public 
string 
StatusConvocacao &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
public 
string 
StatusContratacao '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public 
string 
EntrouNoSistema %
{& '
get( +
;+ ,
set. 1
;1 2
}3 4
} 
} ¸
ëC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\ConvocacoesViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class  
ConvocacoesViewModel %
{ 
[ 	
Key	 
] 
public 
Guid 
ConvocacaoId &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
public

 
Guid

 

ProcessoId

 
{

  
get

! $
;

$ %
set

& )
;

) *
}

+ ,
public 
Guid 
ConvocadoId 
{  !
get" %
;% &
set' *
;* +
}, -
public 
DateTime !
DataEntregaDocumentos -
{. /
get0 3
;3 4
set5 8
;8 9
}: ;
public 
TimeSpan #
HorarioEntregaDocumento /
{0 1
get2 5
;5 6
set7 :
;: ;
}< =
public 
string $
EnderecoEntregaDocumento .
{/ 0
get1 4
;4 5
set6 9
;9 :
}; <
public 
bool 
EnviouEmail 
{  !
get" %
;% &
set' *
;* +
}, -
public 
string 

Desistente  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 
bool 
Ativo 
{ 
get 
;  
set! $
;$ %
}& '
public 
string "
CandidatosSelecionados ,
{- .
get/ 2
;2 3
set4 7
;7 8
}9 :
public 
string  
TextoParaDesistentes *
{+ ,
get- 0
;0 1
set2 5
;5 6
}7 8
public 
string 
StatusConvocacao &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
public 
string 
StatusContratacao '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public 
object 
EntrouNoSistema %
{& '
get( +
;+ ,
internal- 5
set6 9
;9 :
}; <
public 
string 
Email 
{ 
get !
;! "
set# &
;& '
}( )
public 
string 
Nome 
{ 
get  
;  !
set" %
;% &
}' (
} 
} „´
èC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\ConvocadoViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class 
ConvocadoViewModel #
{ 
public 
ConvocadoViewModel !
(! "
)" #
{		 	
ConvocadoId

 
=

 
Guid

 
.

 
NewGuid

 &
(

& '
)

' (
;

( )
} 	
[ 	
Key	 
] 
public 
Guid 
ConvocadoId 
{  !
get" %
;% &
set' *
;* +
}, -
public 
Guid 

ProcessoId 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
	Inscricao 
{  !
get" %
;% &
set' *
;* +
}, -
[ 	
Required	 
( 
AllowEmptyStrings #
=$ %
false& +
)+ ,
], -
[ 	
	MaxLength	 
( 
$num 
) 
] 
[ 	
Display	 
( 
Name 
= 
$str  
)  !
]! "
public 
string 
Nome 
{ 
get  
;  !
set" %
;% &
}' (
[ 	
Required	 
( 
AllowEmptyStrings #
=$ %
false& +
)+ ,
], -
[ 	
	MaxLength	 
( 
$num 
) 
] 
[ 	
Display	 
( 
Name 
= 
$str '
)' (
]( )
public 
string 
Mae 
{ 
get 
;  
set! $
;$ %
}& '
[ 	
Required	 
( 
AllowEmptyStrings #
=$ %
false& +
)+ ,
], -
[ 	
	MaxLength	 
( 
$num 
) 
] 
[ 	
Display	 
( 
Name 
= 
$str  
)  !
]! "
public   
string   
Sexo   
{   
get    
;    !
set  " %
;  % &
}  ' (
["" 	
Required""	 
("" 
AllowEmptyStrings"" #
=""$ %
false""& +
)""+ ,
]"", -
[## 	
	MaxLength##	 
(## 
$num## 
)## 
]## 
[$$ 	
Display$$	 
($$ 
Name$$ 
=$$ 
$str$$ 3
)$$3 4
]$$4 5
public%% 
string%% 
	Documento%% 
{%%  !
get%%" %
;%%% &
set%%' *
;%%* +
}%%, -
['' 	
Required''	 
('' 
AllowEmptyStrings'' #
=''$ %
false''& +
)''+ ,
]'', -
[(( 	
	MaxLength((	 
((( 
$num(( 
)(( 
](( 
[)) 	
Display))	 
()) 
Name)) 
=)) 
$str)) 
)))  
]))  !
public** 
string** 
Cpf** 
{** 
get** 
;**  
set**! $
;**$ %
}**& '
[,, 	
Required,,	 
(,, 
AllowEmptyStrings,, #
=,,$ %
false,,& +
),,+ ,
],,, -
[-- 	
	MaxLength--	 
(-- 
$num-- 
)-- 
]-- 
[.. 	
Display..	 
(.. 
Name.. 
=.. 
$str.. "
).." #
]..# $
[// 	
EmailAddress//	 
(// 
ErrorMessage// "
=//# $
$str//% 7
)//7 8
]//8 9
public00 
string00 
Email00 
{00 
get00 !
;00! "
set00# &
;00& '
}00( )
[22 	
Required22	 
(22 
AllowEmptyStrings22 #
=22$ %
false22& +
)22+ ,
]22, -
[33 	
	MaxLength33	 
(33 
$num33 
)33 
]33 
[44 	
Display44	 
(44 
Name44 
=44 
$str44 .
)44. /
]44/ 0
public55 
string55 
Telefone55 
{55  
get55! $
;55$ %
set55& )
;55) *
}55+ ,
[77 	
Required77	 
(77 
AllowEmptyStrings77 #
=77$ %
false77& +
)77+ ,
]77, -
[88 	
	MaxLength88	 
(88 
$num88 
)88 
]88 
[99 	
Display99	 
(99 
Name99 
=99 
$str99 #
)99# $
]99$ %
public:: 
string:: 
Celular:: 
{:: 
get::  #
;::# $
set::% (
;::( )
}::* +
[<< 	
Required<<	 
(<< 
AllowEmptyStrings<< #
=<<$ %
false<<& +
)<<+ ,
]<<, -
[== 	
	MaxLength==	 
(== 
$num== 
)== 
]== 
[>> 	
Display>>	 
(>> 
Name>> 
=>> 
$str>> $
)>>$ %
]>>% &
public?? 
string?? 
Endereco?? 
{??  
get??! $
;??$ %
set??& )
;??) *
}??+ ,
[AA 	
RequiredAA	 
(AA 
AllowEmptyStringsAA #
=AA$ %
falseAA& +
)AA+ ,
]AA, -
[BB 	
	MaxLengthBB	 
(BB 
$numBB 
)BB 
]BB 
[CC 	
DisplayCC	 
(CC 
NameCC 
=CC 
$strCC "
)CC" #
]CC# $
publicDD 
stringDD 
NumeroDD 
{DD 
getDD "
;DD" #
setDD$ '
;DD' (
}DD) *
[FF 	
DisplayFF	 
(FF 
NameFF 
=FF 
$strFF %
)FF% &
]FF& '
publicFF( .
stringFF/ 5
ComplementoFF6 A
{FFB C
getFFD G
;FFG H
setFFI L
;FFL M
}FFN O
[HH 	
RequiredHH	 
(HH 
AllowEmptyStringsHH #
=HH$ %
falseHH& +
)HH+ ,
]HH, -
[II 	
	MaxLengthII	 
(II 
$numII 
)II 
]II 
[JJ 	
DisplayJJ	 
(JJ 
NameJJ 
=JJ 
$strJJ "
)JJ" #
]JJ# $
publicKK 
stringKK 
BairroKK 
{KK 
getKK "
;KK" #
setKK$ '
;KK' (
}KK) *
[MM 	
RequiredMM	 
(MM 
AllowEmptyStringsMM #
=MM$ %
falseMM& +
)MM+ ,
]MM, -
[NN 	
	MaxLengthNN	 
(NN 
$numNN 
)NN 
]NN 
[OO 	
DisplayOO	 
(OO 
NameOO 
=OO 
$strOO "
)OO" #
]OO# $
publicPP 
stringPP 
CidadePP 
{PP 
getPP "
;PP" #
setPP$ '
;PP' (
}PP) *
[RR 	
RequiredRR	 
(RR 
AllowEmptyStringsRR #
=RR$ %
falseRR& +
)RR+ ,
]RR, -
[SS 	
	MaxLengthSS	 
(SS 
$numSS 
)SS 
]SS 
[TT 	
DisplayTT	 
(TT 
NameTT 
=TT 
$strTT "
)TT" #
]TT# $
publicUU 
stringUU 
UfUU 
{UU 
getUU 
;UU 
setUU  #
;UU# $
}UU% &
[WW 	
RequiredWW	 
(WW 
AllowEmptyStringsWW #
=WW$ %
falseWW& +
)WW+ ,
]WW, -
[XX 	
	MaxLengthXX	 
(XX 
$numXX 
)XX 
]XX 
[YY 	
DisplayYY	 
(YY 
NameYY 
=YY 
$strYY 
)YY  
]YY  !
publicZZ 
stringZZ 
CepZZ 
{ZZ 
getZZ 
;ZZ  
setZZ! $
;ZZ$ %
}ZZ& '
[\\ 	
Display\\	 
(\\ 
Name\\ 
=\\ 
$str\\ !
)\\! "
]\\" #
public\\$ *
string\\+ 1
Cargo\\2 7
{\\8 9
get\\: =
;\\= >
set\\? B
;\\B C
}\\D E
[^^ 	
Display^^	 
(^^ 
Name^^ 
=^^ 
$str^^ #
)^^# $
]^^$ %
public^^& ,
Guid^^- 1
CargoId^^2 9
{^^: ;
get^^< ?
;^^? @
set^^A D
;^^D E
}^^F G
[`` 	
Display``	 
(`` 
Name`` 
=`` 
$str`` #
)``# $
]``$ %
public``& ,
int``- 0
	Pontuacao``1 :
{``; <
get``= @
;``@ A
set``B E
;``E F
}``G H
[bb 	
Displaybb	 
(bb 
Namebb 
=bb 
$strbb !
)bb! "
]bb" #
publicbb$ *
intbb+ .
Posicaobb/ 6
{bb7 8
getbb9 <
;bb< =
setbb> A
;bbA B
}bbC D
[dd 	
Displaydd	 
(dd 
Namedd 
=dd 
$strdd #
)dd# $
]dd$ %
publicdd& ,
stringdd- 3
	Resultadodd4 =
{dd> ?
getdd@ C
;ddC D
setddE H
;ddH I
}ddJ K
[ff 	
Requiredff	 
(ff 
AllowEmptyStringsff #
=ff$ %
falseff& +
)ff+ ,
]ff, -
[gg 	
	MaxLengthgg	 
(gg 
$numgg 
)gg 
]gg 
[hh 	
Displayhh	 
(hh 
Namehh 
=hh 
$strhh (
)hh( )
]hh) *
publicii 
stringii 
Naturalidadeii "
{ii# $
getii% (
;ii( )
setii* -
;ii- .
}ii/ 0
[kk 	
Requiredkk	 
(kk 
AllowEmptyStringskk #
=kk$ %
falsekk& +
)kk+ ,
]kk, -
[ll 	
	MaxLengthll	 
(ll 
$numll 
)ll 
]ll 
[nn 	
Displaynn	 
(nn 
Namenn 
=nn 
$strnn '
)nn' (
]nn( )
publicoo 
stringoo 
Paioo 
{oo 
getoo 
;oo  
setoo! $
;oo$ %
}oo& '
[qq 	
Requiredqq	 
(qq 
AllowEmptyStringsqq #
=qq$ %
falseqq& +
)qq+ ,
]qq, -
[rr 	
	MaxLengthrr	 
(rr 
$numrr 
)rr 
]rr 
[ss 	
Displayss	 
(ss 
Namess 
=ss 
$strss )
)ss) *
]ss* +
publictt 
stringtt 
OrgaoEmissortt "
{tt# $
gettt% (
;tt( )
settt* -
;tt- .
}tt/ 0
[vv 	
Requiredvv	 
(vv 
AllowEmptyStringsvv #
=vv$ %
falsevv& +
)vv+ ,
]vv, -
[ww 	
Displayww	 
(ww 
Nameww 
=ww 
$strww (
)ww( )
]ww) *
publicxx 
stringxx 
EstadoCivilxx !
{xx" #
getxx$ '
;xx' (
setxx) ,
;xx, -
}xx. /
publiczz 
stringzz 
EntrouNoSistemazz %
{zz& '
getzz( +
;zz+ ,
setzz- 0
;zz0 1
}zz2 3
public|| 
string|| 

Desistente||  
{||! "
get||# &
;||& '
set||( +
;||+ ,
}||- .
public}} 
DateTime}} !
DataEntregaDocumentos}} -
{}}. /
get}}0 3
;}}3 4
set}}5 8
;}}8 9
}}}: ;
public~~ 
Guid~~ 
ConvocacaoId~~  
{~~! "
get~~# &
;~~& '
set~~( +
;~~+ ,
}~~- .
public 
string 
StatusConvocacao &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
public
ÄÄ 
string
ÄÄ 
StatusContratacao
ÄÄ '
{
ÄÄ( )
get
ÄÄ* -
;
ÄÄ- .
set
ÄÄ/ 2
;
ÄÄ2 3
}
ÄÄ4 5
[
ÇÇ 	
Required
ÇÇ	 
(
ÇÇ 
AllowEmptyStrings
ÇÇ #
=
ÇÇ$ %
false
ÇÇ& +
)
ÇÇ+ ,
]
ÇÇ, -
[
ÉÉ 	
	MaxLength
ÉÉ	 
(
ÉÉ 
$num
ÉÉ 
)
ÉÉ 
]
ÉÉ 
[
ÑÑ 	
Display
ÑÑ	 
(
ÑÑ 
Name
ÑÑ 
=
ÑÑ 
$str
ÑÑ .
)
ÑÑ. /
]
ÑÑ/ 0
public
ÖÖ 
string
ÖÖ 
DataNascimento
ÖÖ $
{
ÖÖ% &
get
ÖÖ' *
;
ÖÖ* +
set
ÖÖ, /
;
ÖÖ/ 0
}
ÖÖ1 2
[
áá 	
Required
áá	 
(
áá 
AllowEmptyStrings
áá #
=
áá$ %
false
áá& +
)
áá+ ,
]
áá, -
[
àà 	
	MaxLength
àà	 
(
àà 
$num
àà 
)
àà 
]
àà 
[
ââ 	
Display
ââ	 
(
ââ 
Name
ââ 
=
ââ 
$str
ââ +
)
ââ+ ,
]
ââ, -
public
ää 
string
ää 
FatorSanguineo
ää $
{
ää% &
get
ää' *
;
ää* +
set
ää, /
;
ää/ 0
}
ää1 2
[
åå 	
Required
åå	 
(
åå 
AllowEmptyStrings
åå #
=
åå$ %
false
åå& +
)
åå+ ,
]
åå, -
[
çç 	
	MaxLength
çç	 
(
çç 
$num
çç 
)
çç 
]
çç 
[
éé 	
Display
éé	 
(
éé 
Name
éé 
=
éé 
$str
éé "
)
éé" #
]
éé# $
public
èè 
string
èè 
Doador
èè 
{
èè 
get
èè "
;
èè" #
set
èè$ '
;
èè' (
}
èè) *
[
ëë 	
	MaxLength
ëë	 
(
ëë 
$num
ëë 
)
ëë 
]
ëë 
[
íí 	
Display
íí	 
(
íí 
Name
íí 
=
íí 
$str
íí ,
)
íí, -
]
íí- .
public
ìì 
string
ìì 
Recados
ìì 
{
ìì 
get
ìì  #
;
ìì# $
set
ìì% (
;
ìì( )
}
ìì* +
[
ïï 	
Required
ïï	 
(
ïï 
AllowEmptyStrings
ïï #
=
ïï$ %
false
ïï& +
)
ïï+ ,
]
ïï, -
[
ññ 	
	MaxLength
ññ	 
(
ññ 
$num
ññ 
)
ññ 
]
ññ 
[
óó 	
Display
óó	 
(
óó 
Name
óó 
=
óó 
$str
óó )
)
óó) *
]
óó* +
public
òò 
string
òò 
Nacionalidade
òò #
{
òò$ %
get
òò& )
;
òò) *
set
òò+ .
;
òò. /
}
òò0 1
[
öö 	
Required
öö	 
(
öö 
AllowEmptyStrings
öö #
=
öö$ %
false
öö& +
)
öö+ ,
]
öö, -
[
õõ 	
	MaxLength
õõ	 
(
õõ 
$num
õõ 
)
õõ 
]
õõ 
[
úú 	
Display
úú	 
(
úú 
Name
úú 
=
úú 
$str
úú -
)
úú- .
]
úú. /
public
ùù 
string
ùù 
GrauInstrucao
ùù #
{
ùù$ %
get
ùù& )
;
ùù) *
set
ùù+ .
;
ùù. /
}
ùù0 1
[
üü 	
Required
üü	 
(
üü 
AllowEmptyStrings
üü #
=
üü$ %
false
üü& +
)
üü+ ,
]
üü, -
[
†† 	
	MaxLength
††	 
(
†† 
$num
†† 
)
†† 
]
†† 
[
°° 	
Display
°°	 
(
°° 
Name
°° 
=
°° 
$str
°° 1
)
°°1 2
]
°°2 3
public
¢¢ 
string
¢¢ 
InstituicaoEnsino
¢¢ '
{
¢¢( )
get
¢¢* -
;
¢¢- .
set
¢¢/ 2
;
¢¢2 3
}
¢¢4 5
[
§§ 	
Required
§§	 
(
§§ 
AllowEmptyStrings
§§ #
=
§§$ %
false
§§& +
)
§§+ ,
]
§§, -
[
•• 	
	MaxLength
••	 
(
•• 
$num
•• 
)
•• 
]
•• 
[
¶¶ 	
Display
¶¶	 
(
¶¶ 
Name
¶¶ 
=
¶¶ 
$str
¶¶ +
)
¶¶+ ,
]
¶¶, -
public
ßß 
string
ßß 
TelefoneIES
ßß !
{
ßß" #
get
ßß$ '
;
ßß' (
set
ßß) ,
;
ßß, -
}
ßß. /
public
©© 
string
©© 
Curso
©© 
{
©© 
get
©© !
;
©©! "
set
©©# &
;
©©& '
}
©©( )
[
´´ 	
Required
´´	 
(
´´ 
AllowEmptyStrings
´´ #
=
´´$ %
false
´´& +
)
´´+ ,
]
´´, -
[
¨¨ 	
	MaxLength
¨¨	 
(
¨¨ 
$num
¨¨ 
)
¨¨ 
]
¨¨ 
[
≠≠ 	
Display
≠≠	 
(
≠≠ 
Name
≠≠ 
=
≠≠ 
$str
≠≠ 2
)
≠≠2 3
]
≠≠3 4
public
ÆÆ 
string
ÆÆ 
HorarioAulaIes
ÆÆ $
{
ÆÆ% &
get
ÆÆ' *
;
ÆÆ* +
set
ÆÆ, /
;
ÆÆ/ 0
}
ÆÆ1 2
[
∞∞ 	
Required
∞∞	 
(
∞∞ 
AllowEmptyStrings
∞∞ #
=
∞∞$ %
false
∞∞& +
)
∞∞+ ,
]
∞∞, -
[
±± 	
	MaxLength
±±	 
(
±± 
$num
±± 
)
±± 
]
±± 
[
≤≤ 	
Display
≤≤	 
(
≤≤ 
Name
≤≤ 
=
≤≤ 
$str
≤≤ /
)
≤≤/ 0
]
≤≤0 1
public
≥≥ 
string
≥≥ 
PeriodoAtual
≥≥ "
{
≥≥# $
get
≥≥% (
;
≥≥( )
set
≥≥* -
;
≥≥- .
}
≥≥/ 0
[
µµ 	
Required
µµ	 
(
µµ 
AllowEmptyStrings
µµ #
=
µµ$ %
false
µµ& +
)
µµ+ ,
]
µµ, -
[
∂∂ 	
	MaxLength
∂∂	 
(
∂∂ 
$num
∂∂ 
)
∂∂ 
]
∂∂ 
[
∑∑ 	
Display
∑∑	 
(
∑∑ 
Name
∑∑ 
=
∑∑ 
$str
∑∑ ?
)
∑∑? @
]
∑∑@ A
public
∏∏ 
string
∏∏ 
ColacaoGrau
∏∏ !
{
∏∏" #
get
∏∏$ '
;
∏∏' (
set
∏∏) ,
;
∏∏, -
}
∏∏. /
[
∫∫ 	
Required
∫∫	 
(
∫∫ 
AllowEmptyStrings
∫∫ #
=
∫∫$ %
false
∫∫& +
)
∫∫+ ,
]
∫∫, -
[
ªª 	
	MaxLength
ªª	 
(
ªª 
$num
ªª 
)
ªª 
]
ªª 
[
ºº 	
Display
ºº	 
(
ºº 
Name
ºº 
=
ºº 
$str
ºº #
)
ºº# $
]
ºº$ %
public
ΩΩ 
string
ΩΩ 
Agencia
ΩΩ 
{
ΩΩ 
get
ΩΩ  #
;
ΩΩ# $
set
ΩΩ% (
;
ΩΩ( )
}
ΩΩ* +
[
øø 	
Required
øø	 
(
øø 
AllowEmptyStrings
øø #
=
øø$ %
false
øø& +
)
øø+ ,
]
øø, -
[
¿¿ 	
	MaxLength
¿¿	 
(
¿¿ 
$num
¿¿ 
)
¿¿ 
]
¿¿ 
[
¡¡ 	
Display
¡¡	 
(
¡¡ 
Name
¡¡ 
=
¡¡ 
$str
¡¡ +
)
¡¡+ ,
]
¡¡, -
public
¬¬ 
string
¬¬ 
NomeAgencia
¬¬ !
{
¬¬" #
get
¬¬$ '
;
¬¬' (
set
¬¬) ,
;
¬¬, -
}
¬¬. /
[
ƒƒ 	
Required
ƒƒ	 
(
ƒƒ 
AllowEmptyStrings
ƒƒ #
=
ƒƒ$ %
false
ƒƒ& +
)
ƒƒ+ ,
]
ƒƒ, -
[
≈≈ 	
	MaxLength
≈≈	 
(
≈≈ 
$num
≈≈ 
)
≈≈ 
]
≈≈ 
[
∆∆ 	
Display
∆∆	 
(
∆∆ 
Name
∆∆ 
=
∆∆ 
$str
∆∆ *
)
∆∆* +
]
∆∆+ ,
public
«« 
string
«« 
ContaCorrente
«« #
{
««$ %
get
««& )
;
««) *
set
««+ .
;
««. /
}
««0 1
}
»» 
}…… Ö
ïC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\DadosConvocadosViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class $
DadosConvocadosViewModel )
{		 
[

 	
Key

	 
]

 
public 
Guid 
Id 
{ 
get 
; 
set !
;! "
}# $
[ 	
Display	 
( 
Name 
= 
$str !
)! "
]" #
public 
	IFormFile 
File 
{ 
get  #
;# $
set% (
;( )
}* +
} 
} ø
íC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\DocumentacaoViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class !
DocumentacaoViewModel &
{ 
public !
DocumentacaoViewModel $
($ %
)% &
{		 	
DocumentoId

 
=

 
Guid

 
.

 
NewGuid

 &
(

& '
)

' (
;

( )
} 	
[ 	
Key	 
] 
[ 	
Display	 
( 
Name 
= 
$str 
) 
] 
public 
Guid 
DocumentoId 
{  !
get" %
;% &
set' *
;* +
}, -
[ 	
Required	 
] 
[ 	
Display	 
( 
Name 
= 
$str $
)$ %
]% &
public 
Guid 

ProcessoId 
{  
get! $
;$ %
set& )
;) *
}+ ,
[ 	
Required	 
( 
AllowEmptyStrings #
=$ %
false& +
)+ ,
], -
[ 	
	MaxLength	 
( 
$num 
) 
] 
[ 	
Display	 
( 
Name 
= 
$str 0
)0 1
]1 2
public 
string 
	Descricao 
{  !
get" %
;% &
set' *
;* +
}, -
[ 	
Display	 
( 
Name 
= 
$str )
)) *
]* +
public, 2
DateTime3 ;
DataCriacao< G
{H I
getJ M
;M N
setO R
;R S
}T U
[ 	
Required	 
( 
AllowEmptyStrings #
=$ %
false& +
)+ ,
], -
[ 	
	MaxLength	 
( 
$num 
) 
] 
[ 	
Display	 
( 
Name 
= 
$str !
)! "
]" #
public 
string 
Path 
{ 
get  
;  !
set" %
;% &
}' (
[!! 	
Required!!	 
(!! 
AllowEmptyStrings!! #
=!!$ %
false!!& +
)!!+ ,
]!!, -
["" 	
Display""	 
("" 
Name"" 
="" 
$str"" 
)""  
]""  !
public## 
bool## 
Ativo## 
{## 
get## 
;##  
set##! $
;##$ %
}##& '
}$$ 
}%% Ì
òC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\DocumentoCandidatoViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class '
DocumentoCandidatoViewModel ,
{ 
[ 	
Key	 
] 
public		 
Guid		  
DocumentoCandidatoId		 (
{		) *
get		+ .
;		. /
set		0 3
;		3 4
}		5 6
[ 	
Required	 
] 
public 
Guid 

ProcessoId 
{  
get! $
;$ %
set& )
;) *
}+ ,
[ 	
Required	 
] 
public 
Guid 
ConvocadoId 
{  !
get" %
;% &
set' *
;* +
}, -
[ 	
Required	 
( 
AllowEmptyStrings #
=$ %
false& +
)+ ,
], -
[ 	
	MaxLength	 
( 
$num 
) 
] 
[ 	
Display	 
( 
Name 
= 
$str $
)$ %
]% &
public 
string 
	Documento 
{  !
get" %
;% &
set' *
;* +
}, -
[ 	
Required	 
( 
AllowEmptyStrings #
=$ %
false& +
)+ ,
], -
[ 	
Display	 
( 
Name 
= 
$str (
)( )
]) *
public 
DateTime 
DataInclusao $
{% &
get' *
;* +
set, /
;/ 0
}1 2
[ 	
Required	 
( 
AllowEmptyStrings #
=$ %
false& +
)+ ,
], -
[ 	
Display	 
( 
Name 
= 
$str ,
), -
]- .
public 
string 
TipoDocumento #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
string 
Path 
{ 
get  
;  !
set" %
;% &
}' (
[!! 	
Required!!	 
(!! 
AllowEmptyStrings!! #
=!!$ %
false!!& +
)!!+ ,
]!!, -
public"" 
string"" 
Ativo"" 
{"" 
get"" !
;""! "
set""# &
;""& '
}""( )
}## 
}$$ ¢*
éC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\EditUserViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class 
EditUserViewModel "
{ 
public		 
string		 
Id		 
{		 
get		 
;		 
set		  #
;		# $
}		% &
public 
IEnumerable 
< 
SelectListItem )
>) *
	RolesList+ 4
{5 6
get7 :
;: ;
set< ?
;? @
}A B
[ 	
Required	 
] 
[ 	
EmailAddress	 
] 
[ 	
Display	 
( 
Name 
= 
$str 
)  
]  !
public 
string 
Email 
{ 
get !
;! "
set# &
;& '
}( )
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
, 
ErrorMessage '
=( )
$str* Y
,Y Z
MinimumLength[ h
=i j
$numk l
)l m
]m n
[ 	
DataType	 
( 
DataType 
. 
Password #
)# $
]$ %
[ 	
Display	 
( 
Name 
= 
$str 
)  
]  !
public 
string 
Password 
{  
get! $
;$ %
set& )
;) *
}+ ,
[ 	
DataType	 
( 
DataType 
. 
Password #
)# $
]$ %
[ 	
Display	 
( 
Name 
= 
$str )
)) *
]* +
[ 	
Compare	 
( 
$str 
, 
ErrorMessage )
=* +
$str, [
)[ \
]\ ]
public 
string 
ConfirmPassword %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
[ 	
Required	 
] 
[ 	
Display	 
( 
Name 
= 
$str *
)* +
]+ ,
[ 	
	MaxLength	 
( 
$num 
, 
ErrorMessage $
=% &
$str' R
)R S
]S T
public   
string   
Nome   
{   
get    
;    !
set  " %
;  % &
}  ' (
["" 	
Required""	 
]"" 
[## 	
Display##	 
(## 
Name## 
=## 
$str## 1
)##1 2
]##2 3
[$$ 	
	MaxLength$$	 
($$ 
$num$$ 
,$$ 
ErrorMessage$$ #
=$$$ %
$str$$& S
)$$S T
]$$T U
public%% 
string%% 
Empresa%% 
{%% 
get%%  #
;%%# $
set%%% (
;%%( )
}%%* +
['' 	
Required''	 
]'' 
[(( 	
Display((	 
((( 
Name(( 
=(( 
$str(( 1
)((1 2
]((2 3
[)) 	
	MaxLength))	 
()) 
$num)) 
,)) 
ErrorMessage)) #
=))$ %
$str))& P
)))P Q
]))Q R
public** 
string** 
Cnpj** 
{** 
get**  
;**  !
set**" %
;**% &
}**' (
[,, 	
Required,,	 
],, 
[-- 	
Display--	 
(-- 
Name-- 
=-- 
$str-- .
)--. /
]--/ 0
[.. 	
	MaxLength..	 
(.. 
$num.. 
,.. 
ErrorMessage.. #
=..$ %
$str..& T
)..T U
]..U V
public// 
string// 
Telefone// 
{//  
get//! $
;//$ %
set//& )
;//) *
}//+ ,
[11 	
Required11	 
]11 
[22 	
Display22	 
(22 
Name22 
=22 
$str22 3
)223 4
]224 5
[33 	
	MaxLength33	 
(33 
$num33 
,33 
ErrorMessage33 $
=33% &
$str33' T
)33T U
]33U V
public44 
string44 
Imagem44 
{44 
get44 "
;44" #
set44$ '
;44' (
}44) *
[66 	
Required66	 
]66 
[77 	
Display77	 
(77 
Name77 
=77 
$str77  
)77  !
]77! "
public88 
bool88 
Ativo88 
{88 
get88 
;88  
set88! $
;88$ %
}88& '
}99 
}:: à
üC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\ExternalLoginConfirmationViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class .
"ExternalLoginConfirmationViewModel 3
{ 
[ 	
Required	 
] 
[ 
Display 
( 
Name  
=! "
$str# *
)* +
]+ ,
public- 3
string4 :
Email; @
{A B
getC F
;F G
setH K
;K L
}M N
} 
}		 ƒ
óC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\ExternalLoginListViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class &
ExternalLoginListViewModel +
{ 
public 
string 
	ReturnUrl 
{  !
get" %
;% &
set' *
;* +
}, -
} 
} ¨
åC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\FactorViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class 
FactorViewModel  
{ 
public 
string 
Purpose 
{ 
get  #
;# $
set% (
;( )
}* +
} 
} ™
îC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\ForgotPasswordViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class #
ForgotPasswordViewModel (
{ 
[ 	
Required	 
] 
[ 	
EmailAddress	 
] 
[		 	
Display			 
(		 
Name		 
=		 
$str		  
)		  !
]		! "
public

 
string

 
Email

 
{

 
get

 !
;

! "
set

# &
;

& '
}

( )
} 
} ‚
åC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\ForgotViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class 
ForgotViewModel  
{ 
[ 	
Required	 
] 
[ 
Display 
( 
Name  
=! "
$str# *
)* +
]+ ,
public- 3
string4 :
Email; @
{A B
getC F
;F G
setH K
;K L
}M N
} 
}		 €	
ãC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\IndexViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class 
IndexViewModel 
{ 
public 
bool 
HasPassword 
{  !
get" %
;% &
set' *
;* +
}, -
public		 
IList		 
<		 
UserLoginInfo		 "
>		" #
Logins		$ *
{		+ ,
get		- 0
;		0 1
set		2 5
;		5 6
}		7 8
public

 
string

 
PhoneNumber

 !
{

" #
get

$ '
;

' (
set

) ,
;

, -
}

. /
public 
bool 
	TwoFactor 
{ 
get  #
;# $
set% (
;( )
}* +
public 
bool 
BrowserRemembered %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
} 
} ú
ïC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\ListaDocumentosViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class $
ListaDocumentosViewModel )
{ 
public 
Guid 
ConvocacaoId  
{! "
get# &
;& '
set( +
;+ ,
}- .
public		 
string		 
Nome		 
{		 
get		  
;		  !
set		" %
;		% &
}		' (
public

 
string

 
Curso

 
{

 
get

 !
;

! "
set

# &
;

& '
}

( )
[ 	
Display	 
( 
Name 
= 
$str !
)! "
]" #
public 
string 
Path 
{ 
get  
;  !
set" %
;% &
}' (
[ 	
Display	 
( 
Name 
= 
$str +
)+ ,
], -
public 
string 
TipoDocumento #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
DateTime 
DataPostagem $
{% &
get' *
;* +
set, /
;/ 0
}1 2
[ 	
Display	 
( 
Name 
= 
$str #
)# $
]$ %
public 
string 
	Inscricao 
{  !
get" %
;% &
set' *
;* +
}, -
public 
Guid  
DocumentoCandidatoId (
{) *
get+ .
;. /
set0 3
;3 4
}5 6
} 
} ˆ
íC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\ManageLoginsViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class !
ManageLoginsViewModel &
{ 
public		 
IList		 
<		 
UserLoginInfo		 "
>		" #
CurrentLogins		$ 1
{		2 3
get		4 7
;		7 8
set		9 <
;		< =
}		> ?
} 
} ˙W
åC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\PessoaViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class 
PessoaViewModel  
{ 
public 
PessoaViewModel 
( 
)  
{		 	
PessoaId

 
=

 
Guid

 
.

 
NewGuid

 #
(

# $
)

$ %
;

% &
} 	
[ 	
Key	 
] 
public 
Guid 
PessoaId "
{# $
get% (
;( )
set* -
;- .
}/ 0
[ 	
Required	 
( 
AllowEmptyStrings #
=$ %
false& +
)+ ,
], -
[ 	
Display	 
( 
Name 
= 
$str +
)+ ,
], -
public 
string 
Nome 
{ 
get  
;  !
set" %
;% &
}' (
[ 	
Required	 
( 
AllowEmptyStrings #
=$ %
false& +
)+ ,
], -
[ 	
Display	 
( 
Name 
= 
$str &
)& '
]' (
public 
string 
Naturalidade "
{# $
get% (
;( )
set* -
;- .
}/ 0
[ 	
Required	 
( 
AllowEmptyStrings #
=$ %
false& +
)+ ,
], -
[ 	
Display	 
( 
Name 
= 
$str 
) 
] 
public 
string 
Mae 
{ 
get 
;  
set! $
;$ %
}& '
[ 	
Required	 
( 
AllowEmptyStrings #
=$ %
false& +
)+ ,
], -
[ 	
Display	 
( 
Name 
= 
$str 
) 
] 
public 
string 
Pai 
{ 
get 
;  
set! $
;$ %
}& '
[ 	
Required	 
( 
AllowEmptyStrings #
=$ %
false& +
)+ ,
], -
[   	
Display  	 
(   
Name   
=   
$str   #
)  # $
]  $ %
public!! 
string!! 
	Documento!! 
{!!  !
get!!" %
;!!% &
set!!' *
;!!* +
}!!, -
[## 	
Required##	 
(## 
AllowEmptyStrings## #
=##$ %
false##& +
)##+ ,
]##, -
[$$ 	
Display$$	 
($$ 
Name$$ 
=$$ 
$str$$ '
)$$' (
]$$( )
public%% 
string%% 
OrgaoEmissor%% "
{%%# $
get%%% (
;%%( )
set%%* -
;%%- .
}%%/ 0
['' 	
Required''	 
('' 
AllowEmptyStrings'' #
=''$ %
false''& +
)''+ ,
]'', -
[(( 	
Display((	 
((( 
Name(( 
=(( 
$str(( 
)(( 
]((  
public)) 
int)) 
Sexo)) 
{)) 
get)) 
;)) 
set)) "
;))" #
}))$ %
[++ 	
Required++	 
(++ 
AllowEmptyStrings++ #
=++$ %
false++& +
)+++ ,
]++, -
[,, 	
Display,,	 
(,, 
Name,, 
=,, 
$str,, &
),,& '
],,' (
public-- 
int-- 
EstadoCivil-- 
{--  
get--! $
;--$ %
set--& )
;--) *
}--+ ,
[// 	
Required//	 
(// 
AllowEmptyStrings// #
=//$ %
false//& +
)//+ ,
]//, -
[00 	
Display00	 
(00 
Name00 
=00 
$str00 ,
)00, -
]00- .
public11 
DateTime11 
DataNascimento11 &
{11' (
get11) ,
;11, -
set11. 1
;111 2
}113 4
[33 	
Required33	 
(33 
AllowEmptyStrings33 #
=33$ %
false33& +
)33+ ,
]33, -
[44 	
Display44	 
(44 
Name44 
=44 
$str44  
)44  !
]44! "
public55 
int55 
Filhos55 
{55 
get55 
;55  
set55! $
;55$ %
}55& '
[77 	
Required77	 
(77 
AllowEmptyStrings77 #
=77$ %
false77& +
)77+ ,
]77, -
[88 	
Display88	 
(88 
Name88 
=88 
$str88 "
)88" #
]88# $
public99 
string99 
Endereco99 
{99  
get99! $
;99$ %
set99& )
;99) *
}99+ ,
[;; 	
Required;;	 
(;; 
AllowEmptyStrings;; #
=;;$ %
false;;& +
);;+ ,
];;, -
[<< 	
Display<<	 
(<< 
Name<< 
=<< 
$str<<  
)<<  !
]<<! "
public== 
string== 
Numero== 
{== 
get== "
;==" #
set==$ '
;==' (
}==) *
[?? 	
Required??	 
(?? 
AllowEmptyStrings?? #
=??$ %
false??& +
)??+ ,
]??, -
[@@ 	
Display@@	 
(@@ 
Name@@ 
=@@ 
$str@@ %
)@@% &
]@@& '
publicAA 
stringAA 
ComplementoAA !
{AA" #
getAA$ '
;AA' (
setAA) ,
;AA, -
}AA. /
[CC 	
RequiredCC	 
(CC 
AllowEmptyStringsCC #
=CC$ %
falseCC& +
)CC+ ,
]CC, -
[DD 	
DisplayDD	 
(DD 
NameDD 
=DD 
$strDD  
)DD  !
]DD! "
publicEE 
stringEE 
BairroEE 
{EE 
getEE "
;EE" #
setEE$ '
;EE' (
}EE) *
[GG 	
RequiredGG	 
(GG 
AllowEmptyStringsGG #
=GG$ %
falseGG& +
)GG+ ,
]GG, -
[HH 	
DisplayHH	 
(HH 
NameHH 
=HH 
$strHH 
)HH 
]HH 
publicII 
stringII 
CepII 
{II 
getII 
;II  
setII! $
;II$ %
}II& '
[KK 	
RequiredKK	 
(KK 
AllowEmptyStringsKK #
=KK$ %
falseKK& +
)KK+ ,
]KK, -
[LL 	
DisplayLL	 
(LL 
NameLL 
=LL 
$strLL  
)LL  !
]LL! "
publicMM 
stringMM 
CidadeMM 
{MM 
getMM "
;MM" #
setMM$ '
;MM' (
}MM) *
[OO 	
RequiredOO	 
(OO 
AllowEmptyStringsOO #
=OO$ %
falseOO& +
)OO+ ,
]OO, -
[PP 	
DisplayPP	 
(PP 
NamePP 
=PP 
$strPP 
)PP 
]PP 
publicQQ 
stringQQ 
UfQQ 
{QQ 
getQQ 
;QQ 
setQQ  #
;QQ# $
}QQ% &
[SS 	
RequiredSS	 
(SS 
AllowEmptyStringsSS #
=SS$ %
falseSS& +
)SS+ ,
]SS, -
[TT 	
DisplayTT	 
(TT 
NameTT 
=TT 
$strTT 
)TT  
]TT  !
publicUU 
stringUU 
CargoUU 
{UU 
getUU !
;UU! "
setUU# &
;UU& '
}UU( )
[WW 	
RequiredWW	 
(WW 
AllowEmptyStringsWW #
=WW$ %
falseWW& +
)WW+ ,
]WW, -
[XX 	
DisplayXX	 
(XX 
NameXX 
=XX 
$strXX $
)XX$ %
]XX% &
publicYY 
boolYY 

DeficienteYY 
{YY  
getYY! $
;YY$ %
setYY& )
;YY) *
}YY+ ,
[[[ 	
Required[[	 
([[ 
AllowEmptyStrings[[ #
=[[$ %
false[[& +
)[[+ ,
][[, -
[\\ 	
Display\\	 
(\\ 
Name\\ 
=\\ 
$str\\ %
)\\% &
]\\& '
public]] 
string]] 
Deficiencia]] !
{]]" #
get]]$ '
;]]' (
set]]) ,
;]], -
}]]. /
[__ 	
Required__	 
(__ 
AllowEmptyStrings__ #
=__$ %
false__& +
)__+ ,
]__, -
[`` 	
Display``	 
(`` 
Name`` 
=`` 
$str`` +
)``+ ,
]``, -
publicaa 
stringaa 
CondicaoEspecialaa &
{aa' (
getaa) ,
;aa, -
setaa. 1
;aa1 2
}aa3 4
[cc 	
Requiredcc	 
(cc 
AllowEmptyStringscc #
=cc$ %
falsecc& +
)cc+ ,
]cc, -
[dd 	
Displaydd	 
(dd 
Namedd 
=dd 
$strdd 
)dd 
]dd 
publicee 
stringee 
Cpfee 
{ee 
getee 
;ee  
setee! $
;ee$ %
}ee& '
[gg 	
Requiredgg	 
(gg 
AllowEmptyStringsgg #
=gg$ %
falsegg& +
)gg+ ,
]gg, -
[hh 	
Displayhh	 
(hh 
Namehh 
=hh 
$strhh  
)hh  !
]hh! "
publicii 
stringii 
Emailii 
{ii 
getii !
;ii! "
setii# &
;ii& '
}ii( )
[kk 	
Requiredkk	 
(kk 
AllowEmptyStringskk #
=kk$ %
falsekk& +
)kk+ ,
]kk, -
[ll 	
Displayll	 
(ll 
Namell 
=ll 
$strll 
)ll 
]ll  
publicmm 
boolmm 
Afromm 
{mm 
getmm 
;mm 
setmm  #
;mm# $
}mm% &
}nn 
}oo ì
îC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\PrimeiroAcessoViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class #
PrimeiroAcessoViewModel (
{ 
public 
Guid 
PrimeiroAcessoId $
{% &
get' *
;* +
set, /
;/ 0
}1 2
public 
string 
Email 
{ 
get !
;! "
set# &
;& '
}( )
public		 
Guid		 
ConvocadoId		 
{		  !
get		" %
;		% &
set		' *
;		* +
}		, -
public

 
DateTime

 
Data

 
{

 
get

 "
;

" #
set

$ '
;

' (
}

) *
} 
} √
éC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\ProcessoViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class 
ProcessoViewModel "
{ 
[ 	
Key	 
] 
public		 
Guid		 

ProcessoId		 
{		  
get		! $
;		$ %
set		& )
;		) *
}		+ ,
[ 	
Required	 
] 
public 
Guid 
	ClienteId 
{ 
get  #
;# $
set% (
;( )
}* +
[ 	
Required	 
( 
AllowEmptyStrings #
=$ %
false& +
)+ ,
], -
[ 	
	MaxLength	 
( 
$num 
) 
] 
[ 	
Display	 
( 
Name 
= 
$str 
) 
]  
public 
string 
Nome 
{ 
get  
;  !
set" %
;% &
}' (
[ 	
Required	 
( 
AllowEmptyStrings #
=$ %
false& +
)+ ,
], -
[ 	
Display	 
( 
Name 
= 
$str )
)) *
]* +
public 
DateTime 
DataCriacao #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[ 	
Required	 
] 
[ 	
Display	 
( 
Name 
= 
$str 
)  
]  !
public 
bool 
Ativo 
{ 
get 
;  
set! $
;$ %
}& '
[ 	
Required	 
( 
AllowEmptyStrings #
=$ %
false& +
)+ ,
], -
[ 	
Display	 
( 
Name 
= 
$str :
): ;
]; <
[ 	
	MaxLength	 
( 
$num 
) 
] 
public 
string (
TextoDeAceitacaoDaConvocacao 2
{3 4
get5 8
;8 9
set: =
;= >
}? @
[   	
Required  	 
(   
AllowEmptyStrings   #
=  $ %
false  & +
)  + ,
]  , -
[!! 	
Display!!	 
(!! 
Name!! 
=!! 
$str!! =
)!!= >
]!!> ?
["" 	
	MaxLength""	 
("" 
$num"" 
)"" 
]"" 
public## 
string## %
TextoInicialTelaConvocado## /
{##0 1
get##2 5
;##5 6
set##7 :
;##: ;
}##< =
[%% 	
Required%%	 
(%% 
AllowEmptyStrings%% #
=%%$ %
false%%& +
)%%+ ,
]%%, -
[&& 	
Display&&	 
(&& 
Name&& 
=&& 
$str&& ;
)&&; <
]&&< =
['' 	
	MaxLength''	 
('' 
$num'' 
)'' 
]'' 
public(( 
string((  
TextoParaDesistentes(( *
{((+ ,
get((- 0
;((0 1
set((2 5
;((5 6
}((7 8
})) 
}** ˇ
ìC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\ResetPasswordViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class "
ResetPasswordViewModel '
{ 
[ 	
Required	 
] 
[ 	
EmailAddress	 
] 
[		 	
Display			 
(		 
Name		 
=		 
$str		  
)		  !
]		! "
public

 
string

 
Email

 
{

 
get

 !
;

! "
set

# &
;

& '
}

( )
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
, 
ErrorMessage '
=( )
$str* S
,S T
MinimumLengthU b
=c d
$nume f
)f g
]g h
[ 	
DataType	 
( 
DataType 
. 
Password #
)# $
]$ %
[ 	
Display	 
( 
Name 
= 
$str 
)  
]  !
public 
string 
Password 
{  
get! $
;$ %
set& )
;) *
}+ ,
[ 	
DataType	 
( 
DataType 
. 
Password #
)# $
]$ %
[ 	
Display	 
( 
Name 
= 
$str )
)) *
]* +
[ 	
Compare	 
( 
$str 
, 
ErrorMessage )
=* +
$str, E
)E F
]F G
public 
string 
ConfirmPassword %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 
string 
Code 
{ 
get  
;  !
set" %
;% &
}' (
} 
} “
äC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\RoleViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class 
RoleViewModel 
{ 
public 
string 
Id 
{ 
get 
; 
set  #
;# $
}% &
[		 	
Required			 
(		 
AllowEmptyStrings		 #
=		$ %
false		& +
)		+ ,
]		, -
[

 	
Display

	 
(

 
Name

 
=

 
$str

 &
)

& '
]

' (
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
} 
} Œ
éC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\SendCodeViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class 
SendCodeViewModel "
{ 
public 
string 
SelectedProvider &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
public		 
ICollection		 
<		 
SelectListItem		 )
>		) *
	Providers		+ 4
{		5 6
get		7 :
;		: ;
set		< ?
;		? @
}		A B
public

 
string

 
	ReturnUrl

 
{

  !
get

" %
;

% &
set

' *
;

* +
}

, -
public 
bool 

RememberMe 
{  
get! $
;$ %
set& )
;) *
}+ ,
} 
} ›
ëC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\SetPasswordViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class  
SetPasswordViewModel %
{ 
[ 	
Required	 
] 
[ 	
StringLength	 
( 
$num 
, 
ErrorMessage '
=( )
$str* Y
,Y Z
MinimumLength[ h
=i j
$numk l
)l m
]m n
[		 	
DataType			 
(		 
DataType		 
.		 
Password		 #
)		# $
]		$ %
[

 	
Display

	 
(

 
Name

 
=

 
$str

 &
)

& '
]

' (
public 
string 
NewPassword !
{" #
get$ '
;' (
set) ,
;, -
}. /
[ 	
DataType	 
( 
DataType 
. 
Password #
)# $
]$ %
[ 	
Display	 
( 
Name 
= 
$str .
). /
]/ 0
[ 	
Compare	 
( 
$str 
, 
ErrorMessage  ,
=- .
$str/ i
)i j
]j k
public 
string 
ConfirmPassword %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
} 
} ‘
éC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\TelefoneViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class 
TelefoneViewModel "
{ 
public		 
TelefoneViewModel		  
(		  !
)		! "
{

 	

TelefoneId 
= 
Guid 
. 
NewGuid %
(% &
)& '
;' (
} 	
[ 	
Key	 
] 
public 
Guid 

TelefoneId $
{% &
get' *
;* +
set, /
;/ 0
}1 2
public 
Pessoa 
PessoaId 
{  
get! $
;$ %
set& )
;) *
}+ ,
[ 	
Required	 
( 
AllowEmptyStrings #
=$ %
false& +
)+ ,
], -
[ 	
Display	 
( 
Name 
= 
$str 
) 
] 
public 
string 
Ddd 
{ 
get 
;  
set! $
;$ %
}& '
[ 	
Required	 
( 
AllowEmptyStrings #
=$ %
false& +
)+ ,
], -
[ 	
Display	 
( 
Name 
= 
$str  
)  !
]! "
public 
string 
Numero 
{ 
get "
;" #
set$ '
;' (
}) *
} 
} ◊
ìC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\TipoDocumentoViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class "
TipoDocumentoViewModel '
{ 
[ 	
Key	 
] 
public		 
Guid		 
TipoDocumentoId		 #
{		$ %
get		& )
;		) *
set		+ .
;		. /
}		0 1
public 
Guid 

ProcessoId 
{  
get! $
;$ %
set& )
;) *
}+ ,
[ 	
Required	 
( 
AllowEmptyStrings #
=$ %
false& +
)+ ,
], -
[ 	
	MaxLength	 
( 
$num 
) 
] 
[ 	
Display	 
( 
Name 
= 
$str -
)- .
]. /
public 
string 
TipoDocumentos $
{% &
get' *
;* +
set, /
;/ 0
}1 2
[ 	
Required	 
( 
AllowEmptyStrings #
=$ %
false& +
)+ ,
], -
[ 	
Display	 
( 
Name 
= 
$str !
)! "
]" #
public 
bool 
Ativo 
{ 
get 
;  
set! $
;$ %
}& '
} 
} Ú
çC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\UsuarioViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class 
UsuarioViewModel !
{ 
public 
UsuarioViewModel 
(  
)  !
{		 	
	UsuarioId

 
=

 
Guid

 
.

 
NewGuid

 $
(

$ %
)

% &
;

& '
} 	
[ 	
Key	 
] 
public 
Guid 
	UsuarioId #
{$ %
get& )
;) *
set+ .
;. /
}0 1
[ 	
Required	 
( 
AllowEmptyStrings #
=$ %
false& +
)+ ,
], -
[ 	
Display	 
( 
Name 
= 
$str 
) 
]  
public 
string 
Nome 
{ 
get  
;  !
set" %
;% &
}' (
[ 	
Required	 
( 
AllowEmptyStrings #
=$ %
false& +
)+ ,
], -
[ 	
Display	 
( 
Name 
= 
$str  
)  !
]! "
public 
string 
Email 
{ 
get !
;! "
set# &
;& '
}( )
[ 	
Required	 
( 
AllowEmptyStrings #
=$ %
false& +
)+ ,
], -
[ 	
Display	 
( 
Name 
= 
$str 
)  
]  !
public 
string 
Login 
{ 
get !
;! "
set# &
;& '
}( )
[ 	
Required	 
( 
AllowEmptyStrings #
=$ %
false& +
)+ ,
], -
[ 	
Display	 
( 
Name 
= 
$str 
)  
]  !
public 
string 
Senha 
{ 
get !
;! "
set# &
;& '
}( )
[ 	
Required	 
( 
AllowEmptyStrings #
=$ %
false& +
)+ ,
], -
[   	
Display  	 
(   
Name   
=   
$str    
)    !
]  ! "
public!! 
string!! 
Perfil!! 
{!! 
get!! "
;!!" #
set!!$ '
;!!' (
}!!) *
[## 	
Required##	 
(## 
AllowEmptyStrings## #
=##$ %
false##& +
)##+ ,
]##, -
[$$ 	
Display$$	 
($$ 
Name$$ 
=$$ 
$str$$ 
)$$  
]$$  !
public%% 
bool%% 
Ativo%% 
{%% 
get%% 
;%%  
set%%! $
;%%$ %
}%%& '
}&& 
}'' ó
êC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\VerifyCodeViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class 
VerifyCodeViewModel $
{ 
[ 	
Required	 
] 
public 
string  
Provider! )
{* +
get, /
;/ 0
set1 4
;4 5
}6 7
[		 	
Required			 
]		 
[		 
Display		 
(		 
Name		  
=		! "
$str		# )
)		) *
]		* +
public		, 2
string		3 9
Code		: >
{		? @
get		A D
;		D E
set		F I
;		I J
}		K L
public 
string 
	ReturnUrl 
{  !
get" %
;% &
set' *
;* +
}, -
[ 	
Display	 
( 
Name 
= 
$str 0
)0 1
]1 2
public 
bool 
RememberBrowser #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
bool 

RememberMe 
{  
get! $
;$ %
set& )
;) *
}+ ,
} 
} ˇ
óC:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Application\ViewModels\VerifyPhoneNumberViewModel.cs
	namespace 	 
SistemaDeConvocacoes
 
. 
Application *
.* +

ViewModels+ 5
{ 
public 

class &
VerifyPhoneNumberViewModel +
{ 
[ 	
Required	 
] 
[ 
Display 
( 
Name  
=! "
$str# )
)) *
]* +
public, 2
string3 9
Code: >
{? @
getA D
;D E
setF I
;I J
}K L
[		 	
Required			 
]		 
[

 	
Phone

	 
]

 
[ 	
Display	 
( 
Name 
= 
$str &
)& '
]' (
public 
string 
PhoneNumber !
{" #
get$ '
;' (
set) ,
;, -
}. /
} 
} 