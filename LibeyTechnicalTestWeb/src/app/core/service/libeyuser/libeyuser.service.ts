import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { environment } from "../../../../environments/environment";
import { LibeyUser } from "src/app/models/libeyuser";
import { InsertLibeyUserRequest } from "../../requests/libey-user/libey-user.request";
@Injectable({
	providedIn: "root",
})
export class LibeyUserService {
	constructor(private http: HttpClient) {}
	GetByDocumentNumber(documentNumber: string): Observable<LibeyUser> {
		const uri = `${environment.pathLibeyTechnicalTest}LibeyUser/${documentNumber}`;
		return this.http.get<LibeyUser>(uri);
	}
	Insert(libeyuser: InsertLibeyUserRequest): Observable<Response> {
		const uri = `${environment.pathLibeyTechnicalTest}LibeyUser`;
		return this.http.post<Response>(uri, libeyuser);
	}
}