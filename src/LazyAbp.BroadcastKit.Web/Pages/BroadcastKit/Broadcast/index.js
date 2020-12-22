$(function () {

    var l = abp.localization.getResource('BroadcastKit');

    var service = lazyAbp.broadcastKit.adminBroadcasts;
    var createModal = new abp.ModalManager(abp.appPath + 'BroadcastKit/Broadcast/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'BroadcastKit/Broadcast/EditModal');

    var dataTable = $('#BroadcastTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[0, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                visible: abp.auth.isGranted('BroadcastKit.Broadcast.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('BroadcastKit.Broadcast.Delete'),
                                confirmMessage: function (data) {
                                    return l('BroadcastDeletionConfirmationMessage', data.record.id);
                                },
                                action: function (data) {
                                        service.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            { data: "title" },
            { data: "fullDescription" },
            { data: "isActive" },
            { data: "startTime" },
            { data: "expireTime" },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewBroadcastButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});