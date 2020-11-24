<template>
  <table id="tblUsers">
    <thead>
    <tr>
        <th>First Name</th>
        <th>Last Name</th>
        <th>Username</th>
        <th>Email Address</th>
        <th>Status</th>
    </tr>
    </thead>
    <tbody>
      <tr>
        <td><input type="text" id="firstNameFilter" v-model="filter.firstName"/></td>
        <td><input type="text" id="lastNameFilter" v-model="filter.lastName"/></td>
        <td><input type="text" id="usernameFilter" v-model="filter.username"/></td>
        <td><input type="text" id="emailFilter" v-model="filter.emailAddress"/></td>
        <td>
          <select id="statusFilter" v-model="filter.status">
            <option value="">Show All</option>
            <option value="Active">Active</option>
            <option value="Disabled">Disabled</option>
          </select>
        </td>
      </tr>
        <tr v-for="users in filteredList" v-bind:key="users.username" v-bind:class="{disabled: users.status === 'Disabled'}">
        <td>{{users.firstName}}</td>
        <td>{{users.lastName}}</td>
        <td>{{users.username}}</td>
        <td>{{users.emailAddress}}</td>
        <td>{{users.status}}</td>
        </tr>
      
      <!-- user listing goes here -->
    </tbody>
  </table>
</template>

<script>
export default {
  name: 'user-list',
  data() {
    return {
      createUser: {
         firstName: '',
      lastName: '',
      username: '',
      emailAddress:'',
      status: '',
      },
      filter: {
        firstName: '',
         lastName: '',
      username: '',
      emailAddress:'',
      status: '',
      },
      users: [
        { firstName: 'John', lastName: 'Smith', username: 'jsmith', emailAddress: 'jsmith@gmail.com', status: 'Active' },
        { firstName: 'Anna', lastName: 'Bell', username: 'abell', emailAddress: 'abell@yahoo.com', status: 'Active' },
        { firstName: 'George', lastName: 'Best', username: 'gbest', emailAddress: 'gbest@gmail.com', status: 'Disabled' },
        { firstName: 'Ben', lastName: 'Carter', username: 'bcarter', emailAddress: 'bcarter@gmail.com', status: 'Active' },
        { firstName: 'Katie', lastName: 'Jackson', username: 'kjackson', emailAddress: 'kjackson@yahoo.com', status: 'Active' },
        { firstName: 'Mark', lastName: 'Smith', username: 'msmith', emailAddress: 'msmith@foo.com', status: 'Disabled' }
      ]
    }
  },
computed: {
  filteredList(){
    let filteredUsers = this.users;
    if(this.filter.firstName != ''){
      filteredUsers = filteredUsers.filter((user) => user.firstName.toLowerCase().includes(this.filter.firstName.toLowerCase()));
    }
    if(this.filter.lastName != ''){
      filteredUsers = filteredUsers.filter((user) => user.lastName.toLowerCase().includes(this.filter.lastName.toLowerCase()));
    }
    if(this.filter.username != ''){
      filteredUsers = filteredUsers.filter((user) => user.username.toLowerCase().includes(this.filter.username.toLowerCase()));
    }
    if(this.filter.emailAddress != ''){
      filteredUsers = filteredUsers.filter((user) => user.emailAddress.toLowerCase().includes(this.filter.emailAddress.toLowerCase()));
    }
    if(this.filter.status != ''){
      filteredUsers = filteredUsers.filter((user) => user.status.toLowerCase().includes(this.filter.status.toLowerCase()));
    }
    return filteredUsers;
  },
  returnUser() {
let user = this.users;
if(this.createUser.firstName) {
  user = user.filter(n => n.firstName.toLowerCase().includes(user.createUser.firstName)); 
}
if(this.createUser.lastName) {
  user = user.filter(n => n.lastName.toLowerCase().includes(user.createUser.lastName)); 
}
if(this.createUser.username) {
  user = user.filter(n => n.username.toLowerCase().includes(user.createUser.username)); 
}
if(this.createUser.emailAddress) {
  user = user.filter(n => n.emailAddress.toLowerCase().includes(user.createUser.emailAddress)); 
}
if(this.createUser.status) {
  user = user.filter(n => n.status.toLowerCase().includes(user.createUser.status)); 
}
return user;
  },
},

}
</script>

<style scoped>
table {
  margin-top: 20px;
  font-family:-apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif
}
th {
  text-transform: uppercase
}
td {
  padding: 10px;
}
tr.disabled {
  color: red;
}
input, select {
  font-size: 16px;
}
</style>
