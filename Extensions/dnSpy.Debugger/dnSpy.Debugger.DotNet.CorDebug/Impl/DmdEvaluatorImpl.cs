﻿/*
    Copyright (C) 2014-2017 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Threading;
using dnSpy.Debugger.DotNet.Metadata;

namespace dnSpy.Debugger.DotNet.CorDebug.Impl {
	sealed class DmdEvaluatorImpl : DmdEvaluator {
		readonly DbgEngineImpl engine;

		public DmdEvaluatorImpl(DbgEngineImpl engine) =>
			this.engine = engine ?? throw new ArgumentNullException(nameof(engine));

		public override object Invoke(IDmdEvaluationContext context, DmdMethodBase method, object obj, object[] parameters, CancellationToken cancellationToken) {
			throw new NotImplementedException();//TODO:
		}

		public override void Invoke(IDmdEvaluationContext context, DmdMethodBase method, object obj, object[] parameters, Action<object> callback, CancellationToken cancellationToken) {
			throw new NotImplementedException();//TODO:
		}

		public override object LoadField(IDmdEvaluationContext context, DmdFieldInfo field, object obj, CancellationToken cancellationToken) {
			throw new NotImplementedException();//TODO:
		}

		public override void LoadField(IDmdEvaluationContext context, DmdFieldInfo field, object obj, Action<object> callback, CancellationToken cancellationToken) {
			throw new NotImplementedException();//TODO:
		}

		public override void StoreField(IDmdEvaluationContext context, DmdFieldInfo field, object obj, object value, CancellationToken cancellationToken) {
			throw new NotImplementedException();//TODO:
		}

		public override void StoreField(IDmdEvaluationContext context, DmdFieldInfo field, object obj, object value, Action callback, CancellationToken cancellationToken) {
			throw new NotImplementedException();//TODO:
		}
	}
}